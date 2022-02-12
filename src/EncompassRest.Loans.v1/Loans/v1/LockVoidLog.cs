using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LockVoidLog
/// </summary>
public sealed partial class LockVoidLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _alertIndicator;
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _dateUtc;
    private DirtyValue<bool?>? _fileAttachmentsMigrated;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isSystemSpecificIndicator;
    private DirtyValue<int?>? _logRecordIndex;
    private DirtyValue<string?>? _requestGuid;
    private DirtyValue<string?>? _systemId;
    private DirtyValue<string?>? _timeVoided;
    private DirtyValue<DateTime?>? _updatedDateUtc;
    private DirtyValue<bool?>? _voided;
    private DirtyValue<string?>? _voidedBy;
    private DirtyValue<string?>? _voidedById;

    /// <summary>
    /// LockVoidLog AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }

    /// <summary>
    /// LockVoidLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// LockVoidLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// LockVoidLog Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// LockVoidLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

    /// <summary>
    /// LockVoidLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

    /// <summary>
    /// LockVoidLog Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// LockVoidLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LockVoidLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

    /// <summary>
    /// LockVoidLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

    /// <summary>
    /// LockVoidLog RequestGuid
    /// </summary>
    public string? RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }

    /// <summary>
    /// LockVoidLog SystemId
    /// </summary>
    public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

    /// <summary>
    /// LockVoidLog TimeVoided
    /// </summary>
    public string? TimeVoided { get => _timeVoided; set => SetField(ref _timeVoided, value); }

    /// <summary>
    /// LockVoidLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }

    /// <summary>
    /// LockVoidLog Voided
    /// </summary>
    public bool? Voided { get => _voided; set => SetField(ref _voided, value); }

    /// <summary>
    /// LockVoidLog VoidedBy
    /// </summary>
    public string? VoidedBy { get => _voidedBy; set => SetField(ref _voidedBy, value); }

    /// <summary>
    /// LockVoidLog VoidedById
    /// </summary>
    public string? VoidedById { get => _voidedById; set => SetField(ref _voidedById, value); }
}