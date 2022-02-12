using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FinalSignatureType
/// </summary>
public enum FinalSignatureType
{
    /// <summary>
    /// esigned
    /// </summary>
    [EnumMember(Value = "esigned")]
    Esigned = 0,
    /// <summary>
    /// wetsigned
    /// </summary>
    [EnumMember(Value = "wetsigned")]
    Wetsigned = 1,
    /// <summary>
    /// other
    /// </summary>
    [EnumMember(Value = "other")]
    Other = 2
}