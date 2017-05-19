using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Newtonsoft.Json.Linq;

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

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/loan{queryParameters}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetLoanSchemaAsync), response).ConfigureAwait(false);
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonHelper.FromJson<LoanSchema>(json);
            }
        }

        public async Task<LoanSchema> GetFieldSchemaAsync(string fieldId)
        {
            var json = await GetFieldSchemaJsonAsync(fieldId).ConfigureAwait(false);
            return JsonHelper.FromJson<LoanSchema>(json);
        }

        private async Task<string> GetFieldSchemaJsonAsync(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/loan/{fieldId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetFieldSchemaAsync), response).ConfigureAwait(false);
                }

                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        public async Task<string> GetFieldPathAsync(string fieldId)
        {
            string schemaJson;
            var returnPath = new StringBuilder();
            try
            {
                schemaJson = await GetFieldSchemaJsonAsync(fieldId).ConfigureAwait(false);
            }
            catch (RestException re)
            {
                throw await RestException.CreateAsync(nameof(GetFieldPathAsync), re.Response).ConfigureAwait(false);
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
    }
}