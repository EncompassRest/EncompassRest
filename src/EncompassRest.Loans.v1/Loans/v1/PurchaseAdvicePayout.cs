namespace EncompassRest.Loans.v1;

/// <summary>
/// PurchaseAdvicePayout
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PurchaseAdvicePayout : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<string?>? _description;
    private DirtyValue<decimal?>? _diffAmount;
    private DirtyValue<decimal?>? _expectedAmount;
    private DirtyValue<string?>? _id;

    /// <summary>
    /// PurchaseAdvicePayout Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// PurchaseAdvicePayout Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// PurchaseAdvicePayout DiffAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffAmount { get => _diffAmount; set => SetField(ref _diffAmount, value); }

    /// <summary>
    /// PurchaseAdvicePayout ExpectedAmount
    /// </summary>
    public decimal? ExpectedAmount { get => _expectedAmount; set => SetField(ref _expectedAmount, value); }

    /// <summary>
    /// PurchaseAdvicePayout Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }
}