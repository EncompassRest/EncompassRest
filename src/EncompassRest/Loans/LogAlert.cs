using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LogAlert : IClean
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
                    && LogRecord?.Clean != false;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var dueDate = _dueDate; dueDate.Clean = value; _dueDate = dueDate;
                var followedUpDate = _followedUpDate; followedUpDate.Clean = value; _followedUpDate = followedUpDate;
                var id = _id; id.Clean = value; _id = id;
                var roleId = _roleId; roleId.Clean = value; _roleId = roleId;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var userId = _userId; userId.Clean = value; _userId = userId;
                if (LogRecord != null) LogRecord.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LogAlert()
        {
            Clean = true;
        }
    }
}