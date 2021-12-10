namespace EncompassRest.Loans.v3;

/// <summary>
/// ServiceProviderContactFee
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ServiceProviderContactFee : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<string?>? _description;
    private DirtyValue<int?>? _itemNumber;

    /// <summary>
    /// ServiceProviderContactFeeContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// ServiceProviderContactFeeContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// ServiceProviderContactFeeContract ItemNumber
    /// </summary>
    public int? ItemNumber { get => _itemNumber; set => SetField(ref _itemNumber, value); }
}