using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PerDiemCalculationMethodType
    /// </summary>
    public enum PerDiemCalculationMethodType
    {
        /// <summary>
        /// 360/360
        /// </summary>
        [EnumMember(Value = "360/360")]
        n360_360 = 0,
        /// <summary>
        /// 365/360
        /// </summary>
        [EnumMember(Value = "365/360")]
        n365_360 = 1,
        /// <summary>
        /// 365/365
        /// </summary>
        [EnumMember(Value = "365/365")]
        n365_365 = 2
    }
}