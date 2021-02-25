using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// MilestoneLog
    /// </summary>
    public sealed partial class MilestoneLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert>? _alerts;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<int?>? _days;
        private DirtyValue<bool?>? _doneIndicator;
        private DirtyValue<int?>? _duration;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<LoanAssociate?>? _loanAssociate;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<string?>? _milestoneIdString;
        private DirtyValue<bool?>? _reviewedIndicator;
        private DirtyValue<string?>? _roleRequired;
        private DirtyValue<string?>? _stage;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<string?>? _tPOConnectStatus;
        private DirtyValue<DateTime?>? _updatedDateUtc;

        /// <summary>
        /// MilestoneLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// MilestoneLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// MilestoneLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// MilestoneLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// MilestoneLog Days
        /// </summary>
        public int? Days { get => _days; set => SetField(ref _days, value); }

        /// <summary>
        /// MilestoneLog DoneIndicator
        /// </summary>
        public bool? DoneIndicator { get => _doneIndicator; set => SetField(ref _doneIndicator, value); }

        /// <summary>
        /// MilestoneLog Duration
        /// </summary>
        public int? Duration { get => _duration; set => SetField(ref _duration, value); }

        /// <summary>
        /// MilestoneLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// MilestoneLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// MilestoneLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// MilestoneLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// MilestoneLog LoanAssociate
        /// </summary>
        public LoanAssociate? LoanAssociate { get => _loanAssociate; set => SetField(ref _loanAssociate, value); }

        /// <summary>
        /// MilestoneLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// MilestoneLog MilestoneIdString
        /// </summary>
        public string? MilestoneIdString { get => _milestoneIdString; set => SetField(ref _milestoneIdString, value); }

        /// <summary>
        /// MilestoneLog ReviewedIndicator
        /// </summary>
        public bool? ReviewedIndicator { get => _reviewedIndicator; set => SetField(ref _reviewedIndicator, value); }

        /// <summary>
        /// MilestoneLog RoleRequired
        /// </summary>
        public string? RoleRequired { get => _roleRequired; set => SetField(ref _roleRequired, value); }

        /// <summary>
        /// MilestoneLog Stage
        /// </summary>
        public string? Stage { get => _stage; set => SetField(ref _stage, value); }

        /// <summary>
        /// MilestoneLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// MilestoneLog TPOConnectStatus
        /// </summary>
        public string? TPOConnectStatus { get => _tPOConnectStatus; set => SetField(ref _tPOConnectStatus, value); }

        /// <summary>
        /// MilestoneLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}