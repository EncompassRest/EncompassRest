using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters) => CreateCursorAsync(parameters, CancellationToken.None);

        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return ViewPipelineCursorInternalAsync(null, parameters, null, null, 1, cancellationToken, nameof(CreateCursorAsync), async response =>
            {
                var headers = response.Headers;
                IEnumerable<string> counts;
                const string countHeaderName = "x-total-count";
                if (!headers.TryGetValues(countHeaderName, out counts))
                {
                    throw await RestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {countHeaderName} header", response).ConfigureAwait(false);
                }
                var countString = counts.First();
                int count;
                if (!int.TryParse(countString, out count) || count < 0)
                {
                    throw await RestException.CreateAsync($"{nameof(CreateCursorAsync)} invalid {countHeaderName} header value", response).ConfigureAwait(false);
                }
                if (count == 0)
                {
                    return null;
                }
                IEnumerable<string> cursorIds;
                const string cursorIdHeaderName = "x-cursor";
                if (!headers.TryGetValues(cursorIdHeaderName, out cursorIds))
                {
                    throw await RestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {cursorIdHeaderName} header", response).ConfigureAwait(false);
                }
                var cursorId = cursorIds.First();
                return new LoanPipelineCursor(Client, cursorId, count, parameters.Fields);
            });
        }

        internal async Task<T> ViewPipelineCursorInternalAsync<T>(string cursorId, PipelineParameters parameters, IEnumerable<string> fields, int? start, int? limit, CancellationToken cancellationToken, string methodName, Func<HttpResponseMessage, Task<T>> func)
        {
            var queryParameters = new QueryParameters();

            if (start.HasValue)
            {
                queryParameters.Add("start", start.GetValueOrDefault().ToString());
            }
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.ToString());
            }
            JsonStreamContent content;
            if (string.IsNullOrEmpty(cursorId))
            {
                queryParameters.Add("cursorType", "randomAccess");
                content = JsonStreamContent.Create(parameters);
            }
            else
            {
                queryParameters.Add("cursor", cursorId);
                content = JsonStreamContent.Create(new { Fields = fields });
            }

            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}{queryParameters}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(methodName, response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters) => ViewPipelineAsync(parameters, null, CancellationToken.None);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, CancellationToken cancellationToken) => ViewPipelineAsync(parameters, null, cancellationToken);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit) => ViewPipelineAsync(parameters, limit, CancellationToken.None);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit, CancellationToken cancellationToken)
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