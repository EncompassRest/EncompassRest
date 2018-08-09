using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PostClosingConditionLog
    /// </summary>
    public sealed partial class PostClosingConditionLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// PostClosingConditionLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// PostClosingConditionLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// PostClosingConditionLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<bool?> _cleared;
        /// <summary>
        /// PostClosingConditionLog Cleared
        /// </summary>
        public bool? Cleared { get => _cleared; set => _cleared = value; }
        private DirtyValue<string> _clearedBy;
        /// <summary>
        /// PostClosingConditionLog ClearedBy
        /// </summary>
        public string ClearedBy { get => _clearedBy; set => _clearedBy = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// PostClosingConditionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// PostClosingConditionLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// PostClosingConditionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateAddedUtc;
        /// <summary>
        /// PostClosingConditionLog DateAddedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => _dateAddedUtc = value; }
        private DirtyValue<DateTime?> _dateClearedUtc;
        /// <summary>
        /// PostClosingConditionLog DateClearedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateClearedUtc { get => _dateClearedUtc; set => _dateClearedUtc = value; }
        private DirtyValue<DateTime?> _dateExpected;
        /// <summary>
        /// PostClosingConditionLog DateExpected
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpected { get => _dateExpected; set => _dateExpected = value; }
        private DirtyValue<DateTime?> _dateReceived;
        /// <summary>
        /// PostClosingConditionLog DateReceived
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceived { get => _dateReceived; set => _dateReceived = value; }
        private DirtyValue<DateTime?> _dateRequestedUtc;
        /// <summary>
        /// PostClosingConditionLog DateRequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => _dateRequestedUtc = value; }
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        /// <summary>
        /// PostClosingConditionLog DateRerequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => _dateRerequestedUtc = value; }
        private DirtyValue<DateTime?> _dateSentUtc;
        /// <summary>
        /// PostClosingConditionLog DateSentUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateSentUtc { get => _dateSentUtc; set => _dateSentUtc = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// PostClosingConditionLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<int?> _daysTillDue;
        /// <summary>
        /// PostClosingConditionLog DaysTillDue
        /// </summary>
        public int? DaysTillDue { get => _daysTillDue; set => _daysTillDue = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// PostClosingConditionLog Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _details;
        /// <summary>
        /// PostClosingConditionLog Details
        /// </summary>
        public string Details { get => _details; set => _details = value; }
        private DirtyValue<bool?> _expected;
        /// <summary>
        /// PostClosingConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => _expected = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// PostClosingConditionLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// PostClosingConditionLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PostClosingConditionLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isPastDue;
        /// <summary>
        /// PostClosingConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => _isPastDue = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// PostClosingConditionLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// PostClosingConditionLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _pairId;
        /// <summary>
        /// PostClosingConditionLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => _pairId = value; }
        private DirtyValue<bool?> _received;
        /// <summary>
        /// PostClosingConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => _received = value; }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// PostClosingConditionLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<string> _recipient;
        /// <summary>
        /// PostClosingConditionLog Recipient
        /// </summary>
        public string Recipient { get => _recipient; set => _recipient = value; }
        private DirtyValue<bool?> _requested;
        /// <summary>
        /// PostClosingConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => _requested = value; }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// PostClosingConditionLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<string> _requestedFrom;
        /// <summary>
        /// PostClosingConditionLog RequestedFrom
        /// </summary>
        public string RequestedFrom { get => _requestedFrom; set => _requestedFrom = value; }
        private DirtyValue<bool?> _rerequested;
        /// <summary>
        /// PostClosingConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => _rerequested = value; }
        private DirtyValue<string> _rerequestedBy;
        /// <summary>
        /// PostClosingConditionLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => _rerequestedBy = value; }
        private DirtyValue<bool?> _sent;
        /// <summary>
        /// PostClosingConditionLog Sent
        /// </summary>
        public bool? Sent { get => _sent; set => _sent = value; }
        private DirtyValue<string> _sentBy;
        /// <summary>
        /// PostClosingConditionLog SentBy
        /// </summary>
        public string SentBy { get => _sentBy; set => _sentBy = value; }
        private DirtyValue<string> _source;
        /// <summary>
        /// PostClosingConditionLog Source
        /// </summary>
        public string Source { get => _source; set => _source = value; }
        private DirtyValue<string> _status;
        /// <summary>
        /// PostClosingConditionLog Status
        /// </summary>
        public string Status { get => _status; set => _status = value; }
        private DirtyValue<string> _statusDescription;
        /// <summary>
        /// PostClosingConditionLog StatusDescription
        /// </summary>
        public string StatusDescription { get => _statusDescription; set => _statusDescription = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// PostClosingConditionLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// PostClosingConditionLog Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
    }
}