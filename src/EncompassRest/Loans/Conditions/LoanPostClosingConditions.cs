namespace EncompassRest.Loans.Conditions
{
    public sealed class LoanPostClosingConditions : LoanConditions<PostClosingCondition>
    {
        internal LoanPostClosingConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "postclosing")
        {
        }
    }
}