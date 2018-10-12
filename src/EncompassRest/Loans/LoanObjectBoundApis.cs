namespace EncompassRest.Loans
{
    public sealed class LoanObjectBoundApis : LoanApis
    {
        public Loan Loan { get; }

        public bool ReflectToLoanObject { get; set; }

        internal LoanObjectBoundApis(EncompassRestClient client, Loan loan)
            : base(client, loan.EncompassId)
        {
            Loan = loan;
        }
    }
}