using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FreddieServiceLqaLog
    /// </summary>
    public sealed partial class FreddieServiceLqaLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// FreddieServiceLqaLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// FreddieServiceLqaLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// FreddieServiceLqaLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// FreddieServiceLqaLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _details;
        /// <summary>
        /// FreddieServiceLqaLog Details
        /// </summary>
        public string Details { get => _details; set => SetField(ref _details, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// FreddieServiceLqaLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// FreddieServiceLqaLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// FreddieServiceLqaLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// FreddieServiceLqaLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// FreddieServiceLqaLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// FreddieServiceLqaLog Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<string> _result;
        /// <summary>
        /// FreddieServiceLqaLog Result
        /// </summary>
        public string Result { get => _result; set => SetField(ref _result, value); }
        private DirtyValue<bool?> _showAlert;
        /// <summary>
        /// FreddieServiceLqaLog ShowAlert
        /// </summary>
        public bool? ShowAlert { get => _showAlert; set => SetField(ref _showAlert, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// FreddieServiceLqaLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}