using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StatusOnlineLog
/// </summary>
public sealed partial class StatusOnlineLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _creator;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _description;
    private DirtyList<StatusOnlineEvent>? _events;
    private DirtyValue<string?>? _id;

    /// <summary>
    /// StatusOnlineLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// StatusOnlineLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// StatusOnlineLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// StatusOnlineLogContract Creator
    /// </summary>
    public string? Creator { get => _creator; set => SetField(ref _creator, value); }

    /// <summary>
    /// StatusOnlineLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// StatusOnlineLogContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// StatusOnlineLogContract Events
    /// </summary>
    [AllowNull]
    public IList<StatusOnlineEvent> Events { get => GetField(ref _events); set => SetField(ref _events, value); }

    /// <summary>
    /// StatusOnlineLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }
}