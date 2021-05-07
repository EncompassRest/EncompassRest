namespace EncompassRest.Loans.Attachments
{
    /// <summary>
    /// The Loan Attachments Apis exposed as extension methods from the EncompassRest.EFolder package
    /// within the EncompassRest.Loans.Attachments.v1 namespace.
    /// </summary>
    public interface ILoanAttachments : ILoanApiObject
    {
    }

    internal sealed class LoanAttachments : LoanApiObject, ILoanAttachments
    {
        internal LoanAttachments(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}