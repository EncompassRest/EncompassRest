using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestLog
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !_alertsXml.Clean;
        private Value<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get { return _buySideExpirationDate; } set { _buySideExpirationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideExpirationDate() => !_buySideExpirationDate.Clean;
        private Value<DateTime?> _buySideNewLockExtensionDate;
        public DateTime? BuySideNewLockExtensionDate { get { return _buySideNewLockExtensionDate; } set { _buySideNewLockExtensionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideNewLockExtensionDate() => !_buySideNewLockExtensionDate.Clean;
        private Value<int?> _buySideNumDayExtended;
        public int? BuySideNumDayExtended { get { return _buySideNumDayExtended; } set { _buySideNumDayExtended = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideNumDayExtended() => !_buySideNumDayExtended.Clean;
        private Value<int?> _buySideNumDayLocked;
        public int? BuySideNumDayLocked { get { return _buySideNumDayLocked; } set { _buySideNumDayLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideNumDayLocked() => !_buySideNumDayLocked.Clean;
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !_commentList.Clean;
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !_commentListXml.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !_dateUtc.Clean;
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !_fileAttachmentsMigrated.Clean;
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !_guid.Clean;
        private Value<bool?> _hideLogIndicator;
        public bool? HideLogIndicator { get { return _hideLogIndicator; } set { _hideLogIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHideLogIndicator() => !_hideLogIndicator.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _investorCommitment;
        public string InvestorCommitment { get { return _investorCommitment; } set { _investorCommitment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCommitment() => !_investorCommitment.Clean;
        private Value<bool?> _isFakeRequestIndicator;
        public bool? IsFakeRequestIndicator { get { return _isFakeRequestIndicator; } set { _isFakeRequestIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsFakeRequestIndicator() => !_isFakeRequestIndicator.Clean;
        private Value<bool?> _isLockCancellationIndicator;
        public bool? IsLockCancellationIndicator { get { return _isLockCancellationIndicator; } set { _isLockCancellationIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsLockCancellationIndicator() => !_isLockCancellationIndicator.Clean;
        private Value<bool?> _isLockExtensionIndicator;
        public bool? IsLockExtensionIndicator { get { return _isLockExtensionIndicator; } set { _isLockExtensionIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsLockExtensionIndicator() => !_isLockExtensionIndicator.Clean;
        private Value<bool?> _isReLockIndicator;
        public bool? IsReLockIndicator { get { return _isReLockIndicator; } set { _isReLockIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsReLockIndicator() => !_isReLockIndicator.Clean;
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !_isSystemSpecificIndicator.Clean;
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !_logRecordIndex.Clean;
        private Value<int?> _numDayLocked;
        public int? NumDayLocked { get { return _numDayLocked; } set { _numDayLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumDayLocked() => !_numDayLocked.Clean;
        private Value<string> _parentLockGuid;
        public string ParentLockGuid { get { return _parentLockGuid; } set { _parentLockGuid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentLockGuid() => !_parentLockGuid.Clean;
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedBy() => !_requestedBy.Clean;
        private Value<string> _requestedName;
        public string RequestedName { get { return _requestedName; } set { _requestedName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedName() => !_requestedName.Clean;
        private Value<string> _requestedStatus;
        public string RequestedStatus { get { return _requestedStatus; } set { _requestedStatus = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedStatus() => !_requestedStatus.Clean;
        private Value<string> _sellSideDeliveredBy;
        public string SellSideDeliveredBy { get { return _sellSideDeliveredBy; } set { _sellSideDeliveredBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDeliveredBy() => !_sellSideDeliveredBy.Clean;
        private Value<DateTime?> _sellSideDeliveryDate;
        public DateTime? SellSideDeliveryDate { get { return _sellSideDeliveryDate; } set { _sellSideDeliveryDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDeliveryDate() => !_sellSideDeliveryDate.Clean;
        private Value<DateTime?> _sellSideExpirationDate;
        public DateTime? SellSideExpirationDate { get { return _sellSideExpirationDate; } set { _sellSideExpirationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideExpirationDate() => !_sellSideExpirationDate.Clean;
        private Value<DateTime?> _sellSideNewLockExtensionDate;
        public DateTime? SellSideNewLockExtensionDate { get { return _sellSideNewLockExtensionDate; } set { _sellSideNewLockExtensionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideNewLockExtensionDate() => !_sellSideNewLockExtensionDate.Clean;
        private Value<int?> _sellSideNumDayExtended;
        public int? SellSideNumDayExtended { get { return _sellSideNumDayExtended; } set { _sellSideNumDayExtended = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideNumDayExtended() => !_sellSideNumDayExtended.Clean;
        private Value<string> _snapshotXml;
        public string SnapshotXml { get { return _snapshotXml; } set { _snapshotXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSnapshotXml() => !_snapshotXml.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private Value<string> _timeRequested;
        public string TimeRequested { get { return _timeRequested; } set { _timeRequested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeRequested() => !_timeRequested.Clean;
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
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _alertsXml; v1.Clean = value; _alertsXml = v1;
                var v2 = _buySideExpirationDate; v2.Clean = value; _buySideExpirationDate = v2;
                var v3 = _buySideNewLockExtensionDate; v3.Clean = value; _buySideNewLockExtensionDate = v3;
                var v4 = _buySideNumDayExtended; v4.Clean = value; _buySideNumDayExtended = v4;
                var v5 = _buySideNumDayLocked; v5.Clean = value; _buySideNumDayLocked = v5;
                var v6 = _commentList; v6.Clean = value; _commentList = v6;
                var v7 = _commentListXml; v7.Clean = value; _commentListXml = v7;
                var v8 = _comments; v8.Clean = value; _comments = v8;
                var v9 = _dateUtc; v9.Clean = value; _dateUtc = v9;
                var v10 = _fileAttachmentsMigrated; v10.Clean = value; _fileAttachmentsMigrated = v10;
                var v11 = _guid; v11.Clean = value; _guid = v11;
                var v12 = _hideLogIndicator; v12.Clean = value; _hideLogIndicator = v12;
                var v13 = _id; v13.Clean = value; _id = v13;
                var v14 = _investorCommitment; v14.Clean = value; _investorCommitment = v14;
                var v15 = _isFakeRequestIndicator; v15.Clean = value; _isFakeRequestIndicator = v15;
                var v16 = _isLockCancellationIndicator; v16.Clean = value; _isLockCancellationIndicator = v16;
                var v17 = _isLockExtensionIndicator; v17.Clean = value; _isLockExtensionIndicator = v17;
                var v18 = _isReLockIndicator; v18.Clean = value; _isReLockIndicator = v18;
                var v19 = _isSystemSpecificIndicator; v19.Clean = value; _isSystemSpecificIndicator = v19;
                var v20 = _logRecordIndex; v20.Clean = value; _logRecordIndex = v20;
                var v21 = _numDayLocked; v21.Clean = value; _numDayLocked = v21;
                var v22 = _parentLockGuid; v22.Clean = value; _parentLockGuid = v22;
                var v23 = _requestedBy; v23.Clean = value; _requestedBy = v23;
                var v24 = _requestedName; v24.Clean = value; _requestedName = v24;
                var v25 = _requestedStatus; v25.Clean = value; _requestedStatus = v25;
                var v26 = _sellSideDeliveredBy; v26.Clean = value; _sellSideDeliveredBy = v26;
                var v27 = _sellSideDeliveryDate; v27.Clean = value; _sellSideDeliveryDate = v27;
                var v28 = _sellSideExpirationDate; v28.Clean = value; _sellSideExpirationDate = v28;
                var v29 = _sellSideNewLockExtensionDate; v29.Clean = value; _sellSideNewLockExtensionDate = v29;
                var v30 = _sellSideNumDayExtended; v30.Clean = value; _sellSideNumDayExtended = v30;
                var v31 = _snapshotXml; v31.Clean = value; _snapshotXml = v31;
                var v32 = _systemId; v32.Clean = value; _systemId = v32;
                var v33 = _timeRequested; v33.Clean = value; _timeRequested = v33;
                _settingClean = 0;
            }
        }
    }
}