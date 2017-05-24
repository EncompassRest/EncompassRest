using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegistrationLog
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
        public Value<bool?> CurrentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentIndicator() => !CurrentIndicator.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<DateTime?> ExpiredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpiredDate() => !ExpiredDate.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InvestorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName() => !InvestorName.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<string> Reference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReference() => !Reference.Clean;
        public Value<string> RegisteredById { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegisteredById() => !RegisteredById.Clean;
        public Value<string> RegisteredByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegisteredByName() => !RegisteredByName.Clean;
        public Value<DateTime?> RegisteredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegisteredDate() => !RegisteredDate.Clean;
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
                    && CurrentIndicator.Clean
                    && DateUtc.Clean
                    && ExpiredDate.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && InvestorName.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && Reference.Clean
                    && RegisteredById.Clean
                    && RegisteredByName.Clean
                    && RegisteredDate.Clean
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
                var v3 = CurrentIndicator; v3.Clean = value; CurrentIndicator = v3;
                var v4 = DateUtc; v4.Clean = value; DateUtc = v4;
                var v5 = ExpiredDate; v5.Clean = value; ExpiredDate = v5;
                var v6 = FileAttachmentsMigrated; v6.Clean = value; FileAttachmentsMigrated = v6;
                var v7 = Guid; v7.Clean = value; Guid = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = InvestorName; v9.Clean = value; InvestorName = v9;
                var v10 = IsSystemSpecificIndicator; v10.Clean = value; IsSystemSpecificIndicator = v10;
                var v11 = LogRecordIndex; v11.Clean = value; LogRecordIndex = v11;
                var v12 = Reference; v12.Clean = value; Reference = v12;
                var v13 = RegisteredById; v13.Clean = value; RegisteredById = v13;
                var v14 = RegisteredByName; v14.Clean = value; RegisteredByName = v14;
                var v15 = RegisteredDate; v15.Clean = value; RegisteredDate = v15;
                var v16 = SystemId; v16.Clean = value; SystemId = v16;
                _settingClean = 0;
            }
        }
    }
}