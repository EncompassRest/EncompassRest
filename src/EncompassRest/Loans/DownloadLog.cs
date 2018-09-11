using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DownloadLog
    /// </summary>
    public sealed partial class DownloadLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// DownloadLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _barcodePage;
        /// <summary>
        /// DownloadLog BarcodePage
        /// </summary>
        public string BarcodePage { get => _barcodePage; set => SetField(ref _barcodePage, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// DownloadLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// DownloadLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _dateReceived;
        /// <summary>
        /// DownloadLog DateReceived
        /// </summary>
        public string DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DownloadLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _documentId;
        /// <summary>
        /// DownloadLog DocumentId
        /// </summary>
        public string DocumentId { get => _documentId; set => SetField(ref _documentId, value); }
        private DirtyValue<string> _downloadId;
        /// <summary>
        /// DownloadLog DownloadId
        /// </summary>
        public string DownloadId { get => _downloadId; set => SetField(ref _downloadId, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// DownloadLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _fileSource;
        /// <summary>
        /// DownloadLog FileSource
        /// </summary>
        public string FileSource { get => _fileSource; set => SetField(ref _fileSource, value); }
        private DirtyValue<string> _fileType;
        /// <summary>
        /// DownloadLog FileType
        /// </summary>
        public string FileType { get => _fileType; set => SetField(ref _fileType, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// DownloadLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// DownloadLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// DownloadLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// DownloadLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// DownloadLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }
        private DirtyValue<string> _sender;
        /// <summary>
        /// DownloadLog Sender
        /// </summary>
        public string Sender { get => _sender; set => SetField(ref _sender, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// DownloadLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _title;
        /// <summary>
        /// DownloadLog Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }
    }
}