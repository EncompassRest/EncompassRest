using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CrmLog
    /// </summary>
    public sealed partial class CrmLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// CrmLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// CrmLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// CrmLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _contactGuid;
        /// <summary>
        /// CrmLog ContactGuid
        /// </summary>
        public string ContactGuid { get => _contactGuid; set => _contactGuid = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// CrmLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// CrmLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// CrmLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// CrmLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// CrmLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// CrmLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _mappingId;
        /// <summary>
        /// CrmLog MappingId
        /// </summary>
        public string MappingId { get => _mappingId; set => _mappingId = value; }
        private DirtyValue<int?> _mappingType;
        /// <summary>
        /// CrmLog MappingType
        /// </summary>
        public int? MappingType { get => _mappingType; set => _mappingType = value; }
        private DirtyValue<int?> _roleType;
        /// <summary>
        /// CrmLog RoleType
        /// </summary>
        public int? RoleType { get => _roleType; set => _roleType = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// CrmLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get => _comments.Dirty
                || _contactGuid.Dirty
                || _dateUtc.Dirty
                || _fileAttachmentsMigrated.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _logRecordIndex.Dirty
                || _mappingId.Dirty
                || _mappingType.Dirty
                || _roleType.Dirty
                || _systemId.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true;
            set
            {
                _comments.Dirty = value;
                _contactGuid.Dirty = value;
                _dateUtc.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _mappingId.Dirty = value;
                _mappingType.Dirty = value;
                _roleType.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}