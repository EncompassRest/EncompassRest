using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DownloadLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _barcodePage;
        public string BarcodePage { get { return _barcodePage; } set { _barcodePage = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _dateReceived;
        public string DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<string> _documentId;
        public string DocumentId { get { return _documentId; } set { _documentId = value; } }
        private Value<string> _downloadId;
        public string DownloadId { get { return _downloadId; } set { _downloadId = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _fileSource;
        public string FileSource { get { return _fileSource; } set { _fileSource = value; } }
        private Value<string> _fileType;
        public string FileType { get { return _fileType; } set { _fileType = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private Value<string> _sender;
        public string Sender { get { return _sender; } set { _sender = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
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
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var barcodePage = _barcodePage; barcodePage.Clean = value; _barcodePage = barcodePage;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var dateReceived = _dateReceived; dateReceived.Clean = value; _dateReceived = dateReceived;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var documentId = _documentId; documentId.Clean = value; _documentId = documentId;
                var downloadId = _downloadId; downloadId.Clean = value; _downloadId = downloadId;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var fileSource = _fileSource; fileSource.Clean = value; _fileSource = fileSource;
                var fileType = _fileType; fileType.Clean = value; _fileType = fileType;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var receivedBy = _receivedBy; receivedBy.Clean = value; _receivedBy = receivedBy;
                var sender = _sender; sender.Clean = value; _sender = sender;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var title = _title; title.Clean = value; _title = title;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public DownloadLog()
        {
            Clean = true;
        }
    }
}