using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StatusOnlineLog
/// </summary>
public sealed partial class StatusOnlineLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// StatusOnlineLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// StatusOnlineLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// StatusOnlineLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StatusOnlineLog Creator
    /// </summary>
    public string? Creator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StatusOnlineLog Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// StatusOnlineLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StatusOnlineLog Events
    /// </summary>
    [AllowNull]
    public IList<StatusOnlineEvent> Events { get => GetList<StatusOnlineEvent>(); set => SetList(value); }

    /// <summary>
    /// StatusOnlineLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}