namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableStringField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableStringField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockableStringField ComputedValue
    /// </summary>
    public string? ComputedValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockableStringField UserValue
    /// </summary>
    public string? UserValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockableStringField UseUserValue
    /// </summary>
    public bool? UseUserValue { get => GetValue<bool?>(); set => SetValue(value); }
}