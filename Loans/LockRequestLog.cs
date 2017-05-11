using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LockRequestLog
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public DateTime? BuySideExpirationDate { get; set; }
        public DateTime? BuySideNewLockExtensionDate { get; set; }
        public int? BuySideNumDayExtended { get; set; }
        public int? BuySideNumDayLocked { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public DateTime? DateUtc { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? HideLogIndicator { get; set; }
        public bool? IsFakeRequestIndicator { get; set; }
        public bool? IsLockCancellationIndicator { get; set; }
        public bool? IsLockExtensionIndicator { get; set; }
        public bool? IsReLockIndicator { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public int? NumDayLocked { get; set; }
        public string ParentLockGuid { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedName { get; set; }
        public string RequestedStatus { get; set; }
        public string SellSideDeliveredBy { get; set; }
        public DateTime? SellSideDeliveryDate { get; set; }
        public DateTime? SellSideExpirationDate { get; set; }
        public DateTime? SellSideNewLockExtensionDate { get; set; }
        public int? SellSideNumDayExtended { get; set; }
        public string SystemId { get; set; }
        public string TimeRequested { get; set; }
        public string InvestorCommitment { get; set; }
        public string SnapshotXml { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
    }
}