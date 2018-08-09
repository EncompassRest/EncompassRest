using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilestoneTaskLog
    /// </summary>
    public sealed partial class MilestoneTaskLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _addDate;
        /// <summary>
        /// MilestoneTaskLog AddDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? AddDate { get => _addDate; set => _addDate = value; }
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// MilestoneTaskLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyValue<string> _addedByUserId;
        /// <summary>
        /// MilestoneTaskLog AddedByUserId
        /// </summary>
        public string AddedByUserId { get => _addedByUserId; set => _addedByUserId = value; }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// MilestoneTaskLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// MilestoneTaskLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// MilestoneTaskLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// MilestoneTaskLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// MilestoneTaskLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<bool?> _completed;
        /// <summary>
        /// MilestoneTaskLog Completed
        /// </summary>
        public bool? Completed { get => _completed; set => _completed = value; }
        private DirtyValue<string> _completedBy;
        /// <summary>
        /// MilestoneTaskLog CompletedBy
        /// </summary>
        public string CompletedBy { get => _completedBy; set => _completedBy = value; }
        private DirtyValue<string> _completedByUserId;
        /// <summary>
        /// MilestoneTaskLog CompletedByUserId
        /// </summary>
        public string CompletedByUserId { get => _completedByUserId; set => _completedByUserId = value; }
        private DirtyValue<DateTime?> _completedDateUtc;
        /// <summary>
        /// MilestoneTaskLog CompletedDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompletedDateUtc { get => _completedDateUtc; set => _completedDateUtc = value; }
        private DirtyValue<int?> _contactCount;
        /// <summary>
        /// MilestoneTaskLog ContactCount
        /// </summary>
        public int? ContactCount { get => _contactCount; set => _contactCount = value; }
        private DirtyList<MilestoneTaskContact> _contacts;
        /// <summary>
        /// MilestoneTaskLog Contacts
        /// </summary>
        public IList<MilestoneTaskContact> Contacts { get => _contacts ?? (_contacts = new DirtyList<MilestoneTaskContact>()); set => _contacts = new DirtyList<MilestoneTaskContact>(value); }
        private DirtyValue<string> _contactsXml;
        /// <summary>
        /// MilestoneTaskLog ContactsXml
        /// </summary>
        public string ContactsXml { get => _contactsXml; set => _contactsXml = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// MilestoneTaskLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<int?> _daysToComplete;
        /// <summary>
        /// MilestoneTaskLog DaysToComplete
        /// </summary>
        public int? DaysToComplete { get => _daysToComplete; set => _daysToComplete = value; }
        private DirtyValue<int?> _daysToCompleteFromSetting;
        /// <summary>
        /// MilestoneTaskLog DaysToCompleteFromSetting
        /// </summary>
        public int? DaysToCompleteFromSetting { get => _daysToCompleteFromSetting; set => _daysToCompleteFromSetting = value; }
        private DirtyValue<DateTime?> _expectedDate;
        /// <summary>
        /// MilestoneTaskLog ExpectedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ExpectedDate { get => _expectedDate; set => _expectedDate = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// MilestoneTaskLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// MilestoneTaskLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilestoneTaskLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isRequiredIndicator;
        /// <summary>
        /// MilestoneTaskLog IsRequiredIndicator
        /// </summary>
        public bool? IsRequiredIndicator { get => _isRequiredIndicator; set => _isRequiredIndicator = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// MilestoneTaskLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// MilestoneTaskLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<DateTime?> _milestoneTaskLogDateUtc;
        /// <summary>
        /// MilestoneTaskLog MilestoneTaskLogDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? MilestoneTaskLogDateUtc { get => _milestoneTaskLogDateUtc; set => _milestoneTaskLogDateUtc = value; }
        private DirtyValue<string> _priority;
        /// <summary>
        /// MilestoneTaskLog Priority
        /// </summary>
        public string Priority { get => _priority; set => _priority = value; }
        private DirtyValue<string> _stage;
        /// <summary>
        /// MilestoneTaskLog Stage
        /// </summary>
        public string Stage { get => _stage; set => _stage = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// MilestoneTaskLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _taskDescription;
        /// <summary>
        /// MilestoneTaskLog TaskDescription
        /// </summary>
        public string TaskDescription { get => _taskDescription; set => _taskDescription = value; }
        private DirtyValue<string> _taskGuid;
        /// <summary>
        /// MilestoneTaskLog TaskGuid
        /// </summary>
        public string TaskGuid { get => _taskGuid; set => _taskGuid = value; }
        private DirtyValue<string> _taskName;
        /// <summary>
        /// MilestoneTaskLog TaskName
        /// </summary>
        public string TaskName { get => _taskName; set => _taskName = value; }
    }
}