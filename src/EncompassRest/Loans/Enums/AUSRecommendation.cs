using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// AUSRecommendation
    /// </summary>
    public enum AUSRecommendation
    {
        /// <summary>
        /// 1. Approve/Eligible
        /// </summary>
        [Description("1. Approve/Eligible")]
        [EnumMember(Value = "Approve/Eligible")]
        ApproveEligible = 0,
        /// <summary>
        /// 2. Approve/Ineligible
        /// </summary>
        [Description("2. Approve/Ineligible")]
        [EnumMember(Value = "Approve/Ineligible")]
        ApproveIneligible = 1,
        /// <summary>
        /// 3. Refer/Eligible
        /// </summary>
        [Description("3. Refer/Eligible")]
        [EnumMember(Value = "Refer/Eligible")]
        ReferEligible = 2,
        /// <summary>
        /// 4. Refer/Ineligible
        /// </summary>
        [Description("4. Refer/Ineligible")]
        [EnumMember(Value = "Refer/Ineligible")]
        ReferIneligible = 3,
        /// <summary>
        /// 5. Refer with Caution
        /// </summary>
        [Description("5. Refer with Caution")]
        [EnumMember(Value = "Refer with Caution")]
        ReferWithCaution = 4,
        /// <summary>
        /// 6. Out of Scope
        /// </summary>
        [Description("6. Out of Scope")]
        [EnumMember(Value = "Out of Scope")]
        OutOfScope = 5,
        /// <summary>
        /// 7. Error
        /// </summary>
        [Description("7. Error")]
        Error = 6,
        /// <summary>
        /// 8. Accept
        /// </summary>
        [Description("8. Accept")]
        Accept = 7,
        /// <summary>
        /// 9. Caution
        /// </summary>
        [Description("9. Caution")]
        Caution = 8,
        /// <summary>
        /// 10. Ineligible
        /// </summary>
        [Description("10. Ineligible")]
        Ineligible = 9,
        /// <summary>
        /// 11. Incomplete
        /// </summary>
        [Description("11. Incomplete")]
        Incomplete = 10,
        /// <summary>
        /// 12. Invalid
        /// </summary>
        [Description("12. Invalid")]
        Invalid = 11,
        /// <summary>
        /// 13. Refer
        /// </summary>
        [Description("13. Refer")]
        Refer = 12,
        /// <summary>
        /// 14. Eligible
        /// </summary>
        [Description("14. Eligible")]
        Eligible = 13,
        /// <summary>
        /// 15. Unable to Determine
        /// </summary>
        [Description("15. Unable to Determine")]
        [EnumMember(Value = "Unable to Determine")]
        UnableToDetermine = 14,
        /// <summary>
        /// 16. Other
        /// </summary>
        [Description("16. Other")]
        Other = 15,
        /// <summary>
        /// 17. Not applicable
        /// </summary>
        [Description("17. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 16
    }
}