﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.MilestoneFreeRoles.v1
{
    /// <summary>
    /// The Loan Milestone Free Roles Apis.
    /// </summary>
    public interface ILoanMilestoneFreeRolesV1 : ILoanApiObject
    {
        /// <summary>
        /// Retrieves the milestone-free log with the specified <paramref name="logId"/>.
        /// </summary>
        /// <param name="logId">The milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanMilestoneFreeRole> GetMilestoneFreeRoleAsync(string logId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the milestone-free log with the specified <paramref name="logId"/> as raw json.
        /// </summary>
        /// <param name="logId">The milestone-free log ID.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetMilestoneFreeRoleRawAsync(string logId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all milestone-free logs for the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanMilestoneFreeRole>> GetMilestoneFreeRolesAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all milestone-free logs for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetMilestoneFreeRolesRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the specified milestone-free role for the loan.
        /// </summary>
        /// <param name="milestoneFreeRole">The milestone-free role to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateMilestoneFreeRoleAsync(LoanMilestoneFreeRole milestoneFreeRole, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the milestone-free role with the specified <paramref name="logId"/> for the loan from raw json.
        /// </summary>
        /// <param name="logId">The milestone-free log ID.</param>
        /// <param name="milestoneFreeRole">The milestone-free role to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateMilestoneFreeRoleRawAsync(string logId, string milestoneFreeRole, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class LoanMilestoneFreeRolesV1 : LoanApiObjectV1, ILoanMilestoneFreeRolesV1
    {
        internal LoanMilestoneFreeRolesV1(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "milestoneFreeRoles")
        {
        }

        public Task<List<LoanMilestoneFreeRole>> GetMilestoneFreeRolesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanMilestoneFreeRole>(null, null, nameof(GetMilestoneFreeRolesAsync), null, cancellationToken);

        public Task<string> GetMilestoneFreeRolesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetMilestoneFreeRolesRawAsync), null, cancellationToken);

        public Task<LoanMilestoneFreeRole> GetMilestoneFreeRoleAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync<LoanMilestoneFreeRole>(logId, null, nameof(GetMilestoneFreeRoleAsync), logId, cancellationToken);
        }

        public Task<string> GetMilestoneFreeRoleRawAsync(string logId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, queryString, nameof(GetMilestoneFreeRoleRawAsync), logId, cancellationToken);
        }

        public Task UpdateMilestoneFreeRoleAsync(LoanMilestoneFreeRole milestoneFreeRole, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(milestoneFreeRole, nameof(milestoneFreeRole));
            Preconditions.NotNullOrEmpty(milestoneFreeRole.Id, $"{nameof(milestoneFreeRole)}.{nameof(milestoneFreeRole.Id)}");

            return PatchAsync(milestoneFreeRole.Id, null, JsonStreamContent.Create(milestoneFreeRole), nameof(UpdateMilestoneFreeRoleAsync), milestoneFreeRole.Id, cancellationToken);
        }

        public Task UpdateMilestoneFreeRoleRawAsync(string logId, string milestoneFreeRole, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNullOrEmpty(milestoneFreeRole, nameof(milestoneFreeRole));

            return PatchAsync(logId, queryString, new JsonStringContent(milestoneFreeRole), nameof(UpdateMilestoneFreeRoleRawAsync), logId, cancellationToken);
        }
    }
}