using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans
{
    /// <summary>
    /// UnderwritingConditionLog
    /// </summary>
    public sealed partial class UnderwritingConditionLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _addedBy;
        private DirtyList<LogAlert>? _alerts;
        private DirtyValue<string?>? _alertsXml;
        private DirtyValue<bool?>? _allowToClearIndicator;
        private DirtyValue<string?>? _category;
        private DirtyValue<bool?>? _cleared;
        private DirtyValue<string?>? _clearedBy;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _commentListXml;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _dateAddedUtc;
        private DirtyValue<DateTime?>? _dateClearedUtc;
        private DirtyValue<DateTime?>? _dateExpected;
        private DirtyValue<DateTime?>? _dateExpiredUtc;
        private DirtyValue<DateTime?>? _dateFulfilledUtc;
        private DirtyValue<DateTime?>? _dateReceived;
        private DirtyValue<DateTime?>? _dateReceivedUtc;
        private DirtyValue<DateTime?>? _dateRejectedUtc;
        private DirtyValue<DateTime?>? _dateRequestedUtc;
        private DirtyValue<DateTime?>? _dateRerequestedUtc;
        private DirtyValue<DateTime?>? _dateReviewedUtc;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<DateTime?>? _dateWaivedUtc;
        private DirtyValue<string?>? _description;
        private DirtyValue<string?>? _details;
        private DirtyValue<bool?>? _expected;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<int?>? _forRoleId;
        private DirtyValue<bool?>? _fulfilled;
        private DirtyValue<string?>? _fulfilledBy;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isExternalIndicator;
        private DirtyValue<bool?>? _isInternalIndicator;
        private DirtyValue<bool?>? _isMarkedRemoved;
        private DirtyValue<bool?>? _isPastDue;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<string?>? _pairId;
        private DirtyValue<string?>? _priorTo;
        private DirtyValue<bool?>? _received;
        private DirtyValue<string?>? _receivedBy;
        private DirtyValue<bool?>? _rejected;
        private DirtyValue<string?>? _rejectedBy;
        private DirtyValue<bool?>? _requested;
        private DirtyValue<string?>? _requestedBy;
        private DirtyValue<bool?>? _rerequested;
        private DirtyValue<string?>? _rerequestedBy;
        private DirtyValue<bool?>? _reviewed;
        private DirtyValue<string?>? _reviewedBy;
        private DirtyValue<string?>? _source;
        private DirtyValue<string?>? _status;
        private DirtyValue<string?>? _statusDescription;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<string?>? _title;
        private DirtyValue<DateTime?>? _updatedDateUtc;
        private DirtyValue<bool?>? _waived;
        private DirtyValue<string?>? _waivedBy;

        /// <summary>
        /// UnderwritingConditionLog AddedBy
        /// </summary>
        public string? AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

        /// <summary>
        /// UnderwritingConditionLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// UnderwritingConditionLog AlertsXml
        /// </summary>
        public string? AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// UnderwritingConditionLog AllowToClearIndicator
        /// </summary>
        public bool? AllowToClearIndicator { get => _allowToClearIndicator; set => SetField(ref _allowToClearIndicator, value); }

        /// <summary>
        /// UnderwritingConditionLog Category
        /// </summary>
        public string? Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// UnderwritingConditionLog Cleared
        /// </summary>
        public bool? Cleared { get => _cleared; set => SetField(ref _cleared, value); }

        /// <summary>
        /// UnderwritingConditionLog ClearedBy
        /// </summary>
        public string? ClearedBy { get => _clearedBy; set => SetField(ref _clearedBy, value); }

        /// <summary>
        /// UnderwritingConditionLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// UnderwritingConditionLog CommentListXml
        /// </summary>
        public string? CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// UnderwritingConditionLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// UnderwritingConditionLog DateAddedUtc
        /// </summary>
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateClearedUtc
        /// </summary>
        public DateTime? DateClearedUtc { get => _dateClearedUtc; set => SetField(ref _dateClearedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateExpected
        /// </summary>
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }

        /// <summary>
        /// UnderwritingConditionLog DateExpiredUtc
        /// </summary>
        public DateTime? DateExpiredUtc { get => _dateExpiredUtc; set => SetField(ref _dateExpiredUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateFulfilledUtc
        /// </summary>
        public DateTime? DateFulfilledUtc { get => _dateFulfilledUtc; set => SetField(ref _dateFulfilledUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateReceived
        /// </summary>
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        /// <summary>
        /// UnderwritingConditionLog DateReceivedUtc
        /// </summary>
        public DateTime? DateReceivedUtc { get => _dateReceivedUtc; set => SetField(ref _dateReceivedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateRejectedUtc
        /// </summary>
        public DateTime? DateRejectedUtc { get => _dateRejectedUtc; set => SetField(ref _dateRejectedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateRequestedUtc
        /// </summary>
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => SetField(ref _dateRequestedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateRerequestedUtc
        /// </summary>
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => SetField(ref _dateRerequestedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateReviewedUtc
        /// </summary>
        public DateTime? DateReviewedUtc { get => _dateReviewedUtc; set => SetField(ref _dateReviewedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog DateWaivedUtc
        /// </summary>
        public DateTime? DateWaivedUtc { get => _dateWaivedUtc; set => SetField(ref _dateWaivedUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog Description
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// UnderwritingConditionLog Details
        /// </summary>
        public string? Details { get => _details; set => SetField(ref _details, value); }

        /// <summary>
        /// UnderwritingConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => SetField(ref _expected, value); }

        /// <summary>
        /// UnderwritingConditionLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// UnderwritingConditionLog ForRoleId
        /// </summary>
        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }

        /// <summary>
        /// UnderwritingConditionLog Fulfilled
        /// </summary>
        public bool? Fulfilled { get => _fulfilled; set => SetField(ref _fulfilled, value); }

        /// <summary>
        /// UnderwritingConditionLog FulfilledBy
        /// </summary>
        public string? FulfilledBy { get => _fulfilledBy; set => SetField(ref _fulfilledBy, value); }

        /// <summary>
        /// UnderwritingConditionLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// UnderwritingConditionLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// UnderwritingConditionLog IsExternalIndicator
        /// </summary>
        public bool? IsExternalIndicator { get => _isExternalIndicator; set => SetField(ref _isExternalIndicator, value); }

        /// <summary>
        /// UnderwritingConditionLog IsInternalIndicator
        /// </summary>
        public bool? IsInternalIndicator { get => _isInternalIndicator; set => SetField(ref _isInternalIndicator, value); }

        /// <summary>
        /// UnderwritingConditionLog IsMarkedRemoved
        /// </summary>
        public bool? IsMarkedRemoved { get => _isMarkedRemoved; set => SetField(ref _isMarkedRemoved, value); }

        /// <summary>
        /// UnderwritingConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => SetField(ref _isPastDue, value); }

        /// <summary>
        /// UnderwritingConditionLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// UnderwritingConditionLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// UnderwritingConditionLog PairId
        /// </summary>
        public string? PairId { get => _pairId; set => SetField(ref _pairId, value); }

        /// <summary>
        /// UnderwritingConditionLog PriorTo
        /// </summary>
        public string? PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        /// <summary>
        /// UnderwritingConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }

        /// <summary>
        /// UnderwritingConditionLog ReceivedBy
        /// </summary>
        public string? ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// UnderwritingConditionLog Rejected
        /// </summary>
        public bool? Rejected { get => _rejected; set => SetField(ref _rejected, value); }

        /// <summary>
        /// UnderwritingConditionLog RejectedBy
        /// </summary>
        public string? RejectedBy { get => _rejectedBy; set => SetField(ref _rejectedBy, value); }

        /// <summary>
        /// UnderwritingConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => SetField(ref _requested, value); }

        /// <summary>
        /// UnderwritingConditionLog RequestedBy
        /// </summary>
        public string? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// UnderwritingConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => SetField(ref _rerequested, value); }

        /// <summary>
        /// UnderwritingConditionLog RerequestedBy
        /// </summary>
        public string? RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        /// <summary>
        /// UnderwritingConditionLog Reviewed
        /// </summary>
        public bool? Reviewed { get => _reviewed; set => SetField(ref _reviewed, value); }

        /// <summary>
        /// UnderwritingConditionLog ReviewedBy
        /// </summary>
        public string? ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        /// <summary>
        /// UnderwritingConditionLog Source
        /// </summary>
        public string? Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// UnderwritingConditionLog Status
        /// </summary>
        public string? Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// UnderwritingConditionLog StatusDescription
        /// </summary>
        public string? StatusDescription { get => _statusDescription; set => SetField(ref _statusDescription, value); }

        /// <summary>
        /// UnderwritingConditionLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// UnderwritingConditionLog Title
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// UnderwritingConditionLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }

        /// <summary>
        /// UnderwritingConditionLog Waived
        /// </summary>
        public bool? Waived { get => _waived; set => SetField(ref _waived, value); }

        /// <summary>
        /// UnderwritingConditionLog WaivedBy
        /// </summary>
        public string? WaivedBy { get => _waivedBy; set => SetField(ref _waivedBy, value); }
    }
}