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

            // Do not commit values in these variables to source control
            var clientId = args[0];
            var clientSecret = args[1];
            var instanceId = args[2];
            var userId = args[3];
            var password = args[4];
            var destinationPath = args[5];

            if (!string.IsNullOrEmpty(userId))
            {
                Task.Run(async () =>
                {
                    using (var client = await EncompassRestClient.CreateFromUserCredentialsAsync(clientId, clientSecret, instanceId, userId, password))
                    {
                        await GenerateClassFilesFromSchemaAsync(client, destinationPath, "EncompassRest.Loans");
                    }
                }).Wait();
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

namespace {@namespace}
{{
    public sealed partial class {entityType}
    {{
");
            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var fieldSchema = pair.Value;
                var fieldType = GetFieldType(fieldSchema);
                sb.AppendLine($"        public {(fieldSchema.Nullable != false ? $"JsonNullable<{fieldType}>" : fieldType)} {pair.Key} {{ get; set; }}");
            }

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityType + ".cs")))
            {
                await sw.WriteAsync(sb.ToString()).ConfigureAwait(false);
            }
        }

        private static string GetFieldType(FieldSchema fieldSchema)
        {
            var fieldType = fieldSchema.Type;
            switch (fieldType)
            {
                case "string":
                case "uuid":
                    return "string";
                case "decimal":
                case "NA<decimal>":
                    return "decimal?";
                case "bool":
                case "int":
                    return $"{fieldType}?";
                case "date":
                case "datetime":
                    return "DateTime?";
                case "set":
                case "list":
                    return $"List<{fieldSchema.ElementType}>";
                case "entity":
                    return fieldSchema.EntityType;
                default:
                    return $"PROBLEM<{fieldType}>";
            }
        }
    }
}