using System;

namespace EncompassRest.Loans.v1;

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
    /// Rider Received [RIDERNN03]
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rider Required [RIDERNN02]
    /// </summary>
    public bool? Required { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rider Date [RIDERNN04]
    /// </summary>
    public DateTime? RiderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rider RiderIndex
    /// </summary>
    public int? RiderIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rider Name [RIDERNN01]
    /// </summary>
    public string? RiderName { get => GetValue<string?>(); set => SetValue(value); }
}