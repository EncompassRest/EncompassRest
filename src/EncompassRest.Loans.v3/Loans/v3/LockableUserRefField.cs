namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableUserRefField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableUserRefField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _computedName;
    private DirtyValue<string?>? _computedValue;
    private DirtyValue<string?>? _userValue;
    private DirtyValue<bool?>? _useUserValue;

    /// <summary>
    /// LockableUserRefFieldContract ComputedName
    /// </summary>
    public string? ComputedName { get => _computedName; set => SetField(ref _computedName, value); }

    /// <summary>
    /// LockableUserRefFieldContract ComputedValue
    /// </summary>
    public string? ComputedValue { get => _computedValue; set => SetField(ref _computedValue, value); }

    /// <summary>
    /// LockableUserRefFieldContract UserValue
    /// </summary>
    public string? UserValue { get => _userValue; set => SetField(ref _userValue, value); }

    /// <summary>
    /// LockableUserRefFieldContract UseUserValue
    /// </summary>
    public bool? UseUserValue { get => _useUserValue; set => SetField(ref _useUserValue, value); }
}