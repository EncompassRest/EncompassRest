using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class CrmLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _contactGuid;
        public string ContactGuid { get { return _contactGuid; } set { _contactGuid = value; } }
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
        private Value<string> _mappingId;
        public string MappingId { get { return _mappingId; } set { _mappingId = value; } }
        private Value<int?> _mappingType;
        public int? MappingType { get { return _mappingType; } set { _mappingType = value; } }
        private Value<int?> _roleType;
        public int? RoleType { get { return _roleType; } set { _roleType = value; } }
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
                    && _contactGuid.Clean
                    && _dateUtc.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _logRecordIndex.Clean
                    && _mappingId.Clean
                    && _mappingType.Clean
                    && _roleType.Clean
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
                var v3 = _contactGuid; v3.Clean = value; _contactGuid = v3;
                var v4 = _dateUtc; v4.Clean = value; _dateUtc = v4;
                var v5 = _fileAttachmentsMigrated; v5.Clean = value; _fileAttachmentsMigrated = v5;
                var v6 = _guid; v6.Clean = value; _guid = v6;
                var v7 = _id; v7.Clean = value; _id = v7;
                var v8 = _isSystemSpecificIndicator; v8.Clean = value; _isSystemSpecificIndicator = v8;
                var v9 = _logRecordIndex; v9.Clean = value; _logRecordIndex = v9;
                var v10 = _mappingId; v10.Clean = value; _mappingId = v10;
                var v11 = _mappingType; v11.Clean = value; _mappingType = v11;
                var v12 = _roleType; v12.Clean = value; _roleType = v12;
                var v13 = _systemId; v13.Clean = value; _systemId = v13;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}