using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.MilestoneFreeRoles.v1
{
    public static class LoanMilestoneFreeRolesExtensions
    {
        public static ILoanMilestoneFreeRolesV1? V1 { get; set; }

        private static ILoanMilestoneFreeRolesV1 GetV1(ILoanMilestoneFreeRoles milestoneFreeRoles)
        {
            var v1 = V1;
            if (milestoneFreeRoles is LoanMilestoneFreeRoles r)
            {
                v1 = (ILoanMilestoneFreeRolesV1)r.ExtensionData.GetOrAdd("v1", k => new LoanMilestoneFreeRolesV1(r.Client, r.LoanApis, r.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(milestoneFreeRoles, nameof(milestoneFreeRoles));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves the milestone-free log with the specified <paramref name="logId"/>.
        /// </summary>
        /// <param name="logId">The milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanMilestoneFreeRole> GetMilestoneFreeRoleAsync(this ILoanMilestoneFreeRoles milestoneFreeRoles, string logId, CancellationToken cancellationToken = default) => GetV1(milestoneFreeRoles).GetMilestoneFreeRoleAsync(logId, cancellationToken);

        /// <summary>
        /// Retrieves the milestone-free log with the specified <paramref name="logId"/> as raw json.
        /// </summary>
        /// <param name="logId">The milestone-free log ID.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetMilestoneFreeRoleRawAsync(this ILoanMilestoneFreeRoles milestoneFreeRoles, string logId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(milestoneFreeRoles).GetMilestoneFreeRoleRawAsync(logId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves all milestone-free logs for the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanMilestoneFreeRole>> GetMilestoneFreeRolesAsync(this ILoanMilestoneFreeRoles milestoneFreeRoles, CancellationToken cancellationToken = default) => GetV1(milestoneFreeRoles).GetMilestoneFreeRolesAsync(cancellationToken);

        /// <summary>
        /// Retrieves all milestone-free logs for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetMilestoneFreeRolesRawAsync(this ILoanMilestoneFreeRoles milestoneFreeRoles, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(milestoneFreeRoles).GetMilestoneFreeRolesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Updates the specified milestone-free role for the loan.
        /// </summary>
        /// <param name="milestoneFreeRole">The milestone-free role to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateMilestoneFreeRoleAsync(this ILoanMilestoneFreeRoles milestoneFreeRoles, LoanMilestoneFreeRole milestoneFreeRole, CancellationToken cancellationToken = default) => GetV1(milestoneFreeRoles).UpdateMilestoneFreeRoleAsync(milestoneFreeRole, cancellationToken);

        /// <summary>
        /// Updates the milestone-free role with the specified <paramref name="logId"/> for the loan from raw json.
        /// </summary>
        /// <param name="logId">The milestone-free log ID.</param>
        /// <param name="milestoneFreeRole">The milestone-free role to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateMilestoneFreeRoleRawAsync(this ILoanMilestoneFreeRoles milestoneFreeRoles, string logId, string milestoneFreeRole, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(milestoneFreeRoles).UpdateMilestoneFreeRoleRawAsync(logId, milestoneFreeRole, queryString, cancellationToken);
    }
}