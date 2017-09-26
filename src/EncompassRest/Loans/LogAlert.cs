using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LogAlert : IDirty
    {
        private Value<DateTime?> _dueDate;
        public DateTime? DueDate { get { return _dueDate; } set { _dueDate = value; } }
        private Value<DateTime?> _followedUpDate;
        public DateTime? FollowedUpDate { get { return _followedUpDate; } set { _followedUpDate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        public LogRecord LogRecord { get; set; }
        private Value<int?> _roleId;
        public int? RoleId { get { return _roleId; } set { _roleId = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _userId;
        public string UserId { get { return _userId; } set { _userId = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _dueDate.Dirty
                    || _followedUpDate.Dirty
                    || _id.Dirty
                    || _roleId.Dirty
                    || _systemId.Dirty
                    || _userId.Dirty
                    || LogRecord?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _dueDate.Dirty = value;
                _followedUpDate.Dirty = value;
                _id.Dirty = value;
                _roleId.Dirty = value;
                _systemId.Dirty = value;
                _userId.Dirty = value;
                if (LogRecord != null) LogRecord.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}