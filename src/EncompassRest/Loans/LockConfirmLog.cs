using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LockConfirmLog
    {
        public Value<bool?> AlertIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertIndicator() => !AlertIndicator.Clean;
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<DateTime?> BuySideExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideExpirationDate() => !BuySideExpirationDate.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> ConfirmedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedBy() => !ConfirmedBy.Clean;
        public Value<bool?> ConfirmedByIdIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedByIdIndicator() => !ConfirmedByIdIndicator.Clean;
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
        public Value<string> RequestGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestGuid() => !RequestGuid.Clean;
        public Value<string> SellSideDeliveredBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDeliveredBy() => !SellSideDeliveredBy.Clean;
        public Value<DateTime?> SellSideDeliveryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDeliveryDate() => !SellSideDeliveryDate.Clean;
        public Value<DateTime?> SellSideExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideExpirationDate() => !SellSideExpirationDate.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        public Value<string> TimeConfirmed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeConfirmed() => !TimeConfirmed.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AlertIndicator.Clean
                    && Alerts.Clean
                    && BuySideExpirationDate.Clean
                    && CommentList.Clean
                    && Comments.Clean
                    && ConfirmedBy.Clean
                    && ConfirmedByIdIndicator.Clean
                    && DateUtc.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && RequestGuid.Clean
                    && SellSideDeliveredBy.Clean
                    && SellSideDeliveryDate.Clean
                    && SellSideExpirationDate.Clean
                    && SystemId.Clean
                    && TimeConfirmed.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AlertIndicator; v0.Clean = value; AlertIndicator = v0;
                var v1 = Alerts; v1.Clean = value; Alerts = v1;
                var v2 = BuySideExpirationDate; v2.Clean = value; BuySideExpirationDate = v2;
                var v3 = CommentList; v3.Clean = value; CommentList = v3;
                var v4 = Comments; v4.Clean = value; Comments = v4;
                var v5 = ConfirmedBy; v5.Clean = value; ConfirmedBy = v5;
                var v6 = ConfirmedByIdIndicator; v6.Clean = value; ConfirmedByIdIndicator = v6;
                var v7 = DateUtc; v7.Clean = value; DateUtc = v7;
                var v8 = FileAttachmentsMigrated; v8.Clean = value; FileAttachmentsMigrated = v8;
                var v9 = Guid; v9.Clean = value; Guid = v9;
                var v10 = Id; v10.Clean = value; Id = v10;
                var v11 = IsSystemSpecificIndicator; v11.Clean = value; IsSystemSpecificIndicator = v11;
                var v12 = LogRecordIndex; v12.Clean = value; LogRecordIndex = v12;
                var v13 = RequestGuid; v13.Clean = value; RequestGuid = v13;
                var v14 = SellSideDeliveredBy; v14.Clean = value; SellSideDeliveredBy = v14;
                var v15 = SellSideDeliveryDate; v15.Clean = value; SellSideDeliveryDate = v15;
                var v16 = SellSideExpirationDate; v16.Clean = value; SellSideExpirationDate = v16;
                var v17 = SystemId; v17.Clean = value; SystemId = v17;
                var v18 = TimeConfirmed; v18.Clean = value; TimeConfirmed = v18;
                _settingClean = 0;
            }
        }
    }
}