using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LockCancellationLog
    {
        public JsonNullable<bool?> AlertIndicator { get; set; }
        public string AlertsXml { get; set; }
        public string CancelledBy { get; set; }
        public string CancelledById { get; set; }
        public string CommentListXml { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string RequestGuid { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string TimeCancelled { get; set; }
    }
}