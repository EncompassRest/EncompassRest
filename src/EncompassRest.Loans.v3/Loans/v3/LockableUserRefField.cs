namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableUserRefField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableUserRefField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockableUserRefField ComputedName
    /// </summary>
    public string? ComputedName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockableUserRefField ComputedValue
    /// </summary>
    public string? ComputedValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockableUserRefField UserValue
    /// </summary>
    public string? UserValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockableUserRefField UseUserValue
    /// </summary>
    public bool? UseUserValue { get => GetValue<bool?>(); set => SetValue(value); }
}