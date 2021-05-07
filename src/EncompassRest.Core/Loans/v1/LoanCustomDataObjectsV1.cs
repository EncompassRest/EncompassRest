using EncompassRest.CustomDataObjects.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// The Loan Custom Data Objects Apis.
    /// </summary>
    public interface ILoanCustomDataObjectsV1 : ICustomDataObjectsV1, ILoanApiObject
    {
    }

    internal sealed class LoanCustomDataObjectsV1 : CustomDataObjectsV1, ILoanCustomDataObjectsV1
    {
        public ILoanApis LoanApis { get; }

        public string LoanId { get; }

        internal LoanCustomDataObjectsV1(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, $"encompass/v1/loans/{loanId}/customObjects")
        {
            LoanApis = loanApis;
            LoanId = loanId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{LoanId}{resourceId?.PrecedeWith("/")}");
    }
}