using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieMortgageType
    /// </summary>
    public enum FreddieMortgageType
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
        FarmersHomeAdministration = 4
    }
}