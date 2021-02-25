namespace EncompassApi.Loans
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

    /// <summary>
    /// The Loan Apis with optional support to reflect Api calls to the associated loan object.
    /// </summary>
    public sealed class LoanObjectBoundApis : LoanApis, ILoanObjectBoundApis
    {
        /// <inheritdoc/>
        public Loan Loan { get; }

        /// <inheritdoc/>
        public bool ReflectToLoanObject { get; set; }

        internal LoanObjectBoundApis(EncompassApiClient client, Loan loan)
            : base(client, loan.EncompassId!)
        {
            Loan = loan;
        }
    }
}