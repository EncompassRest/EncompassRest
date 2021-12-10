namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableDecimalField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableDecimalField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _computedValue;
    private DirtyValue<decimal?>? _userValue;
    private DirtyValue<bool?>? _useUserValue;

    /// <summary>
    /// LockableDecimalFieldContract ComputedValue
    /// </summary>
    public decimal? ComputedValue { get => _computedValue; set => SetField(ref _computedValue, value); }

    /// <summary>
    /// LockableDecimalFieldContract UserValue
    /// </summary>
    public decimal? UserValue { get => _userValue; set => SetField(ref _userValue, value); }

    /// <summary>
    /// LockableDecimalFieldContract UseUserValue
    /// </summary>
    public bool? UseUserValue { get => _useUserValue; set => SetField(ref _useUserValue, value); }
}