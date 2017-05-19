using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PrintLog
    {
        public string Id { get; set; }
        public string Action { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public DateTime? DateUtc { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string PrintedBy { get; set; }
        public string PrintedByFullName { get; set; }
        public List<PrintForm> PrintForms { get; set; }
        public string SystemId { get; set; }
    }
}