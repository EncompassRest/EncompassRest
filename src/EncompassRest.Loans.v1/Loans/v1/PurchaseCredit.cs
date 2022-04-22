using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PurchaseCredit
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PurchaseCredit : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PurchaseCredit Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseCredit Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseCredit PurchaseCreditSource
    /// </summary>
    public StringEnumValue<PurchaseCreditSource> PurchaseCreditSource { get => GetValue<StringEnumValue<PurchaseCreditSource>>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseCredit PurchaseCreditType
    /// </summary>
    public StringEnumValue<PurchaseCreditType> PurchaseCreditType { get => GetValue<StringEnumValue<PurchaseCreditType>>(); set => SetValue(value); }
}