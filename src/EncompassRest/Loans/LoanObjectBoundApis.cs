namespace EncompassRest.Loans
{
    public sealed class LoanObjectBoundApis : LoanApis
    {
        public Loan Loan { get; }

        public bool ReflectToLoanObject { get; set; } // What should be the default value?

        internal LoanObjectBoundApis(EncompassRestClient client, Loan loan)
            : base(client, loan.EncompassId)
        {
            Loan = loan;
        }
    }
}