using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// DisclosedOrReceivedMethod
/// </summary>
public enum DisclosedOrReceivedMethod
{
    /// <summary>
    /// ByMail
    /// </summary>
    ByMail = 0,
    /// <summary>
    /// eDisclosure
    /// </summary>
    [EnumMember(Value = "eDisclosure")]
    EDisclosure = 1,
    /// <summary>
    /// Fax
    /// </summary>
    Fax = 2,
    /// <summary>
    /// InPerson
    /// </summary>
    InPerson = 3,
    /// <summary>
    /// Other
    /// </summary>
    Other = 4,
    /// <summary>
    /// Email
    /// </summary>
    Email = 5,
    /// <summary>
    /// Phone
    /// </summary>
    Phone = 6,
    /// <summary>
    /// Signature
    /// </summary>
    Signature = 7,
    /// <summary>
    /// ClosingDocsOrder
    /// </summary>
    ClosingDocsOrder = 8,
    /// <summary>
    /// eClose
    /// </summary>
    [EnumMember(Value = "eClose")]
    EClose = 9
}