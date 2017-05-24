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
            var badEntities = new HashSet<string> { "LOCompensation", "VirtualFields", "ElliUCDFields" };
            foreach (var entity in supportedEntities)
            {
                if (!badEntities.Contains(entity))
                {
                    try
                    {
                        var loanSchema = await client.Schema.GetLoanSchemaAsync(new[] { entity }, true).ConfigureAwait(false);

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

namespace {@namespace}
{{
    public sealed partial class {entityType}
    {{
");

            var properties = new List<(string Name, bool IsEntity, string Type)>();

            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                var propertyType = GetPropertyType(propertySchema, out var isEntity);
                if (!isEntity)
                {
                    propertyType = $"Value<{propertyType}>";
                }
                properties.Add((propertyName, isEntity, propertyType));
                sb.AppendLine($"        public {propertyType} {propertyName} {{ get; set; }}")
                  .AppendLine("        [EditorBrowsable(EditorBrowsableState.Never)]")
                  .AppendLine($"        public bool ShouldSerialize{propertyName}() => {(isEntity ? $"{propertyName}?.Clean == false" : $"!{propertyName}.Clean")};"); // Should be private but is not yet supported in Json.NET
            }

            // Sorts non entity types first
            properties = properties.OrderBy(property => property.IsEntity).ToList();

            // Must ensure no circular cleaning
            sb.Append(
$@"        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {{
            get
            {{
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = {string.Join($"{Environment.NewLine}                    && ", properties.Select(property => $"{property.Name}.Clean"))};
                _gettingClean = 0;
                return clean;
            }}
            set
            {{
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                {string.Join($"{Environment.NewLine}                ", properties.Select((property, index) =>
                    {
                        var propertyName = property.Name;
                        if (property.IsEntity)
                        {
                            return $"if ({propertyName} != null) {propertyName}.Clean = value;";
                        }
                        var variableName = $"v{index}";
                        return $"var {variableName} = {propertyName}; {variableName}.Clean = value; {propertyName} = {variableName};";
                    }))}
                _settingClean = 0;
            }}
        }}
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
                    return "decimal?";
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