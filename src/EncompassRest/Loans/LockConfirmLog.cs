using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LockConfirmLog
    {
        private Value<bool?> _alertIndicator;
        public bool? AlertIndicator { get { return _alertIndicator; } set { _alertIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertIndicator() => !_alertIndicator.Clean;
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get { return _buySideExpirationDate; } set { _buySideExpirationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideExpirationDate() => !_buySideExpirationDate.Clean;
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !_commentList.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<string> _confirmedBy;
        public string ConfirmedBy { get { return _confirmedBy; } set { _confirmedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedBy() => !_confirmedBy.Clean;
        private Value<bool?> _confirmedByIdIndicator;
        public bool? ConfirmedByIdIndicator { get { return _confirmedByIdIndicator; } set { _confirmedByIdIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedByIdIndicator() => !_confirmedByIdIndicator.Clean;
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
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !_isSystemSpecificIndicator.Clean;
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !_logRecordIndex.Clean;
        private Value<string> _requestGuid;
        public string RequestGuid { get { return _requestGuid; } set { _requestGuid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestGuid() => !_requestGuid.Clean;
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
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private Value<string> _timeConfirmed;
        public string TimeConfirmed { get { return _timeConfirmed; } set { _timeConfirmed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeConfirmed() => !_timeConfirmed.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alertIndicator.Clean
                    && _alerts.Clean
                    && _buySideExpirationDate.Clean
                    && _commentList.Clean
                    && _comments.Clean
                    && _confirmedBy.Clean
                    && _confirmedByIdIndicator.Clean
                    && _dateUtc.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _requestGuid.Clean
                    && _sellSideDeliveredBy.Clean
                    && _sellSideDeliveryDate.Clean
                    && _sellSideExpirationDate.Clean
                    && _systemId.Clean
                    && _timeConfirmed.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alertIndicator; v0.Clean = value; _alertIndicator = v0;
                var v1 = _alerts; v1.Clean = value; _alerts = v1;
                var v2 = _buySideExpirationDate; v2.Clean = value; _buySideExpirationDate = v2;
                var v3 = _commentList; v3.Clean = value; _commentList = v3;
                var v4 = _comments; v4.Clean = value; _comments = v4;
                var v5 = _confirmedBy; v5.Clean = value; _confirmedBy = v5;
                var v6 = _confirmedByIdIndicator; v6.Clean = value; _confirmedByIdIndicator = v6;
                var v7 = _dateUtc; v7.Clean = value; _dateUtc = v7;
                var v8 = _fileAttachmentsMigrated; v8.Clean = value; _fileAttachmentsMigrated = v8;
                var v9 = _guid; v9.Clean = value; _guid = v9;
                var v10 = _id; v10.Clean = value; _id = v10;
                var v11 = _isSystemSpecificIndicator; v11.Clean = value; _isSystemSpecificIndicator = v11;
                var v12 = _logRecordIndex; v12.Clean = value; _logRecordIndex = v12;
                var v13 = _requestGuid; v13.Clean = value; _requestGuid = v13;
                var v14 = _sellSideDeliveredBy; v14.Clean = value; _sellSideDeliveredBy = v14;
                var v15 = _sellSideDeliveryDate; v15.Clean = value; _sellSideDeliveryDate = v15;
                var v16 = _sellSideExpirationDate; v16.Clean = value; _sellSideExpirationDate = v16;
                var v17 = _systemId; v17.Clean = value; _systemId = v17;
                var v18 = _timeConfirmed; v18.Clean = value; _timeConfirmed = v18;
                _settingClean = 0;
            }
        }
    }
}