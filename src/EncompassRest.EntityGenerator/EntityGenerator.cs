using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Schema;

namespace EncompassRest
{
    public static class EntityGenerator
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();

            try
            {
                var clientId = args[0];
                var clientSecret = args[1];
                var instanceId = args[2];
                var userId = args[3];
                var password = args[4];
                var destinationPath = args[5];

                Task.Run(async () =>
                {
                    using (var client = await EncompassRestClient.CreateFromUserCredentialsAsync(clientId, clientSecret, instanceId, userId, password))
                    {
                        await GenerateClassFilesFromSchemaAsync(client, destinationPath, "EncompassRest.Loans");
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
            var supportedEntities = await client.Loans.GetSupportedEntitiesAsync().ConfigureAwait(false);
            var exceptions = new List<Exception>();
            var badEntities = new HashSet<string> { "LOCompensation", "VirtualFields", "ElliUCDFields", "NonVols" };
            foreach (var entity in supportedEntities)
            {
                if (!badEntities.Contains(entity))
                {
                    try
                    {
                        var loanSchema = await client.Schema.GetLoanSchemaAsync(true, entity).ConfigureAwait(false);

                        foreach (var pair in loanSchema.EntityTypes)
                        {
                            await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, pair.Key, pair.Value).ConfigureAwait(false);
                        }
                    }
                    catch (Exception ex)
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
    public sealed partial class {entityType} : IDirty
    {{
");

            var properties = new List<(string Name, string FieldName, bool IsEntity)>();

            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                var propertyType = GetPropertyType(propertySchema, out var isEntity);
                var fieldName = propertyName;
                if (!isEntity)
                {
                    fieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                    sb.AppendLine($"        private Value<{propertyType}> {fieldName};");
                }
                properties.Add((propertyName, fieldName, isEntity));

                sb.AppendLine($"        public {propertyType} {propertyName} {(isEntity ? "{ get; set; }" : $"{{ get {{ return {fieldName}; }} set {{ {fieldName} = value; }} }}")}");
            }

            // Sorts non entity types first
            properties = properties.OrderBy(property => property.IsEntity).ToList();

            // Must ensure no circular cleaning
            sb.Append(
$@"        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {{
            get
            {{
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = {string.Join($"{Environment.NewLine}                    || ", properties.Select(property => $"{property.FieldName}{(property.IsEntity ? "?.Dirty == true" : ".Dirty")}"))};
                _gettingDirty = 0;
                return dirty;
            }}
            set
            {{
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                {string.Join($"{Environment.NewLine}                ", properties.Select(property =>
                    {
                        var propertyName = property.FieldName;
                        if (property.IsEntity)
                        {
                            return $"if ({propertyName} != null) {propertyName}.Dirty = value;";
                        }
                        return $"{propertyName}.Dirty = value;";
                    }))}
                _settingDirty = 0;
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

        private static string GetPropertyType(PropertySchema propertySchema, out bool isEntity)
        {
            isEntity = false;
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
                    return $"List<{propertySchema.ElementType}>";
                case "entity":
                    isEntity = true;
                    return propertySchema.EntityType;
                default:
                    return $"PROBLEM<{propertyType}>";
            }
        }
    }
}