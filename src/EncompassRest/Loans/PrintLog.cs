using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrintLog
    /// </summary>
    public sealed partial class PrintLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _action;
        private DirtyList<LogAlert> _alerts;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _comments;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _printedBy;
        private DirtyValue<string> _printedByFullName;
        private DirtyList<PrintForm> _printForms;
        private DirtyValue<string> _systemId;
        private DirtyValue<DateTime?> _updatedDateUtc;

        /// <summary>
        /// PrintLog Action
        /// </summary>
        public string Action { get => _action; set => SetField(ref _action, value); }

        /// <summary>
        /// PrintLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// PrintLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// PrintLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// PrintLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// PrintLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// PrintLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// PrintLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PrintLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// PrintLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// PrintLog PrintedBy
        /// </summary>
        public string PrintedBy { get => _printedBy; set => SetField(ref _printedBy, value); }

        /// <summary>
        /// PrintLog PrintedByFullName
        /// </summary>
        public string PrintedByFullName { get => _printedByFullName; set => SetField(ref _printedByFullName, value); }

        /// <summary>
        /// PrintLog PrintForms
        /// </summary>
        public IList<PrintForm> PrintForms { get => GetField(ref _printForms); set => SetField(ref _printForms, value); }

        /// <summary>
        /// PrintLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// PrintLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}