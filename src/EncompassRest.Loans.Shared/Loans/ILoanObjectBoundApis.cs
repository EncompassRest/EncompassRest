namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loan Apis with optional support to reflect Api calls to the associated loan object.
    /// </summary>
    public interface ILoanObjectBoundApis : ILoanApis
    {
        /// <summary>
        /// The associated loan object.
        /// </summary>
        ILoan Loan { get; }
        /// <summary>
        /// Indicates if Api calls should reflect in the associated loan object.
        /// </summary>
        bool ReflectToLoanObject { get; set; }
    }
}