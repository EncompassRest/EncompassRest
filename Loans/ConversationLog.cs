using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ConversationLog
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public string Company { get; set; }
        public DateTime? DateUtc { get; set; }
        public string Email { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? InLogIndicator { get; set; }
        public bool? IsEmailIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string SystemId { get; set; }
        public string UserId { get; set; }
    }
}