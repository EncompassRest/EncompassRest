using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline
{
    public sealed class Pipeline
    {
        private const string s_apiPath = "encompass/v1/loanPipeline";

        public EncompassRestClient Client { get; }

        internal Pipeline(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<CanonicalNames> GetCanonicalNamesAsync() => GetCanonicalNamesAsync(CancellationToken.None);

        public Task<CanonicalNames> GetCanonicalNamesAsync(CancellationToken cancellationToken) => GetCanonicalNamesInternalAsync(cancellationToken, response => response.Content.ReadAsAsync<CanonicalNames>());

        public Task<string> GetCanonicalNamesRawAsync() => GetCanonicalNamesRawAsync(CancellationToken.None);

        public Task<string> GetCanonicalNamesRawAsync(CancellationToken cancellationToken) => GetCanonicalNamesInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetCanonicalNamesInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/fieldDefinitions", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetCanonicalNamesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        //TODO: Add support for cursor and pagination

        public Task<List<LoanPipelineData>> ViewPipelineAsync(ViewPipelineParameters parameters) => ViewPipelineAsync(parameters, null, CancellationToken.None);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(ViewPipelineParameters parameters, CancellationToken cancellationToken) => ViewPipelineAsync(parameters, null, cancellationToken);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(ViewPipelineParameters parameters, int? limit) => ViewPipelineAsync(parameters, limit, CancellationToken.None);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(ViewPipelineParameters parameters, int? limit, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            return ViewPipelineInternalAsync(JsonStreamContent.Create(parameters), limit, cancellationToken, response => response.Content.ReadAsAsync<List<LoanPipelineData>>());
        }

        public Task<string> ViewPipelineRawAsync(string parameters) => ViewPipelineRawAsync(parameters, null, CancellationToken.None);

        public Task<string> ViewPipelineRawAsync(string parameters, CancellationToken cancellationToken) => ViewPipelineRawAsync(parameters, null, cancellationToken);

        public Task<string> ViewPipelineRawAsync(string parameters, int? limit) => ViewPipelineRawAsync(parameters, limit, CancellationToken.None);

        public Task<string> ViewPipelineRawAsync(string parameters, int? limit, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            return ViewPipelineInternalAsync(new JsonStringContent(parameters), limit, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> ViewPipelineInternalAsync<T>(HttpContent content, int? limit, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            var queryParameters = new QueryParameters();
            if (limit.HasValue)
            {
                queryParameters.Add(new QueryParameter("limit", limit.GetValueOrDefault().ToString()));
            }

            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}{queryParameters}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(ViewPipelineAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }
    }
}