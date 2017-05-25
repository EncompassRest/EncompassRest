using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegistrationLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<bool?> _currentIndicator;
        public bool? CurrentIndicator { get { return _currentIndicator; } set { _currentIndicator = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<DateTime?> _expiredDate;
        public DateTime? ExpiredDate { get { return _expiredDate; } set { _expiredDate = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _investorName;
        public string InvestorName { get { return _investorName; } set { _investorName = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _reference;
        public string Reference { get { return _reference; } set { _reference = value; } }
        private Value<string> _registeredById;
        public string RegisteredById { get { return _registeredById; } set { _registeredById = value; } }
        private Value<string> _registeredByName;
        public string RegisteredByName { get { return _registeredByName; } set { _registeredByName = value; } }
        private Value<DateTime?> _registeredDate;
        public DateTime? RegisteredDate { get { return _registeredDate; } set { _registeredDate = value; } }
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
                    && _currentIndicator.Clean
                    && _dateUtc.Clean
                    && _expiredDate.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _investorName.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _reference.Clean
                    && _registeredById.Clean
                    && _registeredByName.Clean
                    && _registeredDate.Clean
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
                var v3 = _currentIndicator; v3.Clean = value; _currentIndicator = v3;
                var v4 = _dateUtc; v4.Clean = value; _dateUtc = v4;
                var v5 = _expiredDate; v5.Clean = value; _expiredDate = v5;
                var v6 = _fileAttachmentsMigrated; v6.Clean = value; _fileAttachmentsMigrated = v6;
                var v7 = _guid; v7.Clean = value; _guid = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _investorName; v9.Clean = value; _investorName = v9;
                var v10 = _isSystemSpecificIndicator; v10.Clean = value; _isSystemSpecificIndicator = v10;
                var v11 = _logRecordIndex; v11.Clean = value; _logRecordIndex = v11;
                var v12 = _reference; v12.Clean = value; _reference = v12;
                var v13 = _registeredById; v13.Clean = value; _registeredById = v13;
                var v14 = _registeredByName; v14.Clean = value; _registeredByName = v14;
                var v15 = _registeredDate; v15.Clean = value; _registeredDate = v15;
                var v16 = _systemId; v16.Clean = value; _systemId = v16;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}