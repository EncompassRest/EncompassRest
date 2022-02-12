using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// PaymentOfPrincipleType
/// </summary>
public enum PaymentOfPrincipleType
{
    /// <summary>
    /// Original Balance
    /// </summary>
    [EnumMember(Value = "Original Balance")]
    OriginalBalance = 0,
    /// <summary>
    /// Unpaid Balance
    /// </summary>
    [EnumMember(Value = "Unpaid Balance")]
    UnpaidBalance = 1
}