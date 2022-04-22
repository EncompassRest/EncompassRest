using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ProfitManagement
/// </summary>
public sealed partial class ProfitManagement : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Profit Mgt Commissionable Gross Profit [PM10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CommissionableGrossProfit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 1 Amt [PM03]
    /// </summary>
    public decimal? ExpenseAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 2 Amt [PM05]
    /// </summary>
    public decimal? ExpenseAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 3 Amt [PM07]
    /// </summary>
    public decimal? ExpenseAmount3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 4 Amt [PM09]
    /// </summary>
    public decimal? ExpenseAmount4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 1 [PM02]
    /// </summary>
    public string? ExpenseDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 2 [PM04]
    /// </summary>
    public string? ExpenseDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 3 [PM06]
    /// </summary>
    public string? ExpenseDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Expenses 4 [PM08]
    /// </summary>
    public string? ExpenseDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Gross Check Amt [PM01]
    /// </summary>
    public decimal? GrossCheckAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Net Profit [PM28]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NetProfit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ProfitManagement ProfitManagementItems
    /// </summary>
    [AllowNull]
    public IList<ProfitManagementItem> ProfitManagementItems { get => GetList<ProfitManagementItem>(); set => SetList(value); }
}