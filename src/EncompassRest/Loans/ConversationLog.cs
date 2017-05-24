using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ConversationLog
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
        public Value<string> Company { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompany() => !Company.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> InLogIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInLogIndicator() => !InLogIndicator.Clean;
        public Value<bool?> IsEmailIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmailIndicator() => !IsEmailIndicator.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
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
                var clean = Alerts.Clean
                    && CommentList.Clean
                    && Comments.Clean
                    && Company.Clean
                    && DateUtc.Clean
                    && Email.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && InLogIndicator.Clean
                    && IsEmailIndicator.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && Name.Clean
                    && Phone.Clean
                    && SystemId.Clean
                    && UserId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alerts; v0.Clean = value; Alerts = v0;
                var v1 = CommentList; v1.Clean = value; CommentList = v1;
                var v2 = Comments; v2.Clean = value; Comments = v2;
                var v3 = Company; v3.Clean = value; Company = v3;
                var v4 = DateUtc; v4.Clean = value; DateUtc = v4;
                var v5 = Email; v5.Clean = value; Email = v5;
                var v6 = FileAttachmentsMigrated; v6.Clean = value; FileAttachmentsMigrated = v6;
                var v7 = Guid; v7.Clean = value; Guid = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = InLogIndicator; v9.Clean = value; InLogIndicator = v9;
                var v10 = IsEmailIndicator; v10.Clean = value; IsEmailIndicator = v10;
                var v11 = IsSystemSpecificIndicator; v11.Clean = value; IsSystemSpecificIndicator = v11;
                var v12 = LogRecordIndex; v12.Clean = value; LogRecordIndex = v12;
                var v13 = Name; v13.Clean = value; Name = v13;
                var v14 = Phone; v14.Clean = value; Phone = v14;
                var v15 = SystemId; v15.Clean = value; SystemId = v15;
                var v16 = UserId; v16.Clean = value; UserId = v16;
                _settingClean = 0;
            }
        }
    }
}