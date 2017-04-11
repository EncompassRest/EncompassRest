using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassREST.Exceptions;
using EncompassREST.HelperClasses;
using EncompassREST.JsonHelpers;
using Newtonsoft.Json.Linq;

namespace EncompassREST
{
    public class Schemas
    {
        private const string _apiPath = "encompass/v1/schema";

        public Session Session { get; }

        public Schemas(Session session)
        {
            Session = session;
        }

        public Task<string> GetSchemaAsync()
        {
            return GetSchemaAsync(null, true);
        }

        public async Task<string> GetSchemaAsync(IList<string> entities, bool includeFieldExtensions)
        {
            var rp = new RequestParameters();
            if (entities != null &&
                entities.Count > 0)
            {
                rp.Add("entities", string.Join(",", entities));
            }
            rp.Add("includeFieldExtensions", includeFieldExtensions.ToString());

            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/loan{rp}");
            var response = await Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.GetAsync(API_PATH + "/loan" + rp.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RESTException(nameof(GetSchemaAsync), response);
            }
        }

        public async Task<string> GetSchemaFieldAsync(string fieldId)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/loan/{fieldId}");
            //var response = await _Session.RESTClient.GetAsync(API_PATH + "/loan/" + FieldID);
            var response = await Session.RESTClient.SendAsync(message);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RESTException(nameof(GetSchemaFieldAsync), response);
            }
        }

        public async Task<string> GetFieldPathAsync(string fieldId)
        {
            string schemaJson;
            var returnPath = new StringBuilder();
            try
            {
                schemaJson = await GetSchemaFieldAsync(fieldId);
            }
            catch (RESTException re)
            {
                throw new RESTException("GetSchemaFieldAsync", re.Response);
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
            var RawSchema = await GetSchemaAsync();

            var jo = JToken.Parse(RawSchema);
            var entities = jo["entity_types"];
            foreach (var jt in entities.Children())
                await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, ((JProperty)jt).Name, jo);
        }

        private async Task GenerateClassFileFromSchemaAsync(string destinationPath, string @namespace, string section, JToken schemaToken)
        {
            string entity;
            var sb = new StringBuilder();
            var partial = (section == "Loan") ? "partial " : "";
            sb.Append(
$@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {@namespace}
{{
    public {partial}class {section}
    {{
");
            var sectionProperties = schemaToken["entity_types"][section]["properties"];
            foreach (var sectionToken in sectionProperties.Children())
            {
                var variableProperty = (JProperty)sectionToken;
                var vName = variableProperty.Name;
                vName = vName.Substring(0, 1).ToLower() + vName.Substring(1); //set proper case

                var vType = schemaToken["entity_types"][section]["properties"][variableProperty.Name]["type"];

                switch(vType.ToString())
                {
                    case "string":
                    case "uuid":
                        sb.AppendLine($"        public string {vName} {{ get; set; }}");
                        break;
                    case "decimal":
                    case "bool":
                    case "int":
                        sb.AppendLine($"        public {vType}? {vName} {{ get; set; }}");
                        break;
                    case "date":
                    case "datetime":
                        sb.AppendLine($"        public DateTime? {vName} {{ get; set; }}");
                        break;
                        //validate reserialization of these elements
                    case "set":
                    case "list":
                        entity = schemaToken["entity_types"][section]["properties"][variableProperty.Name]["element_type"].ToString();
                        entity = entity.Substring(0, 1).ToUpper() + entity.Substring(1);
                        sb.AppendLine($"        public List<{entity}> {vName} {{ get; set; }}");
                        break;
                    case "entity":
                        entity = schemaToken["entity_types"][section]["properties"][variableProperty.Name]["element_type"].ToString();
                        entity = entity.Substring(0, 1).ToUpper() + entity.Substring(1);
                        sb.AppendLine($"        public {entity} {vName} {{ get; set; }}");
                        break;
                    default:
                        sb.AppendLine($"        public PROBLEM<{variableProperty.Name}> {vName} {{ get; set; }}");
                        break;
                }
            }

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, section + ".cs")))
            {
                await sw.WriteAsync(sb.ToString());
            }
        }
    }
}
