namespace EncompassRest.Loans.v1;

/// <summary>
/// PurchaseAdvicePayout
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PurchaseAdvicePayout : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PurchaseAdvicePayout Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseAdvicePayout Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseAdvicePayout DiffAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseAdvicePayout ExpectedAmount
    /// </summary>
    public decimal? ExpectedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseAdvicePayout Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}