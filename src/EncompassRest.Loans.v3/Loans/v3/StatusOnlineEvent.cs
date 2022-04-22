using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StatusOnlineEvent
/// </summary>
public sealed partial class StatusOnlineEvent : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// StatusOnlineEvent Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// StatusOnlineEvent Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }
}