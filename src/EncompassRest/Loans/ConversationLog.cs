using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ConversationLog
    /// </summary>
    public sealed partial class ConversationLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// ConversationLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// ConversationLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// ConversationLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _company;
        /// <summary>
        /// ConversationLog Company
        /// </summary>
        public string Company { get => _company; set => _company = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// ConversationLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// ConversationLog Email
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// ConversationLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// ConversationLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ConversationLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _inLogIndicator;
        /// <summary>
        /// ConversationLog InLogIndicator
        /// </summary>
        public bool? InLogIndicator { get => _inLogIndicator; set => _inLogIndicator = value; }
        private DirtyValue<bool?> _isEmailIndicator;
        /// <summary>
        /// ConversationLog IsEmailIndicator
        /// </summary>
        public bool? IsEmailIndicator { get => _isEmailIndicator; set => _isEmailIndicator = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// ConversationLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// ConversationLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// ConversationLog Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _phone;
        /// <summary>
        /// ConversationLog Phone
        /// </summary>
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// ConversationLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _userId;
        /// <summary>
        /// ConversationLog UserId
        /// </summary>
        public string UserId { get => _userId; set => _userId = value; }
    }
}