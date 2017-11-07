using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AUSRecommendation
    {
        [EnumMember(Value = "Approve/Eligible")]
        ApproveEligible = 0,
        [EnumMember(Value = "Approve/Ineligible")]
        ApproveIneligible = 1,
        [EnumMember(Value = "Refer/Eligible")]
        ReferEligible = 2,
        [EnumMember(Value = "Refer/Ineligible")]
        ReferIneligible = 3,
        [EnumMember(Value = "Refer with Caution")]
        ReferWithCaution = 4,
        [EnumMember(Value = "Out of Scope")]
        OutOfScope = 5,
        Error = 6,
        Accept = 7,
        Caution = 8,
        Ineligible = 9,
        Incomplete = 10,
        Invalid = 11,
        Refer = 12,
        Eligible = 13,
        [EnumMember(Value = "Unable to Determine")]
        UnableToDetermine = 14,
        Other = 15,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 16
    }
}