using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilestoneLog
    /// </summary>
    public sealed partial class MilestoneLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// MilestoneLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// MilestoneLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// MilestoneLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// MilestoneLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<int?> _days;
        /// <summary>
        /// MilestoneLog Days
        /// </summary>
        public int? Days { get => _days; set => SetField(ref _days, value); }
        private DirtyValue<bool?> _doneIndicator;
        /// <summary>
        /// MilestoneLog DoneIndicator
        /// </summary>
        public bool? DoneIndicator { get => _doneIndicator; set => SetField(ref _doneIndicator, value); }
        private DirtyValue<int?> _duration;
        /// <summary>
        /// MilestoneLog Duration
        /// </summary>
        public int? Duration { get => _duration; set => SetField(ref _duration, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// MilestoneLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// MilestoneLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// MilestoneLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// MilestoneLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private LoanAssociate _loanAssociate;
        /// <summary>
        /// MilestoneLog LoanAssociate
        /// </summary>
        public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// MilestoneLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _milestoneIdString;
        /// <summary>
        /// MilestoneLog MilestoneIdString
        /// </summary>
        public string MilestoneIdString { get => _milestoneIdString; set => SetField(ref _milestoneIdString, value); }
        private DirtyValue<bool?> _reviewedIndicator;
        /// <summary>
        /// MilestoneLog ReviewedIndicator
        /// </summary>
        public bool? ReviewedIndicator { get => _reviewedIndicator; set => SetField(ref _reviewedIndicator, value); }
        private DirtyValue<string> _roleRequired;
        /// <summary>
        /// MilestoneLog RoleRequired
        /// </summary>
        public string RoleRequired { get => _roleRequired; set => SetField(ref _roleRequired, value); }
        private DirtyValue<string> _stage;
        /// <summary>
        /// MilestoneLog Stage
        /// </summary>
        public string Stage { get => _stage; set => SetField(ref _stage, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// MilestoneLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _tPOConnectStatus;
        /// <summary>
        /// MilestoneLog TPOConnectStatus
        /// </summary>
        public string TPOConnectStatus { get => _tPOConnectStatus; set => SetField(ref _tPOConnectStatus, value); }
    }
}