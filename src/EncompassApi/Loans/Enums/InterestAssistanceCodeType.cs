using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// InterestAssistanceCodeType
    /// </summary>
    public enum InterestAssistanceCodeType
    {
        /// <summary>
        /// 1. Eligible for Interest Assistance Program
        /// </summary>
        [EnumMember(Value = "1. Eligible for Interest Assistance Program")]
        n1EligibleForInterestAssistanceProgram = 1,
        /// <summary>
        /// 2. Ineligible for Interest Assistance Program
        /// </summary>
        [EnumMember(Value = "2. Ineligible for Interest Assistance Program")]
        n2IneligibleForInterestAssistanceProgram = 2
    }
}