namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loan Custom Data Objects Apis.
    /// </summary>
    public interface ILoanCustomDataObjects : ILoanApiObject
    {
    }

    internal sealed class LoanCustomDataObjects : LoanApiObject, ILoanCustomDataObjects
    {
        internal LoanCustomDataObjects(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}