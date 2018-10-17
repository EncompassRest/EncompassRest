using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FannnieMortgageType
    /// </summary>
    public enum FannnieMortgageType
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
        /// USDA-RHS
        /// </summary>
        [Description("USDA-RHS")]
        FarmersHomeAdministration = 3,
        /// <summary>
        /// HELOC
        /// </summary>
        HELOC = 4
    }
}