namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// The Loan PostClosing Conditions Apis.
    /// </summary>
    public interface ILoanPostClosingConditions : ILoanConditions<PostClosingCondition>
    {
    }

    /// <summary>
    /// The Loan PostClosing Conditions Apis.
    /// </summary>
    public sealed class LoanPostClosingConditions : LoanConditions<PostClosingCondition>, ILoanPostClosingConditions
    {
        internal LoanPostClosingConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "postclosing")
        {
        }
    }
}