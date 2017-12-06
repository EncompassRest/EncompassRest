#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DownloadLog : ExtensibleObject
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _barcodePage;
        public string BarcodePage { get => _barcodePage; set => _barcodePage = value; }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _dateReceived;
        public string DateReceived { get => _dateReceived; set => _dateReceived = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _documentId;
        public string DocumentId { get => _documentId; set => _documentId = value; }
        private DirtyValue<string> _downloadId;
        public string DownloadId { get => _downloadId; set => _downloadId = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _fileSource;
        public string FileSource { get => _fileSource; set => _fileSource = value; }
        private DirtyValue<string> _fileType;
        public string FileType { get => _fileType; set => _fileType = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<string> _sender;
        public string Sender { get => _sender; set => _sender = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _barcodePage.Dirty
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
                    || _title.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true;
            }
            set
            {
                _barcodePage.Dirty = value;
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
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}