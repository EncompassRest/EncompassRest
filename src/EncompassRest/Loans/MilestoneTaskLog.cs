using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTaskLog
    {
        public DateTime? AddDate { get; set; }
        public string AddedBy { get; set; }
        public string AddedByUserId { get; set; }
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public string AlertsXml { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string CommentListXml { get; set; }
        public string Comments { get; set; }
        public bool? Completed { get; set; }
        public string CompletedBy { get; set; }
        public string CompletedByUserId { get; set; }
        public JsonNullable<DateTime?> CompletedDateUtc { get; set; }
        public int? ContactCount { get; set; }
        public JsonNullable<List<MilestoneTaskContact>> Contacts { get; set; }
        public string ContactsXml { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public int? DaysToComplete { get; set; }
        public int? DaysToCompleteFromSetting { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> IsRequiredIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public DateTime? MilestoneTaskLogDateUtc { get; set; }
        public string Priority { get; set; }
        public string Stage { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string TaskDescription { get; set; }
        public string TaskGuid { get; set; }
        public string TaskName { get; set; }
    }
}