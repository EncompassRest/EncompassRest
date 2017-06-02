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
                    && LoanAssociate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _commentList; v1.Clean = value; _commentList = v1;
                var v2 = _comments; v2.Clean = value; _comments = v2;
                var v3 = _dateUtc; v3.Clean = value; _dateUtc = v3;
                var v4 = _days; v4.Clean = value; _days = v4;
                var v5 = _doneIndicator; v5.Clean = value; _doneIndicator = v5;
                var v6 = _duration; v6.Clean = value; _duration = v6;
                var v7 = _fileAttachmentsMigrated; v7.Clean = value; _fileAttachmentsMigrated = v7;
                var v8 = _guid; v8.Clean = value; _guid = v8;
                var v9 = _id; v9.Clean = value; _id = v9;
                var v10 = _isSystemSpecificIndicator; v10.Clean = value; _isSystemSpecificIndicator = v10;
                var v11 = _logRecordIndex; v11.Clean = value; _logRecordIndex = v11;
                var v12 = _milestoneIdString; v12.Clean = value; _milestoneIdString = v12;
                var v13 = _reviewedIndicator; v13.Clean = value; _reviewedIndicator = v13;
                var v14 = _roleRequired; v14.Clean = value; _roleRequired = v14;
                var v15 = _stage; v15.Clean = value; _stage = v15;
                var v16 = _systemId; v16.Clean = value; _systemId = v16;
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