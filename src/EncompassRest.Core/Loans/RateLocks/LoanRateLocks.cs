namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// The Loan Rate Lock Apis.
    /// </summary>
    public interface ILoanRateLocks : ILoanApiObject
    {
    }

    internal sealed class LoanRateLocks : LoanApiObject, ILoanRateLocks
    {
        internal LoanRateLocks(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}