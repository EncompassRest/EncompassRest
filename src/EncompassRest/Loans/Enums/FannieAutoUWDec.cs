using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieAutoUWDec
    {
        [EnumMember(Value = "Approve Eligible")]
        ApproveEligible = 0,
        [EnumMember(Value = "Approve Ineligible")]
        ApproveIneligible = 1,
        [EnumMember(Value = "EA I Eligible")]
        EAIEligible = 2,
        [EnumMember(Value = "EA I Ineligible")]
        EAIIneligible = 3,
        [EnumMember(Value = "EA II Eligible")]
        EAIIEligible = 4,
        [EnumMember(Value = "EA II Ineligible")]
        EAIIIneligible = 5,
        [EnumMember(Value = "EA III Eligible")]
        EAIIIEligible = 6,
        [EnumMember(Value = "EA III Ineligible")]
        EAIIIIneligible = 7,
        Error = 8,
        [EnumMember(Value = "Out of Scope")]
        OutOfScope = 9,
        [EnumMember(Value = "Refer Eligible")]
        ReferEligible = 10,
        [EnumMember(Value = "Refer Ineligible")]
        ReferIneligible = 11,
        [EnumMember(Value = "Refer With Caution")]
        ReferWithCaution = 12,
        [EnumMember(Value = "Refer With Caution IV")]
        ReferWithCautionIV = 13,
        Unknown = 14
    }
}