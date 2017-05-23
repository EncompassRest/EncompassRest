using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public string AlertsXml { get; set; }
        public JsonNullable<DateTime?> BuySideExpirationDate { get; set; }
        public JsonNullable<DateTime?> BuySideNewLockExtensionDate { get; set; }
        public JsonNullable<int?> BuySideNumDayExtended { get; set; }
        public JsonNullable<int?> BuySideNumDayLocked { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string CommentListXml { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public JsonNullable<bool?> HideLogIndicator { get; set; }
        public string Id { get; set; }
        public string InvestorCommitment { get; set; }
        public JsonNullable<bool?> IsFakeRequestIndicator { get; set; }
        public JsonNullable<bool?> IsLockCancellationIndicator { get; set; }
        public JsonNullable<bool?> IsLockExtensionIndicator { get; set; }
        public JsonNullable<bool?> IsReLockIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public JsonNullable<int?> NumDayLocked { get; set; }
        public string ParentLockGuid { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedName { get; set; }
        public string RequestedStatus { get; set; }
        public string SellSideDeliveredBy { get; set; }
        public JsonNullable<DateTime?> SellSideDeliveryDate { get; set; }
        public JsonNullable<DateTime?> SellSideExpirationDate { get; set; }
        public JsonNullable<DateTime?> SellSideNewLockExtensionDate { get; set; }
        public JsonNullable<int?> SellSideNumDayExtended { get; set; }
        public string SnapshotXml { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string TimeRequested { get; set; }
    }
}