using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// TrstSamePtyTypDesc
/// </summary>
public enum TrstSamePtyTypDesc
{
    /// <summary>
    /// Title
    /// </summary>
    Title = 0,
    /// <summary>
    /// Escrow
    /// </summary>
    Escrow = 1,
    /// <summary>
    /// Encompass Trustee
    /// </summary>
    [EnumMember(Value = "Encompass Trustee")]
    EncompassTrustee = 2,
    /// <summary>
    /// Buyer's Attorney
    /// </summary>
    [EnumMember(Value = "Buyer's Attorney")]
    BuyersAttorney = 3,
    /// <summary>
    /// User Input
    /// </summary>
    [EnumMember(Value = "User Input")]
    UserInput = 4
}