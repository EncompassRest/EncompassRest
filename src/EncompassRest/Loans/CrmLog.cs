using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CrmLog
    /// </summary>
    public sealed partial class CrmLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert>? _alerts;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _contactGuid;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<string?>? _mappingId;
        private DirtyValue<int?>? _mappingType;
        private DirtyValue<int?>? _roleType;
        private DirtyValue<string?>? _systemId;

        /// <summary>
        /// CrmLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// CrmLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// CrmLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// CrmLog ContactGuid
        /// </summary>
        public string? ContactGuid { get => _contactGuid; set => SetField(ref _contactGuid, value); }

        /// <summary>
        /// CrmLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// CrmLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// CrmLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// CrmLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// CrmLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// CrmLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// CrmLog MappingId
        /// </summary>
        public string? MappingId { get => _mappingId; set => SetField(ref _mappingId, value); }

        /// <summary>
        /// CrmLog MappingType
        /// </summary>
        public int? MappingType { get => _mappingType; set => SetField(ref _mappingType, value); }

        /// <summary>
        /// CrmLog RoleType
        /// </summary>
        public int? RoleType { get => _roleType; set => SetField(ref _roleType, value); }

        /// <summary>
        /// CrmLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}