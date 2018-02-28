using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Apis
{
    public sealed class BorrowerPairs : LoanApiObject<Application>
    {
        internal BorrowerPairs(EncompassRestClient client, LoanObjectBoundApis loanObjectBoundApis)
            : base(client, loanObjectBoundApis, "applications")
        {
        }

        internal BorrowerPairs(EncompassRestClient client, string loanId)
            : base(client, loanId, "applications")
        {
        }

        internal override IList<Application> GetInLoan(Loan loan) => loan.Applications;

        public Task<List<Application>> GetBorrowerPairsAsync(CancellationToken cancellationToken = default) => GetAllAsync<Application>(nameof(GetBorrowerPairsAsync), cancellationToken);

        public Task<string> GetBorrowerPairsRawAsync(string queryString = null, CancellationToken cancellation = default) => GetRawAsync(null, queryString, nameof(GetBorrowerPairsRawAsync), null, cancellation);

        public Task<Application> GetBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            return GetAsync<Application>(applicationId, nameof(GetBorrowerPairAsync), cancellationToken);
        }

        public Task<string> GetBorrowerPairRawAsync(string applicationId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            return GetRawAsync(applicationId, queryString, nameof(GetBorrowerPairRawAsync), applicationId, cancellationToken);
        }

        public Task<string> CreateBorrowerPairAsync(Application application, CancellationToken cancellationToken = default) => CreateBorrowerPairAsync(application, false, cancellationToken);

        private Task<string> CreateBorrowerPairAsync(Application application, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(application, nameof(application));
            Preconditions.NullOrEmpty(application.ApplicationId, $"{nameof(application)}.{nameof(application.ApplicationId)}");

            return CreateAsync(application, nameof(CreateBorrowerPairAsync), populate, cancellationToken);
        }

        public Task<string> CreateBorrowerPairRawAsync(string application, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(application, nameof(application));

            return PostAsync(null, queryString, new JsonStringContent(application), nameof(CreateBorrowerPairRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateBorrowerPairAsync(Application application, CancellationToken cancellationToken = default) => UpdateBorrowerPairAsync(application, false, cancellationToken);

        private Task UpdateBorrowerPairAsync(Application application, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(application, nameof(application));
            Preconditions.NotNullOrEmpty(application.ApplicationId, $"{nameof(application)}.{nameof(application.ApplicationId)}");

            return UpdateAsync(application, nameof(UpdateBorrowerPairAsync), populate, cancellationToken);
        }

        public Task<string> UpdateBorrowerPairRawAsync(string applicationId, string application, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));
            Preconditions.NotNullOrEmpty(application, nameof(application));

            return PatchRawAsync(applicationId, queryString, new JsonStringContent(application), nameof(UpdateBorrowerPairRawAsync), applicationId, cancellationToken);
        }

        public Task<bool> DeleteBorrowerPairAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            return DeleteAsync<Application>(applicationId, cancellationToken);
        }
    }
}