using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanBatch
{
    /// <summary>
    /// The Loan Batch Update Apis.
    /// </summary>
    public sealed class BatchUpdate : ApiObject
    {
        internal BatchUpdate(EncompassRestClient client)
            : base(client, "encompass/v1/loanBatch/updateRequests")
        {
        }

        /// <summary>
        /// Retrieves the status for the loan batch update with <paramref name="requestId"/>.
        /// </summary>
        /// <param name="requestId">The loan batch update request id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<BatchUpdateStatus> GetStatusAsync(string requestId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetAsync<BatchUpdateStatus>(requestId, null, nameof(GetStatusAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Retrieves the status for the loan batch update with <paramref name="requestId"/> as raw json.
        /// </summary>
        /// <param name="requestId">The loan batch update request id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetStatusRawAsync(string requestId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetRawAsync(requestId, queryString, nameof(GetStatusRawAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Submits a batch request to the server to update multiple loans and returns the batch update request id.
        /// </summary>
        /// <param name="parameters">The batch update parameters.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateLoansAsync(BatchUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync(null, null, JsonStreamContent.Create(parameters), nameof(UpdateLoansAsync), null, cancellationToken, ReadLocationFunc);
        }

        /// <summary>
        /// Submits a batch request to the server to update multiple loans from raw json and returns the batch update request id.
        /// </summary>
        /// <param name="parameters">The batch update parameters as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateLoansRawAsync(string parameters, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync(null, queryString, new JsonStringContent(parameters), nameof(UpdateLoansRawAsync), null, cancellationToken, ReadLocationFunc);
        }
    }
}