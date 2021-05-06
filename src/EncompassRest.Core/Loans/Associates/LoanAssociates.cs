namespace EncompassRest.Loans.Associates
{
    /// <summary>
    /// The Loan Associates Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.Associates.v1 namespace.
    /// </summary>
    public interface ILoanAssociates : ILoanApiObject
    {
    }

    internal sealed class LoanAssociates : LoanApiObject, ILoanAssociates
    {
        internal LoanAssociates(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}