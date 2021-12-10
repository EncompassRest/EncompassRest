using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StatusOnlineEvent
/// </summary>
public sealed partial class StatusOnlineEvent : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _description;

    /// <summary>
    /// StatusOnlineEventContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// StatusOnlineEventContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }
}