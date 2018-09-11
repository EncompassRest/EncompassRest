using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LogComment
    /// </summary>
    public sealed partial class LogComment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// LogComment AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }
        private DirtyValue<string> _addedByName;
        /// <summary>
        /// LogComment AddedByName
        /// </summary>
        public string AddedByName { get => _addedByName; set => SetField(ref _addedByName, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LogComment Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// LogComment Date
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }
        private DirtyValue<int?> _forRoleId;
        /// <summary>
        /// LogComment ForRoleId
        /// </summary>
        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LogComment Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LogComment Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isInternal;
        /// <summary>
        /// LogComment IsInternal
        /// </summary>
        public bool? IsInternal { get => _isInternal; set => SetField(ref _isInternal, value); }
        private DirtyValue<string> _reviewedBy;
        /// <summary>
        /// LogComment ReviewedBy
        /// </summary>
        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }
        private DirtyValue<DateTime?> _reviewedDate;
        /// <summary>
        /// LogComment ReviewedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }
    }
}