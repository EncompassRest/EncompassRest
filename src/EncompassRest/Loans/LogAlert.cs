#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LogAlert : ExtensibleObject
    {
        private DirtyValue<DateTime?> _dueDate;
        public DateTime? DueDate { get => _dueDate; set => _dueDate = value; }
        private DirtyValue<DateTime?> _followedUpDate;
        public DateTime? FollowedUpDate { get => _followedUpDate; set => _followedUpDate = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private LogRecord _logRecord;
        public LogRecord LogRecord { get => _logRecord ?? (_logRecord = new LogRecord()); set => _logRecord = value; }
        private DirtyValue<int?> _roleId;
        public int? RoleId { get => _roleId; set => _roleId = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _userId;
        public string UserId { get => _userId; set => _userId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _dueDate.Dirty
                    || _followedUpDate.Dirty
                    || _id.Dirty
                    || _roleId.Dirty
                    || _systemId.Dirty
                    || _userId.Dirty
                    || _logRecord?.Dirty == true;
            }
            set
            {
                _dueDate.Dirty = value;
                _followedUpDate.Dirty = value;
                _id.Dirty = value;
                _roleId.Dirty = value;
                _systemId.Dirty = value;
                _userId.Dirty = value;
                if (_logRecord != null) _logRecord.Dirty = value;
            }
        }
    }
}