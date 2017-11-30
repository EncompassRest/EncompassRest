using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline
{
    public sealed class Pipeline : ApiObject
    {
        internal Pipeline(EncompassRestClient client)
            : base(client, "encompass/v1/loanPipeline")
        {
        }

        public Task<CanonicalNames> GetCanonicalNamesAsync() => GetCanonicalNamesAsync(CancellationToken.None);

        public Task<CanonicalNames> GetCanonicalNamesAsync(CancellationToken cancellationToken) => GetAsync<CanonicalNames>("fieldDefinitions", null, nameof(GetCanonicalNamesAsync), null, cancellationToken);

        public Task<string> GetCanonicalNamesRawAsync() => GetCanonicalNamesRawAsync(CancellationToken.None);

        public Task<string> GetCanonicalNamesRawAsync(CancellationToken cancellationToken) => GetRawAsync("fieldDefinitions", null, nameof(GetCanonicalNamesRawAsync), null, cancellationToken);

        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters) => CreateCursorAsync(parameters, CancellationToken.None);

        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var queryParameters = new QueryParameters(
                new QueryParameter("limit", "1"),
                new QueryParameter("cursorType", "randomAccess"));

            return PostAsync(JsonStreamContent.Create(parameters), null, queryParameters.ToString(), nameof(CreateCursorAsync), null, cancellationToken, async response =>
            {
                var headers = response.Headers;
                const string countHeaderName = "x-total-count";
                if (!headers.TryGetValues(countHeaderName, out var counts))
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {countHeaderName} header", response).ConfigureAwait(false);
                }
                var countString = counts.First();
                if (!int.TryParse(countString, out var count) || count < 0)
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} invalid {countHeaderName} header value", response).ConfigureAwait(false);
                }
                if (count == 0)
                {
                    return null;
                }
                const string cursorIdHeaderName = "x-cursor";
                if (!headers.TryGetValues(cursorIdHeaderName, out var cursorIds))
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {cursorIdHeaderName} header", response).ConfigureAwait(false);
                }
                var cursorId = cursorIds.First();
                return new LoanPipelineCursor(Client, cursorId, count, parameters.Fields);
            });
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

            var queryParameters = new QueryParameters();
            if (limit.HasValue)
            {
                queryParameters.Add(new QueryParameter("limit", limit.GetValueOrDefault().ToString()));
            }

            return PostAsync<List<LoanPipelineData>>(JsonStreamContent.Create(parameters), null, queryParameters.ToString(), nameof(ViewPipelineAsync), null, cancellationToken);
        }

        public Task<string> ViewPipelineRawAsync(string parameters) => ViewPipelineRawAsync(parameters, (string)null, CancellationToken.None);

        public Task<string> ViewPipelineRawAsync(string parameters, CancellationToken cancellationToken) => ViewPipelineRawAsync(parameters, (string)null, cancellationToken);

        public Task<string> ViewPipelineRawAsync(string parameters, int? limit) => ViewPipelineRawAsync(parameters, limit, CancellationToken.None);

        public Task<string> ViewPipelineRawAsync(string parameters, int? limit, CancellationToken cancellationToken)
        {
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            var queryParameters = new QueryParameters();
            if (limit.HasValue)
            {
                queryParameters.Add(new QueryParameter("limit", limit.GetValueOrDefault().ToString()));
            }

            return ViewPipelineRawAsync(parameters, queryParameters.ToString(), cancellationToken);
        }

        public Task<string> ViewPipelineRawAsync(string parameters, string queryString) => ViewPipelineRawAsync(parameters, queryString, CancellationToken.None);

        public Task<string> ViewPipelineRawAsync(string parameters, string queryString, CancellationToken cancellationToken) => PostRawAsync(new JsonStringContent(parameters), null, queryString, nameof(ViewPipelineRawAsync), null, cancellationToken);
    }
}