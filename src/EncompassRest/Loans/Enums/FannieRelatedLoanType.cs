using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FannieRelatedLoanType
    /// </summary>
    public enum FannieRelatedLoanType
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
        [EnumMember(Value = "USDA Rural Housing")]
        USDARuralHousing = 2,
        /// <summary>
        /// VA
        /// </summary>
        VA = 3
    }
}