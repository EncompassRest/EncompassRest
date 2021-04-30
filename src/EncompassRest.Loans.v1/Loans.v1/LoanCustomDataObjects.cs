using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1
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
        /// <inheritdoc/>
        public string LoanId { get; }

        internal LoanCustomDataObjects(EncompassRestClient client, string loanId)
            : base(client, $"encompass/v1/loans/{loanId}/customObjects")
        {
            LoanId = loanId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{LoanId}{resourceId?.PrecedeWith("/")}");
    }
}