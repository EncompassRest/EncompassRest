using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class CrmLog
    {
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> ContactGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactGuid() => !ContactGuid.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<string> MappingId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMappingId() => !MappingId.Clean;
        public Value<int?> MappingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMappingType() => !MappingType.Clean;
        public Value<int?> RoleType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoleType() => !RoleType.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Alerts.Clean
                    && CommentList.Clean
                    && Comments.Clean
                    && ContactGuid.Clean
                    && DateUtc.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && MappingId.Clean
                    && MappingType.Clean
                    && RoleType.Clean
                    && SystemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alerts; v0.Clean = value; Alerts = v0;
                var v1 = CommentList; v1.Clean = value; CommentList = v1;
                var v2 = Comments; v2.Clean = value; Comments = v2;
                var v3 = ContactGuid; v3.Clean = value; ContactGuid = v3;
                var v4 = DateUtc; v4.Clean = value; DateUtc = v4;
                var v5 = FileAttachmentsMigrated; v5.Clean = value; FileAttachmentsMigrated = v5;
                var v6 = Guid; v6.Clean = value; Guid = v6;
                var v7 = Id; v7.Clean = value; Id = v7;
                var v8 = IsSystemSpecificIndicator; v8.Clean = value; IsSystemSpecificIndicator = v8;
                var v9 = LogRecordIndex; v9.Clean = value; LogRecordIndex = v9;
                var v10 = MappingId; v10.Clean = value; MappingId = v10;
                var v11 = MappingType; v11.Clean = value; MappingType = v11;
                var v12 = RoleType; v12.Clean = value; RoleType = v12;
                var v13 = SystemId; v13.Clean = value; SystemId = v13;
                _settingClean = 0;
            }
        }
    }
}