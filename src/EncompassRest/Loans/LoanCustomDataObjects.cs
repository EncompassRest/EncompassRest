using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loan Custom Data Objects Apis.
    /// </summary>
    public interface ILoanCustomDataObjects : CustomDataObjects.ICustomDataObjects, ILoanApiObject
    {
    }

    /// <summary>
    /// The Loan Custom Data Objects Apis.
    /// </summary>
    public sealed class LoanCustomDataObjects : CustomDataObjects.CustomDataObjects, ILoanCustomDataObjects
    {
        /// <summary>
        /// The loan id associated with the Api.
        /// </summary>
        public string LoanId { get; }

        internal LoanCustomDataObjects(IEncompassRestClient client, string loanId)
            : base(client, $"encompass/v1/loans/{loanId}/customObjects")
        {
            LoanId = loanId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{LoanId}{resourceId?.PrecedeWith("/")}");
    }
}