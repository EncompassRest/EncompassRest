using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrintLog : IClean
    {
        private Value<string> _action;
        public string Action { get { return _action; } set { _action = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _printedBy;
        public string PrintedBy { get { return _printedBy; } set { _printedBy = value; } }
        private Value<string> _printedByFullName;
        public string PrintedByFullName { get { return _printedByFullName; } set { _printedByFullName = value; } }
        private Value<List<PrintForm>> _printForms;
        public List<PrintForm> PrintForms { get { return _printForms; } set { _printForms = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _action.Clean
                    && _alerts.Clean
                    && _commentList.Clean
                    && _comments.Clean
                    && _dateUtc.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _printedBy.Clean
                    && _printedByFullName.Clean
                    && _printForms.Clean
                    && _systemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _action; v0.Clean = value; _action = v0;
                var v1 = _alerts; v1.Clean = value; _alerts = v1;
                var v2 = _commentList; v2.Clean = value; _commentList = v2;
                var v3 = _comments; v3.Clean = value; _comments = v3;
                var v4 = _dateUtc; v4.Clean = value; _dateUtc = v4;
                var v5 = _fileAttachmentsMigrated; v5.Clean = value; _fileAttachmentsMigrated = v5;
                var v6 = _guid; v6.Clean = value; _guid = v6;
                var v7 = _id; v7.Clean = value; _id = v7;
                var v8 = _isSystemSpecificIndicator; v8.Clean = value; _isSystemSpecificIndicator = v8;
                var v9 = _logRecordIndex; v9.Clean = value; _logRecordIndex = v9;
                var v10 = _printedBy; v10.Clean = value; _printedBy = v10;
                var v11 = _printedByFullName; v11.Clean = value; _printedByFullName = v11;
                var v12 = _printForms; v12.Clean = value; _printForms = v12;
                var v13 = _systemId; v13.Clean = value; _systemId = v13;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}