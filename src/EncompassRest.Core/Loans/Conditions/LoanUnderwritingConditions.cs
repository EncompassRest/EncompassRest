namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Underwriting Conditions Apis.
    /// </summary>
    public interface ILoanUnderwritingConditions : ILoanApiObject
    {
    }

    internal sealed class LoanUnderwritingConditions : LoanApiObject, ILoanUnderwritingConditions
    {
        internal LoanUnderwritingConditions(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}