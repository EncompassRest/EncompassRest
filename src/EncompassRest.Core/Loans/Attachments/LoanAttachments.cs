namespace EncompassRest.Loans.Attachments
{
    /// <summary>
    /// The Loan Attachments Apis.
    /// </summary>
    public interface ILoanAttachments : ILoanApiObject
    {
    }

    internal sealed class LoanAttachments : LoanApiObject, ILoanAttachments
    {
        internal LoanAttachments(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "attachments")
        {
        }
    }
}