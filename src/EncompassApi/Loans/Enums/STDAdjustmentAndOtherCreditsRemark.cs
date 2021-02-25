using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// STDAdjustmentAndOtherCreditsRemark
    /// </summary>
    public enum STDAdjustmentAndOtherCreditsRemark
    {
        /// <summary>
        /// Section K
        /// </summary>
        [Description("Section K")]
        K = 0,
        /// <summary>
        /// Section L
        /// </summary>
        [Description("Section L")]
        L = 1,
        /// <summary>
        /// Section K and Section L
        /// </summary>
        [Description("Section K and Section L")]
        [EnumMember(Value = "K and L")]
        KAndL = 2
    }
}