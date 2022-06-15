namespace EncompassRest.Loans.v3;

internal sealed class LoanObjectBoundApis : LoanApis, ILoanObjectBoundApis
{
    public Loan Loan { get; }

    ILoan ILoanObjectBoundApis.Loan => Loan;

    public bool ReflectToLoanObject { get; set; }

    internal LoanObjectBoundApis(EncompassRestClient client, Loan loan)
        : base(client, loan.Id!)
    {
        Loan = loan;
    }
}