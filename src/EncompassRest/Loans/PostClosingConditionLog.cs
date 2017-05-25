using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PostClosingConditionLog : IClean
    {
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<bool?> _cleared;
        public bool? Cleared { get { return _cleared; } set { _cleared = value; } }
        private Value<string> _clearedBy;
        public string ClearedBy { get { return _clearedBy; } set { _clearedBy = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        private Value<DateTime?> _dateClearedUtc;
        public DateTime? DateClearedUtc { get { return _dateClearedUtc; } set { _dateClearedUtc = value; } }
        private Value<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        private Value<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private Value<DateTime?> _dateRequestedUtc;
        public DateTime? DateRequestedUtc { get { return _dateRequestedUtc; } set { _dateRequestedUtc = value; } }
        private Value<DateTime?> _dateRerequestedUtc;
        public DateTime? DateRerequestedUtc { get { return _dateRerequestedUtc; } set { _dateRerequestedUtc = value; } }
        private Value<DateTime?> _dateSentUtc;
        public DateTime? DateSentUtc { get { return _dateSentUtc; } set { _dateSentUtc = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<int?> _daysTillDue;
        public int? DaysTillDue { get { return _daysTillDue; } set { _daysTillDue = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private Value<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
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
        private Value<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private Value<string> _recipient;
        public string Recipient { get { return _recipient; } set { _recipient = value; } }
        private Value<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private Value<string> _requestedFrom;
        public string RequestedFrom { get { return _requestedFrom; } set { _requestedFrom = value; } }
        private Value<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        private Value<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private Value<bool?> _sent;
        public bool? Sent { get { return _sent; } set { _sent = value; } }
        private Value<string> _sentBy;
        public string SentBy { get { return _sentBy; } set { _sentBy = value; } }
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
                    && _cleared.Clean
                    && _clearedBy.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _dateAddedUtc.Clean
                    && _dateClearedUtc.Clean
                    && _dateExpected.Clean
                    && _dateReceived.Clean
                    && _dateRequestedUtc.Clean
                    && _dateRerequestedUtc.Clean
                    && _dateSentUtc.Clean
                    && _dateUtc.Clean
                    && _daysTillDue.Clean
                    && _description.Clean
                    && _details.Clean
                    && _expected.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isPastDue.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _pairId.Clean
                    && _received.Clean
                    && _receivedBy.Clean
                    && _recipient.Clean
                    && _requested.Clean
                    && _requestedBy.Clean
                    && _requestedFrom.Clean
                    && _rerequested.Clean
                    && _rerequestedBy.Clean
                    && _sent.Clean
                    && _sentBy.Clean
                    && _source.Clean
                    && _status.Clean
                    && _statusDescription.Clean
                    && _systemId.Clean
                    && _title.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _addedBy; v0.Clean = value; _addedBy = v0;
                var v1 = _alerts; v1.Clean = value; _alerts = v1;
                var v2 = _alertsXml; v2.Clean = value; _alertsXml = v2;
                var v3 = _cleared; v3.Clean = value; _cleared = v3;
                var v4 = _clearedBy; v4.Clean = value; _clearedBy = v4;
                var v5 = _commentList; v5.Clean = value; _commentList = v5;
                var v6 = _commentListXml; v6.Clean = value; _commentListXml = v6;
                var v7 = _comments; v7.Clean = value; _comments = v7;
                var v8 = _dateAddedUtc; v8.Clean = value; _dateAddedUtc = v8;
                var v9 = _dateClearedUtc; v9.Clean = value; _dateClearedUtc = v9;
                var v10 = _dateExpected; v10.Clean = value; _dateExpected = v10;
                var v11 = _dateReceived; v11.Clean = value; _dateReceived = v11;
                var v12 = _dateRequestedUtc; v12.Clean = value; _dateRequestedUtc = v12;
                var v13 = _dateRerequestedUtc; v13.Clean = value; _dateRerequestedUtc = v13;
                var v14 = _dateSentUtc; v14.Clean = value; _dateSentUtc = v14;
                var v15 = _dateUtc; v15.Clean = value; _dateUtc = v15;
                var v16 = _daysTillDue; v16.Clean = value; _daysTillDue = v16;
                var v17 = _description; v17.Clean = value; _description = v17;
                var v18 = _details; v18.Clean = value; _details = v18;
                var v19 = _expected; v19.Clean = value; _expected = v19;
                var v20 = _fileAttachmentsMigrated; v20.Clean = value; _fileAttachmentsMigrated = v20;
                var v21 = _guid; v21.Clean = value; _guid = v21;
                var v22 = _id; v22.Clean = value; _id = v22;
                var v23 = _isPastDue; v23.Clean = value; _isPastDue = v23;
                var v24 = _isSystemSpecificIndicator; v24.Clean = value; _isSystemSpecificIndicator = v24;
                var v25 = _logRecordIndex; v25.Clean = value; _logRecordIndex = v25;
                var v26 = _pairId; v26.Clean = value; _pairId = v26;
                var v27 = _received; v27.Clean = value; _received = v27;
                var v28 = _receivedBy; v28.Clean = value; _receivedBy = v28;
                var v29 = _recipient; v29.Clean = value; _recipient = v29;
                var v30 = _requested; v30.Clean = value; _requested = v30;
                var v31 = _requestedBy; v31.Clean = value; _requestedBy = v31;
                var v32 = _requestedFrom; v32.Clean = value; _requestedFrom = v32;
                var v33 = _rerequested; v33.Clean = value; _rerequested = v33;
                var v34 = _rerequestedBy; v34.Clean = value; _rerequestedBy = v34;
                var v35 = _sent; v35.Clean = value; _sent = v35;
                var v36 = _sentBy; v36.Clean = value; _sentBy = v36;
                var v37 = _source; v37.Clean = value; _source = v37;
                var v38 = _status; v38.Clean = value; _status = v38;
                var v39 = _statusDescription; v39.Clean = value; _statusDescription = v39;
                var v40 = _systemId; v40.Clean = value; _systemId = v40;
                var v41 = _title; v41.Clean = value; _title = v41;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}