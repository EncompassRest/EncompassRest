namespace EncompassRest.Loans.Conditions
{
    public sealed class LoanPreliminaryConditions : LoanConditions<PreliminaryCondition>
    {
        internal LoanPreliminaryConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "preliminary")
        {
        }
    }
}