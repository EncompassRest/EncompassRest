namespace EncompassRest.Loans.v1;

internal sealed class LoanObjectBoundApis : LoanApis, ILoanObjectBoundApis
{
    public Loan Loan { get; }

    ILoan ILoanObjectBoundApis.Loan => Loan;

    public bool ReflectToLoanObject { get; set; }

    internal LoanObjectBoundApis(EncompassRestClient client, Loan loan)
        : base(client, loan.EncompassId!)
    {
        Loan = loan;
    }
}