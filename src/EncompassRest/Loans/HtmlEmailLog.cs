using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HtmlEmailLog
    /// </summary>
    public sealed partial class HtmlEmailLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        private DirtyValue<string> _body;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _comments;
        private DirtyValue<string> _creator;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<string> _description;
        private DirtyList<EmailDocument> _docList;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<bool?> _readReceipt;
        private DirtyValue<string> _recipient;
        private DirtyValue<string> _sender;
        private DirtyValue<string> _subject;
        private DirtyValue<string> _systemId;
        private DirtyValue<DateTime?> _updatedDateUtc;

        /// <summary>
        /// HtmlEmailLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// HtmlEmailLog Body
        /// </summary>
        public string Body { get => _body; set => SetField(ref _body, value); }

        /// <summary>
        /// HtmlEmailLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// HtmlEmailLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// HtmlEmailLog Creator
        /// </summary>
        public string Creator { get => _creator; set => SetField(ref _creator, value); }

        /// <summary>
        /// HtmlEmailLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// HtmlEmailLog Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// HtmlEmailLog DocList
        /// </summary>
        public IList<EmailDocument> DocList { get => GetField(ref _docList); set => SetField(ref _docList, value); }

        /// <summary>
        /// HtmlEmailLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// HtmlEmailLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// HtmlEmailLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// HtmlEmailLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// HtmlEmailLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// HtmlEmailLog ReadReceipt
        /// </summary>
        public bool? ReadReceipt { get => _readReceipt; set => SetField(ref _readReceipt, value); }

        /// <summary>
        /// HtmlEmailLog Recipient
        /// </summary>
        public string Recipient { get => _recipient; set => SetField(ref _recipient, value); }

        /// <summary>
        /// HtmlEmailLog Sender
        /// </summary>
        public string Sender { get => _sender; set => SetField(ref _sender, value); }

        /// <summary>
        /// HtmlEmailLog Subject
        /// </summary>
        public string Subject { get => _subject; set => SetField(ref _subject, value); }

        /// <summary>
        /// HtmlEmailLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// HtmlEmailLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}