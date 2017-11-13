using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class MilestoneTaskLog : IDirty
    {
        private DirtyValue<DateTime?> _addDate;
        public DateTime? AddDate { get => _addDate; set => _addDate = value; }
        private DirtyValue<string> _addedBy;
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyValue<string> _addedByUserId;
        public string AddedByUserId { get => _addedByUserId; set => _addedByUserId = value; }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<bool?> _completed;
        public bool? Completed { get => _completed; set => _completed = value; }
        private DirtyValue<string> _completedBy;
        public string CompletedBy { get => _completedBy; set => _completedBy = value; }
        private DirtyValue<string> _completedByUserId;
        public string CompletedByUserId { get => _completedByUserId; set => _completedByUserId = value; }
        private DirtyValue<DateTime?> _completedDateUtc;
        public DateTime? CompletedDateUtc { get => _completedDateUtc; set => _completedDateUtc = value; }
        private DirtyValue<int?> _contactCount;
        public int? ContactCount { get => _contactCount; set => _contactCount = value; }
        private DirtyList<MilestoneTaskContact> _contacts;
        public IList<MilestoneTaskContact> Contacts { get => _contacts ?? (_contacts = new DirtyList<MilestoneTaskContact>()); set => _contacts = new DirtyList<MilestoneTaskContact>(value); }
        private DirtyValue<string> _contactsXml;
        public string ContactsXml { get => _contactsXml; set => _contactsXml = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<int?> _daysToComplete;
        public int? DaysToComplete { get => _daysToComplete; set => _daysToComplete = value; }
        private DirtyValue<int?> _daysToCompleteFromSetting;
        public int? DaysToCompleteFromSetting { get => _daysToCompleteFromSetting; set => _daysToCompleteFromSetting = value; }
        private DirtyValue<DateTime?> _expectedDate;
        public DateTime? ExpectedDate { get => _expectedDate; set => _expectedDate = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isRequiredIndicator;
        public bool? IsRequiredIndicator { get => _isRequiredIndicator; set => _isRequiredIndicator = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<DateTime?> _milestoneTaskLogDateUtc;
        public DateTime? MilestoneTaskLogDateUtc { get => _milestoneTaskLogDateUtc; set => _milestoneTaskLogDateUtc = value; }
        private DirtyValue<string> _priority;
        public string Priority { get => _priority; set => _priority = value; }
        private DirtyValue<string> _stage;
        public string Stage { get => _stage; set => _stage = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _taskDescription;
        public string TaskDescription { get => _taskDescription; set => _taskDescription = value; }
        private DirtyValue<string> _taskGuid;
        public string TaskGuid { get => _taskGuid; set => _taskGuid = value; }
        private DirtyValue<string> _taskName;
        public string TaskName { get => _taskName; set => _taskName = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _addDate.Dirty
                    || _addedBy.Dirty
                    || _addedByUserId.Dirty
                    || _alertsXml.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _completed.Dirty
                    || _completedBy.Dirty
                    || _completedByUserId.Dirty
                    || _completedDateUtc.Dirty
                    || _contactCount.Dirty
                    || _contactsXml.Dirty
                    || _dateUtc.Dirty
                    || _daysToComplete.Dirty
                    || _daysToCompleteFromSetting.Dirty
                    || _expectedDate.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isRequiredIndicator.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _milestoneTaskLogDateUtc.Dirty
                    || _priority.Dirty
                    || _stage.Dirty
                    || _systemId.Dirty
                    || _taskDescription.Dirty
                    || _taskGuid.Dirty
                    || _taskName.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true
                    || _contacts?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _addDate.Dirty = value;
                _addedBy.Dirty = value;
                _addedByUserId.Dirty = value;
                _alertsXml.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _completed.Dirty = value;
                _completedBy.Dirty = value;
                _completedByUserId.Dirty = value;
                _completedDateUtc.Dirty = value;
                _contactCount.Dirty = value;
                _contactsXml.Dirty = value;
                _dateUtc.Dirty = value;
                _daysToComplete.Dirty = value;
                _daysToCompleteFromSetting.Dirty = value;
                _expectedDate.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isRequiredIndicator.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _milestoneTaskLogDateUtc.Dirty = value;
                _priority.Dirty = value;
                _stage.Dirty = value;
                _systemId.Dirty = value;
                _taskDescription.Dirty = value;
                _taskGuid.Dirty = value;
                _taskName.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_contacts != null) _contacts.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}