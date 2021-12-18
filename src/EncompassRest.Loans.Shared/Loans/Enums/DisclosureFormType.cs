using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// DisclosureFormType
/// </summary>
public enum DisclosureFormType
{
    /// <summary>
    /// eDisclosure
    /// </summary>
    [EnumMember(Value = "eDisclosure")]
    EDisclosure = 0,
    /// <summary>
    /// StandardForm
    /// </summary>
    StandardForm = 1,
    /// <summary>
    /// CustomForm
    /// </summary>
    CustomForm = 2,
    /// <summary>
    /// Needed
    /// </summary>
    Needed = 3,
    /// <summary>
    /// ClosingDocsOrder
    /// </summary>
    ClosingDocsOrder = 4,
    /// <summary>
    /// eFolder
    /// </summary>
    [EnumMember(Value = "eFolder")]
    EFolder = 5,
    /// <summary>
    /// CoverSheet
    /// </summary>
    CoverSheet = 6
}