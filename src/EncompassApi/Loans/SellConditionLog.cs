using System;

namespace EncompassApi.Loans
{
    /// <summary>
    /// SellConditionLog
    /// </summary>
    public sealed partial class SellConditionLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _addedBy;
        private DirtyValue<bool?>? _allowToClearIndicator;
        private DirtyValue<string?>? _category;
        private DirtyValue<string?>? _clearedBy;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _conditionCode;
        private DirtyValue<DateTime?>? _dateAddedUtc;
        private DirtyValue<DateTime?>? _dateClearedUtc;
        private DirtyValue<DateTime?>? _dateExpected;
        private DirtyValue<DateTime?>? _dateFulfilledUtc;
        private DirtyValue<DateTime?>? _dateReceived;
        private DirtyValue<DateTime?>? _dateRejectedUtc;
        private DirtyValue<DateTime?>? _dateRequestedUtc;
        private DirtyValue<DateTime?>? _dateRerequestedUtc;
        private DirtyValue<DateTime?>? _dateReviewedUtc;
        private DirtyValue<DateTime?>? _dateWaivedUtc;
        private DirtyValue<int?>? _daysTillDue;
        private DirtyValue<string?>? _description;
        private DirtyValue<string?>? _details;
        private DirtyValue<bool?>? _expected;
        private DirtyValue<int?>? _forRoleId;
        private DirtyValue<string?>? _fulfilledBy;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isExternalIndicator;
        private DirtyValue<bool?>? _isInternalIndicator;
        private DirtyValue<bool?>? _isPastDue;
        private DirtyValue<string?>? _pairId;
        private DirtyValue<string?>? _priorTo;
        private DirtyValue<string?>? _providerURN;
        private DirtyValue<bool?>? _received;
        private DirtyValue<string?>? _receivedBy;
        private DirtyValue<string?>? _rejectedBy;
        private DirtyValue<bool?>? _requested;
        private DirtyValue<string?>? _requestedBy;
        private DirtyValue<string?>? _requestedFrom;
        private DirtyValue<bool?>? _rerequested;
        private DirtyValue<string?>? _rerequestedBy;
        private DirtyValue<string?>? _reviewedBy;
        private DirtyValue<string?>? _source;
        private DirtyValue<string?>? _status;
        private DirtyValue<string?>? _title;
        private DirtyValue<string?>? _waivedBy;

        /// <summary>
        /// SellConditionLog AddedBy
        /// </summary>
        public string? AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

        /// <summary>
        /// SellConditionLog AllowToClearIndicator
        /// </summary>
        public bool? AllowToClearIndicator { get => _allowToClearIndicator; set => SetField(ref _allowToClearIndicator, value); }

        /// <summary>
        /// SellConditionLog Category
        /// </summary>
        public string? Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// SellConditionLog ClearedBy
        /// </summary>
        public string? ClearedBy { get => _clearedBy; set => SetField(ref _clearedBy, value); }

        /// <summary>
        /// SellConditionLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// SellConditionLog ConditionCode
        /// </summary>
        public string? ConditionCode { get => _conditionCode; set => SetField(ref _conditionCode, value); }

        /// <summary>
        /// SellConditionLog DateAddedUtc
        /// </summary>
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }

        /// <summary>
        /// SellConditionLog DateClearedUtc
        /// </summary>
        public DateTime? DateClearedUtc { get => _dateClearedUtc; set => SetField(ref _dateClearedUtc, value); }

        /// <summary>
        /// SellConditionLog DateExpected
        /// </summary>
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }

        /// <summary>
        /// SellConditionLog DateFulfilledUtc
        /// </summary>
        public DateTime? DateFulfilledUtc { get => _dateFulfilledUtc; set => SetField(ref _dateFulfilledUtc, value); }

        /// <summary>
        /// SellConditionLog DateReceived
        /// </summary>
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        /// <summary>
        /// SellConditionLog DateRejectedUtc
        /// </summary>
        public DateTime? DateRejectedUtc { get => _dateRejectedUtc; set => SetField(ref _dateRejectedUtc, value); }

        /// <summary>
        /// SellConditionLog DateRequestedUtc
        /// </summary>
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => SetField(ref _dateRequestedUtc, value); }

        /// <summary>
        /// SellConditionLog DateRerequestedUtc
        /// </summary>
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => SetField(ref _dateRerequestedUtc, value); }

        /// <summary>
        /// SellConditionLog DateReviewedUtc
        /// </summary>
        public DateTime? DateReviewedUtc { get => _dateReviewedUtc; set => SetField(ref _dateReviewedUtc, value); }

        /// <summary>
        /// SellConditionLog DateWaivedUtc
        /// </summary>
        public DateTime? DateWaivedUtc { get => _dateWaivedUtc; set => SetField(ref _dateWaivedUtc, value); }

        /// <summary>
        /// SellConditionLog DaysTillDue
        /// </summary>
        public int? DaysTillDue { get => _daysTillDue; set => SetField(ref _daysTillDue, value); }

        /// <summary>
        /// SellConditionLog Description
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// SellConditionLog Details
        /// </summary>
        public string? Details { get => _details; set => SetField(ref _details, value); }

        /// <summary>
        /// SellConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => SetField(ref _expected, value); }

        /// <summary>
        /// SellConditionLog ForRoleId
        /// </summary>
        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }

        /// <summary>
        /// SellConditionLog FulfilledBy
        /// </summary>
        public string? FulfilledBy { get => _fulfilledBy; set => SetField(ref _fulfilledBy, value); }

        /// <summary>
        /// SellConditionLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// SellConditionLog IsExternalIndicator
        /// </summary>
        public bool? IsExternalIndicator { get => _isExternalIndicator; set => SetField(ref _isExternalIndicator, value); }

        /// <summary>
        /// SellConditionLog IsInternalIndicator
        /// </summary>
        public bool? IsInternalIndicator { get => _isInternalIndicator; set => SetField(ref _isInternalIndicator, value); }

        /// <summary>
        /// SellConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => SetField(ref _isPastDue, value); }

        /// <summary>
        /// SellConditionLog PairId
        /// </summary>
        public string? PairId { get => _pairId; set => SetField(ref _pairId, value); }

        /// <summary>
        /// SellConditionLog PriorTo
        /// </summary>
        public string? PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        /// <summary>
        /// SellConditionLog ProviderURN
        /// </summary>
        public string? ProviderURN { get => _providerURN; set => SetField(ref _providerURN, value); }

        /// <summary>
        /// SellConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }

        /// <summary>
        /// SellConditionLog ReceivedBy
        /// </summary>
        public string? ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// SellConditionLog RejectedBy
        /// </summary>
        public string? RejectedBy { get => _rejectedBy; set => SetField(ref _rejectedBy, value); }

        /// <summary>
        /// SellConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => SetField(ref _requested, value); }

        /// <summary>
        /// SellConditionLog RequestedBy
        /// </summary>
        public string? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// SellConditionLog RequestedFrom
        /// </summary>
        public string? RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

        /// <summary>
        /// SellConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => SetField(ref _rerequested, value); }

        /// <summary>
        /// SellConditionLog RerequestedBy
        /// </summary>
        public string? RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        /// <summary>
        /// SellConditionLog ReviewedBy
        /// </summary>
        public string? ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        /// <summary>
        /// SellConditionLog Source
        /// </summary>
        public string? Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// SellConditionLog Status
        /// </summary>
        public string? Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// SellConditionLog Title
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// SellConditionLog WaivedBy
        /// </summary>
        public string? WaivedBy { get => _waivedBy; set => SetField(ref _waivedBy, value); }
    }
}