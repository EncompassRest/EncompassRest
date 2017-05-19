using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LockDenialLog
    {
        public string Id { get; set; }
        public bool? AlertIndicator { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public DateTime? DateUtc { get; set; }
        public string DeniedBy { get; set; }
        public string DeniedById { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string RequestGuid { get; set; }
        public string SystemId { get; set; }
        public string TimeDenied { get; set; }
    }
}