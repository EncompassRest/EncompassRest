using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PrintLog : IDirty
    {
        private Value<string> _action;
        public string Action { get { return _action; } set { _action = value; } }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { var v = _alerts; return v ?? Interlocked.CompareExchange(ref _alerts, (v = new DirtyList<LogAlert>()), null) ?? v; } set { _alerts = new DirtyList<LogAlert>(value); } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { var v = _commentList; return v ?? Interlocked.CompareExchange(ref _commentList, (v = new DirtyList<LogComment>()), null) ?? v; } set { _commentList = new DirtyList<LogComment>(value); } }
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
        private DirtyList<PrintForm> _printForms;
        public IList<PrintForm> PrintForms { get { var v = _printForms; return v ?? Interlocked.CompareExchange(ref _printForms, (v = new DirtyList<PrintForm>()), null) ?? v; } set { _printForms = new DirtyList<PrintForm>(value); } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _action.Dirty
                    || _comments.Dirty
                    || _dateUtc.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _printedBy.Dirty
                    || _printedByFullName.Dirty
                    || _systemId.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true
                    || _printForms?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _action.Dirty = value;
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _printedBy.Dirty = value;
                _printedByFullName.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_printForms != null) _printForms.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}