using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockableDateField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class LockableDateField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockableDateField ComputedValue
    /// </summary>
    public DateTime? ComputedValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockableDateField UserValue
    /// </summary>
    public DateTime? UserValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockableDateField UseUserValue
    /// </summary>
    public bool? UseUserValue { get => GetValue<bool?>(); set => SetValue(value); }
}