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
        private DirtyList<LogAlert> _alerts;
        private DirtyValue<string> _alertsXml;
        private DirtyValue<string> _category;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _commentListXml;
        private DirtyValue<string> _comments;
        private DirtyValue<DateTime?> _dateAddedUtc;
        private DirtyValue<DateTime?> _dateExpected;
        private DirtyValue<DateTime?> _dateFulfilled;
        private DirtyValue<DateTime?> _dateReceived;
        private DirtyValue<DateTime?> _dateRequestedUtc;
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<string> _description;
        private DirtyValue<string> _details;
        private DirtyValue<bool?> _expected;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<bool?> _fulfilled;
        private DirtyValue<string> _fulfilledBy;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isPastDue;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _pairId;
        private DirtyValue<string> _priorTo;
        private DirtyValue<bool?> _received;
        private DirtyValue<string> _receivedBy;
        private DirtyValue<bool?> _requested;
        private DirtyValue<string> _requestedBy;
        private DirtyValue<bool?> _rerequested;
        private DirtyValue<string> _rerequestedBy;
        private DirtyValue<string> _source;
        private DirtyValue<string> _status;
        private DirtyValue<string> _statusDescription;
        private DirtyValue<string> _systemId;
        private DirtyValue<string> _title;
        private DirtyValue<bool?> _underwriterAccessIndicator;

        /// <summary>
        /// PreliminaryConditionLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

        /// <summary>
        /// PreliminaryConditionLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// PreliminaryConditionLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// PreliminaryConditionLog Category
        /// </summary>
        public string Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// PreliminaryConditionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// PreliminaryConditionLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// PreliminaryConditionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// PreliminaryConditionLog DateAddedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }

        /// <summary>
        /// PreliminaryConditionLog DateExpected
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }

        /// <summary>
        /// PreliminaryConditionLog DateFulfilled
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateFulfilled { get => _dateFulfilled; set => SetField(ref _dateFulfilled, value); }

        /// <summary>
        /// PreliminaryConditionLog DateReceived
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        /// <summary>
        /// PreliminaryConditionLog DateRequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => SetField(ref _dateRequestedUtc, value); }

        /// <summary>
        /// PreliminaryConditionLog DateRerequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => SetField(ref _dateRerequestedUtc, value); }

        /// <summary>
        /// PreliminaryConditionLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// PreliminaryConditionLog Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// PreliminaryConditionLog Details
        /// </summary>
        public string Details { get => _details; set => SetField(ref _details, value); }

        /// <summary>
        /// PreliminaryConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => SetField(ref _expected, value); }

        /// <summary>
        /// PreliminaryConditionLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// PreliminaryConditionLog Fulfilled
        /// </summary>
        public bool? Fulfilled { get => _fulfilled; set => SetField(ref _fulfilled, value); }

        /// <summary>
        /// PreliminaryConditionLog FulfilledBy
        /// </summary>
        public string FulfilledBy { get => _fulfilledBy; set => SetField(ref _fulfilledBy, value); }

        /// <summary>
        /// PreliminaryConditionLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// PreliminaryConditionLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PreliminaryConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => SetField(ref _isPastDue, value); }

        /// <summary>
        /// PreliminaryConditionLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// PreliminaryConditionLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// PreliminaryConditionLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => SetField(ref _pairId, value); }

        /// <summary>
        /// PreliminaryConditionLog PriorTo
        /// </summary>
        public string PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        /// <summary>
        /// PreliminaryConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }

        /// <summary>
        /// PreliminaryConditionLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// PreliminaryConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => SetField(ref _requested, value); }

        /// <summary>
        /// PreliminaryConditionLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// PreliminaryConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => SetField(ref _rerequested, value); }

        /// <summary>
        /// PreliminaryConditionLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        /// <summary>
        /// PreliminaryConditionLog Source
        /// </summary>
        public string Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// PreliminaryConditionLog Status
        /// </summary>
        public string Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// PreliminaryConditionLog StatusDescription
        /// </summary>
        public string StatusDescription { get => _statusDescription; set => SetField(ref _statusDescription, value); }

        /// <summary>
        /// PreliminaryConditionLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// PreliminaryConditionLog Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// PreliminaryConditionLog UnderwriterAccessIndicator
        /// </summary>
        public bool? UnderwriterAccessIndicator { get => _underwriterAccessIndicator; set => SetField(ref _underwriterAccessIndicator, value); }
    }
}