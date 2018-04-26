using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FannieAutoUWDec
    /// </summary>
    public enum FannieAutoUWDec
    {
        /// <summary>
        /// Approve Eligible
        /// </summary>
        [EnumMember(Value = "Approve Eligible")]
        ApproveEligible = 0,
        /// <summary>
        /// Approve Ineligible
        /// </summary>
        [EnumMember(Value = "Approve Ineligible")]
        ApproveIneligible = 1,
        /// <summary>
        /// EA I Eligible
        /// </summary>
        [EnumMember(Value = "EA I Eligible")]
        EAIEligible = 2,
        /// <summary>
        /// EA I Ineligible
        /// </summary>
        [EnumMember(Value = "EA I Ineligible")]
        EAIIneligible = 3,
        /// <summary>
        /// EA II Eligible
        /// </summary>
        [EnumMember(Value = "EA II Eligible")]
        EAIIEligible = 4,
        /// <summary>
        /// EA II Ineligible
        /// </summary>
        [EnumMember(Value = "EA II Ineligible")]
        EAIIIneligible = 5,
        /// <summary>
        /// EA III Eligible
        /// </summary>
        [EnumMember(Value = "EA III Eligible")]
        EAIIIEligible = 6,
        /// <summary>
        /// EA III Ineligible
        /// </summary>
        [EnumMember(Value = "EA III Ineligible")]
        EAIIIIneligible = 7,
        /// <summary>
        /// Error
        /// </summary>
        Error = 8,
        /// <summary>
        /// Out of Scope
        /// </summary>
        [EnumMember(Value = "Out of Scope")]
        OutOfScope = 9,
        /// <summary>
        /// Refer Eligible
        /// </summary>
        [EnumMember(Value = "Refer Eligible")]
        ReferEligible = 10,
        /// <summary>
        /// Refer Ineligible
        /// </summary>
        [EnumMember(Value = "Refer Ineligible")]
        ReferIneligible = 11,
        /// <summary>
        /// Refer With Caution
        /// </summary>
        [EnumMember(Value = "Refer With Caution")]
        ReferWithCaution = 12,
        /// <summary>
        /// Refer With Caution IV
        /// </summary>
        [EnumMember(Value = "Refer With Caution IV")]
        ReferWithCautionIV = 13,
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 14
    }
}