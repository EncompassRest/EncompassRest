using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockCancellationLog
    /// </summary>
    public sealed partial class LockCancellationLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?>? _alertIndicator;
        private DirtyValue<string?>? _alertsXml;
        private DirtyValue<string?>? _cancelledBy;
        private DirtyValue<string?>? _cancelledById;
        private DirtyValue<string?>? _commentListXml;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<string?>? _requestGuid;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<string?>? _timeCancelled;
        private DirtyValue<DateTime?>? _updatedDateUtc;

        /// <summary>
        /// LockCancellationLog AlertIndicator
        /// </summary>
        public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }

        /// <summary>
        /// LockCancellationLog AlertsXml
        /// </summary>
        public string? AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// LockCancellationLog CancelledBy
        /// </summary>
        public string? CancelledBy { get => _cancelledBy; set => SetField(ref _cancelledBy, value); }

        /// <summary>
        /// LockCancellationLog CancelledById
        /// </summary>
        public string? CancelledById { get => _cancelledById; set => SetField(ref _cancelledById, value); }

        /// <summary>
        /// LockCancellationLog CommentListXml
        /// </summary>
        public string? CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// LockCancellationLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// LockCancellationLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// LockCancellationLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// LockCancellationLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// LockCancellationLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LockCancellationLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// LockCancellationLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// LockCancellationLog RequestGuid
        /// </summary>
        public string? RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }

        /// <summary>
        /// LockCancellationLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// LockCancellationLog TimeCancelled
        /// </summary>
        public string? TimeCancelled { get => _timeCancelled; set => SetField(ref _timeCancelled, value); }

        /// <summary>
        /// LockCancellationLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}