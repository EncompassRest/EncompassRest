using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class DownloadLog : IDirty
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { return _alerts ?? (_alerts = new DirtyList<LogAlert>()); } set { _alerts = new DirtyList<LogAlert>(value); } }
        private DirtyValue<string> _barcodePage;
        public string BarcodePage { get { return _barcodePage; } set { _barcodePage = value; } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { return _commentList ?? (_commentList = new DirtyList<LogComment>()); } set { _commentList = new DirtyList<LogComment>(value); } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<string> _dateReceived;
        public string DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private DirtyValue<string> _documentId;
        public string DocumentId { get { return _documentId; } set { _documentId = value; } }
        private DirtyValue<string> _downloadId;
        public string DownloadId { get { return _downloadId; } set { _downloadId = value; } }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private DirtyValue<string> _fileSource;
        public string FileSource { get { return _fileSource; } set { _fileSource = value; } }
        private DirtyValue<string> _fileType;
        public string FileType { get { return _fileType; } set { _fileType = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private DirtyValue<string> _sender;
        public string Sender { get { return _sender; } set { _sender = value; } }
        private DirtyValue<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private DirtyValue<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _barcodePage.Dirty
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
                    || _commentList?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}