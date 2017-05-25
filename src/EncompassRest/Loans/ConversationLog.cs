using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ConversationLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _company;
        public string Company { get { return _company; } set { _company = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _inLogIndicator;
        public bool? InLogIndicator { get { return _inLogIndicator; } set { _inLogIndicator = value; } }
        private Value<bool?> _isEmailIndicator;
        public bool? IsEmailIndicator { get { return _isEmailIndicator; } set { _isEmailIndicator = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _userId;
        public string UserId { get { return _userId; } set { _userId = value; } }
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
                    && _company.Clean
                    && _dateUtc.Clean
                    && _email.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _inLogIndicator.Clean
                    && _isEmailIndicator.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _name.Clean
                    && _phone.Clean
                    && _systemId.Clean
                    && _userId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _commentList; v1.Clean = value; _commentList = v1;
                var v2 = _comments; v2.Clean = value; _comments = v2;
                var v3 = _company; v3.Clean = value; _company = v3;
                var v4 = _dateUtc; v4.Clean = value; _dateUtc = v4;
                var v5 = _email; v5.Clean = value; _email = v5;
                var v6 = _fileAttachmentsMigrated; v6.Clean = value; _fileAttachmentsMigrated = v6;
                var v7 = _guid; v7.Clean = value; _guid = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _inLogIndicator; v9.Clean = value; _inLogIndicator = v9;
                var v10 = _isEmailIndicator; v10.Clean = value; _isEmailIndicator = v10;
                var v11 = _isSystemSpecificIndicator; v11.Clean = value; _isSystemSpecificIndicator = v11;
                var v12 = _logRecordIndex; v12.Clean = value; _logRecordIndex = v12;
                var v13 = _name; v13.Clean = value; _name = v13;
                var v14 = _phone; v14.Clean = value; _phone = v14;
                var v15 = _systemId; v15.Clean = value; _systemId = v15;
                var v16 = _userId; v16.Clean = value; _userId = v16;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}