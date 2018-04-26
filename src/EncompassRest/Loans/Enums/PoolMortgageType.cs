using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PoolMortgageType
    /// </summary>
    public enum PoolMortgageType
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
        /// USDA Rural Housing
        /// </summary>
        [Description("USDA Rural Housing")]
        USDARuralHousing = 2,
        /// <summary>
        /// VA
        /// </summary>
        VA = 3
    }
}