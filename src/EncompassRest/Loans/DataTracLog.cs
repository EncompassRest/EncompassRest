using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DataTracLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _creator;
        public string Creator { get { return _creator; } set { _creator = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _fileId;
        public string FileId { get { return _fileId; } set { _fileId = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _message;
        public string Message { get { return _message; } set { _message = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _commentList.Clean
                    && _comments.Clean
                    && _creator.Clean
                    && _dateUtc.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _fileId.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _message.Clean
                    && _systemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _commentList; v1.Clean = value; _commentList = v1;
                var v2 = _comments; v2.Clean = value; _comments = v2;
                var v3 = _creator; v3.Clean = value; _creator = v3;
                var v4 = _dateUtc; v4.Clean = value; _dateUtc = v4;
                var v5 = _fileAttachmentsMigrated; v5.Clean = value; _fileAttachmentsMigrated = v5;
                var v6 = _fileId; v6.Clean = value; _fileId = v6;
                var v7 = _guid; v7.Clean = value; _guid = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _isSystemSpecificIndicator; v9.Clean = value; _isSystemSpecificIndicator = v9;
                var v10 = _logRecordIndex; v10.Clean = value; _logRecordIndex = v10;
                var v11 = _message; v11.Clean = value; _message = v11;
                var v12 = _systemId; v12.Clean = value; _systemId = v12;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}