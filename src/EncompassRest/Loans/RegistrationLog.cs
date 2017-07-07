using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var currentIndicator = _currentIndicator; currentIndicator.Clean = value; _currentIndicator = currentIndicator;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var expiredDate = _expiredDate; expiredDate.Clean = value; _expiredDate = expiredDate;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var investorName = _investorName; investorName.Clean = value; _investorName = investorName;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var reference = _reference; reference.Clean = value; _reference = reference;
                var registeredById = _registeredById; registeredById.Clean = value; _registeredById = registeredById;
                var registeredByName = _registeredByName; registeredByName.Clean = value; _registeredByName = registeredByName;
                var registeredDate = _registeredDate; registeredDate.Clean = value; _registeredDate = registeredDate;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public RegistrationLog()
        {
            Clean = true;
        }
    }
}