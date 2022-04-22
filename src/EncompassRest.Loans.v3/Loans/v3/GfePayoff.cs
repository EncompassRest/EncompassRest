namespace EncompassRest.Loans.v3;

/// <summary>
/// GfePayoff
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(GfePayoffIndex))]
public sealed partial class GfePayoff : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GfePayoff Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayoff Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GfePayoff GfePayoffIndex
    /// </summary>
    public int? GfePayoffIndex { get => GetValue<int?>(); set => SetValue(value); }
}