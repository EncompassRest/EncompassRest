using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Schema;
using EncompassRest.Tests;

namespace EncompassRest
{
    public static class EntityGenerator
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();

            try
            {
                Task.Run(async () =>
                {
                    using (var client = await TestBaseClass.GetTestClientAsync())
                    {
                        await GenerateClassFilesFromSchemaAsync(client, "Loans", "EncompassRest.Loans");
                    }
                }).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }

        public static async Task GenerateClassFilesFromSchemaAsync(EncompassRestClient client, string destinationPath, string @namespace)
        {
            Directory.CreateDirectory(destinationPath);
            var supportedEntities = await client.Loans.GetSupportedEntitiesAsync().ConfigureAwait(false);
            var exceptions = new List<Exception>();
            var knownBadEntities = new HashSet<string> { "LOCompensation", "VirtualFields", "ElliUCDFields", "NonVols" };
            foreach (var entity in supportedEntities)
            {
                try
                {
                    var loanSchema = await client.Schema.GetLoanSchemaAsync(true, entity).ConfigureAwait(false);

                    foreach (var pair in loanSchema.EntityTypes)
                    {
                        await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, pair.Key, pair.Value).ConfigureAwait(false);
                    }
                    if (knownBadEntities.Contains(entity))
                    {
                        Console.WriteLine($"Schema for {entity} can now be retrieved");
                    }
                }
                catch (Exception ex)
                {
                    if (!knownBadEntities.Contains(entity))
                    {
                        exceptions.Add(new Exception(entity, ex));
                    }
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        private static async Task GenerateClassFileFromSchemaAsync(string destinationPath, string @namespace, string entityType, EntitySchema entitySchema)
        {
            var sb = new StringBuilder();
            sb.Append(
$@"using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace {@namespace}
{{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class {entityType} : IDirty
    {{
");

            var properties = new List<(string Name, string FieldName, bool IsEntity, bool IsCollection)>();

            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                var propertyType = GetPropertyOrElementType(propertySchema, out var isEntity, out var isCollection);
                var elementType = propertyType;
                if (isCollection)
                {
                    propertyType = $"DirtyList<{elementType}>";
                }
                var fieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                sb.AppendLine($"        private {(isEntity || isCollection ? propertyType : $"DirtyValue<{propertyType}>")} {fieldName};");
                properties.Add((propertyName, fieldName, isEntity, isCollection));

                sb.AppendLine($"        public {(isCollection ? $"IList<{elementType}>" : propertyType)} {propertyName} {{ get {{ return {fieldName}{(isEntity || isCollection ? $" ?? ({fieldName} = new {propertyType}())" : string.Empty)}; }} set {{ {fieldName} = {(isCollection ? $"new {propertyType}(value)" : "value")}; }} }}");
            }

            // Sorts non entity types first
            properties = properties.OrderBy(property => property.IsEntity || property.IsCollection).ToList();

            // Must ensure no circular cleaning
            sb.Append(
$@"        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData {{ get {{ return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); }} set {{ _extensionData = new DirtyDictionary<string, object>(value); }} }}
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {{
            get
            {{
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = {string.Join($"{Environment.NewLine}                    || ", properties.Select(property => $"{property.FieldName}{(property.IsEntity || property.IsCollection ? "?.Dirty == true" : ".Dirty")}"))}
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }}
            set
            {{
                if (_settingDirty) return;
                _settingDirty = true;
                {string.Join($"{Environment.NewLine}                ", properties.Select(property =>
                    {
                        var propertyName = property.FieldName;
                        if (property.IsEntity || property.IsCollection)
                        {
                            return $"if ({propertyName} != null) {propertyName}.Dirty = value;";
                        }
                        return $"{propertyName}.Dirty = value;";
                    }))}
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }}
        }}
        bool IDirty.Dirty {{ get {{ return Dirty; }} set {{ Dirty = value; }} }}
    }}
}}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityType + ".cs")))
            {
                await sw.WriteAsync(sb.ToString()).ConfigureAwait(false);
            }
        }

        private static string GetPropertyOrElementType(PropertySchema propertySchema, out bool isEntity, out bool isCollection)
        {
            isEntity = false;
            isCollection = false;
            var propertyType = propertySchema.Type;
            switch (propertyType)
            {
                case "string":
                case "uuid":
                    return "string";
                case "decimal":
                case "NA<decimal>":
                case "bool":
                case "int":
                    return $"{propertyType}?";
                case "date":
                case "datetime":
                    return "DateTime?";
                case "set":
                case "list":
                    isCollection = true;
                    return propertySchema.ElementType;
                case "entity":
                    isEntity = true;
                    return propertySchema.EntityType;
                default:
                    return $"PROBLEM<{propertyType}>";
            }
        }
    }
}