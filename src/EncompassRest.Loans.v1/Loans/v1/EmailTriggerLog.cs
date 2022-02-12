using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// EmailTriggerLog
/// </summary>
public sealed partial class EmailTriggerLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyValue<string?>? _body;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _dateUtc;
    private DirtyValue<bool?>? _fileAttachmentsMigrated;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _inLogIndicator;
    private DirtyValue<bool?>? _isSystemSpecificIndicator;
    private DirtyValue<int?>? _logRecordIndex;
    private DirtyValue<string?>? _recipients;
    private DirtyValue<string?>? _sender;
    private DirtyValue<string?>? _subject;
    private DirtyValue<string?>? _systemId;
    private DirtyValue<DateTime?>? _updatedDateUtc;

    /// <summary>
    /// EmailTriggerLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// EmailTriggerLog Body
    /// </summary>
    public string? Body { get => _body; set => SetField(ref _body, value); }

    /// <summary>
    /// EmailTriggerLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// EmailTriggerLog Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// EmailTriggerLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

    /// <summary>
    /// EmailTriggerLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

    /// <summary>
    /// EmailTriggerLog Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// EmailTriggerLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EmailTriggerLog InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => _inLogIndicator; set => SetField(ref _inLogIndicator, value); }

    /// <summary>
    /// EmailTriggerLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

    /// <summary>
    /// EmailTriggerLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

    /// <summary>
    /// EmailTriggerLog Recipients
    /// </summary>
    public string? Recipients { get => _recipients; set => SetField(ref _recipients, value); }

    /// <summary>
    /// EmailTriggerLog Sender
    /// </summary>
    public string? Sender { get => _sender; set => SetField(ref _sender, value); }

    /// <summary>
    /// EmailTriggerLog Subject
    /// </summary>
    public string? Subject { get => _subject; set => SetField(ref _subject, value); }

    /// <summary>
    /// EmailTriggerLog SystemId
    /// </summary>
    public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

    /// <summary>
    /// EmailTriggerLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
}