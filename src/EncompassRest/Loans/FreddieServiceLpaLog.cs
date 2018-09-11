using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FreddieServiceLpaLog
    /// </summary>
    public sealed partial class FreddieServiceLpaLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// FreddieServiceLpaLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// FreddieServiceLpaLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// FreddieServiceLpaLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// FreddieServiceLpaLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _details;
        /// <summary>
        /// FreddieServiceLpaLog Details
        /// </summary>
        public string Details { get => _details; set => SetField(ref _details, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// FreddieServiceLpaLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// FreddieServiceLpaLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// FreddieServiceLpaLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// FreddieServiceLpaLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// FreddieServiceLpaLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// FreddieServiceLpaLog Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<string> _result;
        /// <summary>
        /// FreddieServiceLpaLog Result
        /// </summary>
        public string Result { get => _result; set => SetField(ref _result, value); }
        private DirtyValue<bool?> _showAlert;
        /// <summary>
        /// FreddieServiceLpaLog ShowAlert
        /// </summary>
        public bool? ShowAlert { get => _showAlert; set => SetField(ref _showAlert, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// FreddieServiceLpaLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}