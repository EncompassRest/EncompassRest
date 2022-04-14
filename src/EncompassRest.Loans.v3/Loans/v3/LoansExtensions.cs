using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v3
{
    /// <summary>
    /// The Loans Api extension methods.
    /// </summary>
    public static class LoansExtensions
    {
        /// <summary>
        /// The custom v3 Api implementation for unit testing.
        /// </summary>
        public static ILoansV3? V3 { get; set; }

        private static ILoansV3 GetV3(ILoans loans)
        {
            var v3 = V3;
            if (loans is Loans l)
            {
                v3 = l.ExtensionData.GetOrAdd(() => new LoansV3(l.Client));
            }
            else if (v3 == null)
            {
                Preconditions.NotNull(loans, nameof(loans));
                throw new InvalidOperationException("Must set V3 property when not using the default implementation");
            }
            return v3;
        }

        /// <summary>
        /// Gets the loan field descriptors.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <returns></returns>
        public static ILoanFieldDescriptors GetFieldDescriptors(this ILoans loans) => GetV3(loans).FieldDescriptors;

        internal static ILoanObjectBoundApis GetLoanApis(this ILoans loans, Loan loan) => GetV3(loans).GetLoanApis(loan);

        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="options">The loan retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Loan> GetLoanAsync(this ILoans loans, string loanId, LoanRetrievalOptions? options = null, CancellationToken cancellationToken = default) => GetV3(loans).GetLoanAsync(loanId, options, cancellationToken);

        /// <summary>
        /// Returns the entire loan or specific entities of a loan as raw json.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetLoanRawAsync(this ILoans loans, string loanId, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(loans).GetLoanRawAsync(loanId, queryString, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass with the optionally specified <paramref name="options"/> and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to create.</param>
        /// <param name="options">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanAsync(this ILoans loans, Loan loan, LoanCreationOptions options, CancellationToken cancellationToken = default) => GetV3(loans).CreateLoanAsync(loan, options, cancellationToken);

        /// <summary>
        /// Creates a new loan in Encompass using raw json and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateLoanRawAsync(this ILoans loans, string loan, string queryString, CancellationToken cancellationToken = default) => GetV3(loans).CreateLoanRawAsync(loan, queryString, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed with the optionally specified <paramref name="options"/>.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loan">The loan to update.</param>
        /// <param name="options">The loan update options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateLoanAsync(this ILoans loans, Loan loan, LoanUpdateOptions? options = null, CancellationToken cancellationToken = default) => GetV3(loans).UpdateLoanAsync(loan, options, cancellationToken);

        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed or by applying a loan template using raw json.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The loan id of the loan to update.</param>
        /// <param name="loan">The loan to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateLoanRawAsync(this ILoans loans, string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(loans).UpdateLoanRawAsync(loanId, loan, queryString, cancellationToken);

        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetV3(loans).DeleteLoanAsync(loanId, cancellationToken);

        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loans">The Loans Api Object.</param>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteLoanAsync(this ILoans loans, string loanId, CancellationToken cancellationToken = default) => GetV3(loans).TryDeleteLoanAsync(loanId, cancellationToken);
    }
}