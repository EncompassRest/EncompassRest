using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FreddieMacRiskClass
    /// </summary>
    public enum FreddieMacRiskClass
    {
        /// <summary>
        /// Risk class had not been changed by the lender
        /// </summary>
        [Description("Risk class had not been changed by the lender")]
        [EnumMember(Value = "0")]
        n0 = 0,
        /// <summary>
        /// Risk class downgraded from Accept Plus to Accept
        /// </summary>
        [Description("Risk class downgraded from Accept Plus to Accept")]
        [EnumMember(Value = "1")]
        n1 = 1,
        /// <summary>
        /// Risk class downgraded from Accept Plus to Refer
        /// </summary>
        [Description("Risk class downgraded from Accept Plus to Refer")]
        [EnumMember(Value = "2")]
        n2 = 2,
        /// <summary>
        /// Risk class downgraded from Accept to Refer
        /// </summary>
        [Description("Risk class downgraded from Accept to Refer")]
        [EnumMember(Value = "3")]
        n3 = 3
    }
}