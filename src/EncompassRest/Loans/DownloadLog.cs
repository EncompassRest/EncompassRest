using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class DownloadLog
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public string BarcodePage { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public string DateReceived { get; set; }
        public DateTime? DateUtc { get; set; }
        public string DocumentId { get; set; }
        public string DownloadId { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string FileSource { get; set; }
        public string FileType { get; set; }
        public string Guid { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string ReceivedBy { get; set; }
        public string Sender { get; set; }
        public string SystemId { get; set; }
        public string Title { get; set; }
    }
}