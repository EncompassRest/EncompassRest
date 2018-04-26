using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Associates
{
    public sealed class LoanAssociates : LoanApiObject
    {
        internal LoanAssociates(EncompassRestClient client, string loanId)
            : base(client, loanId, "associates")
        {
        }

        public Task<List<LoanAssociate>> GetAssociatesAsync(CancellationToken cancellationToken = default) => GetAssociatesAsync(null, null, cancellationToken);

        public Task<List<LoanAssociate>> GetAssociatesAsync(string userId, string roleId, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(userId))
            {
                queryParameters.Add("userId", userId);
            }
            if (!string.IsNullOrEmpty(roleId))
            {
                queryParameters.Add("roleId", roleId);
            }

            return GetDirtyListAsync<LoanAssociate>(null, queryParameters.ToString(), nameof(GetAssociatesAsync), null, cancellationToken);
        }

        public Task<string> GetAssociatesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetAssociatesRawAsync), null, cancellationToken);

        public Task<LoanAssociate> GetAssociateAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync<LoanAssociate>(logId, null, nameof(GetAssociateAsync), logId, cancellationToken);
        }

        public Task<string> GetAssociateRawAsync(string logId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, queryString, nameof(GetAssociateRawAsync), logId, cancellationToken);
        }

        public Task AssignAssociateAsync(string logId, LoanAssociate associate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNull(associate, nameof(associate));
            Preconditions.NotNullOrEmpty(associate.Id, $"{nameof(associate)}.{nameof(associate.Id)}");
            Preconditions.NotNullOrEmpty(associate.LoanAssociateType.Value, $"{nameof(associate)}.{nameof(associate.LoanAssociateType)}");

            return PutAsync(logId, null, JsonStreamContent.Create(associate), nameof(AssignAssociateAsync), logId, cancellationToken);
        }

        public Task AssignAssociateRawAsync(string logId, string associate, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNullOrEmpty(associate, nameof(associate));

            return PutAsync(logId, queryString, new JsonStringContent(associate), nameof(AssignAssociateRawAsync), logId, cancellationToken);
        }

        public Task<bool> UnassignAssociateAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return DeleteAsync(logId, null, cancellationToken);
        }
    }
}