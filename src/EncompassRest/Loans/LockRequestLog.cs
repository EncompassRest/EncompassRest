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
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// LockRequestLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        /// <summary>
        /// LockRequestLog BuySideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => _buySideExpirationDate = value; }
        private DirtyValue<DateTime?> _buySideNewLockExtensionDate;
        /// <summary>
        /// LockRequestLog BuySideNewLockExtensionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BuySideNewLockExtensionDate { get => _buySideNewLockExtensionDate; set => _buySideNewLockExtensionDate = value; }
        private DirtyValue<int?> _buySideNumDayExtended;
        /// <summary>
        /// LockRequestLog BuySideNumDayExtended
        /// </summary>
        public int? BuySideNumDayExtended { get => _buySideNumDayExtended; set => _buySideNumDayExtended = value; }
        private DirtyValue<int?> _buySideNumDayLocked;
        /// <summary>
        /// LockRequestLog BuySideNumDayLocked
        /// </summary>
        public int? BuySideNumDayLocked { get => _buySideNumDayLocked; set => _buySideNumDayLocked = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// LockRequestLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// LockRequestLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LockRequestLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LockRequestLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// LockRequestLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LockRequestLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<bool?> _hideLogIndicator;
        /// <summary>
        /// LockRequestLog HideLogIndicator
        /// </summary>
        public bool? HideLogIndicator { get => _hideLogIndicator; set => _hideLogIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LockRequestLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _investorCommitment;
        /// <summary>
        /// LockRequestLog InvestorCommitment
        /// </summary>
        public string InvestorCommitment { get => _investorCommitment; set => _investorCommitment = value; }
        private DirtyValue<bool?> _isFakeRequestIndicator;
        /// <summary>
        /// LockRequestLog IsFakeRequestIndicator
        /// </summary>
        public bool? IsFakeRequestIndicator { get => _isFakeRequestIndicator; set => _isFakeRequestIndicator = value; }
        private DirtyValue<bool?> _isLockCancellationIndicator;
        /// <summary>
        /// LockRequestLog IsLockCancellationIndicator
        /// </summary>
        public bool? IsLockCancellationIndicator { get => _isLockCancellationIndicator; set => _isLockCancellationIndicator = value; }
        private DirtyValue<bool?> _isLockExtensionIndicator;
        /// <summary>
        /// LockRequestLog IsLockExtensionIndicator
        /// </summary>
        public bool? IsLockExtensionIndicator { get => _isLockExtensionIndicator; set => _isLockExtensionIndicator = value; }
        private DirtyValue<bool?> _isReLockIndicator;
        /// <summary>
        /// LockRequestLog IsReLockIndicator
        /// </summary>
        public bool? IsReLockIndicator { get => _isReLockIndicator; set => _isReLockIndicator = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// LockRequestLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// LockRequestLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<int?> _numDayLocked;
        /// <summary>
        /// LockRequestLog NumDayLocked
        /// </summary>
        public int? NumDayLocked { get => _numDayLocked; set => _numDayLocked = value; }
        private DirtyValue<string> _parentLockGuid;
        /// <summary>
        /// LockRequestLog ParentLockGuid
        /// </summary>
        public string ParentLockGuid { get => _parentLockGuid; set => _parentLockGuid = value; }
        private DirtyValue<int?> _reLockSequenceNumberForInactiveLock;
        /// <summary>
        /// LockRequestLog ReLockSequenceNumberForInactiveLock
        /// </summary>
        public int? ReLockSequenceNumberForInactiveLock { get => _reLockSequenceNumberForInactiveLock; set => _reLockSequenceNumberForInactiveLock = value; }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// LockRequestLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<string> _requestedName;
        /// <summary>
        /// LockRequestLog RequestedName
        /// </summary>
        public string RequestedName { get => _requestedName; set => _requestedName = value; }
        private DirtyValue<string> _requestedStatus;
        /// <summary>
        /// LockRequestLog RequestedStatus
        /// </summary>
        public string RequestedStatus { get => _requestedStatus; set => _requestedStatus = value; }
        private DirtyValue<string> _sellSideDeliveredBy;
        /// <summary>
        /// LockRequestLog SellSideDeliveredBy
        /// </summary>
        public string SellSideDeliveredBy { get => _sellSideDeliveredBy; set => _sellSideDeliveredBy = value; }
        private DirtyValue<DateTime?> _sellSideDeliveryDate;
        /// <summary>
        /// LockRequestLog SellSideDeliveryDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => _sellSideDeliveryDate = value; }
        private DirtyValue<DateTime?> _sellSideExpirationDate;
        /// <summary>
        /// LockRequestLog SellSideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => _sellSideExpirationDate = value; }
        private DirtyValue<DateTime?> _sellSideNewLockExtensionDate;
        /// <summary>
        /// LockRequestLog SellSideNewLockExtensionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideNewLockExtensionDate { get => _sellSideNewLockExtensionDate; set => _sellSideNewLockExtensionDate = value; }
        private DirtyValue<int?> _sellSideNumDayExtended;
        /// <summary>
        /// LockRequestLog SellSideNumDayExtended
        /// </summary>
        public int? SellSideNumDayExtended { get => _sellSideNumDayExtended; set => _sellSideNumDayExtended = value; }
        private DirtyValue<string> _snapshotXml;
        /// <summary>
        /// LockRequestLog SnapshotXml
        /// </summary>
        public string SnapshotXml { get => _snapshotXml; set => _snapshotXml = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LockRequestLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _timeRequested;
        /// <summary>
        /// LockRequestLog TimeRequested
        /// </summary>
        public string TimeRequested { get => _timeRequested; set => _timeRequested = value; }
        internal override bool DirtyInternal
        {
            get => _alertsXml.Dirty
                || _buySideExpirationDate.Dirty
                || _buySideNewLockExtensionDate.Dirty
                || _buySideNumDayExtended.Dirty
                || _buySideNumDayLocked.Dirty
                || _commentListXml.Dirty
                || _comments.Dirty
                || _dateUtc.Dirty
                || _fileAttachmentsMigrated.Dirty
                || _guid.Dirty
                || _hideLogIndicator.Dirty
                || _id.Dirty
                || _investorCommitment.Dirty
                || _isFakeRequestIndicator.Dirty
                || _isLockCancellationIndicator.Dirty
                || _isLockExtensionIndicator.Dirty
                || _isReLockIndicator.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _logRecordIndex.Dirty
                || _numDayLocked.Dirty
                || _parentLockGuid.Dirty
                || _reLockSequenceNumberForInactiveLock.Dirty
                || _requestedBy.Dirty
                || _requestedName.Dirty
                || _requestedStatus.Dirty
                || _sellSideDeliveredBy.Dirty
                || _sellSideDeliveryDate.Dirty
                || _sellSideExpirationDate.Dirty
                || _sellSideNewLockExtensionDate.Dirty
                || _sellSideNumDayExtended.Dirty
                || _snapshotXml.Dirty
                || _systemId.Dirty
                || _timeRequested.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true;
            set
            {
                _alertsXml.Dirty = value;
                _buySideExpirationDate.Dirty = value;
                _buySideNewLockExtensionDate.Dirty = value;
                _buySideNumDayExtended.Dirty = value;
                _buySideNumDayLocked.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _hideLogIndicator.Dirty = value;
                _id.Dirty = value;
                _investorCommitment.Dirty = value;
                _isFakeRequestIndicator.Dirty = value;
                _isLockCancellationIndicator.Dirty = value;
                _isLockExtensionIndicator.Dirty = value;
                _isReLockIndicator.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _numDayLocked.Dirty = value;
                _parentLockGuid.Dirty = value;
                _reLockSequenceNumberForInactiveLock.Dirty = value;
                _requestedBy.Dirty = value;
                _requestedName.Dirty = value;
                _requestedStatus.Dirty = value;
                _sellSideDeliveredBy.Dirty = value;
                _sellSideDeliveryDate.Dirty = value;
                _sellSideExpirationDate.Dirty = value;
                _sellSideNewLockExtensionDate.Dirty = value;
                _sellSideNumDayExtended.Dirty = value;
                _snapshotXml.Dirty = value;
                _systemId.Dirty = value;
                _timeRequested.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}