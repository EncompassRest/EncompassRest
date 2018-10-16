using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LoanType
    /// </summary>
    public enum LoanType
    {
        /// <summary>
        /// Conventional
        /// </summary>
        Conventional = 0,
        /// <summary>
        /// VA
        /// </summary>
        VA = 1,
        /// <summary>
        /// FHA
        /// </summary>
        FHA = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 3,
        /// <summary>
        /// USDA-RHS
        /// </summary>
        [Description("USDA-RHS")]
        FarmersHomeAdministration = 4,
        /// <summary>
        /// HELOC
        /// </summary>
        HELOC = 5
    }
}