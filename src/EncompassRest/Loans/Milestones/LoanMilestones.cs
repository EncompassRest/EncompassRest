using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Milestones
{
    /// <summary>
    /// The Loan Milestones Apis.
    /// </summary>
    public sealed class LoanMilestones : LoanApiObject
    {
        internal LoanMilestones(EncompassRestClient client, string loanId)
            : base(client, loanId, "milestones")
        {
        }

        /// <summary>
        /// Retrieves all milestones for the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<LoanMilestone>> GetMilestonesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanMilestone>(null, null, nameof(GetMilestonesAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves all milestones for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetMilestonesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetMilestonesRawAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves the milestone with the specified <paramref name="logId"/> for the loan.
        /// </summary>
        /// <param name="logId">The milestone log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanMilestone> GetMilestoneAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync<LoanMilestone>(logId, null, nameof(GetMilestoneAsync), logId, cancellationToken);
        }

        /// <summary>
        /// Retrieves the milestone with the specified <paramref name="logId"/> for the loan as raw json.
        /// </summary>
        /// <param name="logId">The milestone log ID.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetMilestoneRawAsync(string logId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, queryString, nameof(GetMilestoneRawAsync), logId, cancellationToken);
        }

        /// <summary>
        /// Updates the specified <paramref name="milestone"/> for the loan.
        /// </summary>
        /// <param name="milestone">The milestone to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateMilestoneAsync(LoanMilestone milestone, CancellationToken cancellationToken = default) => UpdateMilestoneAsync(milestone, null, cancellationToken);

        /// <summary>
        /// Updates the specified <paramref name="milestone"/> for the loan.
        /// </summary>
        /// <param name="milestone">The milestone to update.</param>
        /// <param name="action">Specify the action to perform on the milestone such as finish or unfinish.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        /// <returns></returns>
        public Task UpdateMilestoneAsync(LoanMilestone milestone, MilestoneAction action, CancellationToken cancellationToken = default) => UpdateMilestoneAsync(milestone, action.Validate(nameof(action)).GetValue(), cancellationToken);

        /// <summary>
        /// Updates the specified <paramref name="milestone"/> for the loan.
        /// </summary>
        /// <param name="milestone">The milestone to update.</param>
        /// <param name="action">Specify the action to perform on the milestone such as finish or unfinish.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateMilestoneAsync(LoanMilestone milestone, string action, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(milestone, nameof(milestone));
            Preconditions.NotNullOrEmpty(milestone.Id, $"{nameof(milestone)}.{nameof(milestone.Id)}");
            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(action))
            {
                queryParameters.Add("action", action);
            }

            return PatchAsync(milestone.Id, queryParameters.ToString(), JsonStreamContent.Create(milestone), nameof(UpdateMilestoneAsync), milestone.Id, cancellationToken);
        }

        /// <summary>
        /// Updates the milestone with the specified <paramref name="logId"/> for the loan from raw json.
        /// </summary>
        /// <param name="logId">The milestone log ID.</param>
        /// <param name="milestone">The milestone to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateMilestoneRawAsync(string logId, string milestone, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNullOrEmpty(milestone, nameof(milestone));

            return PatchAsync(logId, queryString, new JsonStringContent(milestone), nameof(UpdateMilestoneRawAsync), logId, cancellationToken);
        }
    }
}