using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmailTriggerLog
    /// </summary>
    public sealed partial class EmailTriggerLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// EmailTriggerLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _body;
        /// <summary>
        /// EmailTriggerLog Body
        /// </summary>
        public string Body { get => _body; set => _body = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// EmailTriggerLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// EmailTriggerLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// EmailTriggerLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// EmailTriggerLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// EmailTriggerLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// EmailTriggerLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _inLogIndicator;
        /// <summary>
        /// EmailTriggerLog InLogIndicator
        /// </summary>
        public bool? InLogIndicator { get => _inLogIndicator; set => _inLogIndicator = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// EmailTriggerLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// EmailTriggerLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _recipients;
        /// <summary>
        /// EmailTriggerLog Recipients
        /// </summary>
        public string Recipients { get => _recipients; set => _recipients = value; }
        private DirtyValue<string> _sender;
        /// <summary>
        /// EmailTriggerLog Sender
        /// </summary>
        public string Sender { get => _sender; set => _sender = value; }
        private DirtyValue<string> _subject;
        /// <summary>
        /// EmailTriggerLog Subject
        /// </summary>
        public string Subject { get => _subject; set => _subject = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// EmailTriggerLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get => _body.Dirty
                || _comments.Dirty
                || _dateUtc.Dirty
                || _fileAttachmentsMigrated.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _inLogIndicator.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _logRecordIndex.Dirty
                || _recipients.Dirty
                || _sender.Dirty
                || _subject.Dirty
                || _systemId.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true;
            set
            {
                _body.Dirty = value;
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _inLogIndicator.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _recipients.Dirty = value;
                _sender.Dirty = value;
                _subject.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}