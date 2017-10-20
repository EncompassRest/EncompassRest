using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestLog : IDirty
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { return _alerts ?? (_alerts = new DirtyList<LogAlert>()); } set { _alerts = new DirtyList<LogAlert>(value); } }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get { return _buySideExpirationDate; } set { _buySideExpirationDate = value; } }
        private DirtyValue<DateTime?> _buySideNewLockExtensionDate;
        public DateTime? BuySideNewLockExtensionDate { get { return _buySideNewLockExtensionDate; } set { _buySideNewLockExtensionDate = value; } }
        private DirtyValue<int?> _buySideNumDayExtended;
        public int? BuySideNumDayExtended { get { return _buySideNumDayExtended; } set { _buySideNumDayExtended = value; } }
        private DirtyValue<int?> _buySideNumDayLocked;
        public int? BuySideNumDayLocked { get { return _buySideNumDayLocked; } set { _buySideNumDayLocked = value; } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { return _commentList ?? (_commentList = new DirtyList<LogComment>()); } set { _commentList = new DirtyList<LogComment>(value); } }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<bool?> _hideLogIndicator;
        public bool? HideLogIndicator { get { return _hideLogIndicator; } set { _hideLogIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _investorCommitment;
        public string InvestorCommitment { get { return _investorCommitment; } set { _investorCommitment = value; } }
        private DirtyValue<bool?> _isFakeRequestIndicator;
        public bool? IsFakeRequestIndicator { get { return _isFakeRequestIndicator; } set { _isFakeRequestIndicator = value; } }
        private DirtyValue<bool?> _isLockCancellationIndicator;
        public bool? IsLockCancellationIndicator { get { return _isLockCancellationIndicator; } set { _isLockCancellationIndicator = value; } }
        private DirtyValue<bool?> _isLockExtensionIndicator;
        public bool? IsLockExtensionIndicator { get { return _isLockExtensionIndicator; } set { _isLockExtensionIndicator = value; } }
        private DirtyValue<bool?> _isReLockIndicator;
        public bool? IsReLockIndicator { get { return _isReLockIndicator; } set { _isReLockIndicator = value; } }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private DirtyValue<int?> _numDayLocked;
        public int? NumDayLocked { get { return _numDayLocked; } set { _numDayLocked = value; } }
        private DirtyValue<string> _parentLockGuid;
        public string ParentLockGuid { get { return _parentLockGuid; } set { _parentLockGuid = value; } }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private DirtyValue<string> _requestedName;
        public string RequestedName { get { return _requestedName; } set { _requestedName = value; } }
        private DirtyValue<string> _requestedStatus;
        public string RequestedStatus { get { return _requestedStatus; } set { _requestedStatus = value; } }
        private DirtyValue<string> _sellSideDeliveredBy;
        public string SellSideDeliveredBy { get { return _sellSideDeliveredBy; } set { _sellSideDeliveredBy = value; } }
        private DirtyValue<DateTime?> _sellSideDeliveryDate;
        public DateTime? SellSideDeliveryDate { get { return _sellSideDeliveryDate; } set { _sellSideDeliveryDate = value; } }
        private DirtyValue<DateTime?> _sellSideExpirationDate;
        public DateTime? SellSideExpirationDate { get { return _sellSideExpirationDate; } set { _sellSideExpirationDate = value; } }
        private DirtyValue<DateTime?> _sellSideNewLockExtensionDate;
        public DateTime? SellSideNewLockExtensionDate { get { return _sellSideNewLockExtensionDate; } set { _sellSideNewLockExtensionDate = value; } }
        private DirtyValue<int?> _sellSideNumDayExtended;
        public int? SellSideNumDayExtended { get { return _sellSideNumDayExtended; } set { _sellSideNumDayExtended = value; } }
        private DirtyValue<string> _snapshotXml;
        public string SnapshotXml { get { return _snapshotXml; } set { _snapshotXml = value; } }
        private DirtyValue<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private DirtyValue<string> _timeRequested;
        public string TimeRequested { get { return _timeRequested; } set { _timeRequested = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _alertsXml.Dirty
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
                    || _commentList?.Dirty == true
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}