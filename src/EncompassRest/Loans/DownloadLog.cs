using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class DownloadLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public string BarcodePage { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public string DateReceived { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public string DocumentId { get; set; }
        public string DownloadId { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string FileSource { get; set; }
        public string FileType { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string ReceivedBy { get; set; }
        public string Sender { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string Title { get; set; }
    }
}