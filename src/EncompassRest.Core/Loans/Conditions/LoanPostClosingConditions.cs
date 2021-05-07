namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan PostClosing Conditions Apis exposed as extension methods from the EncompassRest.EFolder package
    /// within the EncompassRest.Loans.Conditions.v1 namespace.
    /// </summary>
    public interface ILoanPostClosingConditions : ILoanApiObject
    {
    }

    internal sealed class LoanPostClosingConditions : LoanApiObject, ILoanPostClosingConditions
    {
        internal LoanPostClosingConditions(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}