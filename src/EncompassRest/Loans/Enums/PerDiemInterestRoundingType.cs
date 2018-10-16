using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PerDiemInterestRoundingType
    /// </summary>
    public enum PerDiemInterestRoundingType
    {
        /// <summary>
        /// 2 Decimals
        /// </summary>
        [EnumMember(Value = "2 Decimals")]
        n2Decimals = 2,
        /// <summary>
        /// 4 Decimals
        /// </summary>
        [EnumMember(Value = "4 Decimals")]
        n4Decimals = 4,
        /// <summary>
        /// No Rounding
        /// </summary>
        [EnumMember(Value = "No Rounding")]
        NoRounding = 100
    }
}