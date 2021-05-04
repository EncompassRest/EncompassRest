namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// The Loan Apis with optional support to reflect Api calls to the associated loan object.
    /// </summary>
    public interface ILoanObjectBoundApis : ILoanApis
    {
        /// <summary>
        /// The associated loan object.
        /// </summary>
        Loan Loan { get; }
        /// <summary>
        /// Indicates if Api calls should reflect in the associated loan object.
        /// </summary>
        bool ReflectToLoanObject { get; set; }
    }

    internal sealed class LoanObjectBoundApis : LoanApis, ILoanObjectBoundApis
    {
        public Loan Loan { get; }

        public bool ReflectToLoanObject { get; set; }

        internal LoanObjectBoundApis(EncompassRestClient client, Loan loan)
            : base(client, loan.EncompassId!)
        {
            Loan = loan;
        }
    }
}