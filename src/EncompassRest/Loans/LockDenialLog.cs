using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockDenialLog
    /// </summary>
    public sealed partial class LockDenialLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _alertIndicator;
        private DirtyList<LogAlert> _alerts;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _comments;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<string> _deniedBy;
        private DirtyValue<string> _deniedById;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _requestGuid;
        private DirtyValue<string> _systemId;
        private DirtyValue<string> _timeDenied;
        private DirtyValue<DateTime?> _updatedDateUtc;

        /// <summary>
        /// LockDenialLog AlertIndicator
        /// </summary>
        public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }

        /// <summary>
        /// LockDenialLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// LockDenialLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// LockDenialLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// LockDenialLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// LockDenialLog DeniedBy
        /// </summary>
        public string DeniedBy { get => _deniedBy; set => SetField(ref _deniedBy, value); }

        /// <summary>
        /// LockDenialLog DeniedById
        /// </summary>
        public string DeniedById { get => _deniedById; set => SetField(ref _deniedById, value); }

        /// <summary>
        /// LockDenialLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// LockDenialLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// LockDenialLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LockDenialLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// LockDenialLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// LockDenialLog RequestGuid
        /// </summary>
        public string RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }

        /// <summary>
        /// LockDenialLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// LockDenialLog TimeDenied
        /// </summary>
        public string TimeDenied { get => _timeDenied; set => SetField(ref _timeDenied, value); }

        /// <summary>
        /// LockDenialLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}