namespace EncompassRest.Loans.v3;

/// <summary>
/// GfePayoff
/// </summary>
public sealed partial class GfePayoff : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<string?>? _description;
    private DirtyValue<int?>? _gfePayoffIndex;

    /// <summary>
    /// GfePayoffContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// GfePayoffContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// GfePayoffContract GfePayoffIndex
    /// </summary>
    public int? GfePayoffIndex { get => _gfePayoffIndex; set => SetField(ref _gfePayoffIndex, value); }
}