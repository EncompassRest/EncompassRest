using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class LoanCustomDataObjects : CustomDataObjects.CustomDataObjects
    {
        public string LoanId { get; }

        internal LoanCustomDataObjects(EncompassRestClient client, string loanId)
            : base(client, $"encompass/v1/loans/{loanId}/customObjects")
        {
            LoanId = loanId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{LoanId}{resourceId?.PrecedeWith("/")}");
    }
}