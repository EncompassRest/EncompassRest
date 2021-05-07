namespace EncompassRest.Loans.FieldReader
{
    /// <summary>
    /// The Loan Field Reader Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.FieldReader.v1 namespace.
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