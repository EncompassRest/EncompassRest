using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Associates.v1
{
    /// <summary>
    /// The Loan Associates Api extension methods.
    /// </summary>
    public static class LoanAssociatesExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanAssociatesV1? V1 { get; set; }

        private static ILoanAssociatesV1 GetV1(ILoanAssociates loanAssociates)
        {
            var v1 = V1;
            if (loanAssociates is LoanAssociates a)
            {
                v1 = a.ExtensionData.GetOrAdd(() => new LoanAssociatesV1(a.Client, a.LoanApis, a.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanAssociates, nameof(loanAssociates));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Assigns a loan associate to a milestone based on the specified milestone or milestone-free ID and log ID.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="associate">The loan associate to assign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignAssociateAsync(this ILoanAssociates loanAssociates, string logId, LoanAssociate associate, CancellationToken cancellationToken = default) => GetV1(loanAssociates).AssignAssociateAsync(logId, associate, cancellationToken);

        /// <summary>
        /// Assigns a loan associate to a milestone based on the specified milestone or milestone-free ID and log ID from raw json.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="associate">The loan associate to assign as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignAssociateRawAsync(this ILoanAssociates loanAssociates, string logId, string associate, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAssociates).AssignAssociateRawAsync(logId, associate, queryString, cancellationToken);

        /// <summary>
        /// Retrieves information about a loan associate based on the milestone or milestone-free role ID. The response includes the associate's role and contact information.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanAssociate> GetAssociateAsync(this ILoanAssociates loanAssociates, string logId, CancellationToken cancellationToken = default) => GetV1(loanAssociates).GetAssociateAsync(logId, cancellationToken);

        /// <summary>
        /// Retrieves information about a loan associate based on the milestone or milestone-free role ID as raw json.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetAssociateRawAsync(this ILoanAssociates loanAssociates, string logId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAssociates).GetAssociateRawAsync(logId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves a list of loan associates involved with the loan. The response includes role and contact information for each loan associate.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanAssociate>> GetAssociatesAsync(this ILoanAssociates loanAssociates, CancellationToken cancellationToken = default) => GetAssociatesAsync(loanAssociates, null, null, cancellationToken);

        /// <summary>
        /// Retrieves a list of loan associates involved with the loan. The response includes role and contact information for each loan associate.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="userId">When provided, returns information about the Encompass user associated with the loan.</param>
        /// <param name="roleId">When provided, returns information about all Encompass users associated with the specified role ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanAssociate>> GetAssociatesAsync(this ILoanAssociates loanAssociates, string? userId, string? roleId, CancellationToken cancellationToken = default) => GetV1(loanAssociates).GetAssociatesAsync(userId, roleId, cancellationToken);

        /// <summary>
        /// Retrieves a list of loan associates involved with the loan as raw json.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetAssociatesRawAsync(this ILoanAssociates loanAssociates, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanAssociates).GetAssociatesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Unassigns a loan associate from a milestone based on the specified milestone or milestone-free ID.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        [Obsolete("Undocumented API")]
        public static Task<bool> TryUnassignAssociateAsync(this ILoanAssociates loanAssociates, string logId, CancellationToken cancellationToken = default) => GetV1(loanAssociates).TryUnassignAssociateAsync(logId, cancellationToken);

        /// <summary>
        /// Unassigns a loan associate from a milestone based on the specified milestone or milestone-free ID.
        /// </summary>
        /// <param name="loanAssociates">The Loan Associates Api Object.</param>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        [Obsolete("Undocumented API")]
        public static Task UnassignAssociateAsync(this ILoanAssociates loanAssociates, string logId, CancellationToken cancellationToken = default) => GetV1(loanAssociates).UnassignAssociateAsync(logId, cancellationToken);
    }
}