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

        public Task<PipelineCanonicalNames> GetCanonicalNamesAsync(CancellationToken cancellationToken = default) => GetAsync<PipelineCanonicalNames>("fieldDefinitions", null, nameof(GetCanonicalNamesAsync), null, cancellationToken);

        public Task<string> GetCanonicalNamesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("fieldDefinitions", queryString, nameof(GetCanonicalNamesRawAsync), null, cancellationToken);

        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, CancellationToken cancellationToken = default) => CreateCursorAsync(parameters, null, cancellationToken);

        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var queryParameters = new QueryParameters(
                new QueryParameter("limit", "1"),
                new QueryParameter("cursorType", "randomAccess"));

            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }

            return PostAsync(null, queryParameters.ToString(), JsonStreamContent.Create(parameters), nameof(CreateCursorAsync), null, cancellationToken, async response =>
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
                string cursorId = null;
                if (count > 0)
                {
                    const string cursorIdHeaderName = "x-cursor";
                    if (!headers.TryGetValues(cursorIdHeaderName, out var cursorIds))
                    {
                        throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {cursorIdHeaderName} header", response).ConfigureAwait(false);
                    }
                    cursorId = cursorIds.First();
                }
                return new LoanPipelineCursor(Client, cursorId, count, parameters.Fields);
            });
        }

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, CancellationToken cancellationToken = default) => ViewPipelineAsync(parameters, null, null, cancellationToken);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit, CancellationToken cancellationToken = default) => ViewPipelineAsync(parameters, limit, null, cancellationToken);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => ViewPipelineAsync(parameters, null, ignoreInvalidFields, cancellationToken);

        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit, bool? ignoreInvalidFields, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            var queryParameters = new QueryParameters();
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.GetValueOrDefault().ToString());
            }
            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }

            return PostAsync<List<LoanPipelineData>>(null, queryParameters.ToString(), JsonStreamContent.Create(parameters), nameof(ViewPipelineAsync), null, cancellationToken);
        }

        public Task<string> ViewPipelineRawAsync(string parameters, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));

            return PostRawAsync(null, queryString, new JsonStringContent(parameters), nameof(ViewPipelineRawAsync), null, cancellationToken);
        }
    }
}