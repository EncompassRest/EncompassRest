using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class MilestoneLog : IDirty
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<int?> _days;
        public int? Days { get => _days; set => _days = value; }
        private DirtyValue<bool?> _doneIndicator;
        public bool? DoneIndicator { get => _doneIndicator; set => _doneIndicator = value; }
        private DirtyValue<int?> _duration;
        public int? Duration { get => _duration; set => _duration = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private LoanAssociate _loanAssociate;
        public LoanAssociate LoanAssociate { get => _loanAssociate ?? (_loanAssociate = new LoanAssociate()); set => _loanAssociate = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _milestoneIdString;
        public string MilestoneIdString { get => _milestoneIdString; set => _milestoneIdString = value; }
        private DirtyValue<bool?> _reviewedIndicator;
        public bool? ReviewedIndicator { get => _reviewedIndicator; set => _reviewedIndicator = value; }
        private DirtyValue<string> _roleRequired;
        public string RoleRequired { get => _roleRequired; set => _roleRequired = value; }
        private DirtyValue<string> _stage;
        public string Stage { get => _stage; set => _stage = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
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
                var dirty = _comments.Dirty
                    || _dateUtc.Dirty
                    || _days.Dirty
                    || _doneIndicator.Dirty
                    || _duration.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _milestoneIdString.Dirty
                    || _reviewedIndicator.Dirty
                    || _roleRequired.Dirty
                    || _stage.Dirty
                    || _systemId.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true
                    || _loanAssociate?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _days.Dirty = value;
                _doneIndicator.Dirty = value;
                _duration.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _milestoneIdString.Dirty = value;
                _reviewedIndicator.Dirty = value;
                _roleRequired.Dirty = value;
                _stage.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_loanAssociate != null) _loanAssociate.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}