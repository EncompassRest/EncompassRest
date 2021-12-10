using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// AltLiabilityType
/// </summary>
public enum AltLiabilityType
{
    /// <summary>
    /// Alimony
    /// </summary>
    Alimony = 0,
    /// <summary>
    /// Job Related Expenses
    /// </summary>
    [Description("Job Related Expenses")]
    JobRelatedExpenses = 2
}