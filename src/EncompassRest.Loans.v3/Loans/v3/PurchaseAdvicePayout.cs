namespace EncompassRest.Loans.v3;

/// <summary>
/// PurchaseAdvicePayout
/// </summary>
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
    /// PurchaseAdvicePayout PurchaseAdvicePayoutIndex
    /// </summary>
    public int? PurchaseAdvicePayoutIndex { get => GetValue<int?>(); set => SetValue(value); }
}