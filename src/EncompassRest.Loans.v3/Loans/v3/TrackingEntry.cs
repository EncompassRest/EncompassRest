using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrackingEntry
/// </summary>
public sealed partial class TrackingEntry : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TrackingEntry Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingEntry IsChecked
    /// </summary>
    public bool? IsChecked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingEntry Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingEntry User
    /// </summary>
    [AllowNull]
    public EntityReference User { get => GetEntity<EntityReference>(); set => SetEntity(value); }
}