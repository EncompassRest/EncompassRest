using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Milestones
{
    public sealed class LoanMilestones : LoanApiObject
    {
        internal LoanMilestones(EncompassRestClient client, string loanId)
            : base(client, loanId, "milestones")
        {
        }

        public Task<List<LoanMilestone>> GetMilestonesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanMilestone>(null, null, nameof(GetMilestonesAsync), null, cancellationToken);

        public Task<string> GetMilestonesRawAsync(CancellationToken cancellationToken = default) => GetRawAsync(null, null, nameof(GetMilestonesRawAsync), null, cancellationToken);

        public Task<LoanMilestone> GetMilestoneAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync<LoanMilestone>(logId, null, nameof(GetMilestoneAsync), logId, cancellationToken);
        }

        public Task<string> GetMilestoneRawAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, null, nameof(GetMilestoneRawAsync), logId, cancellationToken);
        }

        public Task UpdateMilestoneAsync(LoanMilestone milestone, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(milestone, nameof(milestone));
            Preconditions.NotNullOrEmpty(milestone.Id, $"{nameof(milestone)}.{nameof(milestone.Id)}");

            return PatchAsync(milestone.Id, null, JsonStreamContent.Create(milestone), nameof(UpdateMilestoneAsync), milestone.Id, cancellationToken);
        }

        public Task UpdateMilestoneRawAsync(string logId, string milestone, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNullOrEmpty(milestone, nameof(milestone));

            return PatchAsync(logId, null, new JsonStringContent(milestone), nameof(UpdateMilestoneRawAsync), logId, cancellationToken);
        }
    }
}