namespace EncompassRest.Loans
{
    public interface ILoan
    {
        ILoanFields Fields { get; }
        string? Id { get; set; }
        string? LoanNumber { get; set; }
    }
}