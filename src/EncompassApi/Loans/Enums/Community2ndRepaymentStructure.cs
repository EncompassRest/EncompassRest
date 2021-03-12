using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// Community2ndRepaymentStructure
    /// </summary>
    public enum Community2ndRepaymentStructure
    {
        /// <summary>
        /// 01 Any payment required within first five years
        /// </summary>
        [Description("01 Any payment required within first five years")]
        [EnumMember(Value = "01")]
        n01 = 1,
        /// <summary>
        /// 02 Payments deferred five or more years, fully forgiven
        /// </summary>
        [Description("02 Payments deferred five or more years, fully forgiven")]
        [EnumMember(Value = "02")]
        n02 = 2,
        /// <summary>
        /// 03 Payments deferred five or more years, not fully forgiven
        /// </summary>
        [Description("03 Payments deferred five or more years, not fully forgiven")]
        [EnumMember(Value = "03")]
        n03 = 3
    }
}