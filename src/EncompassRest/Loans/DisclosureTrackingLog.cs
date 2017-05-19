using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class DisclosureTrackingLog
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public string BorrowerPairId { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public bool? ContainGfe { get; set; }
        public bool? ContainSafeHarbor { get; set; }
        public bool? ContainTil { get; set; }
        public DateTime? DateUtc { get; set; }
        public string DisclosedBy { get; set; }
        public string DisclosedByFullName { get; set; }
        public string DisclosedMethod { get; set; }
        public DateTime? DisclosureCreatedDttmUtc { get; set; }
        public bool? EDisclosureApplicationPackageIndicator { get; set; }
        public bool? EDisclosureApprovalPackageIndicator { get; set; }
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get; set; }
        public DateTime? EDisclosureBorrowereSignedDate { get; set; }
        public DateTime? EDisclosureBorrowerRejectConsentDate { get; set; }
        public DateTime? EDisclosureBorrowerViewConsentDate { get; set; }
        public DateTime? EDisclosureBorrowerViewMessageDate { get; set; }
        public DateTime? EDisclosureBorrowerWetSignedDate { get; set; }
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get; set; }
        public DateTime? EDisclosureCoBorrowereSignedDate { get; set; }
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get; set; }
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get; set; }
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get; set; }
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get; set; }
        public string EDisclosureConsentPdf { get; set; }
        public string EDisclosureDisclosedMessage { get; set; }
        public bool? EDisclosureLockPackageIndicator { get; set; }
        public string EDisclosureManualFulfillmentComment { get; set; }
        public DateTime? EDisclosureManualFulfillmentDate { get; set; }
        public string EDisclosureManualFulfillmentMethod { get; set; }
        public string EDisclosureManuallyFulfilledBy { get; set; }
        public DateTime? EDisclosurePackageCreatedDate { get; set; }
        public string EDisclosurePackageId { get; set; }
        public string EDisclosurePackageViewableFile { get; set; }
        public bool? EDisclosureThreeDayPackageIndicator { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public List<DisclosureForm> Forms { get; set; }
        public string FulfillmentOrderedBy { get; set; }
        public string FullfillmentProcessedDate { get; set; }
        public string Guid { get; set; }
        public string IsDisclosed { get; set; }
        public string IsDisclosedAprLocked { get; set; }
        public string IsDisclosedByLocked { get; set; }
        public string IsDisclosedFinanceChargeLocked { get; set; }
        public string IsDisclosedReceivedDateLocked { get; set; }
        public string IsLocked { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public bool? IsWetSignedIndicator { get; set; }
        public string LockedDisclosedAprField { get; set; }
        public string LockedDisclosedByField { get; set; }
        public string LockedDisclosedFinanceChargeField { get; set; }
        public DateTime? LockedDisclosedReceivedDate { get; set; }
        public int? LogRecordIndex { get; set; }
        public string ManuallyCreated { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public List<LogSnapshotField> SnapshotFields { get; set; }
        public string SystemId { get; set; }
        public string FormsXml { get; set; }
        public string SnapshotXml { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string BorrowerName { get; set; }
        public string CoBorrowerName { get; set; }
        public string DisclosedAPR { get; set; }
        public string FinanceCharge { get; set; }
        public string LoanProgram { get; set; }
        public string LoanAmount { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZip { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
    }
}