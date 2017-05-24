using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PreliminaryConditionLog
    {
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedBy() => !_addedBy.Clean;
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !_alertsXml.Clean;
        private Value<string> _category;
        public string Category { get { return _category; } set { _category = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCategory() => !_category.Clean;
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
        private Value<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAddedUtc() => !_dateAddedUtc.Clean;
        private Value<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpected() => !_dateExpected.Clean;
        private Value<DateTime?> _dateFulfilled;
        public DateTime? DateFulfilled { get { return _dateFulfilled; } set { _dateFulfilled = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateFulfilled() => !_dateFulfilled.Clean;
        private Value<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !_dateReceived.Clean;
        private Value<DateTime?> _dateRequestedUtc;
        public DateTime? DateRequestedUtc { get { return _dateRequestedUtc; } set { _dateRequestedUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRequestedUtc() => !_dateRequestedUtc.Clean;
        private Value<DateTime?> _dateRerequestedUtc;
        public DateTime? DateRerequestedUtc { get { return _dateRerequestedUtc; } set { _dateRerequestedUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRerequestedUtc() => !_dateRerequestedUtc.Clean;
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !_dateUtc.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDetails() => !_details.Clean;
        private Value<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpected() => !_expected.Clean;
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !_fileAttachmentsMigrated.Clean;
        private Value<bool?> _fulfilled;
        public bool? Fulfilled { get { return _fulfilled; } set { _fulfilled = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFulfilled() => !_fulfilled.Clean;
        private Value<string> _fulfilledBy;
        public string FulfilledBy { get { return _fulfilledBy; } set { _fulfilledBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFulfilledBy() => !_fulfilledBy.Clean;
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !_guid.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isPastDue;
        public bool? IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsPastDue() => !_isPastDue.Clean;
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !_isSystemSpecificIndicator.Clean;
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !_logRecordIndex.Clean;
        private Value<string> _pairId;
        public string PairId { get { return _pairId; } set { _pairId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePairId() => !_pairId.Clean;
        private Value<string> _priorTo;
        public string PriorTo { get { return _priorTo; } set { _priorTo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorTo() => !_priorTo.Clean;
        private Value<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceived() => !_received.Clean;
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !_receivedBy.Clean;
        private Value<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequested() => !_requested.Clean;
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedBy() => !_requestedBy.Clean;
        private Value<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRerequested() => !_rerequested.Clean;
        private Value<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRerequestedBy() => !_rerequestedBy.Clean;
        private Value<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSource() => !_source.Clean;
        private Value<string> _status;
        public string Status { get { return _status; } set { _status = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatus() => !_status.Clean;
        private Value<string> _statusDescription;
        public string StatusDescription { get { return _statusDescription; } set { _statusDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatusDescription() => !_statusDescription.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private Value<bool?> _underwriterAccessIndicator;
        public bool? UnderwriterAccessIndicator { get { return _underwriterAccessIndicator; } set { _underwriterAccessIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwriterAccessIndicator() => !_underwriterAccessIndicator.Clean;
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
                var v0 = _addedBy; v0.Clean = value; _addedBy = v0;
                var v1 = _alerts; v1.Clean = value; _alerts = v1;
                var v2 = _alertsXml; v2.Clean = value; _alertsXml = v2;
                var v3 = _category; v3.Clean = value; _category = v3;
                var v4 = _commentList; v4.Clean = value; _commentList = v4;
                var v5 = _commentListXml; v5.Clean = value; _commentListXml = v5;
                var v6 = _comments; v6.Clean = value; _comments = v6;
                var v7 = _dateAddedUtc; v7.Clean = value; _dateAddedUtc = v7;
                var v8 = _dateExpected; v8.Clean = value; _dateExpected = v8;
                var v9 = _dateFulfilled; v9.Clean = value; _dateFulfilled = v9;
                var v10 = _dateReceived; v10.Clean = value; _dateReceived = v10;
                var v11 = _dateRequestedUtc; v11.Clean = value; _dateRequestedUtc = v11;
                var v12 = _dateRerequestedUtc; v12.Clean = value; _dateRerequestedUtc = v12;
                var v13 = _dateUtc; v13.Clean = value; _dateUtc = v13;
                var v14 = _description; v14.Clean = value; _description = v14;
                var v15 = _details; v15.Clean = value; _details = v15;
                var v16 = _expected; v16.Clean = value; _expected = v16;
                var v17 = _fileAttachmentsMigrated; v17.Clean = value; _fileAttachmentsMigrated = v17;
                var v18 = _fulfilled; v18.Clean = value; _fulfilled = v18;
                var v19 = _fulfilledBy; v19.Clean = value; _fulfilledBy = v19;
                var v20 = _guid; v20.Clean = value; _guid = v20;
                var v21 = _id; v21.Clean = value; _id = v21;
                var v22 = _isPastDue; v22.Clean = value; _isPastDue = v22;
                var v23 = _isSystemSpecificIndicator; v23.Clean = value; _isSystemSpecificIndicator = v23;
                var v24 = _logRecordIndex; v24.Clean = value; _logRecordIndex = v24;
                var v25 = _pairId; v25.Clean = value; _pairId = v25;
                var v26 = _priorTo; v26.Clean = value; _priorTo = v26;
                var v27 = _received; v27.Clean = value; _received = v27;
                var v28 = _receivedBy; v28.Clean = value; _receivedBy = v28;
                var v29 = _requested; v29.Clean = value; _requested = v29;
                var v30 = _requestedBy; v30.Clean = value; _requestedBy = v30;
                var v31 = _rerequested; v31.Clean = value; _rerequested = v31;
                var v32 = _rerequestedBy; v32.Clean = value; _rerequestedBy = v32;
                var v33 = _source; v33.Clean = value; _source = v33;
                var v34 = _status; v34.Clean = value; _status = v34;
                var v35 = _statusDescription; v35.Clean = value; _statusDescription = v35;
                var v36 = _systemId; v36.Clean = value; _systemId = v36;
                var v37 = _title; v37.Clean = value; _title = v37;
                var v38 = _underwriterAccessIndicator; v38.Clean = value; _underwriterAccessIndicator = v38;
                _settingClean = 0;
            }
        }
    }
}