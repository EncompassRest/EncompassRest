using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PostClosingConditionLog
    {
        public string Id { get; set; }
        public string AddedBy { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public string ClearedBy { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public DateTime? DateAddedUtc { get; set; }
        public DateTime? DateClearedUtc { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateRequestedUtc { get; set; }
        public DateTime? DateRerequestedUtc { get; set; }
        public DateTime? DateSentUtc { get; set; }
        public DateTime? DateUtc { get; set; }
        public int? DaysTillDue { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string PairId { get; set; }
        public string ReceivedBy { get; set; }
        public string Recipient { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedFrom { get; set; }
        public string RerequestedBy { get; set; }
        public string SentBy { get; set; }
        public string Source { get; set; }
        public string SystemId { get; set; }
        public string Title { get; set; }
        public bool? Cleared { get; set; }
        public bool? Sent { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public bool? Expected { get; set; }
        public DateTime? DateExpected { get; set; }
        public bool? Received { get; set; }
        public bool? Requested { get; set; }
        public bool? Rerequested { get; set; }
        public bool? IsPastDue { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
    }
}