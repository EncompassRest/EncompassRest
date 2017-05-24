using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LogAlert
    {
        public Value<DateTime?> DueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueDate() => !DueDate.Clean;
        public Value<DateTime?> FollowedUpDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFollowedUpDate() => !FollowedUpDate.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public LogRecord LogRecord { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecord() => LogRecord?.Clean == false;
        public Value<int?> RoleId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoleId() => !RoleId.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        public Value<string> UserId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserId() => !UserId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = DueDate.Clean
                    && FollowedUpDate.Clean
                    && Id.Clean
                    && RoleId.Clean
                    && SystemId.Clean
                    && UserId.Clean
                    && LogRecord.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = DueDate; v0.Clean = value; DueDate = v0;
                var v1 = FollowedUpDate; v1.Clean = value; FollowedUpDate = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = RoleId; v3.Clean = value; RoleId = v3;
                var v4 = SystemId; v4.Clean = value; SystemId = v4;
                var v5 = UserId; v5.Clean = value; UserId = v5;
                if (LogRecord != null) LogRecord.Clean = value;
                _settingClean = 0;
            }
        }
    }
}