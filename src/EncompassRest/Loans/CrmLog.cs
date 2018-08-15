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
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// CrmLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// CrmLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _contactGuid;
        /// <summary>
        /// CrmLog ContactGuid
        /// </summary>
        public string ContactGuid { get => _contactGuid; set => SetField(ref _contactGuid, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// CrmLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// CrmLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// CrmLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// CrmLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// CrmLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// CrmLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _mappingId;
        /// <summary>
        /// CrmLog MappingId
        /// </summary>
        public string MappingId { get => _mappingId; set => SetField(ref _mappingId, value); }
        private DirtyValue<int?> _mappingType;
        /// <summary>
        /// CrmLog MappingType
        /// </summary>
        public int? MappingType { get => _mappingType; set => SetField(ref _mappingType, value); }
        private DirtyValue<int?> _roleType;
        /// <summary>
        /// CrmLog RoleType
        /// </summary>
        public int? RoleType { get => _roleType; set => SetField(ref _roleType, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// CrmLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}