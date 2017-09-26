using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestLog : IDirty
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get { return _buySideExpirationDate; } set { _buySideExpirationDate = value; } }
        private Value<DateTime?> _buySideNewLockExtensionDate;
        public DateTime? BuySideNewLockExtensionDate { get { return _buySideNewLockExtensionDate; } set { _buySideNewLockExtensionDate = value; } }
        private Value<int?> _buySideNumDayExtended;
        public int? BuySideNumDayExtended { get { return _buySideNumDayExtended; } set { _buySideNumDayExtended = value; } }
        private Value<int?> _buySideNumDayLocked;
        public int? BuySideNumDayLocked { get { return _buySideNumDayLocked; } set { _buySideNumDayLocked = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<bool?> _hideLogIndicator;
        public bool? HideLogIndicator { get { return _hideLogIndicator; } set { _hideLogIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _investorCommitment;
        public string InvestorCommitment { get { return _investorCommitment; } set { _investorCommitment = value; } }
        private Value<bool?> _isFakeRequestIndicator;
        public bool? IsFakeRequestIndicator { get { return _isFakeRequestIndicator; } set { _isFakeRequestIndicator = value; } }
        private Value<bool?> _isLockCancellationIndicator;
        public bool? IsLockCancellationIndicator { get { return _isLockCancellationIndicator; } set { _isLockCancellationIndicator = value; } }
        private Value<bool?> _isLockExtensionIndicator;
        public bool? IsLockExtensionIndicator { get { return _isLockExtensionIndicator; } set { _isLockExtensionIndicator = value; } }
        private Value<bool?> _isReLockIndicator;
        public bool? IsReLockIndicator { get { return _isReLockIndicator; } set { _isReLockIndicator = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<int?> _numDayLocked;
        public int? NumDayLocked { get { return _numDayLocked; } set { _numDayLocked = value; } }
        private Value<string> _parentLockGuid;
        public string ParentLockGuid { get { return _parentLockGuid; } set { _parentLockGuid = value; } }
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private Value<string> _requestedName;
        public string RequestedName { get { return _requestedName; } set { _requestedName = value; } }
        private Value<string> _requestedStatus;
        public string RequestedStatus { get { return _requestedStatus; } set { _requestedStatus = value; } }
        private Value<string> _sellSideDeliveredBy;
        public string SellSideDeliveredBy { get { return _sellSideDeliveredBy; } set { _sellSideDeliveredBy = value; } }
        private Value<DateTime?> _sellSideDeliveryDate;
        public DateTime? SellSideDeliveryDate { get { return _sellSideDeliveryDate; } set { _sellSideDeliveryDate = value; } }
        private Value<DateTime?> _sellSideExpirationDate;
        public DateTime? SellSideExpirationDate { get { return _sellSideExpirationDate; } set { _sellSideExpirationDate = value; } }
        private Value<DateTime?> _sellSideNewLockExtensionDate;
        public DateTime? SellSideNewLockExtensionDate { get { return _sellSideNewLockExtensionDate; } set { _sellSideNewLockExtensionDate = value; } }
        private Value<int?> _sellSideNumDayExtended;
        public int? SellSideNumDayExtended { get { return _sellSideNumDayExtended; } set { _sellSideNumDayExtended = value; } }
        private Value<string> _snapshotXml;
        public string SnapshotXml { get { return _snapshotXml; } set { _snapshotXml = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _timeRequested;
        public string TimeRequested { get { return _timeRequested; } set { _timeRequested = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _alerts.Dirty
                    || _alertsXml.Dirty
                    || _buySideExpirationDate.Dirty
                    || _buySideNewLockExtensionDate.Dirty
                    || _buySideNumDayExtended.Dirty
                    || _buySideNumDayLocked.Dirty
                    || _commentList.Dirty
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
                    || _timeRequested.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _alerts.Dirty = value;
                _alertsXml.Dirty = value;
                _buySideExpirationDate.Dirty = value;
                _buySideNewLockExtensionDate.Dirty = value;
                _buySideNumDayExtended.Dirty = value;
                _buySideNumDayLocked.Dirty = value;
                _commentList.Dirty = value;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}