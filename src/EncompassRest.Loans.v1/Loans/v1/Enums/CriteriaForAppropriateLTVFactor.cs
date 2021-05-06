using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// CriteriaForAppropriateLTVFactor
    /// </summary>
    public enum CriteriaForAppropriateLTVFactor
    {
        /// <summary>
        /// At or above 580
        /// </summary>
        [EnumMember(Value = "At or above 580")]
        AtOrAbove580 = 0,
        /// <summary>
        /// Between 500 and 579
        /// </summary>
        [EnumMember(Value = "Between 500 and 579")]
        Between500And579 = 1,
        /// <summary>
        /// With HOC Approval
        /// </summary>
        [EnumMember(Value = "With HOC Approval")]
        WithHOCApproval = 2,
        /// <summary>
        /// Manual Underwriting Required
        /// </summary>
        [EnumMember(Value = "Manual Underwriting Required")]
        ManualUnderwritingRequired = 3
    }
}