using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DataTracLog
/// </summary>
public sealed partial class DataTracLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _creator;
    private DirtyValue<DateTime?>? _dateUtc;
    private DirtyValue<bool?>? _fileAttachmentsMigrated;
    private DirtyValue<string?>? _fileId;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isSystemSpecificIndicator;
    private DirtyValue<int?>? _logRecordIndex;
    private DirtyValue<string?>? _message;
    private DirtyValue<string?>? _systemId;
    private DirtyValue<DateTime?>? _updatedDateUtc;

    /// <summary>
    /// DataTracLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// DataTracLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// DataTracLog Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// DataTracLog Creator
    /// </summary>
    public string? Creator { get => _creator; set => SetField(ref _creator, value); }

    /// <summary>
    /// DataTracLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

    /// <summary>
    /// DataTracLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

    /// <summary>
    /// DataTracLog FileId
    /// </summary>
    public string? FileId { get => _fileId; set => SetField(ref _fileId, value); }

    /// <summary>
    /// DataTracLog Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// DataTracLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// DataTracLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

    /// <summary>
    /// DataTracLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

    /// <summary>
    /// DataTracLog Message
    /// </summary>
    public string? Message { get => _message; set => SetField(ref _message, value); }

    /// <summary>
    /// DataTracLog SystemId
    /// </summary>
    public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

    /// <summary>
    /// DataTracLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
}