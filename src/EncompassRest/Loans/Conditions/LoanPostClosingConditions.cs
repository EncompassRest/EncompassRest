namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan PostClosing Conditions Apis.
    /// </summary>
    public sealed class LoanPostClosingConditions : LoanConditions<PostClosingCondition>
    {
        internal LoanPostClosingConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "postclosing")
        {
        }
    }
}