using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LockDenialLog
    {
        public JsonNullable<bool?> AlertIndicator { get; set; }
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public string DeniedBy { get; set; }
        public string DeniedById { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string RequestGuid { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string TimeDenied { get; set; }
    }
}