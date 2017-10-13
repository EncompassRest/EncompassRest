using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline
{
    public sealed class LoanPipelineCursor
    {
        public EncompassRestClient Client { get; }

        public string CursorId { get; }

        public int Count { get; }

        public IEnumerable<string> Fields { get; }

        internal LoanPipelineCursor(EncompassRestClient client, string cursorId, int count, IEnumerable<string> fields)
        {
            Client = client;
            CursorId = cursorId;
            Count = count;
            Fields = fields ?? Array<string>.Empty;
        }

        public Task<LoanPipelineData> GetItemAsync(int index) => GetItemAsync(index, null, CancellationToken.None);

        public Task<LoanPipelineData> GetItemAsync(int index, CancellationToken cancellationToken) => GetItemAsync(index, null, cancellationToken);

        public Task<LoanPipelineData> GetItemAsync(int index, params string[] fields) => GetItemAsync(index, fields, CancellationToken.None);

        public Task<LoanPipelineData> GetItemAsync(int index, IEnumerable<string> fields) => GetItemAsync(index, fields, CancellationToken.None);

        public async Task<LoanPipelineData> GetItemAsync(int index, IEnumerable<string> fields, CancellationToken cancellationToken)
        {
            Preconditions.GreaterThanOrEquals(index, nameof(index), 0);
            Preconditions.LessThan(index, nameof(index), Count, nameof(Count));

            var data = await GetItemsAsync(index, 1, fields, cancellationToken).ConfigureAwait(false);
            return data[0];
        }

        public Task<List<LoanPipelineData>> GetItemsAsync(int start, int? limit) => GetItemsAsync(start, limit, null, CancellationToken.None);

        public Task<List<LoanPipelineData>> GetItemsAsync(int start, int? limit, CancellationToken cancellationToken) => GetItemsAsync(start, limit, null, cancellationToken);

        public Task<List<LoanPipelineData>> GetItemsAsync(int start, int? limit, params string[] fields) => GetItemsAsync(start, limit, fields, CancellationToken.None);

        public Task<List<LoanPipelineData>> GetItemsAsync(int start, int? limit, IEnumerable<string> fields) => GetItemsAsync(start, limit, fields, CancellationToken.None);

        public Task<List<LoanPipelineData>> GetItemsAsync(int start, int? limit, IEnumerable<string> fields, CancellationToken cancellationToken)
        {
            Preconditions.GreaterThanOrEquals(start, nameof(start), 0);
            Preconditions.LessThan(start, nameof(start), Count, nameof(Count));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            var queryParameters = new QueryParameters(
                new QueryParameter("cursor", CursorId),
                new QueryParameter("start", start.ToString()));
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.ToString());
            }
            var content = JsonStreamContent.Create(new { Fields = fields ?? Fields });

            return Client.Pipeline.ViewPipelineInternalAsync(content, queryParameters.ToString(), cancellationToken, nameof(GetItemsAsync), response => response.Content.ReadAsAsync<List<LoanPipelineData>>());
        }
        public Task<string> GetItemsRawAsync(int start, int? limit) => GetItemsRawAsync(start, limit, null, CancellationToken.None);

        public Task<string> GetItemsRawAsync(int start, int? limit, CancellationToken cancellationToken) => GetItemsRawAsync(start, limit, null, cancellationToken);

        public Task<string> GetItemsRawAsync(int start, int? limit, params string[] fields) => GetItemsRawAsync(start, limit, fields, CancellationToken.None);

        public Task<string> GetItemsRawAsync(int start, int? limit, IEnumerable<string> fields) => GetItemsRawAsync(start, limit, fields, CancellationToken.None);

        public Task<string> GetItemsRawAsync(int start, int? limit, IEnumerable<string> fields, CancellationToken cancellationToken)
        {
            Preconditions.GreaterThanOrEquals(start, nameof(start), 0);
            Preconditions.LessThan(start, nameof(start), Count, nameof(Count));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            var queryParameters = new QueryParameters(
                new QueryParameter("cursor", CursorId),
                new QueryParameter("start", start.ToString()));
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.ToString());
            }
            var content = JsonStreamContent.Create(new { Fields = fields ?? Fields });

            return Client.Pipeline.ViewPipelineInternalAsync(content, queryParameters.ToString(), cancellationToken, nameof(GetItemsRawAsync), response => response.Content.ReadAsStringAsync());
        }
    }
}