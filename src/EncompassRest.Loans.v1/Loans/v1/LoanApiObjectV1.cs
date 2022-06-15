using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1;

internal abstract class LoanApiObjectV1<T> : LoanApiObjectBase<T>
    where T : DirtyExtensibleObject
{
    internal LoanApiObjectV1(EncompassRestClient client, ILoanApis loanApis, string loanId, string baseApiPath)
        : base(client, loanApis, loanId, $"encompass/v1/loans/{loanId}{baseApiPath?.PrecedeWith("/")}")
    {
    }
}