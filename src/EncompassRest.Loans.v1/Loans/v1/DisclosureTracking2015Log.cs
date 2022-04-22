using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DisclosureTracking2015Log
/// </summary>
public sealed partial class DisclosureTracking2015Log : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosureTracking2015Log ActualFulfillmentDate
    /// </summary>
    public DateTime? ActualFulfillmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualLECD3TotalClosingCostJFromLatestRec
    /// </summary>
    public string? ActualLECD3TotalClosingCostJFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec
    /// </summary>
    public string? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualLELoanAmountFromLatestRec
    /// </summary>
    public string? ActualLELoanAmountFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec
    /// </summary>
    public string? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualSTDLEClosingCostFinancedFromLatestRec
    /// </summary>
    public string? ActualSTDLEClosingCostFinancedFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualSTDLEDepositFromLatestRec
    /// </summary>
    public string? ActualSTDLEDepositFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualSTDLEFundForBorrowerFromLatestRec
    /// </summary>
    public string? ActualSTDLEFundForBorrowerFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualSTDLESellerCreditsFromLatestRec
    /// </summary>
    public string? ActualSTDLESellerCreditsFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ActualSTDLETotalClosingCostJFromLatestRec
    /// </summary>
    public string? ActualSTDLETotalClosingCostJFromLatestRec { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTracking2015Log AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ApplicationDate
    /// </summary>
    public DateTime? ApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log AppliedCureAmount
    /// </summary>
    public string? AppliedCureAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log AutomaticFullfillmentServiceName
    /// </summary>
    public string? AutomaticFullfillmentServiceName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerActualReceivedDate
    /// </summary>
    public DateTime? BorrowerActualReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerDisclosedMethod
    /// </summary>
    public string? BorrowerDisclosedMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerDisclosedMethodOther
    /// </summary>
    public string? BorrowerDisclosedMethodOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerLoanLevelConsentMapForCC
    /// </summary>
    public bool? BorrowerLoanLevelConsentMapForCC { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerName
    /// </summary>
    public string? BorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerPairId
    /// </summary>
    public string? BorrowerPairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerPresumedReceivedDate
    /// </summary>
    public DateTime? BorrowerPresumedReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BorrowerType
    /// </summary>
    public string? BorrowerType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log BrokerDisclosed
    /// </summary>
    public bool? BrokerDisclosed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDDateIssued
    /// </summary>
    public DateTime? CDDateIssued { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIs24HourAdvancePreview
    /// </summary>
    public bool? CDReasonIs24HourAdvancePreview { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsChangedCircumstanceEligibility
    /// </summary>
    public bool? CDReasonIsChangedCircumstanceEligibility { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsChangeInAPR
    /// </summary>
    public bool? CDReasonIsChangeInAPR { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsChangeInLoanProduct
    /// </summary>
    public bool? CDReasonIsChangeInLoanProduct { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsChangeInSettlementCharges
    /// </summary>
    public bool? CDReasonIsChangeInSettlementCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsClericalErrorCorrection
    /// </summary>
    public bool? CDReasonIsClericalErrorCorrection { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsInterestRateDependentCharges
    /// </summary>
    public bool? CDReasonIsInterestRateDependentCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsOther
    /// </summary>
    public bool? CDReasonIsOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsPrepaymentPenaltyAdded
    /// </summary>
    public bool? CDReasonIsPrepaymentPenaltyAdded { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsRevisionsRequestedByConsumer
    /// </summary>
    public bool? CDReasonIsRevisionsRequestedByConsumer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonIsToleranceCure
    /// </summary>
    public bool? CDReasonIsToleranceCure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CDReasonOther
    /// </summary>
    public string? CDReasonOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChangeInCircumstance
    /// </summary>
    public string? ChangeInCircumstance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChangeInCircumstanceComments
    /// </summary>
    public string? ChangeInCircumstanceComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChangesReceivedDate
    /// </summary>
    public DateTime? ChangesReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChargesCannotIncrease10Itemization34
    /// </summary>
    public string? ChargesCannotIncrease10Itemization34 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChargesCannotIncrease10LE32
    /// </summary>
    public string? ChargesCannotIncrease10LE32 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChargesThatCannotDecreaseItemization9
    /// </summary>
    public string? ChargesThatCannotDecreaseItemization9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChargesThatCannotDecreaseLE7
    /// </summary>
    public string? ChargesThatCannotDecreaseLE7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChargesThatCannotIncreaseItemization13
    /// </summary>
    public string? ChargesThatCannotIncreaseItemization13 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ChargesThatCannotIncreaseLE11
    /// </summary>
    public string? ChargesThatCannotIncreaseLE11 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ClosingDate
    /// </summary>
    public DateTime? ClosingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CoBorrowerActualReceivedDate
    /// </summary>
    public DateTime? CoBorrowerActualReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CoBorrowerDisclosedMethod
    /// </summary>
    public string? CoBorrowerDisclosedMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CoBorrowerDisclosedMethodOther
    /// </summary>
    public string? CoBorrowerDisclosedMethodOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CoBorrowerLoanLevelConsentMapForCC
    /// </summary>
    public bool? CoBorrowerLoanLevelConsentMapForCC { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CoBorrowerName
    /// </summary>
    public string? CoBorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CoBorrowerPresumedReceivedDate
    /// </summary>
    public DateTime? CoBorrowerPresumedReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CoBorrowerType
    /// </summary>
    public string? CoBorrowerType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTracking2015Log CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ContainCD
    /// </summary>
    public bool? ContainCD { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ContainLE
    /// </summary>
    public bool? ContainLE { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ContainSafeHarbor
    /// </summary>
    public bool? ContainSafeHarbor { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CureAppliedToLenderCredit
    /// </summary>
    public string? CureAppliedToLenderCredit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log CureAppliedToPrincipalReduction
    /// </summary>
    public string? CureAppliedToPrincipalReduction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DateAdded
    /// </summary>
    public DateTime? DateAdded { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedAPR
    /// </summary>
    public string? DisclosedAPR { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedBy
    /// </summary>
    public string? DisclosedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedByFullName
    /// </summary>
    public string? DisclosedByFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedDailyInterest
    /// </summary>
    public string? DisclosedDailyInterest { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedDate
    /// </summary>
    public DateTime? DisclosedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedForCD
    /// </summary>
    public bool? DisclosedForCD { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedForLE
    /// </summary>
    public bool? DisclosedForLE { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedMethod
    /// </summary>
    public string? DisclosedMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedMethodName
    /// </summary>
    public string? DisclosedMethodName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedMethodOther
    /// </summary>
    public string? DisclosedMethodOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosedSalesPrice
    /// </summary>
    public string? DisclosedSalesPrice { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosureCreatedDttmUtc
    /// </summary>
    public DateTime? DisclosureCreatedDttmUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosureMethod
    /// </summary>
    public string? DisclosureMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log DisclosureType
    /// </summary>
    public string? DisclosureType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureApplicationPackageIndicator
    /// </summary>
    public bool? EDisclosureApplicationPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureApprovalPackageIndicator
    /// </summary>
    public bool? EDisclosureApprovalPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerAcceptConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentIP
    /// </summary>
    public string? EDisclosureBorrowerAcceptConsentIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedDate
    /// </summary>
    public DateTime? EDisclosureBorrowerAuthenticatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedIP
    /// </summary>
    public string? EDisclosureBorrowerAuthenticatedIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerDocumentViewedDate
    /// </summary>
    public DateTime? EDisclosureBorrowerDocumentViewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerEmail
    /// </summary>
    public string? EDisclosureBorrowerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowereSignedDate
    /// </summary>
    public DateTime? EDisclosureBorrowereSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowereSignedIP
    /// </summary>
    public string? EDisclosureBorrowereSignedIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerLoanLevelConsent
    /// </summary>
    public string? EDisclosureBorrowerLoanLevelConsent { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerName
    /// </summary>
    public string? EDisclosureBorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerRejectConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentIP
    /// </summary>
    public string? EDisclosureBorrowerRejectConsentIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerViewConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerViewConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerViewMessageDate
    /// </summary>
    public DateTime? EDisclosureBorrowerViewMessageDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureBorrowerWetSignedDate
    /// </summary>
    public DateTime? EDisclosureBorrowerWetSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentIP
    /// </summary>
    public string? EDisclosureCoBorrowerAcceptConsentIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerAuthenticatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedIP
    /// </summary>
    public string? EDisclosureCoBorrowerAuthenticatedIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerDocumentViewedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerDocumentViewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerEmail
    /// </summary>
    public string? EDisclosureCoBorrowerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowereSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedIP
    /// </summary>
    public string? EDisclosureCoBorrowereSignedIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerLoanLevelConsent
    /// </summary>
    public string? EDisclosureCoBorrowerLoanLevelConsent { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerName
    /// </summary>
    public string? EDisclosureCoBorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentIP
    /// </summary>
    public string? EDisclosureCoBorrowerRejectConsentIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerViewConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerViewConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerViewMessageDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerViewMessageDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureCoBorrowerWebSignedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerWebSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureConsentPdf
    /// </summary>
    public string? EDisclosureConsentPdf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureDisclosedMessage
    /// </summary>
    public string? EDisclosureDisclosedMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureLockPackageIndicator
    /// </summary>
    public bool? EDisclosureLockPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureLOeSignedDate
    /// </summary>
    public DateTime? EDisclosureLOeSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureLOeSignedIP
    /// </summary>
    public string? EDisclosureLOeSignedIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureLOName
    /// </summary>
    public string? EDisclosureLOName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureLOViewMessageDate
    /// </summary>
    public DateTime? EDisclosureLOViewMessageDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureManualFulfillmentComment
    /// </summary>
    public string? EDisclosureManualFulfillmentComment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureManualFulfillmentDate
    /// </summary>
    public DateTime? EDisclosureManualFulfillmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureManualFulfillmentMethod
    /// </summary>
    public string? EDisclosureManualFulfillmentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureManuallyFulfilledBy
    /// </summary>
    public string? EDisclosureManuallyFulfilledBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosurePackageCreatedDate
    /// </summary>
    public DateTime? EDisclosurePackageCreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosurePackageId
    /// </summary>
    public string? EDisclosurePackageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosurePackageViewableFile
    /// </summary>
    public string? EDisclosurePackageViewableFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDisclosureThreeDayPackageIndicator
    /// </summary>
    public bool? EDisclosureThreeDayPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EDSRequestGuid
    /// </summary>
    public string? EDSRequestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log EstimatedTotalPayoffsAndPaymentsAmount
    /// </summary>
    public string? EstimatedTotalPayoffsAndPaymentsAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log FinanceCharge
    /// </summary>
    public string? FinanceCharge { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Forms
    /// </summary>
    [AllowNull]
    public IList<DisclosureForm> Forms { get => GetList<DisclosureForm>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTracking2015Log FormsXml
    /// </summary>
    public string? FormsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log FulfillmentOrderedBy
    /// </summary>
    public string? FulfillmentOrderedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log FulfillmentOrderedByCoBorrower
    /// </summary>
    public string? FulfillmentOrderedByCoBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log FullfillmentProcessedDate
    /// </summary>
    public string? FullfillmentProcessedDate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log FullfillmentProcessedDateCoBorrower
    /// </summary>
    public DateTime? FullfillmentProcessedDateCoBorrower { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IntentToProceed
    /// </summary>
    public bool? IntentToProceed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IntentToProceedComments
    /// </summary>
    public string? IntentToProceedComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IntentToProceedDate
    /// </summary>
    public DateTime? IntentToProceedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IntentToProceedReceivedBy
    /// </summary>
    public string? IntentToProceedReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IntentToProceedReceivedMethod
    /// </summary>
    public string? IntentToProceedReceivedMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IntentToProceedReceivedMethodOther
    /// </summary>
    public string? IntentToProceedReceivedMethodOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsBorrowerPresumedDateLocked
    /// </summary>
    public bool? IsBorrowerPresumedDateLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsBorrowerTypeLocked
    /// </summary>
    public bool? IsBorrowerTypeLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsCoBorrowerPresumedDateLocked
    /// </summary>
    public bool? IsCoBorrowerPresumedDateLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsCoBorrowerTypeLocked
    /// </summary>
    public bool? IsCoBorrowerTypeLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsDisclosed
    /// </summary>
    public string? IsDisclosed { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsDisclosedAprLocked
    /// </summary>
    public string? IsDisclosedAprLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsDisclosedByLocked
    /// </summary>
    public string? IsDisclosedByLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsDisclosedDailyInterestLocked
    /// </summary>
    public bool? IsDisclosedDailyInterestLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsDisclosedFinanceChargeLocked
    /// </summary>
    public string? IsDisclosedFinanceChargeLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsDisclosedReceivedDateLocked
    /// </summary>
    public string? IsDisclosedReceivedDateLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsIntentReceivedByLocked
    /// </summary>
    public bool? IsIntentReceivedByLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsLocked
    /// </summary>
    public string? IsLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log IsWetSignedIndicator
    /// </summary>
    public bool? IsWetSignedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LenderCompensationCreditAmount2
    /// </summary>
    public string? LenderCompensationCreditAmount2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LenderTotalPaidOriginatorAmount
    /// </summary>
    public string? LenderTotalPaidOriginatorAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceEligibility
    /// </summary>
    public bool? LEReasonIsChangedCircumstanceEligibility { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceSettlementCharges
    /// </summary>
    public bool? LEReasonIsChangedCircumstanceSettlementCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonIsDelayedSettlementOnConstructionLoans
    /// </summary>
    public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonIsExpiration
    /// </summary>
    public bool? LEReasonIsExpiration { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonIsInterestRateDependentCharges
    /// </summary>
    public bool? LEReasonIsInterestRateDependentCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonIsOther
    /// </summary>
    public bool? LEReasonIsOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonIsRevisionsRequestedByConsumer
    /// </summary>
    public bool? LEReasonIsRevisionsRequestedByConsumer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LEReasonOther
    /// </summary>
    public string? LEReasonOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line802LOCompAdditionalAmount1
    /// </summary>
    public string? Line802LOCompAdditionalAmount1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line802LOCompAdditionalAmount2
    /// </summary>
    public string? Line802LOCompAdditionalAmount2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line907InsuranceIndicator2015
    /// </summary>
    public string? Line907InsuranceIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line907PropertyIndicator2015
    /// </summary>
    public string? Line907PropertyIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line907TaxesIndicator2015
    /// </summary>
    public string? Line907TaxesIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line908InsuranceIndicator2015
    /// </summary>
    public string? Line908InsuranceIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line908PropertyIndicator2015
    /// </summary>
    public string? Line908PropertyIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line908TaxesIndicator2015
    /// </summary>
    public string? Line908TaxesIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line909InsuranceIndicator2015
    /// </summary>
    public string? Line909InsuranceIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line909PropertyIndicator2015
    /// </summary>
    public string? Line909PropertyIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line909TaxesIndicator2015
    /// </summary>
    public string? Line909TaxesIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line910InsuranceIndicator2015
    /// </summary>
    public string? Line910InsuranceIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line910PropertyIndicator2015
    /// </summary>
    public string? Line910PropertyIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line910TaxesIndicator2015
    /// </summary>
    public string? Line910TaxesIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line911InsuranceIndicator2015
    /// </summary>
    public string? Line911InsuranceIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line911PropertyIndicator2015
    /// </summary>
    public string? Line911PropertyIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line911TaxesIndicator2015
    /// </summary>
    public string? Line911TaxesIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line912InsuranceIndicator2015
    /// </summary>
    public string? Line912InsuranceIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line912PropertyIndicator2015
    /// </summary>
    public string? Line912PropertyIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log Line912TaxesIndicator2015
    /// </summary>
    public string? Line912TaxesIndicator2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LinkedGuid
    /// </summary>
    public string? LinkedGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanAdjustmentsOtherCredits
    /// </summary>
    public string? LoanAdjustmentsOtherCredits { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanAmount
    /// </summary>
    public string? LoanAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCost2BorrowerClosingCostAtClosing
    /// </summary>
    public string? LoanClosingCost2BorrowerClosingCostAtClosing { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCost2LenderCredits
    /// </summary>
    public string? LoanClosingCost2LenderCredits { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCost2TotalLoanCost
    /// </summary>
    public string? LoanClosingCost2TotalLoanCost { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCost2TotalOtherCost
    /// </summary>
    public string? LoanClosingCost2TotalOtherCost { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCost3StdLegalLimit
    /// </summary>
    public string? LoanClosingCost3StdLegalLimit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCostGfe1200BorPaidAmount
    /// </summary>
    public string? LoanClosingCostGfe1200BorPaidAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCostGfe800BorPaidAmount
    /// </summary>
    public string? LoanClosingCostGfe800BorPaidAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCostLenderCredits
    /// </summary>
    public string? LoanClosingCostLenderCredits { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCostSection1000BorrowerTotalPaidAmount
    /// </summary>
    public string? LoanClosingCostSection1000BorrowerTotalPaidAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCostsFinanced
    /// </summary>
    public string? LoanClosingCostsFinanced { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanClosingCostTotalFeeAmount2015
    /// </summary>
    public string? LoanClosingCostTotalFeeAmount2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanDownPayment
    /// </summary>
    public string? LoanDownPayment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanEstimate2TotalLoanAndOtherCosts
    /// </summary>
    public string? LoanEstimate2TotalLoanAndOtherCosts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanEstimate2TotalLoanCosts
    /// </summary>
    public string? LoanEstimate2TotalLoanCosts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanEstimate2TotalOtherCosts
    /// </summary>
    public string? LoanEstimate2TotalOtherCosts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalLoanCosts
    /// </summary>
    public string? LoanEstimate2UnroundedTotalLoanCosts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalOtherCosts
    /// </summary>
    public string? LoanEstimate2UnroundedTotalOtherCosts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanEstimateLoanProduct
    /// </summary>
    public string? LoanEstimateLoanProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanFeesCityTaxBorPaidAmount
    /// </summary>
    public string? LoanFeesCityTaxBorPaidAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanFeesStateTaxBorPaidAmount
    /// </summary>
    public string? LoanFeesStateTaxBorPaidAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanFundsForBorrower
    /// </summary>
    public string? LoanFundsForBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanGfeAgregateAdjustment
    /// </summary>
    public string? LoanGfeAgregateAdjustment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanGfeGovermentRecordingCharges
    /// </summary>
    public string? LoanGfeGovermentRecordingCharges { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanLineItemAmount
    /// </summary>
    public string? LoanLineItemAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanProgram
    /// </summary>
    public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditAmount1
    /// </summary>
    public string? LoanPurchaseCreditAmount1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditAmount2
    /// </summary>
    public string? LoanPurchaseCreditAmount2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditAmount3
    /// </summary>
    public string? LoanPurchaseCreditAmount3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditAmount4
    /// </summary>
    public string? LoanPurchaseCreditAmount4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditType1
    /// </summary>
    public string? LoanPurchaseCreditType1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditType2
    /// </summary>
    public string? LoanPurchaseCreditType2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditType3
    /// </summary>
    public string? LoanPurchaseCreditType3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanPurchaseCreditType4
    /// </summary>
    public string? LoanPurchaseCreditType4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanRefinanceIncludingDebtsToBePaidOffAmount
    /// </summary>
    public string? LoanRefinanceIncludingDebtsToBePaidOffAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanSection1000SellerPaidTotalAmount
    /// </summary>
    public string? LoanSection1000SellerPaidTotalAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanSellerCreditAmount
    /// </summary>
    public string? LoanSellerCreditAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LoanTotalClosingCosts
    /// </summary>
    public string? LoanTotalClosingCosts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedBorrowerPresumedReceivedDate
    /// </summary>
    public DateTime? LockedBorrowerPresumedReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedBorrowerType
    /// </summary>
    public string? LockedBorrowerType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedCoBorrowerPresumedReceivedDate
    /// </summary>
    public DateTime? LockedCoBorrowerPresumedReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedCoBorrowerType
    /// </summary>
    public string? LockedCoBorrowerType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedDisclosedAprField
    /// </summary>
    public string? LockedDisclosedAprField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedDisclosedByField
    /// </summary>
    public string? LockedDisclosedByField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedDisclosedDailyInterestField
    /// </summary>
    public string? LockedDisclosedDailyInterestField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedDisclosedDateField
    /// </summary>
    public DateTime? LockedDisclosedDateField { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedDisclosedFinanceChargeField
    /// </summary>
    public string? LockedDisclosedFinanceChargeField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedDisclosedReceivedDate
    /// </summary>
    public DateTime? LockedDisclosedReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LockedIntentReceivedByField
    /// </summary>
    public string? LockedIntentReceivedByField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ManuallyCreated
    /// </summary>
    public string? ManuallyCreated { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log NumberOfDisclosureDocs
    /// </summary>
    public int? NumberOfDisclosureDocs { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log PrepaymentPenaltyIndicator
    /// </summary>
    public string? PrepaymentPenaltyIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log PresumedFulfillmentDate
    /// </summary>
    public DateTime? PresumedFulfillmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log PropertyAddress
    /// </summary>
    public string? PropertyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log PropertyCity
    /// </summary>
    public string? PropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log PropertyState
    /// </summary>
    public string? PropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log PropertyZip
    /// </summary>
    public string? PropertyZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ProviderListNoFeeSent
    /// </summary>
    public bool? ProviderListNoFeeSent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ProviderListSent
    /// </summary>
    public bool? ProviderListSent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log PurchasePriceAmount
    /// </summary>
    public string? PurchasePriceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log RevisedDueDate
    /// </summary>
    public DateTime? RevisedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log SnapshotFields
    /// </summary>
    [AllowNull]
    public IList<LogSnapshotField> SnapshotFields { get => GetList<LogSnapshotField>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTracking2015Log SnapshotXml
    /// </summary>
    public string? SnapshotXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log STDAdjustmentAndOtherCreditsRemark
    /// </summary>
    public string? STDAdjustmentAndOtherCreditsRemark { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log UCDCreationError
    /// </summary>
    public bool? UCDCreationError { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTracking2015Log UseForUcdExport
    /// </summary>
    public bool? UseForUcdExport { get => GetValue<bool?>(); set => SetValue(value); }
}