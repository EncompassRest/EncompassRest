using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PurchaseCredit
/// </summary>
public sealed partial class PurchaseCredit : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PurchaseCredit Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseCredit PurchaseCreditIndex
    /// </summary>
    public int? PurchaseCreditIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseCredit PurchaseCreditSource
    /// </summary>
    public StringEnumValue<PurchaseCreditSource> PurchaseCreditSource { get => GetValue<StringEnumValue<PurchaseCreditSource>>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseCredit PurchaseCreditType
    /// </summary>
    public StringEnumValue<PurchaseCreditType> PurchaseCreditType { get => GetValue<StringEnumValue<PurchaseCreditType>>(); set => SetValue(value); }
}