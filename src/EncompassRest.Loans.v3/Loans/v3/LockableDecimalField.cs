namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableDecimalField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableDecimalField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockableDecimalField ComputedValue
    /// </summary>
    public decimal? ComputedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LockableDecimalField UserValue
    /// </summary>
    public decimal? UserValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LockableDecimalField UseUserValue
    /// </summary>
    public bool? UseUserValue { get => GetValue<bool?>(); set => SetValue(value); }
}