using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CreditChargeType
    {
        [EnumMember(Value = "Origination Charge")]
        OriginationCharge = 0,
        [EnumMember(Value = "Settlement Reduced")]
        SettlementReduced = 1,
        [EnumMember(Value = "Settlement Increased")]
        SettlementIncreased = 2
    }
}