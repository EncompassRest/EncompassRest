using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FannieServiceEcLog
    /// </summary>
    public sealed partial class FannieServiceEcLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// FannieServiceEcLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// FannieServiceEcLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// FannieServiceEcLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// FannieServiceEcLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _details;
        /// <summary>
        /// FannieServiceEcLog Details
        /// </summary>
        public string Details { get => _details; set => _details = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// FannieServiceEcLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// FannieServiceEcLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// FannieServiceEcLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// FannieServiceEcLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// FannieServiceEcLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// FannieServiceEcLog Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _result;
        /// <summary>
        /// FannieServiceEcLog Result
        /// </summary>
        public string Result { get => _result; set => _result = value; }
        private DirtyValue<bool?> _showAlert;
        /// <summary>
        /// FannieServiceEcLog ShowAlert
        /// </summary>
        public bool? ShowAlert { get => _showAlert; set => _showAlert = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// FannieServiceEcLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
    }
}