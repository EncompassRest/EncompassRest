namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Conditions Apis.
    /// </summary>
    public interface ILoanConditions : ILoanApiObject
    {
        /// <summary>
        /// The Loan PostClosing Conditions Apis.
        /// </summary>
        ILoanPostClosingConditions PostClosing { get; }
        /// <summary>
        /// The Loan Preliminary Conditions Apis.
        /// </summary>
        ILoanPreliminaryConditions Preliminary { get; }
        /// <summary>
        /// The Loan Underwriting Conditions Apis.
        /// </summary>
        ILoanUnderwritingConditions Underwriting { get; }
    }

    internal sealed class LoanConditions : LoanApiObject, ILoanConditions
    {
        private LoanUnderwritingConditions? _underwriting;
        private LoanPreliminaryConditions? _preliminary;
        private LoanPostClosingConditions? _postClosing;

        public ILoanUnderwritingConditions Underwriting => _underwriting ??= new LoanUnderwritingConditions(Client, LoanApis, LoanId);

        public ILoanPreliminaryConditions Preliminary => _preliminary ??= new LoanPreliminaryConditions(Client, LoanApis, LoanId);

        public ILoanPostClosingConditions PostClosing => _postClosing ??= new LoanPostClosingConditions(Client, LoanApis, LoanId);

        internal LoanConditions(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "conditions")
        {
        }
    }
}