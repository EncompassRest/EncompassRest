namespace EncompassRest.Loans.Apis
{
    /// <summary>
    /// The Loan Borrower Pairs Apis.
    /// </summary>
    public interface IBorrowerPairs : ILoanApiObject
    {
    }

    internal sealed class BorrowerPairs : LoanApiObject, IBorrowerPairs
    {
        internal BorrowerPairs(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "applications")
        {
        }
    }
}