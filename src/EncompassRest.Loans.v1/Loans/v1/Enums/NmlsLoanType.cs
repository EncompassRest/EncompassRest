using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NmlsLoanType
    /// </summary>
    public enum NmlsLoanType
    {
        /// <summary>
        /// Residential First Mortgage (1-4 Unit)
        /// </summary>
        [Description("Residential First Mortgage (1-4 Unit)")]
        ResidentialFirst = 0,
        /// <summary>
        /// Closed-End Second Mortgage
        /// </summary>
        [Description("Closed-End Second Mortgage")]
        ClosedEndSecond = 1,
        /// <summary>
        /// Funded HELOC
        /// </summary>
        [Description("Funded HELOC")]
        HELOC = 2,
        /// <summary>
        /// Reverse Mortgage
        /// </summary>
        [Description("Reverse Mortgage")]
        ReverseMortgage = 3,
        /// <summary>
        /// Construction and Land Development, 1-4 Unit Residential
        /// </summary>
        [Description("Construction and Land Development, 1-4 Unit Residential")]
        Construction = 4,
        /// <summary>
        /// Multifamily Loans Agency
        /// </summary>
        [Description("Multifamily Loans Agency")]
        Multifamily = 5,
        /// <summary>
        /// Commercial Mortgage Loan
        /// </summary>
        [Description("Commercial Mortgage Loan")]
        Commercial = 6,
        /// <summary>
        /// Other Mortgage Loan
        /// </summary>
        [Description("Other Mortgage Loan")]
        Other = 7
    }
}