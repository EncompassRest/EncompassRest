namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// The Loan Rate Lock Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.RateLocks.v1 namespace.
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