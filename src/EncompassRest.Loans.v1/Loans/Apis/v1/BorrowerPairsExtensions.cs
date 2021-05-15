using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Apis.v1
{
    /// <summary>
    /// The Loan Borrower Pairs Api extension methods.
    /// </summary>
    public static class BorrowerPairsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IBorrowerPairsV1? V1 { get; set; }

        private static IBorrowerPairsV1 GetV1(IBorrowerPairs borrowerPairs)
        {
            var v1 = V1;
            if (borrowerPairs is BorrowerPairs b)
            {
                v1 = b.ExtensionData.GetOrAdd(() => new BorrowerPairsV1(b.Client, b.LoanApis, b.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(borrowerPairs, nameof(borrowerPairs));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Creates a new borrower pair for the loan and returns the application id.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="application">The borrower pair to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateBorrowerPairAsync(this IBorrowerPairs borrowerPairs, Application application, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).CreateBorrowerPairAsync(application, cancellationToken);

        /// <summary>
        /// Creates a new borrower pair for the loan from raw json and returns the response body if not empty or else the application id.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="application">The borrower pair to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateBorrowerPairRawAsync(this IBorrowerPairs borrowerPairs, string application, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).CreateBorrowerPairRawAsync(application, queryString);

        /// <summary>
        /// Permanently deletes the borrower pair with the specified <paramref name="applicationId"/> from the loan.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="applicationId">The application id of the borrower pair to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteBorrowerPairAsync(this IBorrowerPairs borrowerPairs, string applicationId, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).DeleteBorrowerPairAsync(applicationId, cancellationToken);

        /// <summary>
        /// Retrieves the loan's borrower pair with the specified <paramref name="applicationId"/>.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="applicationId">The application id of the borrower pair to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Application> GetBorrowerPairAsync(this IBorrowerPairs borrowerPairs, string applicationId, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).GetBorrowerPairAsync(applicationId, cancellationToken);

        /// <summary>
        /// Retrieves the loan's borrower pair with the specified <paramref name="applicationId"/>.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="applicationId">The application id of the borrower pair to get.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetBorrowerPairRawAsync(this IBorrowerPairs borrowerPairs, string applicationId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).GetBorrowerPairRawAsync(applicationId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves all borrower pairs for the loan.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<IList<Application>> GetBorrowerPairsAsync(this IBorrowerPairs borrowerPairs, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).GetBorrowerPairsAsync(cancellationToken);

        /// <summary>
        /// Retrieves all borrower pairs for the loan as raw json.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetBorrowerPairsRawAsync(this IBorrowerPairs borrowerPairs, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).GetBorrowerPairsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Swaps the position of borrower pairs in the loan. Note that the <see cref="Borrower.AltId"/> of the borrower and co-borrower do not change on the applications.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="applications">The applications to swap.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task MoveBorrowerPairsAsync(this IBorrowerPairs borrowerPairs, IList<Application> applications, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).MoveBorrowerPairsAsync(applications, cancellationToken);

        /// <summary>
        /// Swaps the position of borrower pairs in the loan from raw json. Note that the altIds of the borrower and co-borrower do not change on the applications.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="applications">The applications to swap as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task MoveBorrowerPairsRawAsync(this IBorrowerPairs borrowerPairs, string applications, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).MoveBorrowerPairsRawAsync(applications, queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the borrower pair with the specified <paramref name="applicationId"/> from the loan.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="applicationId">The application id of the borrower pair to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteBorrowerPairAsync(this IBorrowerPairs borrowerPairs, string applicationId, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).TryDeleteBorrowerPairAsync(applicationId, cancellationToken);

        /// <summary>
        /// Updates an existing borrower pair for the loan.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="application">The borrower pair to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateBorrowerPairAsync(this IBorrowerPairs borrowerPairs, Application application, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).UpdateBorrowerPairAsync(application, cancellationToken);

        /// <summary>
        /// Updates an existing borrower pair for the loan from raw json.
        /// </summary>
        /// <param name="borrowerPairs">The Loan Borrower Pairs Api Object.</param>
        /// <param name="applicationId">The application id of the borrower pair to update.</param>
        /// <param name="application">The borrower pair to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateBorrowerPairRawAsync(this IBorrowerPairs borrowerPairs, string applicationId, string application, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(borrowerPairs).UpdateBorrowerPairRawAsync(applicationId, application, queryString, cancellationToken);
    }
}