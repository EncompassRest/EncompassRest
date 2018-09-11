using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LogEntryLog
    /// </summary>
    public sealed partial class LogEntryLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// LogEntryLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// LogEntryLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LogEntryLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LogEntryLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// LogEntryLog Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// LogEntryLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LogEntryLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LogEntryLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// LogEntryLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// LogEntryLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LogEntryLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _userId;
        /// <summary>
        /// LogEntryLog UserId
        /// </summary>
        public string UserId { get => _userId; set => SetField(ref _userId, value); }
    }
}