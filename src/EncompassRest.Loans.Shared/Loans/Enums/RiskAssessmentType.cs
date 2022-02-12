using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// RiskAssessmentType
/// </summary>
public enum RiskAssessmentType
{
    /// <summary>
    /// Manual Underwriting
    /// </summary>
    [EnumMember(Value = "Manual Underwriting")]
    ManualUnderwriting = 0,
    /// <summary>
    /// DU
    /// </summary>
    DU = 1,
    /// <summary>
    /// LPA
    /// </summary>
    [Description("LPA")]
    LP = 2,
    /// <summary>
    /// LQA
    /// </summary>
    LQA = 3,
    /// <summary>
    /// Other
    /// </summary>
    Other = 4,
    /// <summary>
    /// Early Check
    /// </summary>
    [Description("Early Check")]
    EarlyCheck = 5
}