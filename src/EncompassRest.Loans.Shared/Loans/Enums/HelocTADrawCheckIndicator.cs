using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// HelocTADrawCheckIndicator
/// </summary>
public enum HelocTADrawCheckIndicator
{
    /// <summary>
    /// Draw Check
    /// </summary>
    [EnumMember(Value = "Draw Check")]
    DrawCheck = 0,
    /// <summary>
    /// Draw Draft
    /// </summary>
    [EnumMember(Value = "Draw Draft")]
    DrawDraft = 1
}