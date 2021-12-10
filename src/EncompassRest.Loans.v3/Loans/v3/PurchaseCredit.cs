using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PurchaseCredit
/// </summary>
public sealed partial class PurchaseCredit : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<int?>? _purchaseCreditIndex;
    private DirtyValue<StringEnumValue<PurchaseCreditSource>>? _purchaseCreditSource;
    private DirtyValue<StringEnumValue<PurchaseCreditType>>? _purchaseCreditType;

    /// <summary>
    /// PurchaseCreditContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// PurchaseCreditContract PurchaseCreditIndex
    /// </summary>
    public int? PurchaseCreditIndex { get => _purchaseCreditIndex; set => SetField(ref _purchaseCreditIndex, value); }

    /// <summary>
    /// PurchaseCreditContract PurchaseCreditSource
    /// </summary>
    public StringEnumValue<PurchaseCreditSource> PurchaseCreditSource { get => _purchaseCreditSource; set => SetField(ref _purchaseCreditSource, value); }

    /// <summary>
    /// PurchaseCreditContract PurchaseCreditType
    /// </summary>
    public StringEnumValue<PurchaseCreditType> PurchaseCreditType { get => _purchaseCreditType; set => SetField(ref _purchaseCreditType, value); }
}