using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieMacArmIndexType
    /// </summary>
    public enum FreddieMacArmIndexType
    {
        /// <summary>
        /// 1-Year Treasury
        /// </summary>
        [Description("1-Year Treasury")]
        [EnumMember(Value = "01")]
        n01 = 1,
        /// <summary>
        /// 3-Year Treasury
        /// </summary>
        [Description("3-Year Treasury")]
        [EnumMember(Value = "02")]
        n02 = 2,
        /// <summary>
        /// 6-Month T-Bill
        /// </summary>
        [Description("6-Month T-Bill")]
        [EnumMember(Value = "03")]
        n03 = 3,
        /// <summary>
        /// COFI (11th District Monthly COF)
        /// </summary>
        [Description("COFI (11th District Monthly COF)")]
        [EnumMember(Value = "29")]
        n29 = 29,
        /// <summary>
        /// National Median COF
        /// </summary>
        [Description("National Median COF")]
        [EnumMember(Value = "40")]
        n40 = 40,
        /// <summary>
        /// LIBOR
        /// </summary>
        [Description("LIBOR")]
        [EnumMember(Value = "44")]
        n44 = 44,
        /// <summary>
        /// Other
        /// </summary>
        [Description("Other")]
        [EnumMember(Value = "99")]
        n99 = 99
    }
}