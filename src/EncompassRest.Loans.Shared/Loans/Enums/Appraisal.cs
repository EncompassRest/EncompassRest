using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// Appraisal
/// </summary>
public enum Appraisal
{
    /// <summary>
    /// Omit from print
    /// </summary>
    [EnumMember(Value = "Omit from print")]
    OmitFromPrint = 0,
    /// <summary>
    /// Use Section 35
    /// </summary>
    [EnumMember(Value = "Use Section 35")]
    UseSection35 = 1
}