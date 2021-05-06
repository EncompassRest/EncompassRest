namespace EncompassRest.Loans.Apis
{
    /// <summary>
    /// The Loan Borrower Pairs Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.Apis.v1 namespace.
    /// </summary>
    public interface IBorrowerPairs : ILoanApiObject
    {
    }

    internal sealed class BorrowerPairs : LoanApiObject, IBorrowerPairs
    {
        internal BorrowerPairs(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}