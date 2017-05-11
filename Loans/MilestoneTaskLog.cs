using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class MilestoneTaskLog
    {
        public string Id { get; set; }
        public string AddedBy { get; set; }
        public string AddedByUserId { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public string CompletedBy { get; set; }
        public string CompletedByUserId { get; set; }
        public DateTime? CompletedDateUtc { get; set; }
        public List<MilestoneTaskContact> Contacts { get; set; }
        public DateTime? DateUtc { get; set; }
        public int? DaysToComplete { get; set; }
        public int? DaysToCompleteFromSetting { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? IsRequiredIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string Priority { get; set; }
        public string Stage { get; set; }
        public string SystemId { get; set; }
        public string TaskDescription { get; set; }
        public string TaskGuid { get; set; }
        public string TaskName { get; set; }
        public bool? Completed { get; set; }
        public int? ContactCount { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? MilestoneTaskLogDateUtc { get; set; }
        public string ContactsXml { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
    }
}