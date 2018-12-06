namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Underwriting Conditions Apis.
    /// </summary>
    public sealed class LoanUnderwritingConditions : LoanConditions<UnderwritingCondition>
    {
        internal LoanUnderwritingConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "underwriting")
        {
        }
    }
}