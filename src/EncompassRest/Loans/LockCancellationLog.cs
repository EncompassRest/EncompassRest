using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LockCancellationLog : IClean
    {
        private Value<bool?> _alertIndicator;
        public bool? AlertIndicator { get { return _alertIndicator; } set { _alertIndicator = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<string> _cancelledBy;
        public string CancelledBy { get { return _cancelledBy; } set { _cancelledBy = value; } }
        private Value<string> _cancelledById;
        public string CancelledById { get { return _cancelledById; } set { _cancelledById = value; } }
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
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _requestGuid;
        public string RequestGuid { get { return _requestGuid; } set { _requestGuid = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _timeCancelled;
        public string TimeCancelled { get { return _timeCancelled; } set { _timeCancelled = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alertIndicator.Clean
                    && _alertsXml.Clean
                    && _cancelledBy.Clean
                    && _cancelledById.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _dateUtc.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _requestGuid.Clean
                    && _systemId.Clean
                    && _timeCancelled.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var alertIndicator = _alertIndicator; alertIndicator.Clean = value; _alertIndicator = alertIndicator;
                var alertsXml = _alertsXml; alertsXml.Clean = value; _alertsXml = alertsXml;
                var cancelledBy = _cancelledBy; cancelledBy.Clean = value; _cancelledBy = cancelledBy;
                var cancelledById = _cancelledById; cancelledById.Clean = value; _cancelledById = cancelledById;
                var commentListXml = _commentListXml; commentListXml.Clean = value; _commentListXml = commentListXml;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var requestGuid = _requestGuid; requestGuid.Clean = value; _requestGuid = requestGuid;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var timeCancelled = _timeCancelled; timeCancelled.Clean = value; _timeCancelled = timeCancelled;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LockCancellationLog()
        {
            Clean = true;
        }
    }
}