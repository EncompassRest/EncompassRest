using System;

namespace EncompassApi.Loans
{
    /// <summary>
    /// LogAlert
    /// </summary>
    public sealed partial class LogAlert : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?>? _dueDate;
        private DirtyValue<DateTime?>? _followedUpDate;
        private DirtyValue<string?>? _id;
        private DirtyValue<LogRecord?>? _logRecord;
        private DirtyValue<int?>? _roleId;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<string?>? _userId;

        /// <summary>
        /// LogAlert DueDate
        /// </summary>
        public DateTime? DueDate { get => _dueDate; set => SetField(ref _dueDate, value); }

        /// <summary>
        /// LogAlert FollowedUpDate
        /// </summary>
        public DateTime? FollowedUpDate { get => _followedUpDate; set => SetField(ref _followedUpDate, value); }

        /// <summary>
        /// LogAlert Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LogAlert LogRecord
        /// </summary>
        public LogRecord? LogRecord { get => _logRecord; set => SetField(ref _logRecord, value); }

        /// <summary>
        /// LogAlert RoleId
        /// </summary>
        public int? RoleId { get => _roleId; set => SetField(ref _roleId, value); }

        /// <summary>
        /// LogAlert SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// LogAlert UserId
        /// </summary>
        public string? UserId { get => _userId; set => SetField(ref _userId, value); }
    }
}