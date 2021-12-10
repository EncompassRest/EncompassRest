using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ProfitManagement
/// </summary>
public sealed partial class ProfitManagement : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _commissionableGrossProfit;
    private DirtyValue<decimal?>? _expenseAmount1;
    private DirtyValue<decimal?>? _expenseAmount2;
    private DirtyValue<decimal?>? _expenseAmount3;
    private DirtyValue<decimal?>? _expenseAmount4;
    private DirtyValue<string?>? _expenseDescription1;
    private DirtyValue<string?>? _expenseDescription2;
    private DirtyValue<string?>? _expenseDescription3;
    private DirtyValue<string?>? _expenseDescription4;
    private DirtyValue<decimal?>? _grossCheckAmount;
    private DirtyValue<decimal?>? _netProfit;
    private DirtyList<ProfitManagementItem>? _profitManagementItems;

    /// <summary>
    /// Profit Mgt Commissionable Gross Profit [PM10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CommissionableGrossProfit { get => _commissionableGrossProfit; set => SetField(ref _commissionableGrossProfit, value); }

    /// <summary>
    /// Profit Mgt Expenses 1 Amt [PM03]
    /// </summary>
    public decimal? ExpenseAmount1 { get => _expenseAmount1; set => SetField(ref _expenseAmount1, value); }

    /// <summary>
    /// Profit Mgt Expenses 2 Amt [PM05]
    /// </summary>
    public decimal? ExpenseAmount2 { get => _expenseAmount2; set => SetField(ref _expenseAmount2, value); }

    /// <summary>
    /// Profit Mgt Expenses 3 Amt [PM07]
    /// </summary>
    public decimal? ExpenseAmount3 { get => _expenseAmount3; set => SetField(ref _expenseAmount3, value); }

    /// <summary>
    /// Profit Mgt Expenses 4 Amt [PM09]
    /// </summary>
    public decimal? ExpenseAmount4 { get => _expenseAmount4; set => SetField(ref _expenseAmount4, value); }

    /// <summary>
    /// Profit Mgt Expenses 1 [PM02]
    /// </summary>
    public string? ExpenseDescription1 { get => _expenseDescription1; set => SetField(ref _expenseDescription1, value); }

    /// <summary>
    /// Profit Mgt Expenses 2 [PM04]
    /// </summary>
    public string? ExpenseDescription2 { get => _expenseDescription2; set => SetField(ref _expenseDescription2, value); }

    /// <summary>
    /// Profit Mgt Expenses 3 [PM06]
    /// </summary>
    public string? ExpenseDescription3 { get => _expenseDescription3; set => SetField(ref _expenseDescription3, value); }

    /// <summary>
    /// Profit Mgt Expenses 4 [PM08]
    /// </summary>
    public string? ExpenseDescription4 { get => _expenseDescription4; set => SetField(ref _expenseDescription4, value); }

    /// <summary>
    /// Profit Mgt Gross Check Amt [PM01]
    /// </summary>
    public decimal? GrossCheckAmount { get => _grossCheckAmount; set => SetField(ref _grossCheckAmount, value); }

    /// <summary>
    /// Profit Mgt Net Profit [PM28]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NetProfit { get => _netProfit; set => SetField(ref _netProfit, value); }

    /// <summary>
    /// ProfitManagementContract ProfitManagementItems
    /// </summary>
    [AllowNull]
    public IList<ProfitManagementItem> ProfitManagementItems { get => GetField(ref _profitManagementItems); set => SetField(ref _profitManagementItems, value); }
}