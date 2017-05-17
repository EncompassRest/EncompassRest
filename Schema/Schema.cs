using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Schema
{
    public sealed class Schema
    {
        private const string _apiPath = "encompass/v1/schema";

        public EncompassRestClient Client { get; }

        internal Schema(EncompassRestClient client)
        {
            Client = client;
        }

        public async Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<string> entities = null, bool includeFieldExtensions = false)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }
            queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/loan{queryParameters}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetLoanSchemaAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<LoanSchema>(json);
            }
        }

        public async Task<LoanSchema> GetFieldSchemaAsync(string fieldId)
        {
            var json = await GetFieldSchemaJsonAsync(fieldId);
            return JsonHelper.FromJson<LoanSchema>(json);
        }

        public async Task<string> GetFieldSchemaJsonAsync(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/loan/{fieldId}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetFieldSchemaAsync), response);
                }

                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> GetFieldPathAsync(string fieldId)
        {
            string schemaJson;
            var returnPath = new StringBuilder();
            try
            {
                schemaJson = await GetFieldSchemaJsonAsync(fieldId);
            }
            catch (RestException re)
            {
                throw await RestException.CreateAsync(nameof(GetFieldPathAsync), re.Response);
            }

            var jsonMain = JObject.Parse(schemaJson);
            var entityTypes = jsonMain["entity_types"];
            foreach (var token in entityTypes)
            {
                var p = (JProperty)token;
                returnPath.Append(p.Name + ".");
            }

            //jsonMain["entity_types"].Last["properties"]
            
            var fieldIdTokens = jsonMain.FindTokens("field_id");
            if (fieldIdTokens.Count == 1)
            {
                var path = fieldIdTokens.FirstOrDefault().Path;
                var itemsInPath = path.Split('.');
                returnPath.Append(itemsInPath.GetValue(itemsInPath.Count() - 2));
            }
            else
            {
                var fieldInstanceTokens = jsonMain.FindTokens("field_instances");
                var path = fieldInstanceTokens.FirstOrDefault().Path;
                var itemsInPath = path.Split('.');
                returnPath.Append(itemsInPath.GetValue(itemsInPath.Count() - 2));
            }

            return returnPath.ToString();
        }

        public async Task GenerateClassFilesFromSchemaAsync(string destinationPath, string @namespace)
        {
            var supportedEntities = await Client.Loans.GetSupportedEntitiesAsync();
            var exceptions = new List<Exception>();
            var badEntities = new HashSet<string> { "LOCompensation", "VirtualFields", "CustomModelFields" };
            foreach (var entity in supportedEntities)
            {
                if (badEntities.Contains(entity))
                {
                    continue;
                }
                try
                {
                    var loanSchema = await GetLoanSchemaAsync(new[] { entity }, true);

                    foreach (var pair in loanSchema.EntityTypes)
                    {
                        await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, pair.Key, pair.Value);
                    }
                }
                catch (Exception ex)
                {
                    exceptions.Add(new Exception(entity, ex));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        private async Task GenerateClassFileFromSchemaAsync(string destinationPath, string @namespace, string entityType, EntitySchema entitySchema)
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
                var vName = pair.Key;
                vName = vName.Substring(0, 1).ToUpper() + vName.Substring(1);

                var propertyType = GetPropertyType(pair.Value);
                sb.AppendLine($"        public {propertyType} {vName} {{ get; set; }}");
            }

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityType + ".cs")))
            {
                await sw.WriteAsync(sb.ToString());
            }
        }

        private string GetPropertyType(FieldSchema fieldSchema)
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
                    var elementType = fieldSchema.ElementType;
                    elementType = elementType.Substring(0, 1).ToUpper() + elementType.Substring(1);
                    return $"List<{elementType}>";
                case "entity":
                    var entityType =  fieldSchema.EntityType;
                    entityType = entityType.Substring(0, 1).ToUpper() + entityType.Substring(1);
                    return entityType;
                default:
                    return $"PROBLEM<{fieldType}>";
            }
        }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy), NamingStrategyParameters = new object[] { true, false })]
    public sealed class LoanSchema
    {
        public string SchemaVersion { get; set; }
        public Dictionary<string, EntitySchema> EntityTypes { get; set; }
    }
    
    public sealed class EntitySchema
    {
        public Dictionary<string, FieldSchema> Properties { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy), NamingStrategyParameters = new object[] { true, false })]
    public sealed class FieldSchema
    {
        public string Format { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? Nullable { get; set; }
        public string Type { get; set; }
        public List<FieldOption> AllowedValues { get; set; }
        public string EntityType { get; set; }
        public bool? Required { get; set; }
        public string Description { get; set; }
        public string ElementType { get; set; }
    }

    public sealed class FieldOption
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}