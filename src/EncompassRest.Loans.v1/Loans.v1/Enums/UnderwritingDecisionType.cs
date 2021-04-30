using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// UnderwritingDecisionType
    /// </summary>
    public enum UnderwritingDecisionType
    {
        /// <summary>
        /// Accept
        /// </summary>
        Accept = 0,
        /// <summary>
        /// Refer
        /// </summary>
        Refer = 1,
        /// <summary>
        /// Refer with Caution (Manual U/W)
        /// </summary>
        [EnumMember(Value = "Refer with Caution (Manual U/W)")]
        ReferWithCautionManualUW = 2
    }
}