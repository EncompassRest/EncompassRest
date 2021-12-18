using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// IncludeOriginationPointsCreditType
    /// </summary>
    public enum IncludeOriginationPointsCreditType
    {
        /// <summary>
        /// Include Origination Points
        /// </summary>
        [EnumMember(Value = "Include Origination Points")]
        IncludeOriginationPoints = 0,
        /// <summary>
        /// Include Origination Credit (YSP)
        /// </summary>
        [Description("Include Origination Credit (YSP)")]
        [EnumMember(Value = "Include Origination Credit")]
        IncludeOriginationCredit = 1
    }
}