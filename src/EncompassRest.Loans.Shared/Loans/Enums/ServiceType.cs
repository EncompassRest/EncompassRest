using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ServiceType
/// </summary>
public enum ServiceType
{
    /// <summary>
    /// Title - Settlement and Closing
    /// </summary>
    [EnumMember(Value = "Title - Settlement and Closing")]
    TitleSettlementAndClosing = 0,
    /// <summary>
    /// Title - Insurance
    /// </summary>
    [EnumMember(Value = "Title - Insurance")]
    TitleInsurance = 1,
    /// <summary>
    /// Escrow - Settlement and Closing
    /// </summary>
    [EnumMember(Value = "Escrow - Settlement and Closing")]
    EscrowSettlementAndClosing = 2,
    /// <summary>
    /// Escrow - Insurance
    /// </summary>
    [EnumMember(Value = "Escrow - Insurance")]
    EscrowInsurance = 3
}