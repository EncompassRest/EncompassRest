using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Utilities;

namespace EncompassApi.LoanBatch
{
    /// <summary>
    /// The Loan Batch Update Apis.
    /// </summary>
    public interface IBatchUpdate : IApiObject
    {
        /// <summary>
        /// Retrieves the status for the loan batch update with <paramref name="requestId"/>.
        /// </summary>
        /// <param name="requestId">The loan batch update request id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<BatchUpdateStatus> GetStatusAsync(string requestId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the status for the loan batch update with <paramref name="requestId"/> as raw json.
        /// </summary>
        /// <param name="requestId">The loan batch update request id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetStatusRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Submits a batch request to the server to update multiple loans and returns the batch update request id.
        /// </summary>
        /// <param name="parameters">The batch update parameters.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateLoansAsync(BatchUpdateParameters parameters, CancellationToken cancellationToken = default);
        /// <summary>
        /// Submits a batch request to the server to update multiple loans from raw json and returns the batch update request id.
        /// </summary>
        /// <param name="parameters">The batch update parameters as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateLoansRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Batch Update Apis.
    /// </summary>
    public sealed class BatchUpdate : ApiObject, IBatchUpdate
    {
        internal BatchUpdate(IEncompassApiClient client)
            : base(client, "encompass/v1/loanBatch/updateRequests")
        {
        }

        /// <inheritdoc/>
        public Task<BatchUpdateStatus> GetStatusAsync(string requestId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetAsync<BatchUpdateStatus>(requestId, null, nameof(GetStatusAsync), requestId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetStatusRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetRawAsync(requestId, queryString, nameof(GetStatusRawAsync), requestId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> UpdateLoansAsync(BatchUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync(null, null, JsonStreamContent.Create(parameters), nameof(UpdateLoansAsync), null, cancellationToken, ReadLocationFunc);
        }

        /// <inheritdoc/>
        public Task<string> UpdateLoansRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            return PostAsync(null, queryString, new JsonStringContent(parameters), nameof(UpdateLoansRawAsync), null, cancellationToken, ReadLocationFunc);
        }
    }
}