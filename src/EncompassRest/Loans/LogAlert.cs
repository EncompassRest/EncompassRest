using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LogAlert
    {
        private Value<DateTime?> _dueDate;
        public DateTime? DueDate { get { return _dueDate; } set { _dueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueDate() => !_dueDate.Clean;
        private Value<DateTime?> _followedUpDate;
        public DateTime? FollowedUpDate { get { return _followedUpDate; } set { _followedUpDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFollowedUpDate() => !_followedUpDate.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        public LogRecord LogRecord { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecord() => LogRecord?.Clean == false;
        private Value<int?> _roleId;
        public int? RoleId { get { return _roleId; } set { _roleId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoleId() => !_roleId.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private Value<string> _userId;
        public string UserId { get { return _userId; } set { _userId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserId() => !_userId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _dueDate.Clean
                    && _followedUpDate.Clean
                    && _id.Clean
                    && _roleId.Clean
                    && _systemId.Clean
                    && _userId.Clean
                    && LogRecord.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _dueDate; v0.Clean = value; _dueDate = v0;
                var v1 = _followedUpDate; v1.Clean = value; _followedUpDate = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _roleId; v3.Clean = value; _roleId = v3;
                var v4 = _systemId; v4.Clean = value; _systemId = v4;
                var v5 = _userId; v5.Clean = value; _userId = v5;
                if (LogRecord != null) LogRecord.Clean = value;
                _settingClean = 0;
            }
        }
    }
}