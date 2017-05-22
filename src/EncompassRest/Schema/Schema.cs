using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Utilities;

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
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/loan/{fieldId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetFieldSchemaAsync), response).ConfigureAwait(false);
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonHelper.FromJson<LoanSchema>(json);
            }
        }
    }
}