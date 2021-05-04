using System;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Base Loan Api Interface.
    /// </summary>
    public interface ILoanApiObject : IApiObject
    {
        ILoanApis LoanApis { get; }

        /// <summary>
        /// The loan id associated with the Api.
        /// </summary>
        string LoanId { get; }
    }

    internal abstract class LoanApiObject : ApiObject, ILoanApiObject
    {
        public ILoanApis LoanApis { get; }

        public string LoanId { get; }

        internal LoanApiObject(EncompassRestClient client, ILoanApis? loanApis, string loanId, string? baseApiPath)
            : base(client, $"encompass/v1/loans/{loanId}{baseApiPath?.PrecedeWith("/")}")
        {
            LoanApis = loanApis ?? this as ILoanApis ?? throw new ArgumentNullException(nameof(loanApis));
            LoanId = loanId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{LoanId}{resourceId?.PrecedeWith("/")}");
    }
}