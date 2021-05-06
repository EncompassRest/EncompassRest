using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// GiftFundsSource
    /// </summary>
    public enum GiftFundsSource
    {
        /// <summary>
        /// N/A
        /// </summary>
        [Description("N/A")]
        [EnumMember(Value = "00")]
        n00 = 0,
        /// <summary>
        /// 01:Relative
        /// </summary>
        [Description("01:Relative")]
        [EnumMember(Value = "01")]
        n01 = 1,
        /// <summary>
        /// 02:Nonprofit/Religious/Community
        /// </summary>
        [Description("02:Nonprofit/Religious/Community")]
        [EnumMember(Value = "02")]
        n02 = 2,
        /// <summary>
        /// 03:Government Assistance
        /// </summary>
        [Description("03:Government Assistance")]
        [EnumMember(Value = "03")]
        n03 = 3,
        /// <summary>
        /// 06:Employer/Other
        /// </summary>
        [Description("06:Employer/Other")]
        [EnumMember(Value = "06")]
        n06 = 6,
        /// <summary>
        /// 15:Nonprofit/Religious/Community - Non-Seller Funded
        /// </summary>
        [Description("15:Nonprofit/Religious/Community - Non-Seller Funded")]
        [EnumMember(Value = "15")]
        n15 = 15
    }
}