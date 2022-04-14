using EncompassRest.Utilities;

namespace EncompassRest.Loans.v3
{
    internal abstract class LoanApiObjectV3 : LoanApiObject, ILoanApiObject
    {
        internal LoanApiObjectV3(EncompassRestClient client, ILoanApis? loanApis, string loanId, string? baseApiPath)
            : base(client, loanApis, loanId, $"encompass/v3/loans/{loanId}{baseApiPath?.PrecedeWith("/")}")
        {
        }
    }
}