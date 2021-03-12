using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FreddieRelatedLoanType
    /// </summary>
    public enum FreddieRelatedLoanType
    {
        /// <summary>
        /// Conventional
        /// </summary>
        Conventional = 0,
        /// <summary>
        /// USDA Rural Housing
        /// </summary>
        [EnumMember(Value = "USDA Rural Housing")]
        USDARuralHousing = 1
    }
}