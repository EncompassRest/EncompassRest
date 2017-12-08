using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanBatch
{
    public sealed class BatchUpdate : ApiObject
    {
        internal BatchUpdate(EncompassRestClient client)
            : base(client, "encompass/v1/loanBatch/updateRequests")
        {
        }

        public Task<BatchUpdateStatus> GetStatusAsync(string requestId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetAsync<BatchUpdateStatus>(requestId, null, nameof(GetStatusAsync), requestId, cancellationToken);
        }

        public Task<string> GetStatusRawAsync(string requestId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetRawAsync(requestId, null, nameof(GetStatusRawAsync), requestId, cancellationToken);
        }

        public Task<string> UpdateLoansAsync(BatchUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync(null, null, JsonStreamContent.Create(parameters), nameof(UpdateLoansAsync), null, cancellationToken, ReadLocationFunc);
        }

        public Task<string> UpdateLoansRawAsync(string parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync(null, null, new JsonStringContent(parameters), nameof(UpdateLoansRawAsync), null, cancellationToken, ReadLocationFunc);
        }
    }
}