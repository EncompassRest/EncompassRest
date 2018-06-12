using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LogAlert
    /// </summary>
    public sealed partial class LogAlert : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _dueDate;
        /// <summary>
        /// LogAlert DueDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DueDate { get => _dueDate; set => _dueDate = value; }
        private DirtyValue<DateTime?> _followedUpDate;
        /// <summary>
        /// LogAlert FollowedUpDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FollowedUpDate { get => _followedUpDate; set => _followedUpDate = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LogAlert Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private LogRecord _logRecord;
        /// <summary>
        /// LogAlert LogRecord
        /// </summary>
        public LogRecord LogRecord { get => _logRecord ?? (_logRecord = new LogRecord()); set => _logRecord = value; }
        private DirtyValue<int?> _roleId;
        /// <summary>
        /// LogAlert RoleId
        /// </summary>
        public int? RoleId { get => _roleId; set => _roleId = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LogAlert SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _userId;
        /// <summary>
        /// LogAlert UserId
        /// </summary>
        public string UserId { get => _userId; set => _userId = value; }
        internal override bool DirtyInternal
        {
            get => _dueDate.Dirty
                || _followedUpDate.Dirty
                || _id.Dirty
                || _roleId.Dirty
                || _systemId.Dirty
                || _userId.Dirty
                || _logRecord?.Dirty == true;
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