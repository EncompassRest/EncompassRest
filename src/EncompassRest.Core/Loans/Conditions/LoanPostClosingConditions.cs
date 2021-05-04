namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan PostClosing Conditions Apis.
    /// </summary>
    public interface ILoanPostClosingConditions : ILoanApiObject
    {
    }

    internal sealed class LoanPostClosingConditions : LoanApiObject, ILoanPostClosingConditions
    {
        internal LoanPostClosingConditions(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "postclosing")
        {
        }
    }
}