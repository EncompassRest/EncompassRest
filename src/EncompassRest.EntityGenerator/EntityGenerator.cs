using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Schema;

namespace EncompassRest
{
    public static class EntityGenerator
    {
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
    public sealed {(entityType == "Loan" ? "partial " : "")}class {entityType}
    {{
");
            foreach (var pair in entitySchema.Properties)
            {
                var propertyType = GetPropertyType(pair.Value);
                sb.AppendLine($"        public {propertyType} {pair.Key} {{ get; set; }}");
            }

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityType + ".cs")))
            {
                await sw.WriteAsync(sb.ToString()).ConfigureAwait(false);
            }
        }

        private static string GetPropertyType(FieldSchema fieldSchema)
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