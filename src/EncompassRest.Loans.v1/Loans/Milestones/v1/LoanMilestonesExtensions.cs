using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Milestones.v1
{
    public static class LoanMilestonesExtensions
    {
        public static ILoanMilestonesV1? V1 { get; set; }

        private static ILoanMilestonesV1 GetV1(ILoanMilestones loanMilestones)
        {
            var v1 = V1;
            if (loanMilestones is LoanMilestones m)
            {
                v1 = (ILoanMilestonesV1)m.ExtensionData.GetOrAdd("v1", k => new LoanMilestonesV1(m.Client, m.LoanApis, m.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanMilestones, nameof(loanMilestones));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves the milestone with the specified <paramref name="logId"/> for the loan.
        /// </summary>
        /// <param name="logId">The milestone log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanMilestone> GetMilestoneAsync(this ILoanMilestones loanMilestones, string logId, CancellationToken cancellationToken = default) => GetV1(loanMilestones).GetMilestoneAsync(logId, cancellationToken);

        /// <summary>
        /// Retrieves the milestone with the specified <paramref name="logId"/> for the loan as raw json.
        /// </summary>
        /// <param name="logId">The milestone log ID.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetMilestoneRawAsync(this ILoanMilestones loanMilestones, string logId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanMilestones).GetMilestoneRawAsync(logId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves all milestones for the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanMilestone>> GetMilestonesAsync(this ILoanMilestones loanMilestones, CancellationToken cancellationToken = default) => GetV1(loanMilestones).GetMilestonesAsync(cancellationToken);

        /// <summary>
        /// Retrieves all milestones for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetMilestonesRawAsync(this ILoanMilestones loanMilestones, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanMilestones).GetMilestonesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Updates the specified <paramref name="milestone"/> for the loan.
        /// </summary>
        /// <param name="milestone">The milestone to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateMilestoneAsync(this ILoanMilestones loanMilestones, LoanMilestone milestone, CancellationToken cancellationToken = default) => UpdateMilestoneAsync(loanMilestones, milestone, action: null, cancellationToken);

        /// <summary>
        /// Updates the specified <paramref name="milestone"/> for the loan.
        /// </summary>
        /// <param name="milestone">The milestone to update.</param>
        /// <param name="action">Specify the action to perform on the milestone such as finish or unfinish.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateMilestoneAsync(this ILoanMilestones loanMilestones, LoanMilestone milestone, MilestoneAction action, CancellationToken cancellationToken = default) => UpdateMilestoneAsync(loanMilestones, milestone, action.Validate(nameof(action)).GetValue(), cancellationToken);

        /// <summary>
        /// Updates the specified <paramref name="milestone"/> for the loan.
        /// </summary>
        /// <param name="milestone">The milestone to update.</param>
        /// <param name="action">Specify the action to perform on the milestone such as finish or unfinish.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateMilestoneAsync(this ILoanMilestones loanMilestones, LoanMilestone milestone, string? action, CancellationToken cancellationToken = default) => GetV1(loanMilestones).UpdateMilestoneAsync(milestone, action, cancellationToken);

        /// <summary>
        /// Updates the milestone with the specified <paramref name="logId"/> for the loan from raw json.
        /// </summary>
        /// <param name="logId">The milestone log ID.</param>
        /// <param name="milestone">The milestone to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateMilestoneRawAsync(this ILoanMilestones loanMilestones, string logId, string milestone, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanMilestones).UpdateMilestoneRawAsync(logId, milestone, queryString, cancellationToken);
    }
}