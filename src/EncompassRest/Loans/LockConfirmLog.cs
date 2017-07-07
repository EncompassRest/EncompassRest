using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LockConfirmLog : IClean
    {
        private Value<bool?> _alertIndicator;
        public bool? AlertIndicator { get { return _alertIndicator; } set { _alertIndicator = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get { return _buySideExpirationDate; } set { _buySideExpirationDate = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _confirmedBy;
        public string ConfirmedBy { get { return _confirmedBy; } set { _confirmedBy = value; } }
        private Value<bool?> _confirmedByIdIndicator;
        public bool? ConfirmedByIdIndicator { get { return _confirmedByIdIndicator; } set { _confirmedByIdIndicator = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _requestGuid;
        public string RequestGuid { get { return _requestGuid; } set { _requestGuid = value; } }
        private Value<string> _sellSideDeliveredBy;
        public string SellSideDeliveredBy { get { return _sellSideDeliveredBy; } set { _sellSideDeliveredBy = value; } }
        private Value<DateTime?> _sellSideDeliveryDate;
        public DateTime? SellSideDeliveryDate { get { return _sellSideDeliveryDate; } set { _sellSideDeliveryDate = value; } }
        private Value<DateTime?> _sellSideExpirationDate;
        public DateTime? SellSideExpirationDate { get { return _sellSideExpirationDate; } set { _sellSideExpirationDate = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _timeConfirmed;
        public string TimeConfirmed { get { return _timeConfirmed; } set { _timeConfirmed = value; } }
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
                var alertIndicator = _alertIndicator; alertIndicator.Clean = value; _alertIndicator = alertIndicator;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var buySideExpirationDate = _buySideExpirationDate; buySideExpirationDate.Clean = value; _buySideExpirationDate = buySideExpirationDate;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var confirmedBy = _confirmedBy; confirmedBy.Clean = value; _confirmedBy = confirmedBy;
                var confirmedByIdIndicator = _confirmedByIdIndicator; confirmedByIdIndicator.Clean = value; _confirmedByIdIndicator = confirmedByIdIndicator;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var requestGuid = _requestGuid; requestGuid.Clean = value; _requestGuid = requestGuid;
                var sellSideDeliveredBy = _sellSideDeliveredBy; sellSideDeliveredBy.Clean = value; _sellSideDeliveredBy = sellSideDeliveredBy;
                var sellSideDeliveryDate = _sellSideDeliveryDate; sellSideDeliveryDate.Clean = value; _sellSideDeliveryDate = sellSideDeliveryDate;
                var sellSideExpirationDate = _sellSideExpirationDate; sellSideExpirationDate.Clean = value; _sellSideExpirationDate = sellSideExpirationDate;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var timeConfirmed = _timeConfirmed; timeConfirmed.Clean = value; _timeConfirmed = timeConfirmed;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LockConfirmLog()
        {
            Clean = true;
        }
    }
}