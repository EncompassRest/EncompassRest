using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FnmCommunityLendingProductName
    /// </summary>
    public enum FnmCommunityLendingProductName
    {
        /// <summary>
        /// 04 My Community Mortgage
        /// </summary>
        [Description("04 My Community Mortgage")]
        [EnumMember(Value = "04")]
        n04 = 4,
        /// <summary>
        /// 06 HFA Preferred Risk Sharing
        /// </summary>
        [Description("06 HFA Preferred Risk Sharing")]
        [EnumMember(Value = "06")]
        n06 = 6,
        /// <summary>
        /// 07 HFA Preferred
        /// </summary>
        [Description("07 HFA Preferred")]
        [EnumMember(Value = "07")]
        n07 = 7,
        /// <summary>
        /// 08 Home Ready
        /// </summary>
        [Description("08 Home Ready")]
        [EnumMember(Value = "08")]
        n08 = 8
    }
}