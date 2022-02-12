namespace EncompassRest.Loans.v1;

/// <summary>
/// GfePayoff
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(GfePayoffIndex))]
public sealed partial class GfePayoff : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<string?>? _description;
    private DirtyValue<int?>? _gfePayoffIndex;
    private DirtyValue<string?>? _id;

    /// <summary>
    /// GfePayoff Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// GfePayoff Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// GfePayoff GfePayoffIndex
    /// </summary>
    public int? GfePayoffIndex { get => _gfePayoffIndex; set => SetField(ref _gfePayoffIndex, value); }

    /// <summary>
    /// GfePayoff Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }
}