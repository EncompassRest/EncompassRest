using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// EscrowFirstPaymentDateType
/// </summary>
public enum EscrowFirstPaymentDateType
{
    /// <summary>
    /// 1st Payment Date
    /// </summary>
    [Description("1st Payment Date")]
    FirstPaymentDate = 0,
    /// <summary>
    /// 1st Amort Date
    /// </summary>
    [Description("1st Amort Date")]
    FirstAmortDate = 1
}