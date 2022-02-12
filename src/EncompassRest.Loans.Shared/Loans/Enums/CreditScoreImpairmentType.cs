using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// CreditScoreImpairmentType
/// </summary>
public enum CreditScoreImpairmentType
{
    /// <summary>
    /// Insufficient Credit History
    /// </summary>
    [Description("Insufficient Credit History")]
    InsufficientCreditHistory = 0,
    /// <summary>
    /// Significant Errors Score
    /// </summary>
    [Description("Significant Errors Score")]
    SignificantErrorsScore = 1
}