using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneLog : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _commentList.Clean
                    && _comments.Clean
                    && _dateUtc.Clean
                    && _days.Clean
                    && _doneIndicator.Clean
                    && _duration.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _milestoneIdString.Clean
                    && _reviewedIndicator.Clean
                    && _roleRequired.Clean
                    && _stage.Clean
                    && _systemId.Clean
                    && LoanAssociate?.Clean != false;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var days = _days; days.Clean = value; _days = days;
                var doneIndicator = _doneIndicator; doneIndicator.Clean = value; _doneIndicator = doneIndicator;
                var duration = _duration; duration.Clean = value; _duration = duration;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var milestoneIdString = _milestoneIdString; milestoneIdString.Clean = value; _milestoneIdString = milestoneIdString;
                var reviewedIndicator = _reviewedIndicator; reviewedIndicator.Clean = value; _reviewedIndicator = reviewedIndicator;
                var roleRequired = _roleRequired; roleRequired.Clean = value; _roleRequired = roleRequired;
                var stage = _stage; stage.Clean = value; _stage = stage;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                if (LoanAssociate != null) LoanAssociate.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public MilestoneLog()
        {
            Clean = true;
        }
    }
}