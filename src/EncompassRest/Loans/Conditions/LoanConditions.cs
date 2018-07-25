using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Conditions
{
    public sealed class LoanConditions : LoanApiObject
    {
        private LoanUnderwritingConditions _underwriting;
        private LoanPreliminaryConditions _preliminary;
        private LoanPostClosingConditions _postClosing;

        public LoanUnderwritingConditions Underwriting => _underwriting ?? (_underwriting = new LoanUnderwritingConditions(Client, LoanId));

        public LoanPreliminaryConditions Preliminary => _preliminary ?? (_preliminary = new LoanPreliminaryConditions(Client, LoanId));

        public LoanPostClosingConditions PostClosing => _postClosing ?? (_postClosing = new LoanPostClosingConditions(Client, LoanId));

        internal LoanConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "conditions")
        {
        }
    }

    public abstract class LoanConditions<TCondition> : LoanApiObject
        where TCondition : LoanCondition
    {
        internal LoanConditions(EncompassRestClient client, string loanId, string baseApiPath)
            : base(client, loanId, $"conditions{baseApiPath?.PrecedeWith("/")}")
        {
        }

        public Task<List<TCondition>> GetConditionsAsync(ConditionQueryParameters queryParameters = null, CancellationToken cancellationToken = default) => GetDirtyListAsync<TCondition>(null, queryParameters?.ToString(), nameof(GetConditionsAsync), null, cancellationToken);

        public Task<string> GetConditionsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetConditionsRawAsync), null, cancellationToken);

        public Task<TCondition> GetConditionAsync(string conditionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));

            return GetDirtyAsync<TCondition>(conditionId, null, nameof(GetConditionAsync), conditionId, cancellationToken);
        }

        public Task<string> GetConditionRawAsync(string conditionId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));

            return GetRawAsync(conditionId, queryString, nameof(GetConditionRawAsync), conditionId, cancellationToken);
        }

        // Undocumented
        internal Task<string> CreateConditionAsync(TCondition condition, CancellationToken cancellationToken = default) => CreateConditionAsync(condition, false, cancellationToken);

        // Undocumented
        internal Task<string> CreateConditionAsync(TCondition condition, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(condition, nameof(condition));
            Preconditions.NullOrEmpty(condition.Id, $"{nameof(condition)}.{nameof(condition.Id)}");

            return PostPopulateDirtyAsync(null, nameof(CreateConditionAsync), condition, populate, cancellationToken);
        }
    }
}