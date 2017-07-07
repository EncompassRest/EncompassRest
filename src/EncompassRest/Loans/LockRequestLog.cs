using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestLog : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _alertsXml.Clean
                    && _buySideExpirationDate.Clean
                    && _buySideNewLockExtensionDate.Clean
                    && _buySideNumDayExtended.Clean
                    && _buySideNumDayLocked.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _dateUtc.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _hideLogIndicator.Clean
                    && _id.Clean
                    && _investorCommitment.Clean
                    && _isFakeRequestIndicator.Clean
                    && _isLockCancellationIndicator.Clean
                    && _isLockExtensionIndicator.Clean
                    && _isReLockIndicator.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _numDayLocked.Clean
                    && _parentLockGuid.Clean
                    && _requestedBy.Clean
                    && _requestedName.Clean
                    && _requestedStatus.Clean
                    && _sellSideDeliveredBy.Clean
                    && _sellSideDeliveryDate.Clean
                    && _sellSideExpirationDate.Clean
                    && _sellSideNewLockExtensionDate.Clean
                    && _sellSideNumDayExtended.Clean
                    && _snapshotXml.Clean
                    && _systemId.Clean
                    && _timeRequested.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var alertsXml = _alertsXml; alertsXml.Clean = value; _alertsXml = alertsXml;
                var buySideExpirationDate = _buySideExpirationDate; buySideExpirationDate.Clean = value; _buySideExpirationDate = buySideExpirationDate;
                var buySideNewLockExtensionDate = _buySideNewLockExtensionDate; buySideNewLockExtensionDate.Clean = value; _buySideNewLockExtensionDate = buySideNewLockExtensionDate;
                var buySideNumDayExtended = _buySideNumDayExtended; buySideNumDayExtended.Clean = value; _buySideNumDayExtended = buySideNumDayExtended;
                var buySideNumDayLocked = _buySideNumDayLocked; buySideNumDayLocked.Clean = value; _buySideNumDayLocked = buySideNumDayLocked;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var commentListXml = _commentListXml; commentListXml.Clean = value; _commentListXml = commentListXml;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var hideLogIndicator = _hideLogIndicator; hideLogIndicator.Clean = value; _hideLogIndicator = hideLogIndicator;
                var id = _id; id.Clean = value; _id = id;
                var investorCommitment = _investorCommitment; investorCommitment.Clean = value; _investorCommitment = investorCommitment;
                var isFakeRequestIndicator = _isFakeRequestIndicator; isFakeRequestIndicator.Clean = value; _isFakeRequestIndicator = isFakeRequestIndicator;
                var isLockCancellationIndicator = _isLockCancellationIndicator; isLockCancellationIndicator.Clean = value; _isLockCancellationIndicator = isLockCancellationIndicator;
                var isLockExtensionIndicator = _isLockExtensionIndicator; isLockExtensionIndicator.Clean = value; _isLockExtensionIndicator = isLockExtensionIndicator;
                var isReLockIndicator = _isReLockIndicator; isReLockIndicator.Clean = value; _isReLockIndicator = isReLockIndicator;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var numDayLocked = _numDayLocked; numDayLocked.Clean = value; _numDayLocked = numDayLocked;
                var parentLockGuid = _parentLockGuid; parentLockGuid.Clean = value; _parentLockGuid = parentLockGuid;
                var requestedBy = _requestedBy; requestedBy.Clean = value; _requestedBy = requestedBy;
                var requestedName = _requestedName; requestedName.Clean = value; _requestedName = requestedName;
                var requestedStatus = _requestedStatus; requestedStatus.Clean = value; _requestedStatus = requestedStatus;
                var sellSideDeliveredBy = _sellSideDeliveredBy; sellSideDeliveredBy.Clean = value; _sellSideDeliveredBy = sellSideDeliveredBy;
                var sellSideDeliveryDate = _sellSideDeliveryDate; sellSideDeliveryDate.Clean = value; _sellSideDeliveryDate = sellSideDeliveryDate;
                var sellSideExpirationDate = _sellSideExpirationDate; sellSideExpirationDate.Clean = value; _sellSideExpirationDate = sellSideExpirationDate;
                var sellSideNewLockExtensionDate = _sellSideNewLockExtensionDate; sellSideNewLockExtensionDate.Clean = value; _sellSideNewLockExtensionDate = sellSideNewLockExtensionDate;
                var sellSideNumDayExtended = _sellSideNumDayExtended; sellSideNumDayExtended.Clean = value; _sellSideNumDayExtended = sellSideNumDayExtended;
                var snapshotXml = _snapshotXml; snapshotXml.Clean = value; _snapshotXml = snapshotXml;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var timeRequested = _timeRequested; timeRequested.Clean = value; _timeRequested = timeRequested;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LockRequestLog()
        {
            Clean = true;
        }
    }
}