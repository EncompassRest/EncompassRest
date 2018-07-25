namespace EncompassRest.Loans.Conditions
{
    public sealed class LoanUnderwritingConditions : LoanConditions<UnderwritingCondition>
    {
        internal LoanUnderwritingConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "underwriting")
        {
        }
    }
}