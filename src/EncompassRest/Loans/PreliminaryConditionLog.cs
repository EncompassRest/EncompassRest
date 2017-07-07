using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PreliminaryConditionLog : IClean
    {
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<string> _category;
        public string Category { get { return _category; } set { _category = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        private Value<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        private Value<DateTime?> _dateFulfilled;
        public DateTime? DateFulfilled { get { return _dateFulfilled; } set { _dateFulfilled = value; } }
        private Value<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private Value<DateTime?> _dateRequestedUtc;
        public DateTime? DateRequestedUtc { get { return _dateRequestedUtc; } set { _dateRequestedUtc = value; } }
        private Value<DateTime?> _dateRerequestedUtc;
        public DateTime? DateRerequestedUtc { get { return _dateRerequestedUtc; } set { _dateRerequestedUtc = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private Value<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<bool?> _fulfilled;
        public bool? Fulfilled { get { return _fulfilled; } set { _fulfilled = value; } }
        private Value<string> _fulfilledBy;
        public string FulfilledBy { get { return _fulfilledBy; } set { _fulfilledBy = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isPastDue;
        public bool? IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _pairId;
        public string PairId { get { return _pairId; } set { _pairId = value; } }
        private Value<string> _priorTo;
        public string PriorTo { get { return _priorTo; } set { _priorTo = value; } }
        private Value<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private Value<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private Value<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        private Value<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private Value<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        private Value<string> _status;
        public string Status { get { return _status; } set { _status = value; } }
        private Value<string> _statusDescription;
        public string StatusDescription { get { return _statusDescription; } set { _statusDescription = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<bool?> _underwriterAccessIndicator;
        public bool? UnderwriterAccessIndicator { get { return _underwriterAccessIndicator; } set { _underwriterAccessIndicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _addedBy.Clean
                    && _alerts.Clean
                    && _alertsXml.Clean
                    && _category.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _dateAddedUtc.Clean
                    && _dateExpected.Clean
                    && _dateFulfilled.Clean
                    && _dateReceived.Clean
                    && _dateRequestedUtc.Clean
                    && _dateRerequestedUtc.Clean
                    && _dateUtc.Clean
                    && _description.Clean
                    && _details.Clean
                    && _expected.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _fulfilled.Clean
                    && _fulfilledBy.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isPastDue.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _pairId.Clean
                    && _priorTo.Clean
                    && _received.Clean
                    && _receivedBy.Clean
                    && _requested.Clean
                    && _requestedBy.Clean
                    && _rerequested.Clean
                    && _rerequestedBy.Clean
                    && _source.Clean
                    && _status.Clean
                    && _statusDescription.Clean
                    && _systemId.Clean
                    && _title.Clean
                    && _underwriterAccessIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var addedBy = _addedBy; addedBy.Clean = value; _addedBy = addedBy;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var alertsXml = _alertsXml; alertsXml.Clean = value; _alertsXml = alertsXml;
                var category = _category; category.Clean = value; _category = category;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var commentListXml = _commentListXml; commentListXml.Clean = value; _commentListXml = commentListXml;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var dateAddedUtc = _dateAddedUtc; dateAddedUtc.Clean = value; _dateAddedUtc = dateAddedUtc;
                var dateExpected = _dateExpected; dateExpected.Clean = value; _dateExpected = dateExpected;
                var dateFulfilled = _dateFulfilled; dateFulfilled.Clean = value; _dateFulfilled = dateFulfilled;
                var dateReceived = _dateReceived; dateReceived.Clean = value; _dateReceived = dateReceived;
                var dateRequestedUtc = _dateRequestedUtc; dateRequestedUtc.Clean = value; _dateRequestedUtc = dateRequestedUtc;
                var dateRerequestedUtc = _dateRerequestedUtc; dateRerequestedUtc.Clean = value; _dateRerequestedUtc = dateRerequestedUtc;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var description = _description; description.Clean = value; _description = description;
                var details = _details; details.Clean = value; _details = details;
                var expected = _expected; expected.Clean = value; _expected = expected;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var fulfilled = _fulfilled; fulfilled.Clean = value; _fulfilled = fulfilled;
                var fulfilledBy = _fulfilledBy; fulfilledBy.Clean = value; _fulfilledBy = fulfilledBy;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isPastDue = _isPastDue; isPastDue.Clean = value; _isPastDue = isPastDue;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var pairId = _pairId; pairId.Clean = value; _pairId = pairId;
                var priorTo = _priorTo; priorTo.Clean = value; _priorTo = priorTo;
                var received = _received; received.Clean = value; _received = received;
                var receivedBy = _receivedBy; receivedBy.Clean = value; _receivedBy = receivedBy;
                var requested = _requested; requested.Clean = value; _requested = requested;
                var requestedBy = _requestedBy; requestedBy.Clean = value; _requestedBy = requestedBy;
                var rerequested = _rerequested; rerequested.Clean = value; _rerequested = rerequested;
                var rerequestedBy = _rerequestedBy; rerequestedBy.Clean = value; _rerequestedBy = rerequestedBy;
                var source = _source; source.Clean = value; _source = source;
                var status = _status; status.Clean = value; _status = status;
                var statusDescription = _statusDescription; statusDescription.Clean = value; _statusDescription = statusDescription;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var title = _title; title.Clean = value; _title = title;
                var underwriterAccessIndicator = _underwriterAccessIndicator; underwriterAccessIndicator.Clean = value; _underwriterAccessIndicator = underwriterAccessIndicator;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PreliminaryConditionLog()
        {
            Clean = true;
        }
    }
}