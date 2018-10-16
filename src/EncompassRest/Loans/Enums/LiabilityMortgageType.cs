using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LiabilityMortgageType
    /// </summary>
    public enum LiabilityMortgageType
    {
        /// <summary>
        /// Conventional
        /// </summary>
        Conventional = 0,
        /// <summary>
        /// FHA
        /// </summary>
        FHA = 1,
        /// <summary>
        /// VA
        /// </summary>
        VA = 2,
        /// <summary>
        /// USDA-RHS
        /// </summary>
        [Description("USDA-RHS")]
        FarmersHomeAdministration = 3,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4
    }
}