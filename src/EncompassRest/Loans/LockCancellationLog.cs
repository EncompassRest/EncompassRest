using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockCancellationLog
    /// </summary>
    public sealed partial class LockCancellationLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _alertIndicator;
        /// <summary>
        /// LockCancellationLog AlertIndicator
        /// </summary>
        public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// LockCancellationLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }
        private DirtyValue<string> _cancelledBy;
        /// <summary>
        /// LockCancellationLog CancelledBy
        /// </summary>
        public string CancelledBy { get => _cancelledBy; set => SetField(ref _cancelledBy, value); }
        private DirtyValue<string> _cancelledById;
        /// <summary>
        /// LockCancellationLog CancelledById
        /// </summary>
        public string CancelledById { get => _cancelledById; set => SetField(ref _cancelledById, value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// LockCancellationLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LockCancellationLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LockCancellationLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// LockCancellationLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LockCancellationLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LockCancellationLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// LockCancellationLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// LockCancellationLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _requestGuid;
        /// <summary>
        /// LockCancellationLog RequestGuid
        /// </summary>
        public string RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LockCancellationLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _timeCancelled;
        /// <summary>
        /// LockCancellationLog TimeCancelled
        /// </summary>
        public string TimeCancelled { get => _timeCancelled; set => SetField(ref _timeCancelled, value); }
    }
}