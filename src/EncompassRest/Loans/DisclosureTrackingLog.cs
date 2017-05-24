using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTrackingLog
    {
        public Value<List<LogAlert>> Alerts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !Alerts.Clean;
        public Value<string> AlertsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !AlertsXml.Clean;
        public Value<DateTime?> ApplicationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationDate() => !ApplicationDate.Clean;
        public Value<string> BorrowerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerName() => !BorrowerName.Clean;
        public Value<string> BorrowerPairId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPairId() => !BorrowerPairId.Clean;
        public Value<string> CoBorrowerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerName() => !CoBorrowerName.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> CommentListXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !CommentListXml.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<bool?> ContainGfe { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainGfe() => !ContainGfe.Clean;
        public Value<bool?> ContainSafeHarbor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainSafeHarbor() => !ContainSafeHarbor.Clean;
        public Value<bool?> ContainTil { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainTil() => !ContainTil.Clean;
        public Value<DateTime?> DateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !DateUtc.Clean;
        public Value<string> DisclosedAPR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedAPR() => !DisclosedAPR.Clean;
        public Value<string> DisclosedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedBy() => !DisclosedBy.Clean;
        public Value<string> DisclosedByFullName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedByFullName() => !DisclosedByFullName.Clean;
        public Value<string> DisclosedMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedMethod() => !DisclosedMethod.Clean;
        public Value<DateTime?> DisclosureCreatedDttmUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureCreatedDttmUtc() => !DisclosureCreatedDttmUtc.Clean;
        public Value<bool?> EDisclosureApplicationPackageIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureApplicationPackageIndicator() => !EDisclosureApplicationPackageIndicator.Clean;
        public Value<bool?> EDisclosureApprovalPackageIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureApprovalPackageIndicator() => !EDisclosureApprovalPackageIndicator.Clean;
        public Value<DateTime?> EDisclosureBorrowerAcceptConsentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerAcceptConsentDate() => !EDisclosureBorrowerAcceptConsentDate.Clean;
        public Value<DateTime?> EDisclosureBorrowereSignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowereSignedDate() => !EDisclosureBorrowereSignedDate.Clean;
        public Value<DateTime?> EDisclosureBorrowerRejectConsentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerRejectConsentDate() => !EDisclosureBorrowerRejectConsentDate.Clean;
        public Value<DateTime?> EDisclosureBorrowerViewConsentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerViewConsentDate() => !EDisclosureBorrowerViewConsentDate.Clean;
        public Value<DateTime?> EDisclosureBorrowerViewMessageDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerViewMessageDate() => !EDisclosureBorrowerViewMessageDate.Clean;
        public Value<DateTime?> EDisclosureBorrowerWetSignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerWetSignedDate() => !EDisclosureBorrowerWetSignedDate.Clean;
        public Value<DateTime?> EDisclosureCoBorrowerAcceptConsentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerAcceptConsentDate() => !EDisclosureCoBorrowerAcceptConsentDate.Clean;
        public Value<DateTime?> EDisclosureCoBorrowereSignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowereSignedDate() => !EDisclosureCoBorrowereSignedDate.Clean;
        public Value<DateTime?> EDisclosureCoBorrowerRejectConsentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerRejectConsentDate() => !EDisclosureCoBorrowerRejectConsentDate.Clean;
        public Value<DateTime?> EDisclosureCoBorrowerViewConsentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerViewConsentDate() => !EDisclosureCoBorrowerViewConsentDate.Clean;
        public Value<DateTime?> EDisclosureCoBorrowerViewMessageDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerViewMessageDate() => !EDisclosureCoBorrowerViewMessageDate.Clean;
        public Value<DateTime?> EDisclosureCoBorrowerWebSignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerWebSignedDate() => !EDisclosureCoBorrowerWebSignedDate.Clean;
        public Value<string> EDisclosureConsentPdf { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureConsentPdf() => !EDisclosureConsentPdf.Clean;
        public Value<string> EDisclosureDisclosedMessage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureDisclosedMessage() => !EDisclosureDisclosedMessage.Clean;
        public Value<bool?> EDisclosureLockPackageIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureLockPackageIndicator() => !EDisclosureLockPackageIndicator.Clean;
        public Value<string> EDisclosureManualFulfillmentComment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManualFulfillmentComment() => !EDisclosureManualFulfillmentComment.Clean;
        public Value<DateTime?> EDisclosureManualFulfillmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManualFulfillmentDate() => !EDisclosureManualFulfillmentDate.Clean;
        public Value<string> EDisclosureManualFulfillmentMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManualFulfillmentMethod() => !EDisclosureManualFulfillmentMethod.Clean;
        public Value<string> EDisclosureManuallyFulfilledBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManuallyFulfilledBy() => !EDisclosureManuallyFulfilledBy.Clean;
        public Value<DateTime?> EDisclosurePackageCreatedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosurePackageCreatedDate() => !EDisclosurePackageCreatedDate.Clean;
        public Value<string> EDisclosurePackageId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosurePackageId() => !EDisclosurePackageId.Clean;
        public Value<string> EDisclosurePackageViewableFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosurePackageViewableFile() => !EDisclosurePackageViewableFile.Clean;
        public Value<bool?> EDisclosureThreeDayPackageIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureThreeDayPackageIndicator() => !EDisclosureThreeDayPackageIndicator.Clean;
        public Value<bool?> FileAttachmentsMigrated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !FileAttachmentsMigrated.Clean;
        public Value<string> FinanceCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinanceCharge() => !FinanceCharge.Clean;
        public Value<List<DisclosureForm>> Forms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForms() => !Forms.Clean;
        public Value<string> FormsXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormsXml() => !FormsXml.Clean;
        public Value<string> FulfillmentOrderedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFulfillmentOrderedBy() => !FulfillmentOrderedBy.Clean;
        public Value<string> FullfillmentProcessedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullfillmentProcessedDate() => !FullfillmentProcessedDate.Clean;
        public Value<string> Guid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !Guid.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IsDisclosed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosed() => !IsDisclosed.Clean;
        public Value<string> IsDisclosedAprLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedAprLocked() => !IsDisclosedAprLocked.Clean;
        public Value<string> IsDisclosedByLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedByLocked() => !IsDisclosedByLocked.Clean;
        public Value<string> IsDisclosedFinanceChargeLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedFinanceChargeLocked() => !IsDisclosedFinanceChargeLocked.Clean;
        public Value<string> IsDisclosedReceivedDateLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedReceivedDateLocked() => !IsDisclosedReceivedDateLocked.Clean;
        public Value<string> IsLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsLocked() => !IsLocked.Clean;
        public Value<bool?> IsSystemSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !IsSystemSpecificIndicator.Clean;
        public Value<bool?> IsWetSignedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsWetSignedIndicator() => !IsWetSignedIndicator.Clean;
        public Value<string> LoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmount() => !LoanAmount.Clean;
        public Value<string> LoanProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgram() => !LoanProgram.Clean;
        public Value<string> LockedDisclosedAprField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedAprField() => !LockedDisclosedAprField.Clean;
        public Value<string> LockedDisclosedByField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedByField() => !LockedDisclosedByField.Clean;
        public Value<string> LockedDisclosedFinanceChargeField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedFinanceChargeField() => !LockedDisclosedFinanceChargeField.Clean;
        public Value<DateTime?> LockedDisclosedReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedReceivedDate() => !LockedDisclosedReceivedDate.Clean;
        public Value<int?> LogRecordIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !LogRecordIndex.Clean;
        public Value<string> ManuallyCreated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManuallyCreated() => !ManuallyCreated.Clean;
        public Value<string> PropertyAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyAddress() => !PropertyAddress.Clean;
        public Value<string> PropertyCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyCity() => !PropertyCity.Clean;
        public Value<string> PropertyState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyState() => !PropertyState.Clean;
        public Value<string> PropertyZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyZip() => !PropertyZip.Clean;
        public Value<DateTime?> ReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedDate() => !ReceivedDate.Clean;
        public Value<List<LogSnapshotField>> SnapshotFields { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSnapshotFields() => !SnapshotFields.Clean;
        public Value<string> SnapshotXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSnapshotXml() => !SnapshotXml.Clean;
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
                    && AlertsXml.Clean
                    && ApplicationDate.Clean
                    && BorrowerName.Clean
                    && BorrowerPairId.Clean
                    && CoBorrowerName.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && ContainGfe.Clean
                    && ContainSafeHarbor.Clean
                    && ContainTil.Clean
                    && DateUtc.Clean
                    && DisclosedAPR.Clean
                    && DisclosedBy.Clean
                    && DisclosedByFullName.Clean
                    && DisclosedMethod.Clean
                    && DisclosureCreatedDttmUtc.Clean
                    && EDisclosureApplicationPackageIndicator.Clean
                    && EDisclosureApprovalPackageIndicator.Clean
                    && EDisclosureBorrowerAcceptConsentDate.Clean
                    && EDisclosureBorrowereSignedDate.Clean
                    && EDisclosureBorrowerRejectConsentDate.Clean
                    && EDisclosureBorrowerViewConsentDate.Clean
                    && EDisclosureBorrowerViewMessageDate.Clean
                    && EDisclosureBorrowerWetSignedDate.Clean
                    && EDisclosureCoBorrowerAcceptConsentDate.Clean
                    && EDisclosureCoBorrowereSignedDate.Clean
                    && EDisclosureCoBorrowerRejectConsentDate.Clean
                    && EDisclosureCoBorrowerViewConsentDate.Clean
                    && EDisclosureCoBorrowerViewMessageDate.Clean
                    && EDisclosureCoBorrowerWebSignedDate.Clean
                    && EDisclosureConsentPdf.Clean
                    && EDisclosureDisclosedMessage.Clean
                    && EDisclosureLockPackageIndicator.Clean
                    && EDisclosureManualFulfillmentComment.Clean
                    && EDisclosureManualFulfillmentDate.Clean
                    && EDisclosureManualFulfillmentMethod.Clean
                    && EDisclosureManuallyFulfilledBy.Clean
                    && EDisclosurePackageCreatedDate.Clean
                    && EDisclosurePackageId.Clean
                    && EDisclosurePackageViewableFile.Clean
                    && EDisclosureThreeDayPackageIndicator.Clean
                    && FileAttachmentsMigrated.Clean
                    && FinanceCharge.Clean
                    && Forms.Clean
                    && FormsXml.Clean
                    && FulfillmentOrderedBy.Clean
                    && FullfillmentProcessedDate.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IsDisclosed.Clean
                    && IsDisclosedAprLocked.Clean
                    && IsDisclosedByLocked.Clean
                    && IsDisclosedFinanceChargeLocked.Clean
                    && IsDisclosedReceivedDateLocked.Clean
                    && IsLocked.Clean
                    && IsSystemSpecificIndicator.Clean
                    && IsWetSignedIndicator.Clean
                    && LoanAmount.Clean
                    && LoanProgram.Clean
                    && LockedDisclosedAprField.Clean
                    && LockedDisclosedByField.Clean
                    && LockedDisclosedFinanceChargeField.Clean
                    && LockedDisclosedReceivedDate.Clean
                    && LogRecordIndex.Clean
                    && ManuallyCreated.Clean
                    && PropertyAddress.Clean
                    && PropertyCity.Clean
                    && PropertyState.Clean
                    && PropertyZip.Clean
                    && ReceivedDate.Clean
                    && SnapshotFields.Clean
                    && SnapshotXml.Clean
                    && SystemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alerts; v0.Clean = value; Alerts = v0;
                var v1 = AlertsXml; v1.Clean = value; AlertsXml = v1;
                var v2 = ApplicationDate; v2.Clean = value; ApplicationDate = v2;
                var v3 = BorrowerName; v3.Clean = value; BorrowerName = v3;
                var v4 = BorrowerPairId; v4.Clean = value; BorrowerPairId = v4;
                var v5 = CoBorrowerName; v5.Clean = value; CoBorrowerName = v5;
                var v6 = CommentList; v6.Clean = value; CommentList = v6;
                var v7 = CommentListXml; v7.Clean = value; CommentListXml = v7;
                var v8 = Comments; v8.Clean = value; Comments = v8;
                var v9 = ContainGfe; v9.Clean = value; ContainGfe = v9;
                var v10 = ContainSafeHarbor; v10.Clean = value; ContainSafeHarbor = v10;
                var v11 = ContainTil; v11.Clean = value; ContainTil = v11;
                var v12 = DateUtc; v12.Clean = value; DateUtc = v12;
                var v13 = DisclosedAPR; v13.Clean = value; DisclosedAPR = v13;
                var v14 = DisclosedBy; v14.Clean = value; DisclosedBy = v14;
                var v15 = DisclosedByFullName; v15.Clean = value; DisclosedByFullName = v15;
                var v16 = DisclosedMethod; v16.Clean = value; DisclosedMethod = v16;
                var v17 = DisclosureCreatedDttmUtc; v17.Clean = value; DisclosureCreatedDttmUtc = v17;
                var v18 = EDisclosureApplicationPackageIndicator; v18.Clean = value; EDisclosureApplicationPackageIndicator = v18;
                var v19 = EDisclosureApprovalPackageIndicator; v19.Clean = value; EDisclosureApprovalPackageIndicator = v19;
                var v20 = EDisclosureBorrowerAcceptConsentDate; v20.Clean = value; EDisclosureBorrowerAcceptConsentDate = v20;
                var v21 = EDisclosureBorrowereSignedDate; v21.Clean = value; EDisclosureBorrowereSignedDate = v21;
                var v22 = EDisclosureBorrowerRejectConsentDate; v22.Clean = value; EDisclosureBorrowerRejectConsentDate = v22;
                var v23 = EDisclosureBorrowerViewConsentDate; v23.Clean = value; EDisclosureBorrowerViewConsentDate = v23;
                var v24 = EDisclosureBorrowerViewMessageDate; v24.Clean = value; EDisclosureBorrowerViewMessageDate = v24;
                var v25 = EDisclosureBorrowerWetSignedDate; v25.Clean = value; EDisclosureBorrowerWetSignedDate = v25;
                var v26 = EDisclosureCoBorrowerAcceptConsentDate; v26.Clean = value; EDisclosureCoBorrowerAcceptConsentDate = v26;
                var v27 = EDisclosureCoBorrowereSignedDate; v27.Clean = value; EDisclosureCoBorrowereSignedDate = v27;
                var v28 = EDisclosureCoBorrowerRejectConsentDate; v28.Clean = value; EDisclosureCoBorrowerRejectConsentDate = v28;
                var v29 = EDisclosureCoBorrowerViewConsentDate; v29.Clean = value; EDisclosureCoBorrowerViewConsentDate = v29;
                var v30 = EDisclosureCoBorrowerViewMessageDate; v30.Clean = value; EDisclosureCoBorrowerViewMessageDate = v30;
                var v31 = EDisclosureCoBorrowerWebSignedDate; v31.Clean = value; EDisclosureCoBorrowerWebSignedDate = v31;
                var v32 = EDisclosureConsentPdf; v32.Clean = value; EDisclosureConsentPdf = v32;
                var v33 = EDisclosureDisclosedMessage; v33.Clean = value; EDisclosureDisclosedMessage = v33;
                var v34 = EDisclosureLockPackageIndicator; v34.Clean = value; EDisclosureLockPackageIndicator = v34;
                var v35 = EDisclosureManualFulfillmentComment; v35.Clean = value; EDisclosureManualFulfillmentComment = v35;
                var v36 = EDisclosureManualFulfillmentDate; v36.Clean = value; EDisclosureManualFulfillmentDate = v36;
                var v37 = EDisclosureManualFulfillmentMethod; v37.Clean = value; EDisclosureManualFulfillmentMethod = v37;
                var v38 = EDisclosureManuallyFulfilledBy; v38.Clean = value; EDisclosureManuallyFulfilledBy = v38;
                var v39 = EDisclosurePackageCreatedDate; v39.Clean = value; EDisclosurePackageCreatedDate = v39;
                var v40 = EDisclosurePackageId; v40.Clean = value; EDisclosurePackageId = v40;
                var v41 = EDisclosurePackageViewableFile; v41.Clean = value; EDisclosurePackageViewableFile = v41;
                var v42 = EDisclosureThreeDayPackageIndicator; v42.Clean = value; EDisclosureThreeDayPackageIndicator = v42;
                var v43 = FileAttachmentsMigrated; v43.Clean = value; FileAttachmentsMigrated = v43;
                var v44 = FinanceCharge; v44.Clean = value; FinanceCharge = v44;
                var v45 = Forms; v45.Clean = value; Forms = v45;
                var v46 = FormsXml; v46.Clean = value; FormsXml = v46;
                var v47 = FulfillmentOrderedBy; v47.Clean = value; FulfillmentOrderedBy = v47;
                var v48 = FullfillmentProcessedDate; v48.Clean = value; FullfillmentProcessedDate = v48;
                var v49 = Guid; v49.Clean = value; Guid = v49;
                var v50 = Id; v50.Clean = value; Id = v50;
                var v51 = IsDisclosed; v51.Clean = value; IsDisclosed = v51;
                var v52 = IsDisclosedAprLocked; v52.Clean = value; IsDisclosedAprLocked = v52;
                var v53 = IsDisclosedByLocked; v53.Clean = value; IsDisclosedByLocked = v53;
                var v54 = IsDisclosedFinanceChargeLocked; v54.Clean = value; IsDisclosedFinanceChargeLocked = v54;
                var v55 = IsDisclosedReceivedDateLocked; v55.Clean = value; IsDisclosedReceivedDateLocked = v55;
                var v56 = IsLocked; v56.Clean = value; IsLocked = v56;
                var v57 = IsSystemSpecificIndicator; v57.Clean = value; IsSystemSpecificIndicator = v57;
                var v58 = IsWetSignedIndicator; v58.Clean = value; IsWetSignedIndicator = v58;
                var v59 = LoanAmount; v59.Clean = value; LoanAmount = v59;
                var v60 = LoanProgram; v60.Clean = value; LoanProgram = v60;
                var v61 = LockedDisclosedAprField; v61.Clean = value; LockedDisclosedAprField = v61;
                var v62 = LockedDisclosedByField; v62.Clean = value; LockedDisclosedByField = v62;
                var v63 = LockedDisclosedFinanceChargeField; v63.Clean = value; LockedDisclosedFinanceChargeField = v63;
                var v64 = LockedDisclosedReceivedDate; v64.Clean = value; LockedDisclosedReceivedDate = v64;
                var v65 = LogRecordIndex; v65.Clean = value; LogRecordIndex = v65;
                var v66 = ManuallyCreated; v66.Clean = value; ManuallyCreated = v66;
                var v67 = PropertyAddress; v67.Clean = value; PropertyAddress = v67;
                var v68 = PropertyCity; v68.Clean = value; PropertyCity = v68;
                var v69 = PropertyState; v69.Clean = value; PropertyState = v69;
                var v70 = PropertyZip; v70.Clean = value; PropertyZip = v70;
                var v71 = ReceivedDate; v71.Clean = value; ReceivedDate = v71;
                var v72 = SnapshotFields; v72.Clean = value; SnapshotFields = v72;
                var v73 = SnapshotXml; v73.Clean = value; SnapshotXml = v73;
                var v74 = SystemId; v74.Clean = value; SystemId = v74;
                _settingClean = 0;
            }
        }
    }
}