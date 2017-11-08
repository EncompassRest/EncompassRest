using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class RegistrationLog : IDirty
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { return _alerts ?? (_alerts = new DirtyList<LogAlert>()); } set { _alerts = new DirtyList<LogAlert>(value); } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { return _commentList ?? (_commentList = new DirtyList<LogComment>()); } set { _commentList = new DirtyList<LogComment>(value); } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<bool?> _currentIndicator;
        public bool? CurrentIndicator { get { return _currentIndicator; } set { _currentIndicator = value; } }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private DirtyValue<DateTime?> _expiredDate;
        public DateTime? ExpiredDate { get { return _expiredDate; } set { _expiredDate = value; } }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _investorName;
        public string InvestorName { get { return _investorName; } set { _investorName = value; } }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private DirtyValue<string> _reference;
        public string Reference { get { return _reference; } set { _reference = value; } }
        private DirtyValue<string> _registeredById;
        public string RegisteredById { get { return _registeredById; } set { _registeredById = value; } }
        private DirtyValue<string> _registeredByName;
        public string RegisteredByName { get { return _registeredByName; } set { _registeredByName = value; } }
        private DirtyValue<DateTime?> _registeredDate;
        public DateTime? RegisteredDate { get { return _registeredDate; } set { _registeredDate = value; } }
        private DirtyValue<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
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
                var dirty = _comments.Dirty
                    || _currentIndicator.Dirty
                    || _dateUtc.Dirty
                    || _expiredDate.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _investorName.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _reference.Dirty
                    || _registeredById.Dirty
                    || _registeredByName.Dirty
                    || _registeredDate.Dirty
                    || _systemId.Dirty
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
                _comments.Dirty = value;
                _currentIndicator.Dirty = value;
                _dateUtc.Dirty = value;
                _expiredDate.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _investorName.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _reference.Dirty = value;
                _registeredById.Dirty = value;
                _registeredByName.Dirty = value;
                _registeredDate.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}