using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ResidencyBasisType
/// </summary>
public enum ResidencyBasisType
{
    /// <summary>
    /// No Primary Housing Expense
    /// </summary>
    [Description("No Primary Housing Expense")]
    NoPrimaryHousingExpense = 0,
    /// <summary>
    /// Rent
    /// </summary>
    Rent = 1,
    /// <summary>
    /// Own
    /// </summary>
    Own = 2
}