namespace EncompassRest.Loans.v3;

/// <summary>
/// PurchaseAdvicePayout
/// </summary>
public sealed partial class PurchaseAdvicePayout : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<string?>? _description;
    private DirtyValue<decimal?>? _diffAmount;
    private DirtyValue<decimal?>? _expectedAmount;
    private DirtyValue<int?>? _purchaseAdvicePayoutIndex;

    /// <summary>
    /// PurchaseAdvicePayoutContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// PurchaseAdvicePayoutContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// PurchaseAdvicePayoutContract DiffAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffAmount { get => _diffAmount; set => SetField(ref _diffAmount, value); }

    /// <summary>
    /// PurchaseAdvicePayoutContract ExpectedAmount
    /// </summary>
    public decimal? ExpectedAmount { get => _expectedAmount; set => SetField(ref _expectedAmount, value); }

    /// <summary>
    /// PurchaseAdvicePayoutContract PurchaseAdvicePayoutIndex
    /// </summary>
    public int? PurchaseAdvicePayoutIndex { get => _purchaseAdvicePayoutIndex; set => SetField(ref _purchaseAdvicePayoutIndex, value); }
}