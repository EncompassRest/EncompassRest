using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PrintLog
    {
        public string Action { get; set; }
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string PrintedBy { get; set; }
        public string PrintedByFullName { get; set; }
        public JsonNullable<List<PrintForm>> PrintForms { get; set; }
        public JsonNullable<string> SystemId { get; set; }
    }
}