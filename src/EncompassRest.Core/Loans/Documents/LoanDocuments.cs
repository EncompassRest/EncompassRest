namespace EncompassRest.Loans.Documents
{
    /// <summary>
    /// The Loan Documents Apis.
    /// </summary>
    public interface ILoanDocuments : ILoanApiObject
    {
    }

    internal sealed class LoanDocuments : LoanApiObject, ILoanDocuments
    {
        internal LoanDocuments(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}