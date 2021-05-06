namespace EncompassRest.Loans.FieldReader
{
    /// <summary>
    /// The Loan Field Reader Apis.
    /// </summary>
    public interface ILoanFieldReader : ILoanApiObject
    {
    }

    internal sealed class LoanFieldReader : LoanApiObject, ILoanFieldReader
    {
        internal LoanFieldReader(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}