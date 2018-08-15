using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockRequestLog
    /// </summary>
    public sealed partial class LockRequestLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// LockRequestLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// LockRequestLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        /// <summary>
        /// LockRequestLog BuySideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }
        private DirtyValue<DateTime?> _buySideNewLockExtensionDate;
        /// <summary>
        /// LockRequestLog BuySideNewLockExtensionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BuySideNewLockExtensionDate { get => _buySideNewLockExtensionDate; set => SetField(ref _buySideNewLockExtensionDate, value); }
        private DirtyValue<int?> _buySideNumDayExtended;
        /// <summary>
        /// LockRequestLog BuySideNumDayExtended
        /// </summary>
        public int? BuySideNumDayExtended { get => _buySideNumDayExtended; set => SetField(ref _buySideNumDayExtended, value); }
        private DirtyValue<int?> _buySideNumDayLocked;
        /// <summary>
        /// LockRequestLog BuySideNumDayLocked
        /// </summary>
        public int? BuySideNumDayLocked { get => _buySideNumDayLocked; set => SetField(ref _buySideNumDayLocked, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// LockRequestLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// LockRequestLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LockRequestLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<int?> _cumulatedDaystoExtend;
        /// <summary>
        /// LockRequestLog CumulatedDaystoExtend
        /// </summary>
        public int? CumulatedDaystoExtend { get => _cumulatedDaystoExtend; set => SetField(ref _cumulatedDaystoExtend, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LockRequestLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// LockRequestLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LockRequestLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<bool?> _hideLogIndicator;
        /// <summary>
        /// LockRequestLog HideLogIndicator
        /// </summary>
        public bool? HideLogIndicator { get => _hideLogIndicator; set => SetField(ref _hideLogIndicator, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LockRequestLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _investorCommitment;
        /// <summary>
        /// LockRequestLog InvestorCommitment
        /// </summary>
        public string InvestorCommitment { get => _investorCommitment; set => SetField(ref _investorCommitment, value); }
        private DirtyValue<string> _investorName;
        /// <summary>
        /// LockRequestLog InvestorName
        /// </summary>
        public string InvestorName { get => _investorName; set => SetField(ref _investorName, value); }
        private DirtyValue<bool?> _isFakeRequestIndicator;
        /// <summary>
        /// LockRequestLog IsFakeRequestIndicator
        /// </summary>
        public bool? IsFakeRequestIndicator { get => _isFakeRequestIndicator; set => SetField(ref _isFakeRequestIndicator, value); }
        private DirtyValue<bool?> _isLockCancellationIndicator;
        /// <summary>
        /// LockRequestLog IsLockCancellationIndicator
        /// </summary>
        public bool? IsLockCancellationIndicator { get => _isLockCancellationIndicator; set => SetField(ref _isLockCancellationIndicator, value); }
        private DirtyValue<bool?> _isLockExtensionIndicator;
        /// <summary>
        /// LockRequestLog IsLockExtensionIndicator
        /// </summary>
        public bool? IsLockExtensionIndicator { get => _isLockExtensionIndicator; set => SetField(ref _isLockExtensionIndicator, value); }
        private DirtyValue<bool?> _isReLockIndicator;
        /// <summary>
        /// LockRequestLog IsReLockIndicator
        /// </summary>
        public bool? IsReLockIndicator { get => _isReLockIndicator; set => SetField(ref _isReLockIndicator, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// LockRequestLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// LockRequestLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<int?> _numDayLocked;
        /// <summary>
        /// LockRequestLog NumDayLocked
        /// </summary>
        public int? NumDayLocked { get => _numDayLocked; set => SetField(ref _numDayLocked, value); }
        private DirtyValue<string> _parentLockGuid;
        /// <summary>
        /// LockRequestLog ParentLockGuid
        /// </summary>
        public string ParentLockGuid { get => _parentLockGuid; set => SetField(ref _parentLockGuid, value); }
        private DirtyValue<string> _rateLockAction;
        /// <summary>
        /// LockRequestLog RateLockAction
        /// </summary>
        public string RateLockAction { get => _rateLockAction; set => SetField(ref _rateLockAction, value); }
        private DirtyValue<int?> _reLockSequenceNumberForInactiveLock;
        /// <summary>
        /// LockRequestLog ReLockSequenceNumberForInactiveLock
        /// </summary>
        public int? ReLockSequenceNumberForInactiveLock { get => _reLockSequenceNumberForInactiveLock; set => SetField(ref _reLockSequenceNumberForInactiveLock, value); }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// LockRequestLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }
        private DirtyValue<string> _requestedName;
        /// <summary>
        /// LockRequestLog RequestedName
        /// </summary>
        public string RequestedName { get => _requestedName; set => SetField(ref _requestedName, value); }
        private DirtyValue<string> _requestedStatus;
        /// <summary>
        /// LockRequestLog RequestedStatus
        /// </summary>
        public string RequestedStatus { get => _requestedStatus; set => SetField(ref _requestedStatus, value); }
        private DirtyValue<string> _reviseAction;
        /// <summary>
        /// LockRequestLog ReviseAction
        /// </summary>
        public string ReviseAction { get => _reviseAction; set => SetField(ref _reviseAction, value); }
        private DirtyValue<string> _sellSideDeliveredBy;
        /// <summary>
        /// LockRequestLog SellSideDeliveredBy
        /// </summary>
        public string SellSideDeliveredBy { get => _sellSideDeliveredBy; set => SetField(ref _sellSideDeliveredBy, value); }
        private DirtyValue<DateTime?> _sellSideDeliveryDate;
        /// <summary>
        /// LockRequestLog SellSideDeliveryDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => SetField(ref _sellSideDeliveryDate, value); }
        private DirtyValue<DateTime?> _sellSideExpirationDate;
        /// <summary>
        /// LockRequestLog SellSideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => SetField(ref _sellSideExpirationDate, value); }
        private DirtyValue<DateTime?> _sellSideNewLockExtensionDate;
        /// <summary>
        /// LockRequestLog SellSideNewLockExtensionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideNewLockExtensionDate { get => _sellSideNewLockExtensionDate; set => SetField(ref _sellSideNewLockExtensionDate, value); }
        private DirtyValue<int?> _sellSideNumDayExtended;
        /// <summary>
        /// LockRequestLog SellSideNumDayExtended
        /// </summary>
        public int? SellSideNumDayExtended { get => _sellSideNumDayExtended; set => SetField(ref _sellSideNumDayExtended, value); }
        private DirtyValue<string> _snapshotXml;
        /// <summary>
        /// LockRequestLog SnapshotXml
        /// </summary>
        public string SnapshotXml { get => _snapshotXml; set => SetField(ref _snapshotXml, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LockRequestLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _timeRequested;
        /// <summary>
        /// LockRequestLog TimeRequested
        /// </summary>
        public string TimeRequested { get => _timeRequested; set => SetField(ref _timeRequested, value); }
    }
}