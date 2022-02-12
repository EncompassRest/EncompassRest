using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// NmlsReverseMortgageType
/// </summary>
public enum NmlsReverseMortgageType
{
    /// <summary>
    /// HECM-Standard
    /// </summary>
    [EnumMember(Value = "HECM-Standard")]
    HECMStandard = 0,
    /// <summary>
    /// HECM-Saver
    /// </summary>
    [EnumMember(Value = "HECM-Saver")]
    HECMSaver = 1,
    /// <summary>
    /// Proprietary/Other
    /// </summary>
    [EnumMember(Value = "Proprietary/Other")]
    ProprietaryOther = 2
}