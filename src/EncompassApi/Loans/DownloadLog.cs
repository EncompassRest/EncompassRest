using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// DownloadLog
    /// </summary>
    public sealed partial class DownloadLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert>? _alerts;
        private DirtyValue<string?>? _barcodePage;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _dateReceived;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<string?>? _documentId;
        private DirtyValue<string?>? _downloadId;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<string?>? _fileSource;
        private DirtyValue<string?>? _fileType;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<string?>? _receivedBy;
        private DirtyValue<string?>? _sender;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<string?>? _title;
        private DirtyValue<DateTime?>? _updatedDateUtc;

        /// <summary>
        /// DownloadLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// DownloadLog BarcodePage
        /// </summary>
        public string? BarcodePage { get => _barcodePage; set => SetField(ref _barcodePage, value); }

        /// <summary>
        /// DownloadLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// DownloadLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// DownloadLog DateReceived
        /// </summary>
        public string? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        /// <summary>
        /// DownloadLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// DownloadLog DocumentId
        /// </summary>
        public string? DocumentId { get => _documentId; set => SetField(ref _documentId, value); }

        /// <summary>
        /// DownloadLog DownloadId
        /// </summary>
        public string? DownloadId { get => _downloadId; set => SetField(ref _downloadId, value); }

        /// <summary>
        /// DownloadLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// DownloadLog FileSource
        /// </summary>
        public string? FileSource { get => _fileSource; set => SetField(ref _fileSource, value); }

        /// <summary>
        /// DownloadLog FileType
        /// </summary>
        public string? FileType { get => _fileType; set => SetField(ref _fileType, value); }

        /// <summary>
        /// DownloadLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// DownloadLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// DownloadLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// DownloadLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// DownloadLog ReceivedBy
        /// </summary>
        public string? ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// DownloadLog Sender
        /// </summary>
        public string? Sender { get => _sender; set => SetField(ref _sender, value); }

        /// <summary>
        /// DownloadLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// DownloadLog Title
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// DownloadLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}