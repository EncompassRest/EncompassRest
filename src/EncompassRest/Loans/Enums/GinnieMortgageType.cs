using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// GinnieMortgageType
    /// </summary>
    public enum GinnieMortgageType
    {
        /// <summary>
        /// FHA
        /// </summary>
        FHA = 0,
        /// <summary>
        /// Public and Indian Housing
        /// </summary>
        [Description("Public and Indian Housing")]
        PublicIndianHousing = 1,
        /// <summary>
        /// USDA Rural Development
        /// </summary>
        [Description("USDA Rural Development")]
        USDARuralDevelopment = 2,
        /// <summary>
        /// VA
        /// </summary>
        VA = 3
    }
}