namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loan Custom Data Objects Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.v1 namespace.
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