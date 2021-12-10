using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableBorrowerTypeField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableBorrowerTypeField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<AltBorrowerType>>? _computedValue;
    private DirtyValue<StringEnumValue<AltBorrowerType>>? _userValue;
    private DirtyValue<bool?>? _useUserValue;

    /// <summary>
    /// LockableBorrowerTypeFieldContract ComputedValue
    /// </summary>
    public StringEnumValue<AltBorrowerType> ComputedValue { get => _computedValue; set => SetField(ref _computedValue, value); }

    /// <summary>
    /// LockableBorrowerTypeFieldContract UserValue
    /// </summary>
    public StringEnumValue<AltBorrowerType> UserValue { get => _userValue; set => SetField(ref _userValue, value); }

    /// <summary>
    /// LockableBorrowerTypeFieldContract UseUserValue
    /// </summary>
    public bool? UseUserValue { get => _useUserValue; set => SetField(ref _useUserValue, value); }
}