namespace EncompassRest.Loans.Documents
{
    /// <summary>
    /// The Loan Documents Apis exposed as extension methods from the EncompassRest.EFolder package
    /// within the EncompassRest.Loans.Documents.v1 namespace.
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