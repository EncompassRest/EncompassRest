namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Preliminary Conditions Apis.
    /// </summary>
    public interface ILoanPreliminaryConditions : ILoanApiObject
    {
    }

    internal sealed class LoanPreliminaryConditions : LoanApiObject, ILoanPreliminaryConditions
    {
        internal LoanPreliminaryConditions(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}