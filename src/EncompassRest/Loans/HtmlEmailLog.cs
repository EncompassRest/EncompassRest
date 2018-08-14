using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HtmlEmailLog
    /// </summary>
    public sealed partial class HtmlEmailLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// HtmlEmailLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _body;
        /// <summary>
        /// HtmlEmailLog Body
        /// </summary>
        public string Body { get => _body; set => _body = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// HtmlEmailLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// HtmlEmailLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _creator;
        /// <summary>
        /// HtmlEmailLog Creator
        /// </summary>
        public string Creator { get => _creator; set => _creator = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// HtmlEmailLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// HtmlEmailLog Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyList<EmailDocument> _docList;
        /// <summary>
        /// HtmlEmailLog DocList
        /// </summary>
        public IList<EmailDocument> DocList { get => _docList ?? (_docList = new DirtyList<EmailDocument>()); set => _docList = new DirtyList<EmailDocument>(value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// HtmlEmailLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// HtmlEmailLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// HtmlEmailLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// HtmlEmailLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// HtmlEmailLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<bool?> _readReceipt;
        /// <summary>
        /// HtmlEmailLog ReadReceipt
        /// </summary>
        public bool? ReadReceipt { get => _readReceipt; set => _readReceipt = value; }
        private DirtyValue<string> _recipient;
        /// <summary>
        /// HtmlEmailLog Recipient
        /// </summary>
        public string Recipient { get => _recipient; set => _recipient = value; }
        private DirtyValue<string> _sender;
        /// <summary>
        /// HtmlEmailLog Sender
        /// </summary>
        public string Sender { get => _sender; set => _sender = value; }
        private DirtyValue<string> _subject;
        /// <summary>
        /// HtmlEmailLog Subject
        /// </summary>
        public string Subject { get => _subject; set => _subject = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// HtmlEmailLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
    }
}