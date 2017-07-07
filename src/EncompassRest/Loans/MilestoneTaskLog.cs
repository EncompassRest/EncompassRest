using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTaskLog : IClean
    {
        private Value<DateTime?> _addDate;
        public DateTime? AddDate { get { return _addDate; } set { _addDate = value; } }
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<string> _addedByUserId;
        public string AddedByUserId { get { return _addedByUserId; } set { _addedByUserId = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<bool?> _completed;
        public bool? Completed { get { return _completed; } set { _completed = value; } }
        private Value<string> _completedBy;
        public string CompletedBy { get { return _completedBy; } set { _completedBy = value; } }
        private Value<string> _completedByUserId;
        public string CompletedByUserId { get { return _completedByUserId; } set { _completedByUserId = value; } }
        private Value<DateTime?> _completedDateUtc;
        public DateTime? CompletedDateUtc { get { return _completedDateUtc; } set { _completedDateUtc = value; } }
        private Value<int?> _contactCount;
        public int? ContactCount { get { return _contactCount; } set { _contactCount = value; } }
        private Value<List<MilestoneTaskContact>> _contacts;
        public List<MilestoneTaskContact> Contacts { get { return _contacts; } set { _contacts = value; } }
        private Value<string> _contactsXml;
        public string ContactsXml { get { return _contactsXml; } set { _contactsXml = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<int?> _daysToComplete;
        public int? DaysToComplete { get { return _daysToComplete; } set { _daysToComplete = value; } }
        private Value<int?> _daysToCompleteFromSetting;
        public int? DaysToCompleteFromSetting { get { return _daysToCompleteFromSetting; } set { _daysToCompleteFromSetting = value; } }
        private Value<DateTime?> _expectedDate;
        public DateTime? ExpectedDate { get { return _expectedDate; } set { _expectedDate = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isRequiredIndicator;
        public bool? IsRequiredIndicator { get { return _isRequiredIndicator; } set { _isRequiredIndicator = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<DateTime?> _milestoneTaskLogDateUtc;
        public DateTime? MilestoneTaskLogDateUtc { get { return _milestoneTaskLogDateUtc; } set { _milestoneTaskLogDateUtc = value; } }
        private Value<string> _priority;
        public string Priority { get { return _priority; } set { _priority = value; } }
        private Value<string> _stage;
        public string Stage { get { return _stage; } set { _stage = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _taskDescription;
        public string TaskDescription { get { return _taskDescription; } set { _taskDescription = value; } }
        private Value<string> _taskGuid;
        public string TaskGuid { get { return _taskGuid; } set { _taskGuid = value; } }
        private Value<string> _taskName;
        public string TaskName { get { return _taskName; } set { _taskName = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _addDate.Clean
                    && _addedBy.Clean
                    && _addedByUserId.Clean
                    && _alerts.Clean
                    && _alertsXml.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _completed.Clean
                    && _completedBy.Clean
                    && _completedByUserId.Clean
                    && _completedDateUtc.Clean
                    && _contactCount.Clean
                    && _contacts.Clean
                    && _contactsXml.Clean
                    && _dateUtc.Clean
                    && _daysToComplete.Clean
                    && _daysToCompleteFromSetting.Clean
                    && _expectedDate.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isRequiredIndicator.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _milestoneTaskLogDateUtc.Clean
                    && _priority.Clean
                    && _stage.Clean
                    && _systemId.Clean
                    && _taskDescription.Clean
                    && _taskGuid.Clean
                    && _taskName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var addDate = _addDate; addDate.Clean = value; _addDate = addDate;
                var addedBy = _addedBy; addedBy.Clean = value; _addedBy = addedBy;
                var addedByUserId = _addedByUserId; addedByUserId.Clean = value; _addedByUserId = addedByUserId;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var alertsXml = _alertsXml; alertsXml.Clean = value; _alertsXml = alertsXml;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var commentListXml = _commentListXml; commentListXml.Clean = value; _commentListXml = commentListXml;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var completed = _completed; completed.Clean = value; _completed = completed;
                var completedBy = _completedBy; completedBy.Clean = value; _completedBy = completedBy;
                var completedByUserId = _completedByUserId; completedByUserId.Clean = value; _completedByUserId = completedByUserId;
                var completedDateUtc = _completedDateUtc; completedDateUtc.Clean = value; _completedDateUtc = completedDateUtc;
                var contactCount = _contactCount; contactCount.Clean = value; _contactCount = contactCount;
                var contacts = _contacts; contacts.Clean = value; _contacts = contacts;
                var contactsXml = _contactsXml; contactsXml.Clean = value; _contactsXml = contactsXml;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var daysToComplete = _daysToComplete; daysToComplete.Clean = value; _daysToComplete = daysToComplete;
                var daysToCompleteFromSetting = _daysToCompleteFromSetting; daysToCompleteFromSetting.Clean = value; _daysToCompleteFromSetting = daysToCompleteFromSetting;
                var expectedDate = _expectedDate; expectedDate.Clean = value; _expectedDate = expectedDate;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isRequiredIndicator = _isRequiredIndicator; isRequiredIndicator.Clean = value; _isRequiredIndicator = isRequiredIndicator;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var milestoneTaskLogDateUtc = _milestoneTaskLogDateUtc; milestoneTaskLogDateUtc.Clean = value; _milestoneTaskLogDateUtc = milestoneTaskLogDateUtc;
                var priority = _priority; priority.Clean = value; _priority = priority;
                var stage = _stage; stage.Clean = value; _stage = stage;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var taskDescription = _taskDescription; taskDescription.Clean = value; _taskDescription = taskDescription;
                var taskGuid = _taskGuid; taskGuid.Clean = value; _taskGuid = taskGuid;
                var taskName = _taskName; taskName.Clean = value; _taskName = taskName;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public MilestoneTaskLog()
        {
            Clean = true;
        }
    }
}