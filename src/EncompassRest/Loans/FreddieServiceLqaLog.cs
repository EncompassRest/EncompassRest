using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FreddieServiceLqaLog
    /// </summary>
    public sealed partial class FreddieServiceLqaLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _comments;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<string> _details;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _name;
        private DirtyValue<string> _result;
        private DirtyValue<bool?> _showAlert;
        private DirtyValue<string> _systemId;

        /// <summary>
        /// FreddieServiceLqaLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// FreddieServiceLqaLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// FreddieServiceLqaLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// FreddieServiceLqaLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// FreddieServiceLqaLog Details
        /// </summary>
        public string Details { get => _details; set => SetField(ref _details, value); }

        /// <summary>
        /// FreddieServiceLqaLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// FreddieServiceLqaLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// FreddieServiceLqaLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// FreddieServiceLqaLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// FreddieServiceLqaLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// FreddieServiceLqaLog Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// FreddieServiceLqaLog Result
        /// </summary>
        public string Result { get => _result; set => SetField(ref _result, value); }

        /// <summary>
        /// FreddieServiceLqaLog ShowAlert
        /// </summary>
        public bool? ShowAlert { get => _showAlert; set => SetField(ref _showAlert, value); }

        /// <summary>
        /// FreddieServiceLqaLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}