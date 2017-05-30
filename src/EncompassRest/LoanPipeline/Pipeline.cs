using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline
{
    public sealed class Pipeline
    {
        private const string _apiPath = "encompass/v1/loanPipeline";

        public EncompassRestClient Client { get; }

        internal Pipeline(EncompassRestClient client)
        {
            Client = client;
        }

        public async Task<CanonicalNames> GetCanonicalNamesAsync()
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/fieldDefinitions").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetCanonicalNamesAsync), response).ConfigureAwait(false);
                }

                return await response.Content.ReadAsAsync<CanonicalNames>().ConfigureAwait(false);
            }
        }

        public async Task<List<LoanPipelineData>> ViewPipelineAsync(ViewPipelineParameters parameters, int? limit = null)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            if (limit <= 0)
            {
                throw new ArgumentException("must be null or greater than 0", nameof(limit));
            }

            var queryParameters = new QueryParameters();
            if (limit.HasValue)
            {
                queryParameters.Add(new QueryParameter("limit", limit.GetValueOrDefault().ToString()));
            }

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}{queryParameters}", JsonStreamContent.Create(parameters)).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(ViewPipelineAsync), response).ConfigureAwait(false);
                }

                return await response.Content.ReadAsAsync<List<LoanPipelineData>>().ConfigureAwait(false);
            }
        }
    }
}