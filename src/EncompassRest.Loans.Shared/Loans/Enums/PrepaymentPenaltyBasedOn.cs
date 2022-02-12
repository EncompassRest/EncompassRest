using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// PrepaymentPenaltyBasedOn
/// </summary>
public enum PrepaymentPenaltyBasedOn
{
    /// <summary>
    /// Original Principal Amount
    /// </summary>
    [EnumMember(Value = "Original Principal Amount")]
    OriginalPrincipalAmount = 0,
    /// <summary>
    /// Amount Prepaid
    /// </summary>
    [EnumMember(Value = "Amount Prepaid")]
    AmountPrepaid = 1,
    /// <summary>
    /// Unpaid Balance
    /// </summary>
    [EnumMember(Value = "Unpaid Balance")]
    UnpaidBalance = 2
}