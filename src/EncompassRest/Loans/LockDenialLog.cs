using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LockDenialLog
    {
        public Value<bool?> AlertIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertIndicator() => !AlertIndicator.Clean;
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<string> DeniedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedBy() => !DeniedBy.Clean;
        public Value<string> DeniedById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedById() => !DeniedById.Clean;
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
        public Value<string> RequestGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestGuid() => !RequestGuid.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        public Value<string> TimeDenied { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeDenied() => !TimeDenied.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AlertIndicator.Clean
                    && Alerts.Clean
                    && CommentList.Clean
                    && Comments.Clean
                    && DateUtc.Clean
                    && DeniedBy.Clean
                    && DeniedById.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && RequestGuid.Clean
                    && SystemId.Clean
                    && TimeDenied.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AlertIndicator; v0.Clean = value; AlertIndicator = v0;
                var v1 = Alerts; v1.Clean = value; Alerts = v1;
                var v2 = CommentList; v2.Clean = value; CommentList = v2;
                var v3 = Comments; v3.Clean = value; Comments = v3;
                var v4 = DateUtc; v4.Clean = value; DateUtc = v4;
                var v5 = DeniedBy; v5.Clean = value; DeniedBy = v5;
                var v6 = DeniedById; v6.Clean = value; DeniedById = v6;
                var v7 = FileAttachmentsMigrated; v7.Clean = value; FileAttachmentsMigrated = v7;
                var v8 = Guid; v8.Clean = value; Guid = v8;
                var v9 = Id; v9.Clean = value; Id = v9;
                var v10 = IsSystemSpecificIndicator; v10.Clean = value; IsSystemSpecificIndicator = v10;
                var v11 = LogRecordIndex; v11.Clean = value; LogRecordIndex = v11;
                var v12 = RequestGuid; v12.Clean = value; RequestGuid = v12;
                var v13 = SystemId; v13.Clean = value; SystemId = v13;
                var v14 = TimeDenied; v14.Clean = value; TimeDenied = v14;
                _settingClean = 0;
            }
        }
    }
}