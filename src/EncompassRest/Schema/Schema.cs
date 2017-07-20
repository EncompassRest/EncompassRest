using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EncompassRest.Loans;
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

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<LoanEntity> entities, bool includeFieldExtensions = false) => GetLoanSchemaAsync(entities?.Select(entity => entity.ToJson().Unquote()), includeFieldExtensions);

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<string> entities = null, bool includeFieldExtensions = false) => GetLoanSchemaInternalAsync(entities, includeFieldExtensions, response => response.Content.ReadAsAsync<LoanSchema>());

        public Task<string> GetLoanSchemaRawAsync(IEnumerable<LoanEntity> entities, bool includeFieldExtensions = false) => GetLoanSchemaRawAsync(entities?.Select(entity => entity.ToJson().Unquote()), includeFieldExtensions);

        public Task<string> GetLoanSchemaRawAsync(IEnumerable<string> entities = null, bool includeFieldExtensions = false) => GetLoanSchemaInternalAsync(entities, includeFieldExtensions, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetLoanSchemaInternalAsync<T>(IEnumerable<string> entities, bool includeFieldExtensions, Func<HttpResponseMessage, Task<T>> func)
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

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetFieldSchemaInternalAsync(fieldId, response => response.Content.ReadAsAsync<LoanSchema>());
        }

        public Task<string> GetFieldSchemaRawAsync(string fieldId)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetFieldSchemaInternalAsync(fieldId, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetFieldSchemaInternalAsync<T>(string fieldId, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/loan/{fieldId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetFieldSchemaAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }
    }
}