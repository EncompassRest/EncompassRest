using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneLog : IDirty
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<int?> _days;
        public int? Days { get { return _days; } set { _days = value; } }
        private Value<bool?> _doneIndicator;
        public bool? DoneIndicator { get { return _doneIndicator; } set { _doneIndicator = value; } }
        private Value<int?> _duration;
        public int? Duration { get { return _duration; } set { _duration = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        public LoanAssociate LoanAssociate { get; set; }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _milestoneIdString;
        public string MilestoneIdString { get { return _milestoneIdString; } set { _milestoneIdString = value; } }
        private Value<bool?> _reviewedIndicator;
        public bool? ReviewedIndicator { get { return _reviewedIndicator; } set { _reviewedIndicator = value; } }
        private Value<string> _roleRequired;
        public string RoleRequired { get { return _roleRequired; } set { _roleRequired = value; } }
        private Value<string> _stage;
        public string Stage { get { return _stage; } set { _stage = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _alerts.Dirty
                    || _commentList.Dirty
                    || _comments.Dirty
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
                    || LoanAssociate?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _alerts.Dirty = value;
                _commentList.Dirty = value;
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
                if (LoanAssociate != null) LoanAssociate.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}