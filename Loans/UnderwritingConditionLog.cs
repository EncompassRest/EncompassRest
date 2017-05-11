using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class UnderwritingConditionLog
    {
        public string Id { get; set; }
        public string AddedBy { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public bool? AllowToClearIndicator { get; set; }
        public string Category { get; set; }
        public string ClearedBy { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public DateTime? DateAddedUtc { get; set; }
        public DateTime? DateClearedUtc { get; set; }
        public DateTime? DateFulfilledUtc { get; set; }
        public DateTime? DateReceivedUtc { get; set; }
        public DateTime? DateRejectedUtc { get; set; }
        public DateTime? DateReviewedUtc { get; set; }
        public DateTime? DateUtc { get; set; }
        public DateTime? DateWaivedUtc { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public int? ForRoleId { get; set; }
        public string FulfilledBy { get; set; }
        public string Guid { get; set; }
        public bool? IsExternalIndicator { get; set; }
        public bool? IsInternalIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string PairId { get; set; }
        public string PriorTo { get; set; }
        public string ReceivedBy { get; set; }
        public string RejectedBy { get; set; }
        public string ReviewedBy { get; set; }
        public string Source { get; set; }
        public string SystemId { get; set; }
        public string Title { get; set; }
        public string WaivedBy { get; set; }
        public DateTime? DateExpiredUtc { get; set; }
        public bool? Cleared { get; set; }
        public bool? Reviewed { get; set; }
        public bool? Waived { get; set; }
        public bool? Rejected { get; set; }
        public bool? Fulfilled { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public bool? Expected { get; set; }
        public DateTime? DateExpected { get; set; }
        public DateTime? DateRequestedUtc { get; set; }
        public string RequestedBy { get; set; }
        public DateTime? DateRerequestedUtc { get; set; }
        public string RerequestedBy { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool? Received { get; set; }
        public bool? Requested { get; set; }
        public bool? Rerequested { get; set; }
        public bool? IsPastDue { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
    }
}