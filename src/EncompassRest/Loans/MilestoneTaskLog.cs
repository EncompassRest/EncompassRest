using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilestoneTaskLog
    /// </summary>
    public sealed partial class MilestoneTaskLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _addDate;
        private DirtyValue<string> _addedBy;
        private DirtyValue<string> _addedByUserId;
        private DirtyList<LogAlert> _alerts;
        private DirtyValue<string> _alertsXml;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _commentListXml;
        private DirtyValue<string> _comments;
        private DirtyValue<bool?> _completed;
        private DirtyValue<string> _completedBy;
        private DirtyValue<string> _completedByUserId;
        private DirtyValue<DateTime?> _completedDateUtc;
        private DirtyValue<int?> _contactCount;
        private DirtyList<MilestoneTaskContact> _contacts;
        private DirtyValue<string> _contactsXml;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<int?> _daysToComplete;
        private DirtyValue<int?> _daysToCompleteFromSetting;
        private DirtyValue<DateTime?> _expectedDate;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isRequiredIndicator;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<DateTime?> _milestoneTaskLogDateUtc;
        private DirtyValue<string> _priority;
        private DirtyValue<string> _stage;
        private DirtyValue<string> _systemId;
        private DirtyValue<string> _taskDescription;
        private DirtyValue<string> _taskGuid;
        private DirtyValue<string> _taskName;

        /// <summary>
        /// MilestoneTaskLog AddDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? AddDate { get => _addDate; set => SetField(ref _addDate, value); }

        /// <summary>
        /// MilestoneTaskLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

        /// <summary>
        /// MilestoneTaskLog AddedByUserId
        /// </summary>
        public string AddedByUserId { get => _addedByUserId; set => SetField(ref _addedByUserId, value); }

        /// <summary>
        /// MilestoneTaskLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// MilestoneTaskLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// MilestoneTaskLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// MilestoneTaskLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// MilestoneTaskLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// MilestoneTaskLog Completed
        /// </summary>
        public bool? Completed { get => _completed; set => SetField(ref _completed, value); }

        /// <summary>
        /// MilestoneTaskLog CompletedBy
        /// </summary>
        public string CompletedBy { get => _completedBy; set => SetField(ref _completedBy, value); }

        /// <summary>
        /// MilestoneTaskLog CompletedByUserId
        /// </summary>
        public string CompletedByUserId { get => _completedByUserId; set => SetField(ref _completedByUserId, value); }

        /// <summary>
        /// MilestoneTaskLog CompletedDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompletedDateUtc { get => _completedDateUtc; set => SetField(ref _completedDateUtc, value); }

        /// <summary>
        /// MilestoneTaskLog ContactCount
        /// </summary>
        public int? ContactCount { get => _contactCount; set => SetField(ref _contactCount, value); }

        /// <summary>
        /// MilestoneTaskLog Contacts
        /// </summary>
        public IList<MilestoneTaskContact> Contacts { get => GetField(ref _contacts); set => SetField(ref _contacts, value); }

        /// <summary>
        /// MilestoneTaskLog ContactsXml
        /// </summary>
        public string ContactsXml { get => _contactsXml; set => SetField(ref _contactsXml, value); }

        /// <summary>
        /// MilestoneTaskLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// MilestoneTaskLog DaysToComplete
        /// </summary>
        public int? DaysToComplete { get => _daysToComplete; set => SetField(ref _daysToComplete, value); }

        /// <summary>
        /// MilestoneTaskLog DaysToCompleteFromSetting
        /// </summary>
        public int? DaysToCompleteFromSetting { get => _daysToCompleteFromSetting; set => SetField(ref _daysToCompleteFromSetting, value); }

        /// <summary>
        /// MilestoneTaskLog ExpectedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

        /// <summary>
        /// MilestoneTaskLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// MilestoneTaskLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// MilestoneTaskLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// MilestoneTaskLog IsRequiredIndicator
        /// </summary>
        public bool? IsRequiredIndicator { get => _isRequiredIndicator; set => SetField(ref _isRequiredIndicator, value); }

        /// <summary>
        /// MilestoneTaskLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// MilestoneTaskLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// MilestoneTaskLog MilestoneTaskLogDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? MilestoneTaskLogDateUtc { get => _milestoneTaskLogDateUtc; set => SetField(ref _milestoneTaskLogDateUtc, value); }

        /// <summary>
        /// MilestoneTaskLog Priority
        /// </summary>
        public string Priority { get => _priority; set => SetField(ref _priority, value); }

        /// <summary>
        /// MilestoneTaskLog Stage
        /// </summary>
        public string Stage { get => _stage; set => SetField(ref _stage, value); }

        /// <summary>
        /// MilestoneTaskLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// MilestoneTaskLog TaskDescription
        /// </summary>
        public string TaskDescription { get => _taskDescription; set => SetField(ref _taskDescription, value); }

        /// <summary>
        /// MilestoneTaskLog TaskGuid
        /// </summary>
        public string TaskGuid { get => _taskGuid; set => SetField(ref _taskGuid, value); }

        /// <summary>
        /// MilestoneTaskLog TaskName
        /// </summary>
        public string TaskName { get => _taskName; set => SetField(ref _taskName, value); }
    }
}