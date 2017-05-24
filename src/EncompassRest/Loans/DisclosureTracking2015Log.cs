using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTracking2015Log
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
        public Value<string> AppliedCureAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppliedCureAmount() => !AppliedCureAmount.Clean;
        public Value<DateTime?> BorrowerActualReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerActualReceivedDate() => !BorrowerActualReceivedDate.Clean;
        public Value<string> BorrowerDisclosedMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDisclosedMethod() => !BorrowerDisclosedMethod.Clean;
        public Value<string> BorrowerDisclosedMethodOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDisclosedMethodOther() => !BorrowerDisclosedMethodOther.Clean;
        public Value<string> BorrowerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerName() => !BorrowerName.Clean;
        public Value<string> BorrowerPairId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPairId() => !BorrowerPairId.Clean;
        public Value<DateTime?> BorrowerPresumedReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPresumedReceivedDate() => !BorrowerPresumedReceivedDate.Clean;
        public Value<string> BorrowerType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerType() => !BorrowerType.Clean;
        public Value<bool?> CDReasonIs24HourAdvancePreview { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIs24HourAdvancePreview() => !CDReasonIs24HourAdvancePreview.Clean;
        public Value<bool?> CDReasonIsChangeInAPR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsChangeInAPR() => !CDReasonIsChangeInAPR.Clean;
        public Value<bool?> CDReasonIsChangeInLoanProduct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsChangeInLoanProduct() => !CDReasonIsChangeInLoanProduct.Clean;
        public Value<bool?> CDReasonIsChangeInSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsChangeInSettlementCharges() => !CDReasonIsChangeInSettlementCharges.Clean;
        public Value<bool?> CDReasonIsClericalErrorCorrection { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsClericalErrorCorrection() => !CDReasonIsClericalErrorCorrection.Clean;
        public Value<bool?> CDReasonIsOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsOther() => !CDReasonIsOther.Clean;
        public Value<bool?> CDReasonIsPrepaymentPenaltyAdded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsPrepaymentPenaltyAdded() => !CDReasonIsPrepaymentPenaltyAdded.Clean;
        public Value<bool?> CDReasonIsToleranceCure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsToleranceCure() => !CDReasonIsToleranceCure.Clean;
        public Value<string> CDReasonOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonOther() => !CDReasonOther.Clean;
        public Value<string> ChangeInCircumstance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangeInCircumstance() => !ChangeInCircumstance.Clean;
        public Value<string> ChangeInCircumstanceComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangeInCircumstanceComments() => !ChangeInCircumstanceComments.Clean;
        public Value<string> ChargesCannotIncrease10Itemization34 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesCannotIncrease10Itemization34() => !ChargesCannotIncrease10Itemization34.Clean;
        public Value<string> ChargesCannotIncrease10LE32 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesCannotIncrease10LE32() => !ChargesCannotIncrease10LE32.Clean;
        public Value<string> ChargesThatCannotDecreaseItemization9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotDecreaseItemization9() => !ChargesThatCannotDecreaseItemization9.Clean;
        public Value<string> ChargesThatCannotDecreaseLE7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotDecreaseLE7() => !ChargesThatCannotDecreaseLE7.Clean;
        public Value<string> ChargesThatCannotIncreaseItemization13 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotIncreaseItemization13() => !ChargesThatCannotIncreaseItemization13.Clean;
        public Value<string> ChargesThatCannotIncreaseLE11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotIncreaseLE11() => !ChargesThatCannotIncreaseLE11.Clean;
        public Value<DateTime?> CoBorrowerActualReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerActualReceivedDate() => !CoBorrowerActualReceivedDate.Clean;
        public Value<string> CoBorrowerDisclosedMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerDisclosedMethod() => !CoBorrowerDisclosedMethod.Clean;
        public Value<string> CoBorrowerDisclosedMethodOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerDisclosedMethodOther() => !CoBorrowerDisclosedMethodOther.Clean;
        public Value<string> CoBorrowerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerName() => !CoBorrowerName.Clean;
        public Value<DateTime?> CoBorrowerPresumedReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerPresumedReceivedDate() => !CoBorrowerPresumedReceivedDate.Clean;
        public Value<string> CoBorrowerType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerType() => !CoBorrowerType.Clean;
        public Value<List<LogComment>> CommentList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !CommentList.Clean;
        public Value<string> CommentListXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !CommentListXml.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<bool?> ContainCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainCD() => !ContainCD.Clean;
        public Value<bool?> ContainLE { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainLE() => !ContainLE.Clean;
        public Value<bool?> ContainSafeHarbor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainSafeHarbor() => !ContainSafeHarbor.Clean;
        public Value<DateTime?> DateAdded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAdded() => !DateAdded.Clean;
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
        public Value<string> DisclosedDailyInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedDailyInterest() => !DisclosedDailyInterest.Clean;
        public Value<DateTime?> DisclosedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedDate() => !DisclosedDate.Clean;
        public Value<bool?> DisclosedForCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedForCD() => !DisclosedForCD.Clean;
        public Value<string> DisclosedMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedMethod() => !DisclosedMethod.Clean;
        public Value<string> DisclosedMethodName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedMethodName() => !DisclosedMethodName.Clean;
        public Value<string> DisclosedMethodOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedMethodOther() => !DisclosedMethodOther.Clean;
        public Value<DateTime?> DisclosureCreatedDttmUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureCreatedDttmUtc() => !DisclosureCreatedDttmUtc.Clean;
        public Value<string> DisclosureMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureMethod() => !DisclosureMethod.Clean;
        public Value<string> DisclosureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureType() => !DisclosureType.Clean;
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
        public Value<string> EstimatedTotalPayoffsAndPaymentsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTotalPayoffsAndPaymentsAmount() => !EstimatedTotalPayoffsAndPaymentsAmount.Clean;
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
        public Value<bool?> IntentToProceed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceed() => !IntentToProceed.Clean;
        public Value<string> IntentToProceedComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedComments() => !IntentToProceedComments.Clean;
        public Value<DateTime?> IntentToProceedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedDate() => !IntentToProceedDate.Clean;
        public Value<string> IntentToProceedReceivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedReceivedBy() => !IntentToProceedReceivedBy.Clean;
        public Value<string> IntentToProceedReceivedMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedReceivedMethod() => !IntentToProceedReceivedMethod.Clean;
        public Value<string> IntentToProceedReceivedMethodOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedReceivedMethodOther() => !IntentToProceedReceivedMethodOther.Clean;
        public Value<bool?> IsBorrowerPresumedDateLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsBorrowerPresumedDateLocked() => !IsBorrowerPresumedDateLocked.Clean;
        public Value<bool?> IsCoBorrowerPresumedDateLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsCoBorrowerPresumedDateLocked() => !IsCoBorrowerPresumedDateLocked.Clean;
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
        public Value<string> LenderCompensationCreditAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCompensationCreditAmount2() => !LenderCompensationCreditAmount2.Clean;
        public Value<string> LenderTotalPaidOriginatorAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderTotalPaidOriginatorAmount() => !LenderTotalPaidOriginatorAmount.Clean;
        public Value<bool?> LEReasonIsChangedCircumstanceEligibility { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsChangedCircumstanceEligibility() => !LEReasonIsChangedCircumstanceEligibility.Clean;
        public Value<bool?> LEReasonIsChangedCircumstanceSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsChangedCircumstanceSettlementCharges() => !LEReasonIsChangedCircumstanceSettlementCharges.Clean;
        public Value<bool?> LEReasonIsDelayedSettlementOnConstructionLoans { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsDelayedSettlementOnConstructionLoans() => !LEReasonIsDelayedSettlementOnConstructionLoans.Clean;
        public Value<bool?> LEReasonIsExpiration { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsExpiration() => !LEReasonIsExpiration.Clean;
        public Value<bool?> LEReasonIsInterestRateDependentCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsInterestRateDependentCharges() => !LEReasonIsInterestRateDependentCharges.Clean;
        public Value<bool?> LEReasonIsOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsOther() => !LEReasonIsOther.Clean;
        public Value<bool?> LEReasonIsRevisionsRequestedByConsumer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsRevisionsRequestedByConsumer() => !LEReasonIsRevisionsRequestedByConsumer.Clean;
        public Value<string> LEReasonOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonOther() => !LEReasonOther.Clean;
        public Value<string> Line802LOCompAdditionalAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine802LOCompAdditionalAmount1() => !Line802LOCompAdditionalAmount1.Clean;
        public Value<string> Line802LOCompAdditionalAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine802LOCompAdditionalAmount2() => !Line802LOCompAdditionalAmount2.Clean;
        public Value<string> Line907InsuranceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine907InsuranceIndicator2015() => !Line907InsuranceIndicator2015.Clean;
        public Value<string> Line907PropertyIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine907PropertyIndicator2015() => !Line907PropertyIndicator2015.Clean;
        public Value<string> Line907TaxesIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine907TaxesIndicator2015() => !Line907TaxesIndicator2015.Clean;
        public Value<string> Line908InsuranceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine908InsuranceIndicator2015() => !Line908InsuranceIndicator2015.Clean;
        public Value<string> Line908PropertyIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine908PropertyIndicator2015() => !Line908PropertyIndicator2015.Clean;
        public Value<string> Line908TaxesIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine908TaxesIndicator2015() => !Line908TaxesIndicator2015.Clean;
        public Value<string> Line909InsuranceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine909InsuranceIndicator2015() => !Line909InsuranceIndicator2015.Clean;
        public Value<string> Line909PropertyIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine909PropertyIndicator2015() => !Line909PropertyIndicator2015.Clean;
        public Value<string> Line909TaxesIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine909TaxesIndicator2015() => !Line909TaxesIndicator2015.Clean;
        public Value<string> Line910InsuranceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine910InsuranceIndicator2015() => !Line910InsuranceIndicator2015.Clean;
        public Value<string> Line910PropertyIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine910PropertyIndicator2015() => !Line910PropertyIndicator2015.Clean;
        public Value<string> Line910TaxesIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine910TaxesIndicator2015() => !Line910TaxesIndicator2015.Clean;
        public Value<string> Line911InsuranceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine911InsuranceIndicator2015() => !Line911InsuranceIndicator2015.Clean;
        public Value<string> Line911PropertyIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine911PropertyIndicator2015() => !Line911PropertyIndicator2015.Clean;
        public Value<string> Line911TaxesIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine911TaxesIndicator2015() => !Line911TaxesIndicator2015.Clean;
        public Value<string> Line912InsuranceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine912InsuranceIndicator2015() => !Line912InsuranceIndicator2015.Clean;
        public Value<string> Line912PropertyIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine912PropertyIndicator2015() => !Line912PropertyIndicator2015.Clean;
        public Value<string> Line912TaxesIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine912TaxesIndicator2015() => !Line912TaxesIndicator2015.Clean;
        public Value<string> LoanAdjustmentsOtherCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAdjustmentsOtherCredits() => !LoanAdjustmentsOtherCredits.Clean;
        public Value<string> LoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmount() => !LoanAmount.Clean;
        public Value<string> LoanClosingCost2BorrowerClosingCostAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2BorrowerClosingCostAtClosing() => !LoanClosingCost2BorrowerClosingCostAtClosing.Clean;
        public Value<string> LoanClosingCost2LenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2LenderCredits() => !LoanClosingCost2LenderCredits.Clean;
        public Value<string> LoanClosingCost2TotalLoanCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2TotalLoanCost() => !LoanClosingCost2TotalLoanCost.Clean;
        public Value<string> LoanClosingCost2TotalOtherCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2TotalOtherCost() => !LoanClosingCost2TotalOtherCost.Clean;
        public Value<string> LoanClosingCost3StdLegalLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost3StdLegalLimit() => !LoanClosingCost3StdLegalLimit.Clean;
        public Value<string> LoanClosingCostGfe1200BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostGfe1200BorPaidAmount() => !LoanClosingCostGfe1200BorPaidAmount.Clean;
        public Value<string> LoanClosingCostGfe800BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostGfe800BorPaidAmount() => !LoanClosingCostGfe800BorPaidAmount.Clean;
        public Value<string> LoanClosingCostLenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostLenderCredits() => !LoanClosingCostLenderCredits.Clean;
        public Value<string> LoanClosingCostSection1000BorrowerTotalPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostSection1000BorrowerTotalPaidAmount() => !LoanClosingCostSection1000BorrowerTotalPaidAmount.Clean;
        public Value<string> LoanClosingCostsFinanced { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostsFinanced() => !LoanClosingCostsFinanced.Clean;
        public Value<string> LoanClosingCostTotalFeeAmount2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostTotalFeeAmount2015() => !LoanClosingCostTotalFeeAmount2015.Clean;
        public Value<string> LoanDownPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDownPayment() => !LoanDownPayment.Clean;
        public Value<string> LoanEstimate2TotalLoanAndOtherCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2TotalLoanAndOtherCosts() => !LoanEstimate2TotalLoanAndOtherCosts.Clean;
        public Value<string> LoanEstimate2TotalLoanCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2TotalLoanCosts() => !LoanEstimate2TotalLoanCosts.Clean;
        public Value<string> LoanEstimate2TotalOtherCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2TotalOtherCosts() => !LoanEstimate2TotalOtherCosts.Clean;
        public Value<string> LoanEstimate2UnroundedTotalLoanCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2UnroundedTotalLoanCosts() => !LoanEstimate2UnroundedTotalLoanCosts.Clean;
        public Value<string> LoanEstimate2UnroundedTotalOtherCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2UnroundedTotalOtherCosts() => !LoanEstimate2UnroundedTotalOtherCosts.Clean;
        public Value<string> LoanEstimateLoanProduct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimateLoanProduct() => !LoanEstimateLoanProduct.Clean;
        public Value<string> LoanFeesCityTaxBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFeesCityTaxBorPaidAmount() => !LoanFeesCityTaxBorPaidAmount.Clean;
        public Value<string> LoanFeesStateTaxBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFeesStateTaxBorPaidAmount() => !LoanFeesStateTaxBorPaidAmount.Clean;
        public Value<string> LoanFundsForBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFundsForBorrower() => !LoanFundsForBorrower.Clean;
        public Value<string> LoanGfeAgregateAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanGfeAgregateAdjustment() => !LoanGfeAgregateAdjustment.Clean;
        public Value<string> LoanGfeGovermentRecordingCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanGfeGovermentRecordingCharges() => !LoanGfeGovermentRecordingCharges.Clean;
        public Value<string> LoanLineItemAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLineItemAmount() => !LoanLineItemAmount.Clean;
        public Value<string> LoanProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgram() => !LoanProgram.Clean;
        public Value<string> LoanPurchaseCreditAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount1() => !LoanPurchaseCreditAmount1.Clean;
        public Value<string> LoanPurchaseCreditAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount2() => !LoanPurchaseCreditAmount2.Clean;
        public Value<string> LoanPurchaseCreditAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount3() => !LoanPurchaseCreditAmount3.Clean;
        public Value<string> LoanPurchaseCreditAmount4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount4() => !LoanPurchaseCreditAmount4.Clean;
        public Value<string> LoanPurchaseCreditType1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType1() => !LoanPurchaseCreditType1.Clean;
        public Value<string> LoanPurchaseCreditType2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType2() => !LoanPurchaseCreditType2.Clean;
        public Value<string> LoanPurchaseCreditType3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType3() => !LoanPurchaseCreditType3.Clean;
        public Value<string> LoanPurchaseCreditType4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType4() => !LoanPurchaseCreditType4.Clean;
        public Value<string> LoanRefinanceIncludingDebtsToBePaidOffAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanRefinanceIncludingDebtsToBePaidOffAmount() => !LoanRefinanceIncludingDebtsToBePaidOffAmount.Clean;
        public Value<string> LoanSection1000SellerPaidTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSection1000SellerPaidTotalAmount() => !LoanSection1000SellerPaidTotalAmount.Clean;
        public Value<string> LoanSellerCreditAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSellerCreditAmount() => !LoanSellerCreditAmount.Clean;
        public Value<string> LoanTotalClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTotalClosingCosts() => !LoanTotalClosingCosts.Clean;
        public Value<DateTime?> LockedBorrowerPresumedReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedBorrowerPresumedReceivedDate() => !LockedBorrowerPresumedReceivedDate.Clean;
        public Value<DateTime?> LockedCoBorrowerPresumedReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedCoBorrowerPresumedReceivedDate() => !LockedCoBorrowerPresumedReceivedDate.Clean;
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
        public Value<string> PrepaymentPenaltyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyIndicator() => !PrepaymentPenaltyIndicator.Clean;
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
        public Value<bool?> ProviderListSent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProviderListSent() => !ProviderListSent.Clean;
        public Value<string> PurchasePriceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePriceAmount() => !PurchasePriceAmount.Clean;
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
                    && AppliedCureAmount.Clean
                    && BorrowerActualReceivedDate.Clean
                    && BorrowerDisclosedMethod.Clean
                    && BorrowerDisclosedMethodOther.Clean
                    && BorrowerName.Clean
                    && BorrowerPairId.Clean
                    && BorrowerPresumedReceivedDate.Clean
                    && BorrowerType.Clean
                    && CDReasonIs24HourAdvancePreview.Clean
                    && CDReasonIsChangeInAPR.Clean
                    && CDReasonIsChangeInLoanProduct.Clean
                    && CDReasonIsChangeInSettlementCharges.Clean
                    && CDReasonIsClericalErrorCorrection.Clean
                    && CDReasonIsOther.Clean
                    && CDReasonIsPrepaymentPenaltyAdded.Clean
                    && CDReasonIsToleranceCure.Clean
                    && CDReasonOther.Clean
                    && ChangeInCircumstance.Clean
                    && ChangeInCircumstanceComments.Clean
                    && ChargesCannotIncrease10Itemization34.Clean
                    && ChargesCannotIncrease10LE32.Clean
                    && ChargesThatCannotDecreaseItemization9.Clean
                    && ChargesThatCannotDecreaseLE7.Clean
                    && ChargesThatCannotIncreaseItemization13.Clean
                    && ChargesThatCannotIncreaseLE11.Clean
                    && CoBorrowerActualReceivedDate.Clean
                    && CoBorrowerDisclosedMethod.Clean
                    && CoBorrowerDisclosedMethodOther.Clean
                    && CoBorrowerName.Clean
                    && CoBorrowerPresumedReceivedDate.Clean
                    && CoBorrowerType.Clean
                    && CommentList.Clean
                    && CommentListXml.Clean
                    && Comments.Clean
                    && ContainCD.Clean
                    && ContainLE.Clean
                    && ContainSafeHarbor.Clean
                    && DateAdded.Clean
                    && DateUtc.Clean
                    && DisclosedAPR.Clean
                    && DisclosedBy.Clean
                    && DisclosedByFullName.Clean
                    && DisclosedDailyInterest.Clean
                    && DisclosedDate.Clean
                    && DisclosedForCD.Clean
                    && DisclosedMethod.Clean
                    && DisclosedMethodName.Clean
                    && DisclosedMethodOther.Clean
                    && DisclosureCreatedDttmUtc.Clean
                    && DisclosureMethod.Clean
                    && DisclosureType.Clean
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
                    && EstimatedTotalPayoffsAndPaymentsAmount.Clean
                    && FileAttachmentsMigrated.Clean
                    && FinanceCharge.Clean
                    && Forms.Clean
                    && FormsXml.Clean
                    && FulfillmentOrderedBy.Clean
                    && FullfillmentProcessedDate.Clean
                    && Guid.Clean
                    && Id.Clean
                    && IntentToProceed.Clean
                    && IntentToProceedComments.Clean
                    && IntentToProceedDate.Clean
                    && IntentToProceedReceivedBy.Clean
                    && IntentToProceedReceivedMethod.Clean
                    && IntentToProceedReceivedMethodOther.Clean
                    && IsBorrowerPresumedDateLocked.Clean
                    && IsCoBorrowerPresumedDateLocked.Clean
                    && IsDisclosed.Clean
                    && IsDisclosedAprLocked.Clean
                    && IsDisclosedByLocked.Clean
                    && IsDisclosedFinanceChargeLocked.Clean
                    && IsDisclosedReceivedDateLocked.Clean
                    && IsLocked.Clean
                    && IsSystemSpecificIndicator.Clean
                    && IsWetSignedIndicator.Clean
                    && LenderCompensationCreditAmount2.Clean
                    && LenderTotalPaidOriginatorAmount.Clean
                    && LEReasonIsChangedCircumstanceEligibility.Clean
                    && LEReasonIsChangedCircumstanceSettlementCharges.Clean
                    && LEReasonIsDelayedSettlementOnConstructionLoans.Clean
                    && LEReasonIsExpiration.Clean
                    && LEReasonIsInterestRateDependentCharges.Clean
                    && LEReasonIsOther.Clean
                    && LEReasonIsRevisionsRequestedByConsumer.Clean
                    && LEReasonOther.Clean
                    && Line802LOCompAdditionalAmount1.Clean
                    && Line802LOCompAdditionalAmount2.Clean
                    && Line907InsuranceIndicator2015.Clean
                    && Line907PropertyIndicator2015.Clean
                    && Line907TaxesIndicator2015.Clean
                    && Line908InsuranceIndicator2015.Clean
                    && Line908PropertyIndicator2015.Clean
                    && Line908TaxesIndicator2015.Clean
                    && Line909InsuranceIndicator2015.Clean
                    && Line909PropertyIndicator2015.Clean
                    && Line909TaxesIndicator2015.Clean
                    && Line910InsuranceIndicator2015.Clean
                    && Line910PropertyIndicator2015.Clean
                    && Line910TaxesIndicator2015.Clean
                    && Line911InsuranceIndicator2015.Clean
                    && Line911PropertyIndicator2015.Clean
                    && Line911TaxesIndicator2015.Clean
                    && Line912InsuranceIndicator2015.Clean
                    && Line912PropertyIndicator2015.Clean
                    && Line912TaxesIndicator2015.Clean
                    && LoanAdjustmentsOtherCredits.Clean
                    && LoanAmount.Clean
                    && LoanClosingCost2BorrowerClosingCostAtClosing.Clean
                    && LoanClosingCost2LenderCredits.Clean
                    && LoanClosingCost2TotalLoanCost.Clean
                    && LoanClosingCost2TotalOtherCost.Clean
                    && LoanClosingCost3StdLegalLimit.Clean
                    && LoanClosingCostGfe1200BorPaidAmount.Clean
                    && LoanClosingCostGfe800BorPaidAmount.Clean
                    && LoanClosingCostLenderCredits.Clean
                    && LoanClosingCostSection1000BorrowerTotalPaidAmount.Clean
                    && LoanClosingCostsFinanced.Clean
                    && LoanClosingCostTotalFeeAmount2015.Clean
                    && LoanDownPayment.Clean
                    && LoanEstimate2TotalLoanAndOtherCosts.Clean
                    && LoanEstimate2TotalLoanCosts.Clean
                    && LoanEstimate2TotalOtherCosts.Clean
                    && LoanEstimate2UnroundedTotalLoanCosts.Clean
                    && LoanEstimate2UnroundedTotalOtherCosts.Clean
                    && LoanEstimateLoanProduct.Clean
                    && LoanFeesCityTaxBorPaidAmount.Clean
                    && LoanFeesStateTaxBorPaidAmount.Clean
                    && LoanFundsForBorrower.Clean
                    && LoanGfeAgregateAdjustment.Clean
                    && LoanGfeGovermentRecordingCharges.Clean
                    && LoanLineItemAmount.Clean
                    && LoanProgram.Clean
                    && LoanPurchaseCreditAmount1.Clean
                    && LoanPurchaseCreditAmount2.Clean
                    && LoanPurchaseCreditAmount3.Clean
                    && LoanPurchaseCreditAmount4.Clean
                    && LoanPurchaseCreditType1.Clean
                    && LoanPurchaseCreditType2.Clean
                    && LoanPurchaseCreditType3.Clean
                    && LoanPurchaseCreditType4.Clean
                    && LoanRefinanceIncludingDebtsToBePaidOffAmount.Clean
                    && LoanSection1000SellerPaidTotalAmount.Clean
                    && LoanSellerCreditAmount.Clean
                    && LoanTotalClosingCosts.Clean
                    && LockedBorrowerPresumedReceivedDate.Clean
                    && LockedCoBorrowerPresumedReceivedDate.Clean
                    && LockedDisclosedAprField.Clean
                    && LockedDisclosedByField.Clean
                    && LockedDisclosedFinanceChargeField.Clean
                    && LockedDisclosedReceivedDate.Clean
                    && LogRecordIndex.Clean
                    && ManuallyCreated.Clean
                    && PrepaymentPenaltyIndicator.Clean
                    && PropertyAddress.Clean
                    && PropertyCity.Clean
                    && PropertyState.Clean
                    && PropertyZip.Clean
                    && ProviderListSent.Clean
                    && PurchasePriceAmount.Clean
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
                var v3 = AppliedCureAmount; v3.Clean = value; AppliedCureAmount = v3;
                var v4 = BorrowerActualReceivedDate; v4.Clean = value; BorrowerActualReceivedDate = v4;
                var v5 = BorrowerDisclosedMethod; v5.Clean = value; BorrowerDisclosedMethod = v5;
                var v6 = BorrowerDisclosedMethodOther; v6.Clean = value; BorrowerDisclosedMethodOther = v6;
                var v7 = BorrowerName; v7.Clean = value; BorrowerName = v7;
                var v8 = BorrowerPairId; v8.Clean = value; BorrowerPairId = v8;
                var v9 = BorrowerPresumedReceivedDate; v9.Clean = value; BorrowerPresumedReceivedDate = v9;
                var v10 = BorrowerType; v10.Clean = value; BorrowerType = v10;
                var v11 = CDReasonIs24HourAdvancePreview; v11.Clean = value; CDReasonIs24HourAdvancePreview = v11;
                var v12 = CDReasonIsChangeInAPR; v12.Clean = value; CDReasonIsChangeInAPR = v12;
                var v13 = CDReasonIsChangeInLoanProduct; v13.Clean = value; CDReasonIsChangeInLoanProduct = v13;
                var v14 = CDReasonIsChangeInSettlementCharges; v14.Clean = value; CDReasonIsChangeInSettlementCharges = v14;
                var v15 = CDReasonIsClericalErrorCorrection; v15.Clean = value; CDReasonIsClericalErrorCorrection = v15;
                var v16 = CDReasonIsOther; v16.Clean = value; CDReasonIsOther = v16;
                var v17 = CDReasonIsPrepaymentPenaltyAdded; v17.Clean = value; CDReasonIsPrepaymentPenaltyAdded = v17;
                var v18 = CDReasonIsToleranceCure; v18.Clean = value; CDReasonIsToleranceCure = v18;
                var v19 = CDReasonOther; v19.Clean = value; CDReasonOther = v19;
                var v20 = ChangeInCircumstance; v20.Clean = value; ChangeInCircumstance = v20;
                var v21 = ChangeInCircumstanceComments; v21.Clean = value; ChangeInCircumstanceComments = v21;
                var v22 = ChargesCannotIncrease10Itemization34; v22.Clean = value; ChargesCannotIncrease10Itemization34 = v22;
                var v23 = ChargesCannotIncrease10LE32; v23.Clean = value; ChargesCannotIncrease10LE32 = v23;
                var v24 = ChargesThatCannotDecreaseItemization9; v24.Clean = value; ChargesThatCannotDecreaseItemization9 = v24;
                var v25 = ChargesThatCannotDecreaseLE7; v25.Clean = value; ChargesThatCannotDecreaseLE7 = v25;
                var v26 = ChargesThatCannotIncreaseItemization13; v26.Clean = value; ChargesThatCannotIncreaseItemization13 = v26;
                var v27 = ChargesThatCannotIncreaseLE11; v27.Clean = value; ChargesThatCannotIncreaseLE11 = v27;
                var v28 = CoBorrowerActualReceivedDate; v28.Clean = value; CoBorrowerActualReceivedDate = v28;
                var v29 = CoBorrowerDisclosedMethod; v29.Clean = value; CoBorrowerDisclosedMethod = v29;
                var v30 = CoBorrowerDisclosedMethodOther; v30.Clean = value; CoBorrowerDisclosedMethodOther = v30;
                var v31 = CoBorrowerName; v31.Clean = value; CoBorrowerName = v31;
                var v32 = CoBorrowerPresumedReceivedDate; v32.Clean = value; CoBorrowerPresumedReceivedDate = v32;
                var v33 = CoBorrowerType; v33.Clean = value; CoBorrowerType = v33;
                var v34 = CommentList; v34.Clean = value; CommentList = v34;
                var v35 = CommentListXml; v35.Clean = value; CommentListXml = v35;
                var v36 = Comments; v36.Clean = value; Comments = v36;
                var v37 = ContainCD; v37.Clean = value; ContainCD = v37;
                var v38 = ContainLE; v38.Clean = value; ContainLE = v38;
                var v39 = ContainSafeHarbor; v39.Clean = value; ContainSafeHarbor = v39;
                var v40 = DateAdded; v40.Clean = value; DateAdded = v40;
                var v41 = DateUtc; v41.Clean = value; DateUtc = v41;
                var v42 = DisclosedAPR; v42.Clean = value; DisclosedAPR = v42;
                var v43 = DisclosedBy; v43.Clean = value; DisclosedBy = v43;
                var v44 = DisclosedByFullName; v44.Clean = value; DisclosedByFullName = v44;
                var v45 = DisclosedDailyInterest; v45.Clean = value; DisclosedDailyInterest = v45;
                var v46 = DisclosedDate; v46.Clean = value; DisclosedDate = v46;
                var v47 = DisclosedForCD; v47.Clean = value; DisclosedForCD = v47;
                var v48 = DisclosedMethod; v48.Clean = value; DisclosedMethod = v48;
                var v49 = DisclosedMethodName; v49.Clean = value; DisclosedMethodName = v49;
                var v50 = DisclosedMethodOther; v50.Clean = value; DisclosedMethodOther = v50;
                var v51 = DisclosureCreatedDttmUtc; v51.Clean = value; DisclosureCreatedDttmUtc = v51;
                var v52 = DisclosureMethod; v52.Clean = value; DisclosureMethod = v52;
                var v53 = DisclosureType; v53.Clean = value; DisclosureType = v53;
                var v54 = EDisclosureApplicationPackageIndicator; v54.Clean = value; EDisclosureApplicationPackageIndicator = v54;
                var v55 = EDisclosureApprovalPackageIndicator; v55.Clean = value; EDisclosureApprovalPackageIndicator = v55;
                var v56 = EDisclosureBorrowerAcceptConsentDate; v56.Clean = value; EDisclosureBorrowerAcceptConsentDate = v56;
                var v57 = EDisclosureBorrowereSignedDate; v57.Clean = value; EDisclosureBorrowereSignedDate = v57;
                var v58 = EDisclosureBorrowerRejectConsentDate; v58.Clean = value; EDisclosureBorrowerRejectConsentDate = v58;
                var v59 = EDisclosureBorrowerViewConsentDate; v59.Clean = value; EDisclosureBorrowerViewConsentDate = v59;
                var v60 = EDisclosureBorrowerViewMessageDate; v60.Clean = value; EDisclosureBorrowerViewMessageDate = v60;
                var v61 = EDisclosureBorrowerWetSignedDate; v61.Clean = value; EDisclosureBorrowerWetSignedDate = v61;
                var v62 = EDisclosureCoBorrowerAcceptConsentDate; v62.Clean = value; EDisclosureCoBorrowerAcceptConsentDate = v62;
                var v63 = EDisclosureCoBorrowereSignedDate; v63.Clean = value; EDisclosureCoBorrowereSignedDate = v63;
                var v64 = EDisclosureCoBorrowerRejectConsentDate; v64.Clean = value; EDisclosureCoBorrowerRejectConsentDate = v64;
                var v65 = EDisclosureCoBorrowerViewConsentDate; v65.Clean = value; EDisclosureCoBorrowerViewConsentDate = v65;
                var v66 = EDisclosureCoBorrowerViewMessageDate; v66.Clean = value; EDisclosureCoBorrowerViewMessageDate = v66;
                var v67 = EDisclosureCoBorrowerWebSignedDate; v67.Clean = value; EDisclosureCoBorrowerWebSignedDate = v67;
                var v68 = EDisclosureConsentPdf; v68.Clean = value; EDisclosureConsentPdf = v68;
                var v69 = EDisclosureDisclosedMessage; v69.Clean = value; EDisclosureDisclosedMessage = v69;
                var v70 = EDisclosureLockPackageIndicator; v70.Clean = value; EDisclosureLockPackageIndicator = v70;
                var v71 = EDisclosureManualFulfillmentComment; v71.Clean = value; EDisclosureManualFulfillmentComment = v71;
                var v72 = EDisclosureManualFulfillmentDate; v72.Clean = value; EDisclosureManualFulfillmentDate = v72;
                var v73 = EDisclosureManualFulfillmentMethod; v73.Clean = value; EDisclosureManualFulfillmentMethod = v73;
                var v74 = EDisclosureManuallyFulfilledBy; v74.Clean = value; EDisclosureManuallyFulfilledBy = v74;
                var v75 = EDisclosurePackageCreatedDate; v75.Clean = value; EDisclosurePackageCreatedDate = v75;
                var v76 = EDisclosurePackageId; v76.Clean = value; EDisclosurePackageId = v76;
                var v77 = EDisclosurePackageViewableFile; v77.Clean = value; EDisclosurePackageViewableFile = v77;
                var v78 = EDisclosureThreeDayPackageIndicator; v78.Clean = value; EDisclosureThreeDayPackageIndicator = v78;
                var v79 = EstimatedTotalPayoffsAndPaymentsAmount; v79.Clean = value; EstimatedTotalPayoffsAndPaymentsAmount = v79;
                var v80 = FileAttachmentsMigrated; v80.Clean = value; FileAttachmentsMigrated = v80;
                var v81 = FinanceCharge; v81.Clean = value; FinanceCharge = v81;
                var v82 = Forms; v82.Clean = value; Forms = v82;
                var v83 = FormsXml; v83.Clean = value; FormsXml = v83;
                var v84 = FulfillmentOrderedBy; v84.Clean = value; FulfillmentOrderedBy = v84;
                var v85 = FullfillmentProcessedDate; v85.Clean = value; FullfillmentProcessedDate = v85;
                var v86 = Guid; v86.Clean = value; Guid = v86;
                var v87 = Id; v87.Clean = value; Id = v87;
                var v88 = IntentToProceed; v88.Clean = value; IntentToProceed = v88;
                var v89 = IntentToProceedComments; v89.Clean = value; IntentToProceedComments = v89;
                var v90 = IntentToProceedDate; v90.Clean = value; IntentToProceedDate = v90;
                var v91 = IntentToProceedReceivedBy; v91.Clean = value; IntentToProceedReceivedBy = v91;
                var v92 = IntentToProceedReceivedMethod; v92.Clean = value; IntentToProceedReceivedMethod = v92;
                var v93 = IntentToProceedReceivedMethodOther; v93.Clean = value; IntentToProceedReceivedMethodOther = v93;
                var v94 = IsBorrowerPresumedDateLocked; v94.Clean = value; IsBorrowerPresumedDateLocked = v94;
                var v95 = IsCoBorrowerPresumedDateLocked; v95.Clean = value; IsCoBorrowerPresumedDateLocked = v95;
                var v96 = IsDisclosed; v96.Clean = value; IsDisclosed = v96;
                var v97 = IsDisclosedAprLocked; v97.Clean = value; IsDisclosedAprLocked = v97;
                var v98 = IsDisclosedByLocked; v98.Clean = value; IsDisclosedByLocked = v98;
                var v99 = IsDisclosedFinanceChargeLocked; v99.Clean = value; IsDisclosedFinanceChargeLocked = v99;
                var v100 = IsDisclosedReceivedDateLocked; v100.Clean = value; IsDisclosedReceivedDateLocked = v100;
                var v101 = IsLocked; v101.Clean = value; IsLocked = v101;
                var v102 = IsSystemSpecificIndicator; v102.Clean = value; IsSystemSpecificIndicator = v102;
                var v103 = IsWetSignedIndicator; v103.Clean = value; IsWetSignedIndicator = v103;
                var v104 = LenderCompensationCreditAmount2; v104.Clean = value; LenderCompensationCreditAmount2 = v104;
                var v105 = LenderTotalPaidOriginatorAmount; v105.Clean = value; LenderTotalPaidOriginatorAmount = v105;
                var v106 = LEReasonIsChangedCircumstanceEligibility; v106.Clean = value; LEReasonIsChangedCircumstanceEligibility = v106;
                var v107 = LEReasonIsChangedCircumstanceSettlementCharges; v107.Clean = value; LEReasonIsChangedCircumstanceSettlementCharges = v107;
                var v108 = LEReasonIsDelayedSettlementOnConstructionLoans; v108.Clean = value; LEReasonIsDelayedSettlementOnConstructionLoans = v108;
                var v109 = LEReasonIsExpiration; v109.Clean = value; LEReasonIsExpiration = v109;
                var v110 = LEReasonIsInterestRateDependentCharges; v110.Clean = value; LEReasonIsInterestRateDependentCharges = v110;
                var v111 = LEReasonIsOther; v111.Clean = value; LEReasonIsOther = v111;
                var v112 = LEReasonIsRevisionsRequestedByConsumer; v112.Clean = value; LEReasonIsRevisionsRequestedByConsumer = v112;
                var v113 = LEReasonOther; v113.Clean = value; LEReasonOther = v113;
                var v114 = Line802LOCompAdditionalAmount1; v114.Clean = value; Line802LOCompAdditionalAmount1 = v114;
                var v115 = Line802LOCompAdditionalAmount2; v115.Clean = value; Line802LOCompAdditionalAmount2 = v115;
                var v116 = Line907InsuranceIndicator2015; v116.Clean = value; Line907InsuranceIndicator2015 = v116;
                var v117 = Line907PropertyIndicator2015; v117.Clean = value; Line907PropertyIndicator2015 = v117;
                var v118 = Line907TaxesIndicator2015; v118.Clean = value; Line907TaxesIndicator2015 = v118;
                var v119 = Line908InsuranceIndicator2015; v119.Clean = value; Line908InsuranceIndicator2015 = v119;
                var v120 = Line908PropertyIndicator2015; v120.Clean = value; Line908PropertyIndicator2015 = v120;
                var v121 = Line908TaxesIndicator2015; v121.Clean = value; Line908TaxesIndicator2015 = v121;
                var v122 = Line909InsuranceIndicator2015; v122.Clean = value; Line909InsuranceIndicator2015 = v122;
                var v123 = Line909PropertyIndicator2015; v123.Clean = value; Line909PropertyIndicator2015 = v123;
                var v124 = Line909TaxesIndicator2015; v124.Clean = value; Line909TaxesIndicator2015 = v124;
                var v125 = Line910InsuranceIndicator2015; v125.Clean = value; Line910InsuranceIndicator2015 = v125;
                var v126 = Line910PropertyIndicator2015; v126.Clean = value; Line910PropertyIndicator2015 = v126;
                var v127 = Line910TaxesIndicator2015; v127.Clean = value; Line910TaxesIndicator2015 = v127;
                var v128 = Line911InsuranceIndicator2015; v128.Clean = value; Line911InsuranceIndicator2015 = v128;
                var v129 = Line911PropertyIndicator2015; v129.Clean = value; Line911PropertyIndicator2015 = v129;
                var v130 = Line911TaxesIndicator2015; v130.Clean = value; Line911TaxesIndicator2015 = v130;
                var v131 = Line912InsuranceIndicator2015; v131.Clean = value; Line912InsuranceIndicator2015 = v131;
                var v132 = Line912PropertyIndicator2015; v132.Clean = value; Line912PropertyIndicator2015 = v132;
                var v133 = Line912TaxesIndicator2015; v133.Clean = value; Line912TaxesIndicator2015 = v133;
                var v134 = LoanAdjustmentsOtherCredits; v134.Clean = value; LoanAdjustmentsOtherCredits = v134;
                var v135 = LoanAmount; v135.Clean = value; LoanAmount = v135;
                var v136 = LoanClosingCost2BorrowerClosingCostAtClosing; v136.Clean = value; LoanClosingCost2BorrowerClosingCostAtClosing = v136;
                var v137 = LoanClosingCost2LenderCredits; v137.Clean = value; LoanClosingCost2LenderCredits = v137;
                var v138 = LoanClosingCost2TotalLoanCost; v138.Clean = value; LoanClosingCost2TotalLoanCost = v138;
                var v139 = LoanClosingCost2TotalOtherCost; v139.Clean = value; LoanClosingCost2TotalOtherCost = v139;
                var v140 = LoanClosingCost3StdLegalLimit; v140.Clean = value; LoanClosingCost3StdLegalLimit = v140;
                var v141 = LoanClosingCostGfe1200BorPaidAmount; v141.Clean = value; LoanClosingCostGfe1200BorPaidAmount = v141;
                var v142 = LoanClosingCostGfe800BorPaidAmount; v142.Clean = value; LoanClosingCostGfe800BorPaidAmount = v142;
                var v143 = LoanClosingCostLenderCredits; v143.Clean = value; LoanClosingCostLenderCredits = v143;
                var v144 = LoanClosingCostSection1000BorrowerTotalPaidAmount; v144.Clean = value; LoanClosingCostSection1000BorrowerTotalPaidAmount = v144;
                var v145 = LoanClosingCostsFinanced; v145.Clean = value; LoanClosingCostsFinanced = v145;
                var v146 = LoanClosingCostTotalFeeAmount2015; v146.Clean = value; LoanClosingCostTotalFeeAmount2015 = v146;
                var v147 = LoanDownPayment; v147.Clean = value; LoanDownPayment = v147;
                var v148 = LoanEstimate2TotalLoanAndOtherCosts; v148.Clean = value; LoanEstimate2TotalLoanAndOtherCosts = v148;
                var v149 = LoanEstimate2TotalLoanCosts; v149.Clean = value; LoanEstimate2TotalLoanCosts = v149;
                var v150 = LoanEstimate2TotalOtherCosts; v150.Clean = value; LoanEstimate2TotalOtherCosts = v150;
                var v151 = LoanEstimate2UnroundedTotalLoanCosts; v151.Clean = value; LoanEstimate2UnroundedTotalLoanCosts = v151;
                var v152 = LoanEstimate2UnroundedTotalOtherCosts; v152.Clean = value; LoanEstimate2UnroundedTotalOtherCosts = v152;
                var v153 = LoanEstimateLoanProduct; v153.Clean = value; LoanEstimateLoanProduct = v153;
                var v154 = LoanFeesCityTaxBorPaidAmount; v154.Clean = value; LoanFeesCityTaxBorPaidAmount = v154;
                var v155 = LoanFeesStateTaxBorPaidAmount; v155.Clean = value; LoanFeesStateTaxBorPaidAmount = v155;
                var v156 = LoanFundsForBorrower; v156.Clean = value; LoanFundsForBorrower = v156;
                var v157 = LoanGfeAgregateAdjustment; v157.Clean = value; LoanGfeAgregateAdjustment = v157;
                var v158 = LoanGfeGovermentRecordingCharges; v158.Clean = value; LoanGfeGovermentRecordingCharges = v158;
                var v159 = LoanLineItemAmount; v159.Clean = value; LoanLineItemAmount = v159;
                var v160 = LoanProgram; v160.Clean = value; LoanProgram = v160;
                var v161 = LoanPurchaseCreditAmount1; v161.Clean = value; LoanPurchaseCreditAmount1 = v161;
                var v162 = LoanPurchaseCreditAmount2; v162.Clean = value; LoanPurchaseCreditAmount2 = v162;
                var v163 = LoanPurchaseCreditAmount3; v163.Clean = value; LoanPurchaseCreditAmount3 = v163;
                var v164 = LoanPurchaseCreditAmount4; v164.Clean = value; LoanPurchaseCreditAmount4 = v164;
                var v165 = LoanPurchaseCreditType1; v165.Clean = value; LoanPurchaseCreditType1 = v165;
                var v166 = LoanPurchaseCreditType2; v166.Clean = value; LoanPurchaseCreditType2 = v166;
                var v167 = LoanPurchaseCreditType3; v167.Clean = value; LoanPurchaseCreditType3 = v167;
                var v168 = LoanPurchaseCreditType4; v168.Clean = value; LoanPurchaseCreditType4 = v168;
                var v169 = LoanRefinanceIncludingDebtsToBePaidOffAmount; v169.Clean = value; LoanRefinanceIncludingDebtsToBePaidOffAmount = v169;
                var v170 = LoanSection1000SellerPaidTotalAmount; v170.Clean = value; LoanSection1000SellerPaidTotalAmount = v170;
                var v171 = LoanSellerCreditAmount; v171.Clean = value; LoanSellerCreditAmount = v171;
                var v172 = LoanTotalClosingCosts; v172.Clean = value; LoanTotalClosingCosts = v172;
                var v173 = LockedBorrowerPresumedReceivedDate; v173.Clean = value; LockedBorrowerPresumedReceivedDate = v173;
                var v174 = LockedCoBorrowerPresumedReceivedDate; v174.Clean = value; LockedCoBorrowerPresumedReceivedDate = v174;
                var v175 = LockedDisclosedAprField; v175.Clean = value; LockedDisclosedAprField = v175;
                var v176 = LockedDisclosedByField; v176.Clean = value; LockedDisclosedByField = v176;
                var v177 = LockedDisclosedFinanceChargeField; v177.Clean = value; LockedDisclosedFinanceChargeField = v177;
                var v178 = LockedDisclosedReceivedDate; v178.Clean = value; LockedDisclosedReceivedDate = v178;
                var v179 = LogRecordIndex; v179.Clean = value; LogRecordIndex = v179;
                var v180 = ManuallyCreated; v180.Clean = value; ManuallyCreated = v180;
                var v181 = PrepaymentPenaltyIndicator; v181.Clean = value; PrepaymentPenaltyIndicator = v181;
                var v182 = PropertyAddress; v182.Clean = value; PropertyAddress = v182;
                var v183 = PropertyCity; v183.Clean = value; PropertyCity = v183;
                var v184 = PropertyState; v184.Clean = value; PropertyState = v184;
                var v185 = PropertyZip; v185.Clean = value; PropertyZip = v185;
                var v186 = ProviderListSent; v186.Clean = value; ProviderListSent = v186;
                var v187 = PurchasePriceAmount; v187.Clean = value; PurchasePriceAmount = v187;
                var v188 = ReceivedDate; v188.Clean = value; ReceivedDate = v188;
                var v189 = SnapshotFields; v189.Clean = value; SnapshotFields = v189;
                var v190 = SnapshotXml; v190.Clean = value; SnapshotXml = v190;
                var v191 = SystemId; v191.Clean = value; SystemId = v191;
                _settingClean = 0;
            }
        }
    }
}