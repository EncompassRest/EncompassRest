using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Milestones
{
    public sealed class LoanMilestones : LoanApiObject
    {
        internal LoanMilestones(EncompassRestClient client, string loanId)
            : base(client, loanId, "milestones")
        {
        }

        public Task<List<LoanMilestone>> GetMilestonesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanMilestone>(null, null, nameof(GetMilestonesAsync), null, cancellationToken);

        public Task<string> GetMilestonesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetMilestonesRawAsync), null, cancellationToken);

        public Task<LoanMilestone> GetMilestoneAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync<LoanMilestone>(logId, null, nameof(GetMilestoneAsync), logId, cancellationToken);
        }

        public Task<string> GetMilestoneRawAsync(string logId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, queryString, nameof(GetMilestoneRawAsync), logId, cancellationToken);
        }

        public Task UpdateMilestoneAsync(LoanMilestone milestone, CancellationToken cancellationToken = default) => UpdateMilestoneAsync(milestone, null, cancellationToken);

        public Task UpdateMilestoneAsync(LoanMilestone milestone, MilestoneAction action, CancellationToken cancellationToken = default) => UpdateMilestoneAsync(milestone, action.Validate(nameof(action)).GetValue(), cancellationToken);

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

        public Task UpdateMilestoneRawAsync(string logId, string milestone, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNullOrEmpty(milestone, nameof(milestone));

            return PatchAsync(logId, queryString, new JsonStringContent(milestone), nameof(UpdateMilestoneRawAsync), logId, cancellationToken);
        }
    }
}