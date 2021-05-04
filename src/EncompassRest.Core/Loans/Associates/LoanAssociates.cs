namespace EncompassRest.Loans.Associates
{
    /// <summary>
    /// The Loan Associates Apis.
    /// </summary>
    public interface ILoanAssociates : ILoanApiObject
    {
    }

    internal sealed class LoanAssociates : LoanApiObject, ILoanAssociates
    {
        internal LoanAssociates(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "associates")
        {
        }
    }
}