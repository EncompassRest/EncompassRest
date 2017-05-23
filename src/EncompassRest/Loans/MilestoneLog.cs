using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public JsonNullable<int?> Days { get; set; }
        public JsonNullable<bool?> DoneIndicator { get; set; }
        public JsonNullable<int?> Duration { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public JsonNullable<LoanAssociate> LoanAssociate { get; set; }
        public int? LogRecordIndex { get; set; }
        public string MilestoneIdString { get; set; }
        public JsonNullable<bool?> ReviewedIndicator { get; set; }
        public string RoleRequired { get; set; }
        public string Stage { get; set; }
        public JsonNullable<string> SystemId { get; set; }
    }
}