using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockDenialLog
    /// </summary>
    public sealed partial class LockDenialLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _alertIndicator;
        /// <summary>
        /// LockDenialLog AlertIndicator
        /// </summary>
        public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// LockDenialLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// LockDenialLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LockDenialLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LockDenialLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _deniedBy;
        /// <summary>
        /// LockDenialLog DeniedBy
        /// </summary>
        public string DeniedBy { get => _deniedBy; set => SetField(ref _deniedBy, value); }
        private DirtyValue<string> _deniedById;
        /// <summary>
        /// LockDenialLog DeniedById
        /// </summary>
        public string DeniedById { get => _deniedById; set => SetField(ref _deniedById, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// LockDenialLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LockDenialLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LockDenialLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// LockDenialLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// LockDenialLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _requestGuid;
        /// <summary>
        /// LockDenialLog RequestGuid
        /// </summary>
        public string RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LockDenialLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _timeDenied;
        /// <summary>
        /// LockDenialLog TimeDenied
        /// </summary>
        public string TimeDenied { get => _timeDenied; set => SetField(ref _timeDenied, value); }
    }
}