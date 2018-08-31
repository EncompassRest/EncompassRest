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
        public DateTime? DueDate { get => _dueDate; set => SetField(ref _dueDate, value); }
        private DirtyValue<DateTime?> _followedUpDate;
        /// <summary>
        /// LogAlert FollowedUpDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FollowedUpDate { get => _followedUpDate; set => SetField(ref _followedUpDate, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LogAlert Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private LogRecord _logRecord;
        /// <summary>
        /// LogAlert LogRecord
        /// </summary>
        public LogRecord LogRecord { get => GetField(ref _logRecord); set => SetField(ref _logRecord, value); }
        private DirtyValue<int?> _roleId;
        /// <summary>
        /// LogAlert RoleId
        /// </summary>
        public int? RoleId { get => _roleId; set => SetField(ref _roleId, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LogAlert SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _userId;
        /// <summary>
        /// LogAlert UserId
        /// </summary>
        public string UserId { get => _userId; set => SetField(ref _userId, value); }
    }
}