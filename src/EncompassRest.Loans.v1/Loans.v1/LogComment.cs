using System;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// LogComment
    /// </summary>
    public sealed partial class LogComment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _addedBy;
        private DirtyValue<string?>? _addedByName;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _date;
        private DirtyValue<int?>? _forRoleId;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isExternal;
        private DirtyValue<bool?>? _isInternal;
        private DirtyValue<string?>? _reviewedBy;
        private DirtyValue<DateTime?>? _reviewedDate;

        /// <summary>
        /// LogComment AddedBy
        /// </summary>
        public string? AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

        /// <summary>
        /// LogComment AddedByName
        /// </summary>
        public string? AddedByName { get => _addedByName; set => SetField(ref _addedByName, value); }

        /// <summary>
        /// LogComment Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// LogComment Date
        /// </summary>
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// LogComment ForRoleId
        /// </summary>
        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }

        /// <summary>
        /// LogComment Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// LogComment Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LogComment IsExternal
        /// </summary>
        public bool? IsExternal { get => _isExternal; set => SetField(ref _isExternal, value); }

        /// <summary>
        /// LogComment IsInternal
        /// </summary>
        public bool? IsInternal { get => _isInternal; set => SetField(ref _isInternal, value); }

        /// <summary>
        /// LogComment ReviewedBy
        /// </summary>
        public string? ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        /// <summary>
        /// LogComment ReviewedDate
        /// </summary>
        public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }
    }
}