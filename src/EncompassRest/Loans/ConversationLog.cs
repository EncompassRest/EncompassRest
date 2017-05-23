using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ConversationLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public string Company { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public string Email { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> InLogIndicator { get; set; }
        public JsonNullable<bool?> IsEmailIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string UserId { get; set; }
    }
}