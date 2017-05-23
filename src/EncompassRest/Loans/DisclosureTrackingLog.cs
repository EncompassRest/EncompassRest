using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTrackingLog
    {
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public string AlertsXml { get; set; }
        public JsonNullable<DateTime?> ApplicationDate { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowerPairId { get; set; }
        public string CoBorrowerName { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string CommentListXml { get; set; }
        public string Comments { get; set; }
        public JsonNullable<bool?> ContainGfe { get; set; }
        public JsonNullable<bool?> ContainSafeHarbor { get; set; }
        public JsonNullable<bool?> ContainTil { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public string DisclosedAPR { get; set; }
        public string DisclosedBy { get; set; }
        public string DisclosedByFullName { get; set; }
        public string DisclosedMethod { get; set; }
        public JsonNullable<DateTime?> DisclosureCreatedDttmUtc { get; set; }
        public JsonNullable<bool?> EDisclosureApplicationPackageIndicator { get; set; }
        public JsonNullable<bool?> EDisclosureApprovalPackageIndicator { get; set; }
        public JsonNullable<DateTime?> EDisclosureBorrowerAcceptConsentDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureBorrowereSignedDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureBorrowerRejectConsentDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureBorrowerViewConsentDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureBorrowerViewMessageDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureBorrowerWetSignedDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureCoBorrowerAcceptConsentDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureCoBorrowereSignedDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureCoBorrowerRejectConsentDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureCoBorrowerViewConsentDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureCoBorrowerViewMessageDate { get; set; }
        public JsonNullable<DateTime?> EDisclosureCoBorrowerWebSignedDate { get; set; }
        public string EDisclosureConsentPdf { get; set; }
        public string EDisclosureDisclosedMessage { get; set; }
        public JsonNullable<bool?> EDisclosureLockPackageIndicator { get; set; }
        public string EDisclosureManualFulfillmentComment { get; set; }
        public JsonNullable<DateTime?> EDisclosureManualFulfillmentDate { get; set; }
        public string EDisclosureManualFulfillmentMethod { get; set; }
        public string EDisclosureManuallyFulfilledBy { get; set; }
        public JsonNullable<DateTime?> EDisclosurePackageCreatedDate { get; set; }
        public string EDisclosurePackageId { get; set; }
        public string EDisclosurePackageViewableFile { get; set; }
        public JsonNullable<bool?> EDisclosureThreeDayPackageIndicator { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public string FinanceCharge { get; set; }
        public JsonNullable<List<DisclosureForm>> Forms { get; set; }
        public string FormsXml { get; set; }
        public string FulfillmentOrderedBy { get; set; }
        public string FullfillmentProcessedDate { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public string IsDisclosed { get; set; }
        public string IsDisclosedAprLocked { get; set; }
        public string IsDisclosedByLocked { get; set; }
        public string IsDisclosedFinanceChargeLocked { get; set; }
        public string IsDisclosedReceivedDateLocked { get; set; }
        public string IsLocked { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public JsonNullable<bool?> IsWetSignedIndicator { get; set; }
        public string LoanAmount { get; set; }
        public string LoanProgram { get; set; }
        public string LockedDisclosedAprField { get; set; }
        public string LockedDisclosedByField { get; set; }
        public string LockedDisclosedFinanceChargeField { get; set; }
        public JsonNullable<DateTime?> LockedDisclosedReceivedDate { get; set; }
        public int? LogRecordIndex { get; set; }
        public string ManuallyCreated { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZip { get; set; }
        public JsonNullable<DateTime?> ReceivedDate { get; set; }
        public JsonNullable<List<LogSnapshotField>> SnapshotFields { get; set; }
        public string SnapshotXml { get; set; }
        public JsonNullable<string> SystemId { get; set; }
    }
}