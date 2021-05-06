namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Preliminary Conditions Apis exposed as extension methods from the EncompassRest.EFolder.v1 package
    /// within the EncompassRest.Loans.Conditions.v1 namespace.
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