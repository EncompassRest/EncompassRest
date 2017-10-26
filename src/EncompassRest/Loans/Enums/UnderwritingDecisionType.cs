using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum UnderwritingDecisionType
    {
        Accept = 0,
        Refer = 1,
        [EnumMember(Value = "Refer with Caution (Manual U/W)")]
        ReferWithCautionManualUW = 2
    }
}