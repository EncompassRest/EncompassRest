using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwritingConditionLog : IClean
    {
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<bool?> _allowToClearIndicator;
        public bool? AllowToClearIndicator { get { return _allowToClearIndicator; } set { _allowToClearIndicator = value; } }
        private Value<string> _category;
        public string Category { get { return _category; } set { _category = value; } }
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
        private Value<DateTime?> _dateExpiredUtc;
        public DateTime? DateExpiredUtc { get { return _dateExpiredUtc; } set { _dateExpiredUtc = value; } }
        private Value<DateTime?> _dateFulfilledUtc;
        public DateTime? DateFulfilledUtc { get { return _dateFulfilledUtc; } set { _dateFulfilledUtc = value; } }
        private Value<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private Value<DateTime?> _dateReceivedUtc;
        public DateTime? DateReceivedUtc { get { return _dateReceivedUtc; } set { _dateReceivedUtc = value; } }
        private Value<DateTime?> _dateRejectedUtc;
        public DateTime? DateRejectedUtc { get { return _dateRejectedUtc; } set { _dateRejectedUtc = value; } }
        private Value<DateTime?> _dateRequestedUtc;
        public DateTime? DateRequestedUtc { get { return _dateRequestedUtc; } set { _dateRequestedUtc = value; } }
        private Value<DateTime?> _dateRerequestedUtc;
        public DateTime? DateRerequestedUtc { get { return _dateRerequestedUtc; } set { _dateRerequestedUtc = value; } }
        private Value<DateTime?> _dateReviewedUtc;
        public DateTime? DateReviewedUtc { get { return _dateReviewedUtc; } set { _dateReviewedUtc = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<DateTime?> _dateWaivedUtc;
        public DateTime? DateWaivedUtc { get { return _dateWaivedUtc; } set { _dateWaivedUtc = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private Value<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<int?> _forRoleId;
        public int? ForRoleId { get { return _forRoleId; } set { _forRoleId = value; } }
        private Value<bool?> _fulfilled;
        public bool? Fulfilled { get { return _fulfilled; } set { _fulfilled = value; } }
        private Value<string> _fulfilledBy;
        public string FulfilledBy { get { return _fulfilledBy; } set { _fulfilledBy = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isExternalIndicator;
        public bool? IsExternalIndicator { get { return _isExternalIndicator; } set { _isExternalIndicator = value; } }
        private Value<bool?> _isInternalIndicator;
        public bool? IsInternalIndicator { get { return _isInternalIndicator; } set { _isInternalIndicator = value; } }
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
        private Value<bool?> _rejected;
        public bool? Rejected { get { return _rejected; } set { _rejected = value; } }
        private Value<string> _rejectedBy;
        public string RejectedBy { get { return _rejectedBy; } set { _rejectedBy = value; } }
        private Value<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private Value<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        private Value<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private Value<bool?> _reviewed;
        public bool? Reviewed { get { return _reviewed; } set { _reviewed = value; } }
        private Value<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
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
        private Value<bool?> _waived;
        public bool? Waived { get { return _waived; } set { _waived = value; } }
        private Value<string> _waivedBy;
        public string WaivedBy { get { return _waivedBy; } set { _waivedBy = value; } }
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
                    && _allowToClearIndicator.Clean
                    && _category.Clean
                    && _cleared.Clean
                    && _clearedBy.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _dateAddedUtc.Clean
                    && _dateClearedUtc.Clean
                    && _dateExpected.Clean
                    && _dateExpiredUtc.Clean
                    && _dateFulfilledUtc.Clean
                    && _dateReceived.Clean
                    && _dateReceivedUtc.Clean
                    && _dateRejectedUtc.Clean
                    && _dateRequestedUtc.Clean
                    && _dateRerequestedUtc.Clean
                    && _dateReviewedUtc.Clean
                    && _dateUtc.Clean
                    && _dateWaivedUtc.Clean
                    && _description.Clean
                    && _details.Clean
                    && _expected.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _forRoleId.Clean
                    && _fulfilled.Clean
                    && _fulfilledBy.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isExternalIndicator.Clean
                    && _isInternalIndicator.Clean
                    && _isPastDue.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _pairId.Clean
                    && _priorTo.Clean
                    && _received.Clean
                    && _receivedBy.Clean
                    && _rejected.Clean
                    && _rejectedBy.Clean
                    && _requested.Clean
                    && _requestedBy.Clean
                    && _rerequested.Clean
                    && _rerequestedBy.Clean
                    && _reviewed.Clean
                    && _reviewedBy.Clean
                    && _source.Clean
                    && _status.Clean
                    && _statusDescription.Clean
                    && _systemId.Clean
                    && _title.Clean
                    && _waived.Clean
                    && _waivedBy.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _addedBy; v0.Clean = value; _addedBy = v0;
                var v1 = _alerts; v1.Clean = value; _alerts = v1;
                var v2 = _alertsXml; v2.Clean = value; _alertsXml = v2;
                var v3 = _allowToClearIndicator; v3.Clean = value; _allowToClearIndicator = v3;
                var v4 = _category; v4.Clean = value; _category = v4;
                var v5 = _cleared; v5.Clean = value; _cleared = v5;
                var v6 = _clearedBy; v6.Clean = value; _clearedBy = v6;
                var v7 = _commentList; v7.Clean = value; _commentList = v7;
                var v8 = _commentListXml; v8.Clean = value; _commentListXml = v8;
                var v9 = _comments; v9.Clean = value; _comments = v9;
                var v10 = _dateAddedUtc; v10.Clean = value; _dateAddedUtc = v10;
                var v11 = _dateClearedUtc; v11.Clean = value; _dateClearedUtc = v11;
                var v12 = _dateExpected; v12.Clean = value; _dateExpected = v12;
                var v13 = _dateExpiredUtc; v13.Clean = value; _dateExpiredUtc = v13;
                var v14 = _dateFulfilledUtc; v14.Clean = value; _dateFulfilledUtc = v14;
                var v15 = _dateReceived; v15.Clean = value; _dateReceived = v15;
                var v16 = _dateReceivedUtc; v16.Clean = value; _dateReceivedUtc = v16;
                var v17 = _dateRejectedUtc; v17.Clean = value; _dateRejectedUtc = v17;
                var v18 = _dateRequestedUtc; v18.Clean = value; _dateRequestedUtc = v18;
                var v19 = _dateRerequestedUtc; v19.Clean = value; _dateRerequestedUtc = v19;
                var v20 = _dateReviewedUtc; v20.Clean = value; _dateReviewedUtc = v20;
                var v21 = _dateUtc; v21.Clean = value; _dateUtc = v21;
                var v22 = _dateWaivedUtc; v22.Clean = value; _dateWaivedUtc = v22;
                var v23 = _description; v23.Clean = value; _description = v23;
                var v24 = _details; v24.Clean = value; _details = v24;
                var v25 = _expected; v25.Clean = value; _expected = v25;
                var v26 = _fileAttachmentsMigrated; v26.Clean = value; _fileAttachmentsMigrated = v26;
                var v27 = _forRoleId; v27.Clean = value; _forRoleId = v27;
                var v28 = _fulfilled; v28.Clean = value; _fulfilled = v28;
                var v29 = _fulfilledBy; v29.Clean = value; _fulfilledBy = v29;
                var v30 = _guid; v30.Clean = value; _guid = v30;
                var v31 = _id; v31.Clean = value; _id = v31;
                var v32 = _isExternalIndicator; v32.Clean = value; _isExternalIndicator = v32;
                var v33 = _isInternalIndicator; v33.Clean = value; _isInternalIndicator = v33;
                var v34 = _isPastDue; v34.Clean = value; _isPastDue = v34;
                var v35 = _isSystemSpecificIndicator; v35.Clean = value; _isSystemSpecificIndicator = v35;
                var v36 = _logRecordIndex; v36.Clean = value; _logRecordIndex = v36;
                var v37 = _pairId; v37.Clean = value; _pairId = v37;
                var v38 = _priorTo; v38.Clean = value; _priorTo = v38;
                var v39 = _received; v39.Clean = value; _received = v39;
                var v40 = _receivedBy; v40.Clean = value; _receivedBy = v40;
                var v41 = _rejected; v41.Clean = value; _rejected = v41;
                var v42 = _rejectedBy; v42.Clean = value; _rejectedBy = v42;
                var v43 = _requested; v43.Clean = value; _requested = v43;
                var v44 = _requestedBy; v44.Clean = value; _requestedBy = v44;
                var v45 = _rerequested; v45.Clean = value; _rerequested = v45;
                var v46 = _rerequestedBy; v46.Clean = value; _rerequestedBy = v46;
                var v47 = _reviewed; v47.Clean = value; _reviewed = v47;
                var v48 = _reviewedBy; v48.Clean = value; _reviewedBy = v48;
                var v49 = _source; v49.Clean = value; _source = v49;
                var v50 = _status; v50.Clean = value; _status = v50;
                var v51 = _statusDescription; v51.Clean = value; _statusDescription = v51;
                var v52 = _systemId; v52.Clean = value; _systemId = v52;
                var v53 = _title; v53.Clean = value; _title = v53;
                var v54 = _waived; v54.Clean = value; _waived = v54;
                var v55 = _waivedBy; v55.Clean = value; _waivedBy = v55;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public UnderwritingConditionLog()
        {
            Clean = true;
        }
    }
}