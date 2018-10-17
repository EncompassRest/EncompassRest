using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Apis
{
    public sealed class DisclosureTracking2015Logs : LoanApiObject<DisclosureTracking2015Log>
    {
        internal DisclosureTracking2015Logs(EncompassRestClient client, LoanObjectBoundApis loanObjectBoundApis, string loanId)
            : base(client, loanObjectBoundApis, loanId, "disclosureTracking2015")
        {
        }

        internal override IList<DisclosureTracking2015Log> GetInLoan(Loan loan) => loan.DisclosureTracking2015Logs;

        public Task<IList<DisclosureTracking2015Log>> GetDisclosureTrackingLogsAsync(CancellationToken cancellationToken = default) => GetAllAsync(nameof(GetDisclosureTrackingLogsAsync), cancellationToken);

        public Task<string> GetDisclosureTrackingLogsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetDisclosureTrackingLogsRawAsync), null, cancellationToken);

        public Task<DisclosureTracking2015Log> GetDisclosureTrackingLogAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync(logId, nameof(GetDisclosureTrackingLogAsync), cancellationToken);
        }

        public Task<string> GetDisclosureTrackingLogRawAsync(string logId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, queryString, nameof(GetDisclosureTrackingLogsRawAsync), logId, cancellationToken);
        }

        public Task<Dictionary<string, string>> GetSnapshotAsync(string logId, CancellationToken cancellationToken = default) => GetSnapshotAsync(logId, null, cancellationToken);

        public Task<Dictionary<string, string>> GetSnapshotAsync(string logId, Disclosure2015FormType type, CancellationToken cancellationToken = default) => GetSnapshotAsync(logId, type.Validate(nameof(type)).GetValue(), cancellationToken);

        public Task<Dictionary<string, string>> GetSnapshotAsync(string logId, string type, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(type))
            {
                queryParameters.Add("type", type);
            }
            return GetAsync<Dictionary<string, string>>($"{logId}/snapshot", queryParameters.ToString(), nameof(GetSnapshotAsync), logId, cancellationToken);
        }

        public Task<string> GetSnapshotRawAsync(string logId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync($"{logId}/snapshot", queryString, nameof(GetSnapshotRawAsync), logId, cancellationToken);
        }
    }
}