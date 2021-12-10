using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosedDateField
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UseUserValue))]
public sealed partial class DisclosedDateField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _computedValue;
    private DirtyValue<DateTime?>? _userValue;
    private DirtyValue<bool?>? _useUserValue;

    /// <summary>
    /// DisclosedDateFieldContract ComputedValue
    /// </summary>
    public DateTime? ComputedValue { get => _computedValue; set => SetField(ref _computedValue, value); }

    /// <summary>
    /// DisclosedDateFieldContract UserValue
    /// </summary>
    public DateTime? UserValue { get => _userValue; set => SetField(ref _userValue, value); }

    /// <summary>
    /// DisclosedDateFieldContract UseUserValue
    /// </summary>
    public bool? UseUserValue { get => _useUserValue; set => SetField(ref _useUserValue, value); }
}