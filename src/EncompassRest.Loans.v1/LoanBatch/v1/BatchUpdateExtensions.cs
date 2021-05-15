using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanBatch.v1
{
    /// <summary>
    /// The Loan Batch Update Api extension methods.
    /// </summary>
    public static class BatchUpdateExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IBatchUpdateV1? V1 { get; set; }

        private static IBatchUpdateV1 GetV1(IBatchUpdate batchUpdate)
        {
            var v1 = V1;
            if (batchUpdate is BatchUpdate b)
            {
                v1 = b.ExtensionData.GetOrAdd(() => new BatchUpdateV1(b.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(batchUpdate, nameof(batchUpdate));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves the status for the loan batch update with <paramref name="requestId"/>.
        /// </summary>
        /// <param name="batchUpdate">The Loan Batch Update Api Object.</param>
        /// <param name="requestId">The loan batch update request id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<BatchUpdateStatus> GetStatusAsync(this IBatchUpdate batchUpdate, string requestId, CancellationToken cancellationToken = default) => GetV1(batchUpdate).GetStatusAsync(requestId, cancellationToken);

        /// <summary>
        /// Retrieves the status for the loan batch update with <paramref name="requestId"/> as raw json.
        /// </summary>
        /// <param name="batchUpdate">The Loan Batch Update Api Object.</param>
        /// <param name="requestId">The loan batch update request id.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetStatusRawAsync(this IBatchUpdate batchUpdate, string requestId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(batchUpdate).GetStatusRawAsync(requestId, queryString, cancellationToken);

        /// <summary>
        /// Submits a batch request to the server to update multiple loans and returns the batch update request id.
        /// </summary>
        /// <param name="batchUpdate">The Loan Batch Update Api Object.</param>
        /// <param name="parameters">The batch update parameters.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateLoansAsync(this IBatchUpdate batchUpdate, BatchUpdateParameters parameters, CancellationToken cancellationToken = default) => GetV1(batchUpdate).UpdateLoansAsync(parameters, cancellationToken);

        /// <summary>
        /// Submits a batch request to the server to update multiple loans from raw json and returns the batch update request id.
        /// </summary>
        /// <param name="batchUpdate">The Loan Batch Update Api Object.</param>
        /// <param name="parameters">The batch update parameters as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateLoansRawAsync(this IBatchUpdate batchUpdate, string parameters, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(batchUpdate).UpdateLoansRawAsync(parameters, queryString, cancellationToken);
    }
}