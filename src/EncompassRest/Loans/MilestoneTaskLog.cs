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
        public DateTime? AddDate { get => _addDate; set => SetField(ref _addDate, value); }
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// MilestoneTaskLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }
        private DirtyValue<string> _addedByUserId;
        /// <summary>
        /// MilestoneTaskLog AddedByUserId
        /// </summary>
        public string AddedByUserId { get => _addedByUserId; set => SetField(ref _addedByUserId, value); }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// MilestoneTaskLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// MilestoneTaskLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// MilestoneTaskLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// MilestoneTaskLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// MilestoneTaskLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<bool?> _completed;
        /// <summary>
        /// MilestoneTaskLog Completed
        /// </summary>
        public bool? Completed { get => _completed; set => SetField(ref _completed, value); }
        private DirtyValue<string> _completedBy;
        /// <summary>
        /// MilestoneTaskLog CompletedBy
        /// </summary>
        public string CompletedBy { get => _completedBy; set => SetField(ref _completedBy, value); }
        private DirtyValue<string> _completedByUserId;
        /// <summary>
        /// MilestoneTaskLog CompletedByUserId
        /// </summary>
        public string CompletedByUserId { get => _completedByUserId; set => SetField(ref _completedByUserId, value); }
        private DirtyValue<DateTime?> _completedDateUtc;
        /// <summary>
        /// MilestoneTaskLog CompletedDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompletedDateUtc { get => _completedDateUtc; set => SetField(ref _completedDateUtc, value); }
        private DirtyValue<int?> _contactCount;
        /// <summary>
        /// MilestoneTaskLog ContactCount
        /// </summary>
        public int? ContactCount { get => _contactCount; set => SetField(ref _contactCount, value); }
        private DirtyList<MilestoneTaskContact> _contacts;
        /// <summary>
        /// MilestoneTaskLog Contacts
        /// </summary>
        public IList<MilestoneTaskContact> Contacts { get => GetField(ref _contacts); set => SetField(ref _contacts, value); }
        private DirtyValue<string> _contactsXml;
        /// <summary>
        /// MilestoneTaskLog ContactsXml
        /// </summary>
        public string ContactsXml { get => _contactsXml; set => SetField(ref _contactsXml, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// MilestoneTaskLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<int?> _daysToComplete;
        /// <summary>
        /// MilestoneTaskLog DaysToComplete
        /// </summary>
        public int? DaysToComplete { get => _daysToComplete; set => SetField(ref _daysToComplete, value); }
        private DirtyValue<int?> _daysToCompleteFromSetting;
        /// <summary>
        /// MilestoneTaskLog DaysToCompleteFromSetting
        /// </summary>
        public int? DaysToCompleteFromSetting { get => _daysToCompleteFromSetting; set => SetField(ref _daysToCompleteFromSetting, value); }
        private DirtyValue<DateTime?> _expectedDate;
        /// <summary>
        /// MilestoneTaskLog ExpectedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// MilestoneTaskLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// MilestoneTaskLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilestoneTaskLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isRequiredIndicator;
        /// <summary>
        /// MilestoneTaskLog IsRequiredIndicator
        /// </summary>
        public bool? IsRequiredIndicator { get => _isRequiredIndicator; set => SetField(ref _isRequiredIndicator, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// MilestoneTaskLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// MilestoneTaskLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<DateTime?> _milestoneTaskLogDateUtc;
        /// <summary>
        /// MilestoneTaskLog MilestoneTaskLogDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? MilestoneTaskLogDateUtc { get => _milestoneTaskLogDateUtc; set => SetField(ref _milestoneTaskLogDateUtc, value); }
        private DirtyValue<string> _priority;
        /// <summary>
        /// MilestoneTaskLog Priority
        /// </summary>
        public string Priority { get => _priority; set => SetField(ref _priority, value); }
        private DirtyValue<string> _stage;
        /// <summary>
        /// MilestoneTaskLog Stage
        /// </summary>
        public string Stage { get => _stage; set => SetField(ref _stage, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// MilestoneTaskLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _taskDescription;
        /// <summary>
        /// MilestoneTaskLog TaskDescription
        /// </summary>
        public string TaskDescription { get => _taskDescription; set => SetField(ref _taskDescription, value); }
        private DirtyValue<string> _taskGuid;
        /// <summary>
        /// MilestoneTaskLog TaskGuid
        /// </summary>
        public string TaskGuid { get => _taskGuid; set => SetField(ref _taskGuid, value); }
        private DirtyValue<string> _taskName;
        /// <summary>
        /// MilestoneTaskLog TaskName
        /// </summary>
        public string TaskName { get => _taskName; set => SetField(ref _taskName, value); }
    }
}