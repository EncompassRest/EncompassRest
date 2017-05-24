using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestLog
    {
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<string> AlertsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !AlertsXml.Clean;
        public Value<DateTime?> BuySideExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideExpirationDate() => !BuySideExpirationDate.Clean;
        public Value<DateTime?> BuySideNewLockExtensionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideNewLockExtensionDate() => !BuySideNewLockExtensionDate.Clean;
        public Value<int?> BuySideNumDayExtended { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideNumDayExtended() => !BuySideNumDayExtended.Clean;
        public Value<int?> BuySideNumDayLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideNumDayLocked() => !BuySideNumDayLocked.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> CommentListXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !CommentListXml.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<bool?> HideLogIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHideLogIndicator() => !HideLogIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InvestorCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCommitment() => !InvestorCommitment.Clean;
        public Value<bool?> IsFakeRequestIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsFakeRequestIndicator() => !IsFakeRequestIndicator.Clean;
        public Value<bool?> IsLockCancellationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsLockCancellationIndicator() => !IsLockCancellationIndicator.Clean;
        public Value<bool?> IsLockExtensionIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsLockExtensionIndicator() => !IsLockExtensionIndicator.Clean;
        public Value<bool?> IsReLockIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsReLockIndicator() => !IsReLockIndicator.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<int?> NumDayLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumDayLocked() => !NumDayLocked.Clean;
        public Value<string> ParentLockGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentLockGuid() => !ParentLockGuid.Clean;
        public Value<string> RequestedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedBy() => !RequestedBy.Clean;
        public Value<string> RequestedName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedName() => !RequestedName.Clean;
        public Value<string> RequestedStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedStatus() => !RequestedStatus.Clean;
        public Value<string> SellSideDeliveredBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDeliveredBy() => !SellSideDeliveredBy.Clean;
        public Value<DateTime?> SellSideDeliveryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDeliveryDate() => !SellSideDeliveryDate.Clean;
        public Value<DateTime?> SellSideExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideExpirationDate() => !SellSideExpirationDate.Clean;
        public Value<DateTime?> SellSideNewLockExtensionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideNewLockExtensionDate() => !SellSideNewLockExtensionDate.Clean;
        public Value<int?> SellSideNumDayExtended { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideNumDayExtended() => !SellSideNumDayExtended.Clean;
        public Value<string> SnapshotXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSnapshotXml() => !SnapshotXml.Clean;
        public Value<string> SystemId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !SystemId.Clean;
        public Value<string> TimeRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeRequested() => !TimeRequested.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Alerts.Clean
                    && AlertsXml.Clean
                    && BuySideExpirationDate.Clean
                    && BuySideNewLockExtensionDate.Clean
                    && BuySideNumDayExtended.Clean
                    && BuySideNumDayLocked.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && DateUtc.Clean
                    && FileAttachmentsMigrated.Clean
                    && Guid.Clean
                    && HideLogIndicator.Clean
                    && Id.Clean
                    && InvestorCommitment.Clean
                    && IsFakeRequestIndicator.Clean
                    && IsLockCancellationIndicator.Clean
                    && IsLockExtensionIndicator.Clean
                    && IsReLockIndicator.Clean
                    && IsSystemSpecificIndicator.Clean
                    && LogRecordIndex.Clean
                    && NumDayLocked.Clean
                    && ParentLockGuid.Clean
                    && RequestedBy.Clean
                    && RequestedName.Clean
                    && RequestedStatus.Clean
                    && SellSideDeliveredBy.Clean
                    && SellSideDeliveryDate.Clean
                    && SellSideExpirationDate.Clean
                    && SellSideNewLockExtensionDate.Clean
                    && SellSideNumDayExtended.Clean
                    && SnapshotXml.Clean
                    && SystemId.Clean
                    && TimeRequested.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alerts; v0.Clean = value; Alerts = v0;
                var v1 = AlertsXml; v1.Clean = value; AlertsXml = v1;
                var v2 = BuySideExpirationDate; v2.Clean = value; BuySideExpirationDate = v2;
                var v3 = BuySideNewLockExtensionDate; v3.Clean = value; BuySideNewLockExtensionDate = v3;
                var v4 = BuySideNumDayExtended; v4.Clean = value; BuySideNumDayExtended = v4;
                var v5 = BuySideNumDayLocked; v5.Clean = value; BuySideNumDayLocked = v5;
                var v6 = CommentList; v6.Clean = value; CommentList = v6;
                var v7 = CommentListXml; v7.Clean = value; CommentListXml = v7;
                var v8 = Comments; v8.Clean = value; Comments = v8;
                var v9 = DateUtc; v9.Clean = value; DateUtc = v9;
                var v10 = FileAttachmentsMigrated; v10.Clean = value; FileAttachmentsMigrated = v10;
                var v11 = Guid; v11.Clean = value; Guid = v11;
                var v12 = HideLogIndicator; v12.Clean = value; HideLogIndicator = v12;
                var v13 = Id; v13.Clean = value; Id = v13;
                var v14 = InvestorCommitment; v14.Clean = value; InvestorCommitment = v14;
                var v15 = IsFakeRequestIndicator; v15.Clean = value; IsFakeRequestIndicator = v15;
                var v16 = IsLockCancellationIndicator; v16.Clean = value; IsLockCancellationIndicator = v16;
                var v17 = IsLockExtensionIndicator; v17.Clean = value; IsLockExtensionIndicator = v17;
                var v18 = IsReLockIndicator; v18.Clean = value; IsReLockIndicator = v18;
                var v19 = IsSystemSpecificIndicator; v19.Clean = value; IsSystemSpecificIndicator = v19;
                var v20 = LogRecordIndex; v20.Clean = value; LogRecordIndex = v20;
                var v21 = NumDayLocked; v21.Clean = value; NumDayLocked = v21;
                var v22 = ParentLockGuid; v22.Clean = value; ParentLockGuid = v22;
                var v23 = RequestedBy; v23.Clean = value; RequestedBy = v23;
                var v24 = RequestedName; v24.Clean = value; RequestedName = v24;
                var v25 = RequestedStatus; v25.Clean = value; RequestedStatus = v25;
                var v26 = SellSideDeliveredBy; v26.Clean = value; SellSideDeliveredBy = v26;
                var v27 = SellSideDeliveryDate; v27.Clean = value; SellSideDeliveryDate = v27;
                var v28 = SellSideExpirationDate; v28.Clean = value; SellSideExpirationDate = v28;
                var v29 = SellSideNewLockExtensionDate; v29.Clean = value; SellSideNewLockExtensionDate = v29;
                var v30 = SellSideNumDayExtended; v30.Clean = value; SellSideNumDayExtended = v30;
                var v31 = SnapshotXml; v31.Clean = value; SnapshotXml = v31;
                var v32 = SystemId; v32.Clean = value; SystemId = v32;
                var v33 = TimeRequested; v33.Clean = value; TimeRequested = v33;
                _settingClean = 0;
            }
        }
    }
}