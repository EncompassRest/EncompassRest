using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// LateChargeType
/// </summary>
public enum LateChargeType
{
    /// <summary>
    /// of the payment
    /// </summary>
    [EnumMember(Value = "of the payment")]
    OfThePayment = 0,
    /// <summary>
    /// of the overdue payment
    /// </summary>
    [EnumMember(Value = "of the overdue payment")]
    OfTheOverduePayment = 1,
    /// <summary>
    /// of the interest payment due
    /// </summary>
    [EnumMember(Value = "of the interest payment due")]
    OfTheInterestPaymentDue = 2,
    /// <summary>
    /// of the principal and interest overdue
    /// </summary>
    [EnumMember(Value = "of the principal and interest overdue")]
    OfThePrincipalAndInterestOverdue = 3,
    /// <summary>
    /// of any installment
    /// </summary>
    [EnumMember(Value = "of any installment")]
    OfAnyInstallment = 4
}