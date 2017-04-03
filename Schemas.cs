using EncompassREST.Exceptions;
using EncompassREST.HelperClasses;
using EncompassREST.JSONHelpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST
{
    public class Schemas
    {
        private string API_PATH = "encompass/v1/schema";
        private Session _Session;

        public Schemas(Session Session)
        {
            _Session = Session;
        }

        public Session Session
        {
            get { return _Session; }
        }

        public async Task<string> GetSchemaAsync()
        {
            return await GetSchemaAsync(null, true);
        }
        public async Task<string> GetSchemaAsync(IList<string> entities,bool includeFieldExtensions)
        {
            
            RequestParameters rp = new RequestParameters();
            if (entities != null &&
                entities.Count > 0)
            {
                rp.Add("entities", String.Join(",", entities));
            }
            rp.Add("includeFieldExtensions", includeFieldExtensions.ToString());

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format(API_PATH + "/loan{0}",rp.ToString()));
            var response = await _Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.GetAsync(API_PATH + "/loan" + rp.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RESTException("getSchema", response);
            }

        }

        public async Task<string> GetSchemaFieldAsync(string FieldID)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format(API_PATH + "/loan/{0}", FieldID));
            //var response = await _Session.RESTClient.GetAsync(API_PATH + "/loan/" + FieldID);
            var response = await _Session.RESTClient.SendAsync(message);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RESTException("GetSchemaField", response);
            }
        }

        public async Task<string> GetFieldPathAsync(string FieldID)
        {
            string schemaJson;
            StringBuilder ReturnPath = new StringBuilder();
            try
            {
                schemaJson = await GetSchemaFieldAsync(FieldID);
            }
            catch (RESTException re)
            {
                throw new RESTException("GetSchemaFieldAsync", re.Response);
            }

            

            JObject jsonMain = JObject.Parse(schemaJson);
            var entityTypes = jsonMain["entity_types"];
            foreach (var token in entityTypes)
            {
                var p = (JProperty)token;
                ReturnPath.Append(p.Name + ".");
            }

            //jsonMain["entity_types"].Last["properties"]


            var fieldIDTokens = jsonMain.FindTokens("field_id");
            if (fieldIDTokens.Count == 1)
            {
                var path = fieldIDTokens.FirstOrDefault().Path;
                var itemsInPath = path.Split('.');
                ReturnPath.Append(itemsInPath.GetValue(itemsInPath.Count() - 2));
            }
            else
            {
                var fieldInstanceTokens = jsonMain.FindTokens("field_instances");
                var path = fieldInstanceTokens.FirstOrDefault().Path;
                var itemsInPath = path.Split('.');
                ReturnPath.Append(itemsInPath.GetValue(itemsInPath.Count() - 2));
            }


            return ReturnPath.ToString();
        }

        public async Task GenerateClassFilesFromSchemaAsync(string DestinationPath,string Namespace)
        {
            string RawSchema = await GetSchemaAsync();

            JToken jo = JToken.Parse(RawSchema);
            var entities = jo["entity_types"];
            foreach (JToken jt in entities.Children())
                await GenerateClassFileFromSchemaAsync(DestinationPath,Namespace,((JProperty)jt).Name,jo);

        }
        private async Task GenerateClassFileFromSchemaAsync(string DestinationPath, string Namespace, string Section, JToken SchemaToken)
        {
            string entity;
            StringBuilder sb = new StringBuilder();
            string partial = (Section == "Loan") ? " partial " : "";
            sb.Append(
@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace " + Namespace + @"
{
    public " + partial + "class " + Section + @"
    {"
);
            var section = SchemaToken["entity_types"][Section]["properties"];
            foreach (JToken SectionToken in section.Children())
            {
                JProperty VariableProperty = (JProperty)SectionToken;
                string vName = VariableProperty.Name;
                vName = vName.Substring(0, 1).ToLower() + vName.Substring(1); //set proper case

                var vType = SchemaToken["entity_types"][Section]["properties"][VariableProperty.Name]["type"];

                switch(vType.ToString())
                {
                    case "string":
                    case "uuid":
                        sb.AppendLine("        public string " + vName + " { get; set; }");
                        break;

                    case "decimal":
                    case "bool":
                    case "int":
                        sb.AppendLine("        public " + vType.ToString() +"? " + vName + " { get; set; }");
                        break;

                    case "date":
                    case "datetime":
                        sb.AppendLine("        public DateTime? " + vName + " { get; set; }");
                        break;

                        //validate reserialization of these elements
                    case "set":
                    case "list":
                        entity = SchemaToken["entity_types"][Section]["properties"][VariableProperty.Name]["element_type"].ToString();
                        entity = entity.Substring(0, 1).ToUpper() + entity.Substring(1);
                        sb.AppendLine("        public List<"+entity + "> " + vName + " { get; set; }");
                        break;

                    case "entity":
                        entity = SchemaToken["entity_types"][Section]["properties"][VariableProperty.Name]["element_type"].ToString();
                        entity = entity.Substring(0, 1).ToUpper() + entity.Substring(1);
                        sb.AppendLine("        public " + entity + " " + vName + " { get; set; }");
                        break;

                    default:
                        sb.AppendLine("        public PROBLEM<" + VariableProperty.Name + "> " + vName + " { get; set; }");
                        break;
                }
            }

            sb.Append(
@"    }
}"
);
            using (StreamWriter sw = new StreamWriter(Path.Combine(DestinationPath, Section + ".cs")))
            {
                await sw.WriteAsync(sb.ToString());
            }
        }

    }
}
