using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PreliminaryConditionLog : IDirty
    {
        private DirtyValue<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { return _alerts ?? (_alerts = new DirtyList<LogAlert>()); } set { _alerts = new DirtyList<LogAlert>(value); } }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private DirtyValue<string> _category;
        public string Category { get { return _category; } set { _category = value; } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { return _commentList ?? (_commentList = new DirtyList<LogComment>()); } set { _commentList = new DirtyList<LogComment>(value); } }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        private DirtyValue<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        private DirtyValue<DateTime?> _dateFulfilled;
        public DateTime? DateFulfilled { get { return _dateFulfilled; } set { _dateFulfilled = value; } }
        private DirtyValue<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private DirtyValue<DateTime?> _dateRequestedUtc;
        public DateTime? DateRequestedUtc { get { return _dateRequestedUtc; } set { _dateRequestedUtc = value; } }
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        public DateTime? DateRerequestedUtc { get { return _dateRerequestedUtc; } set { _dateRerequestedUtc = value; } }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private DirtyValue<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private DirtyValue<bool?> _fulfilled;
        public bool? Fulfilled { get { return _fulfilled; } set { _fulfilled = value; } }
        private DirtyValue<string> _fulfilledBy;
        public string FulfilledBy { get { return _fulfilledBy; } set { _fulfilledBy = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isPastDue;
        public bool? IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private DirtyValue<string> _pairId;
        public string PairId { get { return _pairId; } set { _pairId = value; } }
        private DirtyValue<string> _priorTo;
        public string PriorTo { get { return _priorTo; } set { _priorTo = value; } }
        private DirtyValue<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private DirtyValue<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private DirtyValue<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        private DirtyValue<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private DirtyValue<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        private DirtyValue<string> _status;
        public string Status { get { return _status; } set { _status = value; } }
        private DirtyValue<string> _statusDescription;
        public string StatusDescription { get { return _statusDescription; } set { _statusDescription = value; } }
        private DirtyValue<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private DirtyValue<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private DirtyValue<bool?> _underwriterAccessIndicator;
        public bool? UnderwriterAccessIndicator { get { return _underwriterAccessIndicator; } set { _underwriterAccessIndicator = value; } }
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
                var dirty = _addedBy.Dirty
                    || _alertsXml.Dirty
                    || _category.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _dateAddedUtc.Dirty
                    || _dateExpected.Dirty
                    || _dateFulfilled.Dirty
                    || _dateReceived.Dirty
                    || _dateRequestedUtc.Dirty
                    || _dateRerequestedUtc.Dirty
                    || _dateUtc.Dirty
                    || _description.Dirty
                    || _details.Dirty
                    || _expected.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _fulfilled.Dirty
                    || _fulfilledBy.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isPastDue.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _pairId.Dirty
                    || _priorTo.Dirty
                    || _received.Dirty
                    || _receivedBy.Dirty
                    || _requested.Dirty
                    || _requestedBy.Dirty
                    || _rerequested.Dirty
                    || _rerequestedBy.Dirty
                    || _source.Dirty
                    || _status.Dirty
                    || _statusDescription.Dirty
                    || _systemId.Dirty
                    || _title.Dirty
                    || _underwriterAccessIndicator.Dirty
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
                _addedBy.Dirty = value;
                _alertsXml.Dirty = value;
                _category.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _dateAddedUtc.Dirty = value;
                _dateExpected.Dirty = value;
                _dateFulfilled.Dirty = value;
                _dateReceived.Dirty = value;
                _dateRequestedUtc.Dirty = value;
                _dateRerequestedUtc.Dirty = value;
                _dateUtc.Dirty = value;
                _description.Dirty = value;
                _details.Dirty = value;
                _expected.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _fulfilled.Dirty = value;
                _fulfilledBy.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isPastDue.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _pairId.Dirty = value;
                _priorTo.Dirty = value;
                _received.Dirty = value;
                _receivedBy.Dirty = value;
                _requested.Dirty = value;
                _requestedBy.Dirty = value;
                _rerequested.Dirty = value;
                _rerequestedBy.Dirty = value;
                _source.Dirty = value;
                _status.Dirty = value;
                _statusDescription.Dirty = value;
                _systemId.Dirty = value;
                _title.Dirty = value;
                _underwriterAccessIndicator.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}