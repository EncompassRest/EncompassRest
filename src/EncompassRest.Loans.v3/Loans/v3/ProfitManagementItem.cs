using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ProfitManagementItem
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ProfitManagementItemIndex))]
public sealed partial class ProfitManagementItem : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ProfitManagementItem AtPercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AtPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Profit Mgt Other Descr [PM27]
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ProfitManagementItem PlusAmount
    /// </summary>
    public decimal? PlusAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ProfitManagementItem ProfitManagementItemIndex
    /// </summary>
    public int? ProfitManagementItemIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ProfitManagementItem Total
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ProfitManagementItem Type
    /// </summary>
    public StringEnumValue<ProfitManagementItemType> Type { get => GetValue<StringEnumValue<ProfitManagementItemType>>(); set => SetValue(value); }
}