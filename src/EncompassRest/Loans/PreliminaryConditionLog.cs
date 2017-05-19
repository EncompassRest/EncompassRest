using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PreliminaryConditionLog
    {
        public string Id { get; set; }
        public string AddedBy { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public string Category { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public DateTime? DateAddedUtc { get; set; }
        public DateTime? DateFulfilled { get; set; }
        public DateTime? DateUtc { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string FulfilledBy { get; set; }
        public string Guid { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string PairId { get; set; }
        public string PriorTo { get; set; }
        public string Source { get; set; }
        public string SystemId { get; set; }
        public string Title { get; set; }
        public bool? UnderwriterAccessIndicator { get; set; }
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
        public string ReceivedBy { get; set; }
        public bool? Received { get; set; }
        public bool? Requested { get; set; }
        public bool? Rerequested { get; set; }
        public bool? IsPastDue { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
    }
}