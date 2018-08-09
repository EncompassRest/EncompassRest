using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// UnderwritingConditionLog
    /// </summary>
    public sealed partial class UnderwritingConditionLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// UnderwritingConditionLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// UnderwritingConditionLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// UnderwritingConditionLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<bool?> _allowToClearIndicator;
        /// <summary>
        /// UnderwritingConditionLog AllowToClearIndicator
        /// </summary>
        public bool? AllowToClearIndicator { get => _allowToClearIndicator; set => _allowToClearIndicator = value; }
        private DirtyValue<string> _category;
        /// <summary>
        /// UnderwritingConditionLog Category
        /// </summary>
        public string Category { get => _category; set => _category = value; }
        private DirtyValue<bool?> _cleared;
        /// <summary>
        /// UnderwritingConditionLog Cleared
        /// </summary>
        public bool? Cleared { get => _cleared; set => _cleared = value; }
        private DirtyValue<string> _clearedBy;
        /// <summary>
        /// UnderwritingConditionLog ClearedBy
        /// </summary>
        public string ClearedBy { get => _clearedBy; set => _clearedBy = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// UnderwritingConditionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// UnderwritingConditionLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// UnderwritingConditionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateAddedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateAddedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => _dateAddedUtc = value; }
        private DirtyValue<DateTime?> _dateClearedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateClearedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateClearedUtc { get => _dateClearedUtc; set => _dateClearedUtc = value; }
        private DirtyValue<DateTime?> _dateExpected;
        /// <summary>
        /// UnderwritingConditionLog DateExpected
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpected { get => _dateExpected; set => _dateExpected = value; }
        private DirtyValue<DateTime?> _dateExpiredUtc;
        /// <summary>
        /// UnderwritingConditionLog DateExpiredUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpiredUtc { get => _dateExpiredUtc; set => _dateExpiredUtc = value; }
        private DirtyValue<DateTime?> _dateFulfilledUtc;
        /// <summary>
        /// UnderwritingConditionLog DateFulfilledUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateFulfilledUtc { get => _dateFulfilledUtc; set => _dateFulfilledUtc = value; }
        private DirtyValue<DateTime?> _dateReceived;
        /// <summary>
        /// UnderwritingConditionLog DateReceived
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceived { get => _dateReceived; set => _dateReceived = value; }
        private DirtyValue<DateTime?> _dateReceivedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateReceivedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceivedUtc { get => _dateReceivedUtc; set => _dateReceivedUtc = value; }
        private DirtyValue<DateTime?> _dateRejectedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateRejectedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRejectedUtc { get => _dateRejectedUtc; set => _dateRejectedUtc = value; }
        private DirtyValue<DateTime?> _dateRequestedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateRequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => _dateRequestedUtc = value; }
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateRerequestedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => _dateRerequestedUtc = value; }
        private DirtyValue<DateTime?> _dateReviewedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateReviewedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReviewedUtc { get => _dateReviewedUtc; set => _dateReviewedUtc = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// UnderwritingConditionLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<DateTime?> _dateWaivedUtc;
        /// <summary>
        /// UnderwritingConditionLog DateWaivedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateWaivedUtc { get => _dateWaivedUtc; set => _dateWaivedUtc = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// UnderwritingConditionLog Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _details;
        /// <summary>
        /// UnderwritingConditionLog Details
        /// </summary>
        public string Details { get => _details; set => _details = value; }
        private DirtyValue<bool?> _expected;
        /// <summary>
        /// UnderwritingConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => _expected = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// UnderwritingConditionLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<int?> _forRoleId;
        /// <summary>
        /// UnderwritingConditionLog ForRoleId
        /// </summary>
        public int? ForRoleId { get => _forRoleId; set => _forRoleId = value; }
        private DirtyValue<bool?> _fulfilled;
        /// <summary>
        /// UnderwritingConditionLog Fulfilled
        /// </summary>
        public bool? Fulfilled { get => _fulfilled; set => _fulfilled = value; }
        private DirtyValue<string> _fulfilledBy;
        /// <summary>
        /// UnderwritingConditionLog FulfilledBy
        /// </summary>
        public string FulfilledBy { get => _fulfilledBy; set => _fulfilledBy = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// UnderwritingConditionLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// UnderwritingConditionLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isExternalIndicator;
        /// <summary>
        /// UnderwritingConditionLog IsExternalIndicator
        /// </summary>
        public bool? IsExternalIndicator { get => _isExternalIndicator; set => _isExternalIndicator = value; }
        private DirtyValue<bool?> _isInternalIndicator;
        /// <summary>
        /// UnderwritingConditionLog IsInternalIndicator
        /// </summary>
        public bool? IsInternalIndicator { get => _isInternalIndicator; set => _isInternalIndicator = value; }
        private DirtyValue<bool?> _isPastDue;
        /// <summary>
        /// UnderwritingConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => _isPastDue = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// UnderwritingConditionLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// UnderwritingConditionLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _pairId;
        /// <summary>
        /// UnderwritingConditionLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => _pairId = value; }
        private DirtyValue<string> _priorTo;
        /// <summary>
        /// UnderwritingConditionLog PriorTo
        /// </summary>
        public string PriorTo { get => _priorTo; set => _priorTo = value; }
        private DirtyValue<bool?> _received;
        /// <summary>
        /// UnderwritingConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => _received = value; }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// UnderwritingConditionLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<bool?> _rejected;
        /// <summary>
        /// UnderwritingConditionLog Rejected
        /// </summary>
        public bool? Rejected { get => _rejected; set => _rejected = value; }
        private DirtyValue<string> _rejectedBy;
        /// <summary>
        /// UnderwritingConditionLog RejectedBy
        /// </summary>
        public string RejectedBy { get => _rejectedBy; set => _rejectedBy = value; }
        private DirtyValue<bool?> _requested;
        /// <summary>
        /// UnderwritingConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => _requested = value; }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// UnderwritingConditionLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<bool?> _rerequested;
        /// <summary>
        /// UnderwritingConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => _rerequested = value; }
        private DirtyValue<string> _rerequestedBy;
        /// <summary>
        /// UnderwritingConditionLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => _rerequestedBy = value; }
        private DirtyValue<bool?> _reviewed;
        /// <summary>
        /// UnderwritingConditionLog Reviewed
        /// </summary>
        public bool? Reviewed { get => _reviewed; set => _reviewed = value; }
        private DirtyValue<string> _reviewedBy;
        /// <summary>
        /// UnderwritingConditionLog ReviewedBy
        /// </summary>
        public string ReviewedBy { get => _reviewedBy; set => _reviewedBy = value; }
        private DirtyValue<string> _source;
        /// <summary>
        /// UnderwritingConditionLog Source
        /// </summary>
        public string Source { get => _source; set => _source = value; }
        private DirtyValue<string> _status;
        /// <summary>
        /// UnderwritingConditionLog Status
        /// </summary>
        public string Status { get => _status; set => _status = value; }
        private DirtyValue<string> _statusDescription;
        /// <summary>
        /// UnderwritingConditionLog StatusDescription
        /// </summary>
        public string StatusDescription { get => _statusDescription; set => _statusDescription = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// UnderwritingConditionLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// UnderwritingConditionLog Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<bool?> _waived;
        /// <summary>
        /// UnderwritingConditionLog Waived
        /// </summary>
        public bool? Waived { get => _waived; set => _waived = value; }
        private DirtyValue<string> _waivedBy;
        /// <summary>
        /// UnderwritingConditionLog WaivedBy
        /// </summary>
        public string WaivedBy { get => _waivedBy; set => _waivedBy = value; }
    }
}