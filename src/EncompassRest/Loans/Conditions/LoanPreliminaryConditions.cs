namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Preliminary Conditions Apis.
    /// </summary>
    public sealed class LoanPreliminaryConditions : LoanConditions<PreliminaryCondition>
    {
        internal LoanPreliminaryConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "preliminary")
        {
        }
    }
}