using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// DisclosureFormSignatureType
/// </summary>
public enum DisclosureFormSignatureType
{
    /// <summary>
    /// Informational
    /// </summary>
    Informational = 0,
    /// <summary>
    /// eSignature
    /// </summary>
    [EnumMember(Value = "eSignature")]
    ESignature = 1,
    /// <summary>
    /// WetSignature
    /// </summary>
    WetSignature = 2
}