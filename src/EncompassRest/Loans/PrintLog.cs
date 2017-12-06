#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class PrintLog : ExtensibleObject
    {
        private DirtyValue<string> _action;
        public string Action { get => _action; set => _action = value; }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _printedBy;
        public string PrintedBy { get => _printedBy; set => _printedBy = value; }
        private DirtyValue<string> _printedByFullName;
        public string PrintedByFullName { get => _printedByFullName; set => _printedByFullName = value; }
        private DirtyList<PrintForm> _printForms;
        public IList<PrintForm> PrintForms { get => _printForms ?? (_printForms = new DirtyList<PrintForm>()); set => _printForms = new DirtyList<PrintForm>(value); }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _action.Dirty
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
            }
            set
            {
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
            }
        }
    }
}