using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EmailTriggerLog
/// </summary>
public sealed partial class EmailTriggerLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyValue<string?>? _body;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _inLogIndicator;
    private DirtyValue<string?>? _recipients;
    private DirtyValue<string?>? _sender;
    private DirtyValue<string?>? _subject;

    /// <summary>
    /// EmailTriggerLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// EmailTriggerLogContract Body
    /// </summary>
    public string? Body { get => _body; set => SetField(ref _body, value); }

    /// <summary>
    /// EmailTriggerLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// EmailTriggerLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// EmailTriggerLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// EmailTriggerLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EmailTriggerLogContract InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => _inLogIndicator; set => SetField(ref _inLogIndicator, value); }

    /// <summary>
    /// EmailTriggerLogContract Recipients
    /// </summary>
    public string? Recipients { get => _recipients; set => SetField(ref _recipients, value); }

    /// <summary>
    /// EmailTriggerLogContract Sender
    /// </summary>
    public string? Sender { get => _sender; set => SetField(ref _sender, value); }

    /// <summary>
    /// EmailTriggerLogContract Subject
    /// </summary>
    public string? Subject { get => _subject; set => SetField(ref _subject, value); }
}