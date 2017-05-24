using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DownloadLog
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<string> _barcodePage;
        public string BarcodePage { get { return _barcodePage; } set { _barcodePage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBarcodePage() => !_barcodePage.Clean;
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !_commentList.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<string> _dateReceived;
        public string DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !_dateReceived.Clean;
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !_dateUtc.Clean;
        private Value<string> _documentId;
        public string DocumentId { get { return _documentId; } set { _documentId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentId() => !_documentId.Clean;
        private Value<string> _downloadId;
        public string DownloadId { get { return _downloadId; } set { _downloadId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownloadId() => !_downloadId.Clean;
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !_fileAttachmentsMigrated.Clean;
        private Value<string> _fileSource;
        public string FileSource { get { return _fileSource; } set { _fileSource = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileSource() => !_fileSource.Clean;
        private Value<string> _fileType;
        public string FileType { get { return _fileType; } set { _fileType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileType() => !_fileType.Clean;
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !_guid.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !_isSystemSpecificIndicator.Clean;
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !_logRecordIndex.Clean;
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !_receivedBy.Clean;
        private Value<string> _sender;
        public string Sender { get { return _sender; } set { _sender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSender() => !_sender.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _barcodePage.Clean
                    && _commentList.Clean
                    && _comments.Clean
                    && _dateReceived.Clean
                    && _dateUtc.Clean
                    && _documentId.Clean
                    && _downloadId.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _fileSource.Clean
                    && _fileType.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _receivedBy.Clean
                    && _sender.Clean
                    && _systemId.Clean
                    && _title.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _barcodePage; v1.Clean = value; _barcodePage = v1;
                var v2 = _commentList; v2.Clean = value; _commentList = v2;
                var v3 = _comments; v3.Clean = value; _comments = v3;
                var v4 = _dateReceived; v4.Clean = value; _dateReceived = v4;
                var v5 = _dateUtc; v5.Clean = value; _dateUtc = v5;
                var v6 = _documentId; v6.Clean = value; _documentId = v6;
                var v7 = _downloadId; v7.Clean = value; _downloadId = v7;
                var v8 = _fileAttachmentsMigrated; v8.Clean = value; _fileAttachmentsMigrated = v8;
                var v9 = _fileSource; v9.Clean = value; _fileSource = v9;
                var v10 = _fileType; v10.Clean = value; _fileType = v10;
                var v11 = _guid; v11.Clean = value; _guid = v11;
                var v12 = _id; v12.Clean = value; _id = v12;
                var v13 = _isSystemSpecificIndicator; v13.Clean = value; _isSystemSpecificIndicator = v13;
                var v14 = _logRecordIndex; v14.Clean = value; _logRecordIndex = v14;
                var v15 = _receivedBy; v15.Clean = value; _receivedBy = v15;
                var v16 = _sender; v16.Clean = value; _sender = v16;
                var v17 = _systemId; v17.Clean = value; _systemId = v17;
                var v18 = _title; v18.Clean = value; _title = v18;
                _settingClean = 0;
            }
        }
    }
}