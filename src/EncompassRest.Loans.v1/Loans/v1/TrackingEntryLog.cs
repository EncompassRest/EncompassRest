using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// TrackingEntryLog
/// </summary>
public sealed partial class TrackingEntryLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TrackingEntryLog Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingEntryLog IsChecked
    /// </summary>
    public bool? IsChecked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingEntryLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingEntryLog User
    /// </summary>
    public EntityReference? User { get => GetValue<EntityReference?>(); set => SetValue(value); }
}