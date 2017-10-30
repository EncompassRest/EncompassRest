using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InterestAssistanceCodeType
    {
        [EnumMember(Value = "1. Eligible for Interest Assistance Program")]
        n1EligibleForInterestAssistanceProgram = 1,
        [EnumMember(Value = "2. Ineligible for Interest Assistance Program")]
        n2IneligibleForInterestAssistanceProgram = 2
    }
}