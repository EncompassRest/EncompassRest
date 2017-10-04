using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ConversationLog : IDirty
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { var v = _alerts; return v ?? Interlocked.CompareExchange(ref _alerts, (v = new DirtyList<LogAlert>()), null) ?? v; } set { _alerts = new DirtyList<LogAlert>(value); } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { var v = _commentList; return v ?? Interlocked.CompareExchange(ref _commentList, (v = new DirtyList<LogComment>()), null) ?? v; } set { _commentList = new DirtyList<LogComment>(value); } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<string> _company;
        public string Company { get { return _company; } set { _company = value; } }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private DirtyValue<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _inLogIndicator;
        public bool? InLogIndicator { get { return _inLogIndicator; } set { _inLogIndicator = value; } }
        private DirtyValue<bool?> _isEmailIndicator;
        public bool? IsEmailIndicator { get { return _isEmailIndicator; } set { _isEmailIndicator = value; } }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private DirtyValue<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private DirtyValue<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private DirtyValue<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private DirtyValue<string> _userId;
        public string UserId { get { return _userId; } set { _userId = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _comments.Dirty
                    || _company.Dirty
                    || _dateUtc.Dirty
                    || _email.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _inLogIndicator.Dirty
                    || _isEmailIndicator.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _name.Dirty
                    || _phone.Dirty
                    || _systemId.Dirty
                    || _userId.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _comments.Dirty = value;
                _company.Dirty = value;
                _dateUtc.Dirty = value;
                _email.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _inLogIndicator.Dirty = value;
                _isEmailIndicator.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _name.Dirty = value;
                _phone.Dirty = value;
                _systemId.Dirty = value;
                _userId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}