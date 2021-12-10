using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrackingEntry
/// </summary>
public sealed partial class TrackingEntry : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<bool?>? _isChecked;
    private DirtyValue<string?>? _status;
    private EntityReference? _user;

    /// <summary>
    /// TrackingEntryContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// TrackingEntryContract IsChecked
    /// </summary>
    public bool? IsChecked { get => _isChecked; set => SetField(ref _isChecked, value); }

    /// <summary>
    /// TrackingEntryContract Status
    /// </summary>
    public string? Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// TrackingEntryContract User
    /// </summary>
    [AllowNull]
    public EntityReference User { get => GetField(ref _user); set => SetField(ref _user, value); }
}