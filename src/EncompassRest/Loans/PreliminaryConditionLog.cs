using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PreliminaryConditionLog
    /// </summary>
    public sealed partial class PreliminaryConditionLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// PreliminaryConditionLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// PreliminaryConditionLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// PreliminaryConditionLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }
        private DirtyValue<string> _category;
        /// <summary>
        /// PreliminaryConditionLog Category
        /// </summary>
        public string Category { get => _category; set => SetField(ref _category, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// PreliminaryConditionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// PreliminaryConditionLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// PreliminaryConditionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateAddedUtc;
        /// <summary>
        /// PreliminaryConditionLog DateAddedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }
        private DirtyValue<DateTime?> _dateExpected;
        /// <summary>
        /// PreliminaryConditionLog DateExpected
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }
        private DirtyValue<DateTime?> _dateFulfilled;
        /// <summary>
        /// PreliminaryConditionLog DateFulfilled
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateFulfilled { get => _dateFulfilled; set => SetField(ref _dateFulfilled, value); }
        private DirtyValue<DateTime?> _dateReceived;
        /// <summary>
        /// PreliminaryConditionLog DateReceived
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }
        private DirtyValue<DateTime?> _dateRequestedUtc;
        /// <summary>
        /// PreliminaryConditionLog DateRequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => SetField(ref _dateRequestedUtc, value); }
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        /// <summary>
        /// PreliminaryConditionLog DateRerequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => SetField(ref _dateRerequestedUtc, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// PreliminaryConditionLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// PreliminaryConditionLog Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _details;
        /// <summary>
        /// PreliminaryConditionLog Details
        /// </summary>
        public string Details { get => _details; set => SetField(ref _details, value); }
        private DirtyValue<bool?> _expected;
        /// <summary>
        /// PreliminaryConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => SetField(ref _expected, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// PreliminaryConditionLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<bool?> _fulfilled;
        /// <summary>
        /// PreliminaryConditionLog Fulfilled
        /// </summary>
        public bool? Fulfilled { get => _fulfilled; set => SetField(ref _fulfilled, value); }
        private DirtyValue<string> _fulfilledBy;
        /// <summary>
        /// PreliminaryConditionLog FulfilledBy
        /// </summary>
        public string FulfilledBy { get => _fulfilledBy; set => SetField(ref _fulfilledBy, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// PreliminaryConditionLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// PreliminaryConditionLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isPastDue;
        /// <summary>
        /// PreliminaryConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => SetField(ref _isPastDue, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// PreliminaryConditionLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// PreliminaryConditionLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _pairId;
        /// <summary>
        /// PreliminaryConditionLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => SetField(ref _pairId, value); }
        private DirtyValue<string> _priorTo;
        /// <summary>
        /// PreliminaryConditionLog PriorTo
        /// </summary>
        public string PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }
        private DirtyValue<bool?> _received;
        /// <summary>
        /// PreliminaryConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// PreliminaryConditionLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }
        private DirtyValue<bool?> _requested;
        /// <summary>
        /// PreliminaryConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => SetField(ref _requested, value); }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// PreliminaryConditionLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }
        private DirtyValue<bool?> _rerequested;
        /// <summary>
        /// PreliminaryConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => SetField(ref _rerequested, value); }
        private DirtyValue<string> _rerequestedBy;
        /// <summary>
        /// PreliminaryConditionLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }
        private DirtyValue<string> _source;
        /// <summary>
        /// PreliminaryConditionLog Source
        /// </summary>
        public string Source { get => _source; set => SetField(ref _source, value); }
        private DirtyValue<string> _status;
        /// <summary>
        /// PreliminaryConditionLog Status
        /// </summary>
        public string Status { get => _status; set => SetField(ref _status, value); }
        private DirtyValue<string> _statusDescription;
        /// <summary>
        /// PreliminaryConditionLog StatusDescription
        /// </summary>
        public string StatusDescription { get => _statusDescription; set => SetField(ref _statusDescription, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// PreliminaryConditionLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _title;
        /// <summary>
        /// PreliminaryConditionLog Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<bool?> _underwriterAccessIndicator;
        /// <summary>
        /// PreliminaryConditionLog UnderwriterAccessIndicator
        /// </summary>
        public bool? UnderwriterAccessIndicator { get => _underwriterAccessIndicator; set => SetField(ref _underwriterAccessIndicator, value); }
    }
}