namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableStringField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableStringField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _computedValue;
    private DirtyValue<string?>? _userValue;
    private DirtyValue<bool?>? _useUserValue;

    /// <summary>
    /// LockableStringFieldContract ComputedValue
    /// </summary>
    public string? ComputedValue { get => _computedValue; set => SetField(ref _computedValue, value); }

    /// <summary>
    /// LockableStringFieldContract UserValue
    /// </summary>
    public string? UserValue { get => _userValue; set => SetField(ref _userValue, value); }

    /// <summary>
    /// LockableStringFieldContract UseUserValue
    /// </summary>
    public bool? UseUserValue { get => _useUserValue; set => SetField(ref _useUserValue, value); }
}