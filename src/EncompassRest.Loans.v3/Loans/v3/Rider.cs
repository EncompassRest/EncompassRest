using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Rider
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Rider : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Rider Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rider Received [RIDER0003]
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rider Required [RIDER0002]
    /// </summary>
    public bool? Required { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rider Date [RIDER0004]
    /// </summary>
    public DateTime? RiderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rider Name [RIDER0001]
    /// </summary>
    public string? RiderName { get => GetValue<string?>(); set => SetValue(value); }
}