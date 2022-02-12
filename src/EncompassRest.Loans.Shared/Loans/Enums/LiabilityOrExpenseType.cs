using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// LiabilityOrExpenseType
/// </summary>
public enum LiabilityOrExpenseType
{
    /// <summary>
    /// Alimony
    /// </summary>
    Alimony = 0,
    /// <summary>
    /// Child Support
    /// </summary>
    [Description("Child Support")]
    ChildSupport = 1,
    /// <summary>
    /// Job Related Expenses
    /// </summary>
    [Description("Job Related Expenses")]
    JobRelatedExpenses = 2,
    /// <summary>
    /// Other
    /// </summary>
    Other = 3,
    /// <summary>
    /// Separate Maintenance Expense
    /// </summary>
    [Description("Separate Maintenance Expense")]
    SeparateMaintenanceExpense = 4
}