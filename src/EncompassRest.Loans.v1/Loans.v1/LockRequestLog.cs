using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// LockRequestLog
    /// </summary>
    public sealed partial class LockRequestLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert>? _alerts;
        private DirtyValue<string?>? _alertsXml;
        private DirtyValue<DateTime?>? _buySideExpirationDate;
        private DirtyValue<DateTime?>? _buySideNewLockExtensionDate;
        private DirtyValue<int?>? _buySideNumDayExtended;
        private DirtyValue<int?>? _buySideNumDayLocked;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _commentListXml;
        private DirtyValue<string?>? _comments;
        private DirtyValue<int?>? _cumulatedDaystoExtend;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<string?>? _guid;
        private DirtyValue<bool?>? _hideLogIndicator;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _investorCommitment;
        private DirtyValue<string?>? _investorName;
        private DirtyValue<bool?>? _isFakeRequestIndicator;
        private DirtyValue<bool?>? _isLockCancellationIndicator;
        private DirtyValue<bool?>? _isLockExtensionIndicator;
        private DirtyValue<bool?>? _isReLockIndicator;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<int?>? _numDayLocked;
        private DirtyValue<string?>? _parentLockGuid;
        private DirtyValue<string?>? _rateLockAction;
        private DirtyValue<int?>? _reLockSequenceNumberForInactiveLock;
        private DirtyValue<string?>? _requestedBy;
        private DirtyValue<string?>? _requestedName;
        private DirtyValue<string?>? _requestedStatus;
        private DirtyValue<string?>? _reviseAction;
        private DirtyValue<string?>? _sellSideDeliveredBy;
        private DirtyValue<DateTime?>? _sellSideDeliveryDate;
        private DirtyValue<DateTime?>? _sellSideExpirationDate;
        private DirtyValue<DateTime?>? _sellSideNewLockExtensionDate;
        private DirtyValue<int?>? _sellSideNumDayExtended;
        private DirtyValue<string?>? _snapshotXml;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<string?>? _timeRequested;
        private DirtyValue<DateTime?>? _updatedDateUtc;

        /// <summary>
        /// LockRequestLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// LockRequestLog AlertsXml
        /// </summary>
        public string? AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// LockRequestLog BuySideExpirationDate
        /// </summary>
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }

        /// <summary>
        /// LockRequestLog BuySideNewLockExtensionDate
        /// </summary>
        public DateTime? BuySideNewLockExtensionDate { get => _buySideNewLockExtensionDate; set => SetField(ref _buySideNewLockExtensionDate, value); }

        /// <summary>
        /// LockRequestLog BuySideNumDayExtended
        /// </summary>
        public int? BuySideNumDayExtended { get => _buySideNumDayExtended; set => SetField(ref _buySideNumDayExtended, value); }

        /// <summary>
        /// LockRequestLog BuySideNumDayLocked
        /// </summary>
        public int? BuySideNumDayLocked { get => _buySideNumDayLocked; set => SetField(ref _buySideNumDayLocked, value); }

        /// <summary>
        /// LockRequestLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// LockRequestLog CommentListXml
        /// </summary>
        public string? CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// LockRequestLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// LockRequestLog CumulatedDaystoExtend
        /// </summary>
        public int? CumulatedDaystoExtend { get => _cumulatedDaystoExtend; set => SetField(ref _cumulatedDaystoExtend, value); }

        /// <summary>
        /// LockRequestLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// LockRequestLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// LockRequestLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// LockRequestLog HideLogIndicator
        /// </summary>
        public bool? HideLogIndicator { get => _hideLogIndicator; set => SetField(ref _hideLogIndicator, value); }

        /// <summary>
        /// LockRequestLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LockRequestLog InvestorCommitment
        /// </summary>
        public string? InvestorCommitment { get => _investorCommitment; set => SetField(ref _investorCommitment, value); }

        /// <summary>
        /// LockRequestLog InvestorName
        /// </summary>
        public string? InvestorName { get => _investorName; set => SetField(ref _investorName, value); }

        /// <summary>
        /// LockRequestLog IsFakeRequestIndicator
        /// </summary>
        public bool? IsFakeRequestIndicator { get => _isFakeRequestIndicator; set => SetField(ref _isFakeRequestIndicator, value); }

        /// <summary>
        /// LockRequestLog IsLockCancellationIndicator
        /// </summary>
        public bool? IsLockCancellationIndicator { get => _isLockCancellationIndicator; set => SetField(ref _isLockCancellationIndicator, value); }

        /// <summary>
        /// LockRequestLog IsLockExtensionIndicator
        /// </summary>
        public bool? IsLockExtensionIndicator { get => _isLockExtensionIndicator; set => SetField(ref _isLockExtensionIndicator, value); }

        /// <summary>
        /// LockRequestLog IsReLockIndicator
        /// </summary>
        public bool? IsReLockIndicator { get => _isReLockIndicator; set => SetField(ref _isReLockIndicator, value); }

        /// <summary>
        /// LockRequestLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// LockRequestLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// LockRequestLog NumDayLocked
        /// </summary>
        public int? NumDayLocked { get => _numDayLocked; set => SetField(ref _numDayLocked, value); }

        /// <summary>
        /// LockRequestLog ParentLockGuid
        /// </summary>
        public string? ParentLockGuid { get => _parentLockGuid; set => SetField(ref _parentLockGuid, value); }

        /// <summary>
        /// LockRequestLog RateLockAction
        /// </summary>
        public string? RateLockAction { get => _rateLockAction; set => SetField(ref _rateLockAction, value); }

        /// <summary>
        /// LockRequestLog ReLockSequenceNumberForInactiveLock
        /// </summary>
        public int? ReLockSequenceNumberForInactiveLock { get => _reLockSequenceNumberForInactiveLock; set => SetField(ref _reLockSequenceNumberForInactiveLock, value); }

        /// <summary>
        /// LockRequestLog RequestedBy
        /// </summary>
        public string? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// LockRequestLog RequestedName
        /// </summary>
        public string? RequestedName { get => _requestedName; set => SetField(ref _requestedName, value); }

        /// <summary>
        /// LockRequestLog RequestedStatus
        /// </summary>
        public string? RequestedStatus { get => _requestedStatus; set => SetField(ref _requestedStatus, value); }

        /// <summary>
        /// LockRequestLog ReviseAction
        /// </summary>
        public string? ReviseAction { get => _reviseAction; set => SetField(ref _reviseAction, value); }

        /// <summary>
        /// LockRequestLog SellSideDeliveredBy
        /// </summary>
        public string? SellSideDeliveredBy { get => _sellSideDeliveredBy; set => SetField(ref _sellSideDeliveredBy, value); }

        /// <summary>
        /// LockRequestLog SellSideDeliveryDate
        /// </summary>
        public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => SetField(ref _sellSideDeliveryDate, value); }

        /// <summary>
        /// LockRequestLog SellSideExpirationDate
        /// </summary>
        public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => SetField(ref _sellSideExpirationDate, value); }

        /// <summary>
        /// LockRequestLog SellSideNewLockExtensionDate
        /// </summary>
        public DateTime? SellSideNewLockExtensionDate { get => _sellSideNewLockExtensionDate; set => SetField(ref _sellSideNewLockExtensionDate, value); }

        /// <summary>
        /// LockRequestLog SellSideNumDayExtended
        /// </summary>
        public int? SellSideNumDayExtended { get => _sellSideNumDayExtended; set => SetField(ref _sellSideNumDayExtended, value); }

        /// <summary>
        /// LockRequestLog SnapshotXml
        /// </summary>
        public string? SnapshotXml { get => _snapshotXml; set => SetField(ref _snapshotXml, value); }

        /// <summary>
        /// LockRequestLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// LockRequestLog TimeRequested
        /// </summary>
        public string? TimeRequested { get => _timeRequested; set => SetField(ref _timeRequested, value); }

        /// <summary>
        /// LockRequestLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}