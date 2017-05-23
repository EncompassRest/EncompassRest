using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class HtmlEmailLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public string Body { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public string Creator { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public string Description { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public JsonNullable<string> SystemId { get; set; }
    }
}