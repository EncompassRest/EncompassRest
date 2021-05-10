namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan interface.
    /// </summary>
    public interface ILoan
    {
        /// <summary>
        /// The loan fields collection.
        /// </summary>
        ILoanFields Fields { get; }
        /// <summary>
        /// Loan Info Loan ID [GUID]
        /// </summary>
        string? Id { get; set; }
        /// <summary>
        /// The Loan Apis exposed as extension methods from the Core and EncompassRest.Services packages
        /// within the EncompassRest.Loans.v1 namespace.
        /// </summary>
        ILoanApis LoanApis { get; }
        /// <summary>
        /// Trans Details Loan # [364]
        /// </summary>
        string? LoanNumber { get; set; }
    }
}