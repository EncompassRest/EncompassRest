using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Utilities;

namespace EncompassRest.Schema
{
    public sealed class Schema
    {
        private const string s_apiPath = "encompass/v1/schema";

        public EncompassRestClient Client { get; }

        internal Schema(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, params LoanEntity[] entities) => GetLoanSchemaAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities) => GetLoanSchemaAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanSchemaAsync(includeFieldExtensions, entities?.Select(entity => entity.ToJson().Unquote()), cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, params string[] entities) => GetLoanSchemaAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string> entities) => GetLoanSchemaAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken) => GetLoanSchemaInternalAsync(includeFieldExtensions, entities, cancellationToken, response => response.Content.ReadAsAsync<LoanSchema>());

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, params LoanEntity[] entities) => GetLoanSchemaRawAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities) => GetLoanSchemaRawAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanSchemaRawAsync(includeFieldExtensions, entities?.Select(entity => entity.ToJson().Unquote()), cancellationToken);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, params string[] entities) => GetLoanSchemaRawAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<string> entities) => GetLoanSchemaRawAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken) => GetLoanSchemaInternalAsync(includeFieldExtensions, entities, cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetLoanSchemaInternalAsync<T>(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }
            queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/loan{queryParameters}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetLoanSchemaAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId) => GetFieldSchemaAsync(fieldId, CancellationToken.None);

        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetFieldSchemaInternalAsync(fieldId, cancellationToken, response => response.Content.ReadAsAsync<LoanSchema>());
        }

        public Task<string> GetFieldSchemaRawAsync(string fieldId) => GetFieldSchemaRawAsync(fieldId, CancellationToken.None);

        public Task<string> GetFieldSchemaRawAsync(string fieldId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetFieldSchemaInternalAsync(fieldId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetFieldSchemaInternalAsync<T>(string fieldId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/loan/{fieldId}", cancellationToken).ConfigureAwait(false))
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