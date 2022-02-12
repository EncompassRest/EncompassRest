using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// RenewalType
/// </summary>
public enum RenewalType
{
    /// <summary>
    /// Guaranteed
    /// </summary>
    Guaranteed = 0,
    /// <summary>
    /// Variable
    /// </summary>
    Variable = 1,
    /// <summary>
    /// Not Applicable
    /// </summary>
    [EnumMember(Value = "Not Applicable")]
    NotApplicable = 2
}