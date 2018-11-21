using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Conditions Apis.
    /// </summary>
    public sealed class LoanConditions : LoanApiObject
    {
        private LoanUnderwritingConditions _underwriting;
        private LoanPreliminaryConditions _preliminary;
        private LoanPostClosingConditions _postClosing;

        /// <summary>
        /// The Loan Underwriting Conditions Apis.
        /// </summary>
        public LoanUnderwritingConditions Underwriting => _underwriting ?? (_underwriting = new LoanUnderwritingConditions(Client, LoanId));

        /// <summary>
        /// The Loan Preliminary Conditions Apis.
        /// </summary>
        public LoanPreliminaryConditions Preliminary => _preliminary ?? (_preliminary = new LoanPreliminaryConditions(Client, LoanId));

        /// <summary>
        /// The Loan PostClosing Conditions Apis.
        /// </summary>
        public LoanPostClosingConditions PostClosing => _postClosing ?? (_postClosing = new LoanPostClosingConditions(Client, LoanId));

        internal LoanConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "conditions")
        {
        }
    }

    /// <summary>
    /// The Base Loan Conditions Apis Class.
    /// </summary>
    /// <typeparam name="TCondition"></typeparam>
    public abstract class LoanConditions<TCondition> : LoanApiObject
        where TCondition : LoanCondition
    {
        internal LoanConditions(EncompassRestClient client, string loanId, string baseApiPath)
            : base(client, loanId, $"conditions{baseApiPath?.PrecedeWith("/")}")
        {
        }

        /// <summary>
        /// Gets conditions for the loan.
        /// </summary>
        /// <param name="queryParameters">The condition query parameters to sent in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<TCondition>> GetConditionsAsync(ConditionQueryParameters queryParameters = null, CancellationToken cancellationToken = default) => GetDirtyListAsync<TCondition>(null, queryParameters?.ToString(), nameof(GetConditionsAsync), null, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetConditionsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetConditionsRawAsync), null, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<TCondition> GetConditionAsync(string conditionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));

            return GetDirtyAsync<TCondition>(conditionId, null, nameof(GetConditionAsync), conditionId, cancellationToken);
        }

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan as raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
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