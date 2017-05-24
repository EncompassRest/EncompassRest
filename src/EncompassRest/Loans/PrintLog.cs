using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrintLog
    {
        private Value<string> _action;
        public string Action { get { return _action; } set { _action = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAction() => !_action.Clean;
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !_commentList.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !_dateUtc.Clean;
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !_fileAttachmentsMigrated.Clean;
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
        private Value<string> _printedBy;
        public string PrintedBy { get { return _printedBy; } set { _printedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedBy() => !_printedBy.Clean;
        private Value<string> _printedByFullName;
        public string PrintedByFullName { get { return _printedByFullName; } set { _printedByFullName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedByFullName() => !_printedByFullName.Clean;
        private Value<List<PrintForm>> _printForms;
        public List<PrintForm> PrintForms { get { return _printForms; } set { _printForms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintForms() => !_printForms.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
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
    }
}