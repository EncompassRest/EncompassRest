using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosedDateField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class DisclosedDateField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosedDateField ComputedValue
    /// </summary>
    public DateTime? ComputedValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosedDateField UserValue
    /// </summary>
    public DateTime? UserValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosedDateField UseUserValue
    /// </summary>
    public bool? UseUserValue { get => GetValue<bool?>(); set => SetValue(value); }
}