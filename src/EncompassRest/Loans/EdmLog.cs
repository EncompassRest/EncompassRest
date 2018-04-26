using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EdmLog
    /// </summary>
    public sealed partial class EdmLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// EdmLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// EdmLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// EdmLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _creator;
        /// <summary>
        /// EdmLog Creator
        /// </summary>
        public string Creator { get => _creator; set => _creator = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// EdmLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// EdmLog Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyList<EdmDocument> _documents;
        /// <summary>
        /// EdmLog Documents
        /// </summary>
        public IList<EdmDocument> Documents { get => _documents ?? (_documents = new DirtyList<EdmDocument>()); set => _documents = new DirtyList<EdmDocument>(value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// EdmLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// EdmLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// EdmLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// EdmLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// EdmLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// EdmLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _url;
        /// <summary>
        /// EdmLog Url
        /// </summary>
        public string Url { get => _url; set => _url = value; }
        internal override bool DirtyInternal
        {
            get => _comments.Dirty
                || _creator.Dirty
                || _dateUtc.Dirty
                || _description.Dirty
                || _fileAttachmentsMigrated.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _logRecordIndex.Dirty
                || _systemId.Dirty
                || _url.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true
                || _documents?.Dirty == true;
            set
            {
                _comments.Dirty = value;
                _creator.Dirty = value;
                _dateUtc.Dirty = value;
                _description.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _systemId.Dirty = value;
                _url.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_documents != null) _documents.Dirty = value;
            }
        }
    }
}