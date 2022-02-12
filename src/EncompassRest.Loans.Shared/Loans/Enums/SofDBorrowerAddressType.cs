using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// SofDBorrowerAddressType
/// </summary>
public enum SofDBorrowerAddressType
{
    /// <summary>
    /// Present Address
    /// </summary>
    [EnumMember(Value = "Present Address")]
    PresentAddress = 0,
    /// <summary>
    /// Mailing Address
    /// </summary>
    [EnumMember(Value = "Mailing Address")]
    MailingAddress = 1,
    /// <summary>
    /// Subject Address
    /// </summary>
    [EnumMember(Value = "Subject Address")]
    SubjectAddress = 2
}