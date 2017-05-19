using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class MilestoneLog
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public DateTime? DateUtc { get; set; }
        public int? Days { get; set; }
        public bool? DoneIndicator { get; set; }
        public int? Duration { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public LoanAssociate LoanAssociate { get; set; }
        public int? LogRecordIndex { get; set; }
        public string MilestoneIdString { get; set; }
        public bool? ReviewedIndicator { get; set; }
        public string RoleRequired { get; set; }
        public string Stage { get; set; }
        public string SystemId { get; set; }
    }
}