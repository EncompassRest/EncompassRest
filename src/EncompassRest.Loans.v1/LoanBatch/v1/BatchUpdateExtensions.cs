using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanBatch.v1
{
    /// <summary>
    /// The Loan Batch Update Apis.
    /// </summary>
    public static class BatchUpdateExtensions
    {
        public static IBatchUpdateV1? V1 { get; set; }

        private static IBatchUpdateV1 GetV1(IBatchUpdate batchUpdate)
        {
            var v1 = V1;
            if (batchUpdate is BatchUpdate b)
            {
                v1 = (IBatchUpdateV1)b.ExtensionData.GetOrAdd("v1", k => new BatchUpdateV1(b.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(batchUpdate, nameof(batchUpdate));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <inheritdoc/>
        public static Task<BatchUpdateStatus> GetStatusAsync(this IBatchUpdate batchUpdate, string requestId, CancellationToken cancellationToken = default) => GetV1(batchUpdate).GetStatusAsync(requestId, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> GetStatusRawAsync(this IBatchUpdate batchUpdate, string requestId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(batchUpdate).GetStatusRawAsync(requestId, queryString, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> UpdateLoansAsync(this IBatchUpdate batchUpdate, BatchUpdateParameters parameters, CancellationToken cancellationToken = default) => GetV1(batchUpdate).UpdateLoansAsync(parameters, cancellationToken);

        /// <inheritdoc/>
        public static Task<string> UpdateLoansRawAsync(this IBatchUpdate batchUpdate, string parameters, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(batchUpdate).UpdateLoansRawAsync(parameters, queryString, cancellationToken);
    }
}