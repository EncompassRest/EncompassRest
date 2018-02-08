using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.MilestoneFreeRoles
{
    public sealed class LoanMilestoneFreeRoles : LoanApiObject
    {
        internal LoanMilestoneFreeRoles(EncompassRestClient client, string loanId)
            : base(client, loanId, "milestoneFreeRoles")
        {
        }

        public Task<List<LoanMilestoneFreeRole>> GetMilestoneFreeRolesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanMilestoneFreeRole>(null, null, nameof(GetMilestoneFreeRolesAsync), null, cancellationToken);

        public Task<string> GetMilestoneFreeRolesRawAsync(CancellationToken cancellationToken = default) => GetRawAsync(null, null, nameof(GetMilestoneFreeRolesRawAsync), null, cancellationToken);

        public Task<LoanMilestoneFreeRole> GetMilestoneFreeRoleAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync<LoanMilestoneFreeRole>(logId, null, nameof(GetMilestoneFreeRoleAsync), logId, cancellationToken);
        }

        public Task<string> GetMilestoneFreeRoleRawAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, null, nameof(GetMilestoneFreeRoleRawAsync), logId, cancellationToken);
        }

        public Task UpdateMilestoneFreeRoleAsync(LoanMilestoneFreeRole milestoneFreeRole, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(milestoneFreeRole, nameof(milestoneFreeRole));
            Preconditions.NotNullOrEmpty(milestoneFreeRole.Id, $"{nameof(milestoneFreeRole)}.{nameof(milestoneFreeRole.Id)}");

            return PatchAsync(milestoneFreeRole.Id, null, JsonStreamContent.Create(milestoneFreeRole), nameof(UpdateMilestoneFreeRoleAsync), milestoneFreeRole.Id, cancellationToken);
        }

        public Task UpdateMilestoneFreeRoleRawAsync(string logId, string milestoneFreeRole, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNullOrEmpty(milestoneFreeRole, nameof(milestoneFreeRole));

            return PatchAsync(logId, null, new JsonStringContent(milestoneFreeRole), nameof(UpdateMilestoneFreeRoleRawAsync), logId, cancellationToken);
        }
    }
}