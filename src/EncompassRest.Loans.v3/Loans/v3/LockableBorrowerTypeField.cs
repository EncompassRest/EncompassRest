using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableBorrowerTypeField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableBorrowerTypeField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockableBorrowerTypeField ComputedValue
    /// </summary>
    public StringEnumValue<AltBorrowerType> ComputedValue { get => GetValue<StringEnumValue<AltBorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// LockableBorrowerTypeField UserValue
    /// </summary>
    public StringEnumValue<AltBorrowerType> UserValue { get => GetValue<StringEnumValue<AltBorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// LockableBorrowerTypeField UseUserValue
    /// </summary>
    public bool? UseUserValue { get => GetValue<bool?>(); set => SetValue(value); }
}