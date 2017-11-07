using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CriteriaForAppropriateLTVFactor
    {
        [EnumMember(Value = "At or above 580")]
        AtOrAbove580 = 0,
        [EnumMember(Value = "Between 500 and 579")]
        Between500And579 = 1,
        [EnumMember(Value = "With HOC Approval")]
        WithHOCApproval = 2,
        [EnumMember(Value = "Manual Underwriting Required")]
        ManualUnderwritingRequired = 3
    }
}