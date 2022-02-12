using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// CreditChargeType
/// </summary>
public enum CreditChargeType
{
    /// <summary>
    /// Origination Charge
    /// </summary>
    [EnumMember(Value = "Origination Charge")]
    OriginationCharge = 0,
    /// <summary>
    /// Settlement Charge Reduced
    /// </summary>
    [Description("Settlement Charge Reduced")]
    [EnumMember(Value = "Settlement Reduced")]
    SettlementReduced = 1,
    /// <summary>
    /// Settlement Charge Increased
    /// </summary>
    [Description("Settlement Charge Increased")]
    [EnumMember(Value = "Settlement Increased")]
    SettlementIncreased = 2
}