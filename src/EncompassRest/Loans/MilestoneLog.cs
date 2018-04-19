using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilestoneLog
    /// </summary>
    public sealed partial class MilestoneLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// MilestoneLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// MilestoneLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// MilestoneLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// MilestoneLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<int?> _days;
        /// <summary>
        /// MilestoneLog Days
        /// </summary>
        public int? Days { get => _days; set => _days = value; }
        private DirtyValue<bool?> _doneIndicator;
        /// <summary>
        /// MilestoneLog DoneIndicator
        /// </summary>
        public bool? DoneIndicator { get => _doneIndicator; set => _doneIndicator = value; }
        private DirtyValue<int?> _duration;
        /// <summary>
        /// MilestoneLog Duration
        /// </summary>
        public int? Duration { get => _duration; set => _duration = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// MilestoneLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// MilestoneLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilestoneLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// MilestoneLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private LoanAssociate _loanAssociate;
        /// <summary>
        /// MilestoneLog LoanAssociate
        /// </summary>
        public LoanAssociate LoanAssociate { get => _loanAssociate ?? (_loanAssociate = new LoanAssociate()); set => _loanAssociate = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// MilestoneLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _milestoneIdString;
        /// <summary>
        /// MilestoneLog MilestoneIdString
        /// </summary>
        public string MilestoneIdString { get => _milestoneIdString; set => _milestoneIdString = value; }
        private DirtyValue<bool?> _reviewedIndicator;
        /// <summary>
        /// MilestoneLog ReviewedIndicator
        /// </summary>
        public bool? ReviewedIndicator { get => _reviewedIndicator; set => _reviewedIndicator = value; }
        private DirtyValue<string> _roleRequired;
        /// <summary>
        /// MilestoneLog RoleRequired
        /// </summary>
        public string RoleRequired { get => _roleRequired; set => _roleRequired = value; }
        private DirtyValue<string> _stage;
        /// <summary>
        /// MilestoneLog Stage
        /// </summary>
        public string Stage { get => _stage; set => _stage = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// MilestoneLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _tPOConnectStatus;
        /// <summary>
        /// MilestoneLog TPOConnectStatus
        /// </summary>
        public string TPOConnectStatus { get => _tPOConnectStatus; set => _tPOConnectStatus = value; }
        internal override bool DirtyInternal
        {
            get => _comments.Dirty
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
                || _tPOConnectStatus.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true
                || _loanAssociate?.Dirty == true;
            set
            {
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
                _tPOConnectStatus.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_loanAssociate != null) _loanAssociate.Dirty = value;
            }
        }
    }
}