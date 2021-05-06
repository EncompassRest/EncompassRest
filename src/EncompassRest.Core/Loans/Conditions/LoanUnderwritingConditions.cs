namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Underwriting Conditions Apis exposed as extension methods from the EncompassRest.EFolder.v1 package
    /// within the EncompassRest.Loans.Conditions.v1 namespace.
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