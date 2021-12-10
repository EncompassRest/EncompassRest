using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ProfitManagementItem
/// </summary>
public sealed partial class ProfitManagementItem : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _atPercent;
    private DirtyValue<string?>? _description;
    private DirtyValue<decimal?>? _plusAmount;
    private DirtyValue<int?>? _profitManagementItemIndex;
    private DirtyValue<decimal?>? _total;
    private DirtyValue<StringEnumValue<ProfitManagementItemType>>? _type;

    /// <summary>
    /// ProfitManagementItemContract AtPercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AtPercent { get => _atPercent; set => SetField(ref _atPercent, value); }

    /// <summary>
    /// Profit Mgt Other Descr [PM27]
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// ProfitManagementItemContract PlusAmount
    /// </summary>
    public decimal? PlusAmount { get => _plusAmount; set => SetField(ref _plusAmount, value); }

    /// <summary>
    /// ProfitManagementItemContract ProfitManagementItemIndex
    /// </summary>
    public int? ProfitManagementItemIndex { get => _profitManagementItemIndex; set => SetField(ref _profitManagementItemIndex, value); }

    /// <summary>
    /// ProfitManagementItemContract Total
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => _total; set => SetField(ref _total, value); }

    /// <summary>
    /// ProfitManagementItemContract Type
    /// </summary>
    public StringEnumValue<ProfitManagementItemType> Type { get => _type; set => SetField(ref _type, value); }
}