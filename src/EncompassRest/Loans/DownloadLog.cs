using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DownloadLog : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _alerts.Dirty
                    || _barcodePage.Dirty
                    || _commentList.Dirty
                    || _comments.Dirty
                    || _dateReceived.Dirty
                    || _dateUtc.Dirty
                    || _documentId.Dirty
                    || _downloadId.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _fileSource.Dirty
                    || _fileType.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _receivedBy.Dirty
                    || _sender.Dirty
                    || _systemId.Dirty
                    || _title.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _alerts.Dirty = value;
                _barcodePage.Dirty = value;
                _commentList.Dirty = value;
                _comments.Dirty = value;
                _dateReceived.Dirty = value;
                _dateUtc.Dirty = value;
                _documentId.Dirty = value;
                _downloadId.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _fileSource.Dirty = value;
                _fileType.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _receivedBy.Dirty = value;
                _sender.Dirty = value;
                _systemId.Dirty = value;
                _title.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}