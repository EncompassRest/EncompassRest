using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LogRecord
/// </summary>
public sealed partial class LogRecord : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _dateUtc;
    private DirtyValue<bool?>? _fileAttachmentsMigrated;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isSystemSpecificIndicator;
    private DirtyValue<int?>? _logRecordIndex;
    private DirtyValue<string?>? _systemId;

    /// <summary>
    /// LogRecord CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// LogRecord Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// LogRecord DateUtc
    /// </summary>
    public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

    /// <summary>
    /// LogRecord FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

    /// <summary>
    /// LogRecord Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// LogRecord Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LogRecord IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

    /// <summary>
    /// LogRecord LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

    /// <summary>
    /// LogRecord SystemId
    /// </summary>
    public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }
}