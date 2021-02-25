using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// DaysInYear
    /// </summary>
    public enum DaysInYear
    {
        /// <summary>
        /// 360
        /// </summary>
        [EnumMember(Value = "360")]
        n360 = 360,
        /// <summary>
        /// 364
        /// </summary>
        [EnumMember(Value = "364")]
        n364 = 364,
        /// <summary>
        /// 365
        /// </summary>
        [EnumMember(Value = "365")]
        n365 = 365
    }
}