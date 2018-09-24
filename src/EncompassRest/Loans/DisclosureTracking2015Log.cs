using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DisclosureTracking2015Log
    /// </summary>
    public sealed partial class DisclosureTracking2015Log : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _actualFulfillmentDate;
        private DirtyList<LogAlert> _alerts;
        private DirtyValue<string> _alertsXml;
        private DirtyValue<DateTime?> _applicationDate;
        private DirtyValue<string> _appliedCureAmount;
        private DirtyValue<string> _automaticFullfillmentServiceName;
        private DirtyValue<DateTime?> _borrowerActualReceivedDate;
        private DirtyValue<string> _borrowerDisclosedMethod;
        private DirtyValue<string> _borrowerDisclosedMethodOther;
        private DirtyValue<string> _borrowerName;
        private DirtyValue<string> _borrowerPairId;
        private DirtyValue<DateTime?> _borrowerPresumedReceivedDate;
        private DirtyValue<string> _borrowerType;
        private DirtyValue<bool?> _brokerDisclosed;
        private DirtyValue<bool?> _cDReasonIs24HourAdvancePreview;
        private DirtyValue<bool?> _cDReasonIsChangedCircumstanceEligibility;
        private DirtyValue<bool?> _cDReasonIsChangeInAPR;
        private DirtyValue<bool?> _cDReasonIsChangeInLoanProduct;
        private DirtyValue<bool?> _cDReasonIsChangeInSettlementCharges;
        private DirtyValue<bool?> _cDReasonIsClericalErrorCorrection;
        private DirtyValue<bool?> _cDReasonIsInterestRateDependentCharges;
        private DirtyValue<bool?> _cDReasonIsOther;
        private DirtyValue<bool?> _cDReasonIsPrepaymentPenaltyAdded;
        private DirtyValue<bool?> _cDReasonIsRevisionsRequestedByConsumer;
        private DirtyValue<bool?> _cDReasonIsToleranceCure;
        private DirtyValue<string> _cDReasonOther;
        private DirtyValue<string> _changeInCircumstance;
        private DirtyValue<string> _changeInCircumstanceComments;
        private DirtyValue<DateTime?> _changesReceivedDate;
        private DirtyValue<string> _chargesCannotIncrease10Itemization34;
        private DirtyValue<string> _chargesCannotIncrease10LE32;
        private DirtyValue<string> _chargesThatCannotDecreaseItemization9;
        private DirtyValue<string> _chargesThatCannotDecreaseLE7;
        private DirtyValue<string> _chargesThatCannotIncreaseItemization13;
        private DirtyValue<string> _chargesThatCannotIncreaseLE11;
        private DirtyValue<DateTime?> _coBorrowerActualReceivedDate;
        private DirtyValue<string> _coBorrowerDisclosedMethod;
        private DirtyValue<string> _coBorrowerDisclosedMethodOther;
        private DirtyValue<string> _coBorrowerName;
        private DirtyValue<DateTime?> _coBorrowerPresumedReceivedDate;
        private DirtyValue<string> _coBorrowerType;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _commentListXml;
        private DirtyValue<string> _comments;
        private DirtyValue<bool?> _containCD;
        private DirtyValue<bool?> _containLE;
        private DirtyValue<bool?> _containSafeHarbor;
        private DirtyValue<string> _cureAppliedToLenderCredit;
        private DirtyValue<string> _cureAppliedToPrincipalReduction;
        private DirtyValue<DateTime?> _dateAdded;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<string> _disclosedAPR;
        private DirtyValue<string> _disclosedBy;
        private DirtyValue<string> _disclosedByFullName;
        private DirtyValue<string> _disclosedDailyInterest;
        private DirtyValue<DateTime?> _disclosedDate;
        private DirtyValue<bool?> _disclosedForCD;
        private DirtyValue<bool?> _disclosedForLE;
        private DirtyValue<string> _disclosedMethod;
        private DirtyValue<string> _disclosedMethodName;
        private DirtyValue<string> _disclosedMethodOther;
        private DirtyValue<string> _disclosedSalesPrice;
        private DirtyValue<DateTime?> _disclosureCreatedDttmUtc;
        private DirtyValue<string> _disclosureMethod;
        private DirtyValue<string> _disclosureType;
        private DirtyValue<bool?> _eDisclosureApplicationPackageIndicator;
        private DirtyValue<bool?> _eDisclosureApprovalPackageIndicator;
        private DirtyValue<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        private DirtyValue<string> _eDisclosureBorrowerAcceptConsentIP;
        private DirtyValue<DateTime?> _eDisclosureBorrowerAuthenticatedDate;
        private DirtyValue<string> _eDisclosureBorrowerAuthenticatedIP;
        private DirtyValue<DateTime?> _eDisclosureBorrowerDocumentViewedDate;
        private DirtyValue<string> _eDisclosureBorrowerEmail;
        private DirtyValue<DateTime?> _eDisclosureBorrowereSignedDate;
        private DirtyValue<string> _eDisclosureBorrowereSignedIP;
        private DirtyValue<string> _eDisclosureBorrowerLoanLevelConsent;
        private DirtyValue<string> _eDisclosureBorrowerName;
        private DirtyValue<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        private DirtyValue<string> _eDisclosureBorrowerRejectConsentIP;
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewConsentDate;
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewMessageDate;
        private DirtyValue<DateTime?> _eDisclosureBorrowerWetSignedDate;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        private DirtyValue<string> _eDisclosureCoBorrowerAcceptConsentIP;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAuthenticatedDate;
        private DirtyValue<string> _eDisclosureCoBorrowerAuthenticatedIP;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerDocumentViewedDate;
        private DirtyValue<string> _eDisclosureCoBorrowerEmail;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowereSignedDate;
        private DirtyValue<string> _eDisclosureCoBorrowereSignedIP;
        private DirtyValue<string> _eDisclosureCoBorrowerLoanLevelConsent;
        private DirtyValue<string> _eDisclosureCoBorrowerName;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        private DirtyValue<string> _eDisclosureCoBorrowerRejectConsentIP;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        private DirtyValue<string> _eDisclosureConsentPdf;
        private DirtyValue<string> _eDisclosureDisclosedMessage;
        private DirtyValue<bool?> _eDisclosureLockPackageIndicator;
        private DirtyValue<DateTime?> _eDisclosureLOeSignedDate;
        private DirtyValue<string> _eDisclosureLOeSignedIP;
        private DirtyValue<string> _eDisclosureLOName;
        private DirtyValue<DateTime?> _eDisclosureLOViewMessageDate;
        private DirtyValue<string> _eDisclosureManualFulfillmentComment;
        private DirtyValue<DateTime?> _eDisclosureManualFulfillmentDate;
        private DirtyValue<string> _eDisclosureManualFulfillmentMethod;
        private DirtyValue<string> _eDisclosureManuallyFulfilledBy;
        private DirtyValue<DateTime?> _eDisclosurePackageCreatedDate;
        private DirtyValue<string> _eDisclosurePackageId;
        private DirtyValue<string> _eDisclosurePackageViewableFile;
        private DirtyValue<bool?> _eDisclosureThreeDayPackageIndicator;
        private DirtyValue<string> _estimatedTotalPayoffsAndPaymentsAmount;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _financeCharge;
        private DirtyList<DisclosureForm> _forms;
        private DirtyValue<string> _formsXml;
        private DirtyValue<string> _fulfillmentOrderedBy;
        private DirtyValue<string> _fulfillmentOrderedByCoBorrower;
        private DirtyValue<string> _fullfillmentProcessedDate;
        private DirtyValue<DateTime?> _fullfillmentProcessedDateCoBorrower;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _intentToProceed;
        private DirtyValue<string> _intentToProceedComments;
        private DirtyValue<DateTime?> _intentToProceedDate;
        private DirtyValue<string> _intentToProceedReceivedBy;
        private DirtyValue<string> _intentToProceedReceivedMethod;
        private DirtyValue<string> _intentToProceedReceivedMethodOther;
        private DirtyValue<bool?> _isBorrowerPresumedDateLocked;
        private DirtyValue<bool?> _isBorrowerTypeLocked;
        private DirtyValue<bool?> _isCoBorrowerPresumedDateLocked;
        private DirtyValue<bool?> _isCoBorrowerTypeLocked;
        private DirtyValue<string> _isDisclosed;
        private DirtyValue<string> _isDisclosedAprLocked;
        private DirtyValue<string> _isDisclosedByLocked;
        private DirtyValue<bool?> _isDisclosedDailyInterestLocked;
        private DirtyValue<string> _isDisclosedFinanceChargeLocked;
        private DirtyValue<string> _isDisclosedReceivedDateLocked;
        private DirtyValue<bool?> _isIntentReceivedByLocked;
        private DirtyValue<string> _isLocked;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<bool?> _isWetSignedIndicator;
        private DirtyValue<string> _lenderCompensationCreditAmount2;
        private DirtyValue<string> _lenderTotalPaidOriginatorAmount;
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceEligibility;
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceSettlementCharges;
        private DirtyValue<bool?> _lEReasonIsDelayedSettlementOnConstructionLoans;
        private DirtyValue<bool?> _lEReasonIsExpiration;
        private DirtyValue<bool?> _lEReasonIsInterestRateDependentCharges;
        private DirtyValue<bool?> _lEReasonIsOther;
        private DirtyValue<bool?> _lEReasonIsRevisionsRequestedByConsumer;
        private DirtyValue<string> _lEReasonOther;
        private DirtyValue<string> _line802LOCompAdditionalAmount1;
        private DirtyValue<string> _line802LOCompAdditionalAmount2;
        private DirtyValue<string> _line907InsuranceIndicator2015;
        private DirtyValue<string> _line907PropertyIndicator2015;
        private DirtyValue<string> _line907TaxesIndicator2015;
        private DirtyValue<string> _line908InsuranceIndicator2015;
        private DirtyValue<string> _line908PropertyIndicator2015;
        private DirtyValue<string> _line908TaxesIndicator2015;
        private DirtyValue<string> _line909InsuranceIndicator2015;
        private DirtyValue<string> _line909PropertyIndicator2015;
        private DirtyValue<string> _line909TaxesIndicator2015;
        private DirtyValue<string> _line910InsuranceIndicator2015;
        private DirtyValue<string> _line910PropertyIndicator2015;
        private DirtyValue<string> _line910TaxesIndicator2015;
        private DirtyValue<string> _line911InsuranceIndicator2015;
        private DirtyValue<string> _line911PropertyIndicator2015;
        private DirtyValue<string> _line911TaxesIndicator2015;
        private DirtyValue<string> _line912InsuranceIndicator2015;
        private DirtyValue<string> _line912PropertyIndicator2015;
        private DirtyValue<string> _line912TaxesIndicator2015;
        private DirtyValue<string> _loanAdjustmentsOtherCredits;
        private DirtyValue<string> _loanAmount;
        private DirtyValue<string> _loanClosingCost2BorrowerClosingCostAtClosing;
        private DirtyValue<string> _loanClosingCost2LenderCredits;
        private DirtyValue<string> _loanClosingCost2TotalLoanCost;
        private DirtyValue<string> _loanClosingCost2TotalOtherCost;
        private DirtyValue<string> _loanClosingCost3StdLegalLimit;
        private DirtyValue<string> _loanClosingCostGfe1200BorPaidAmount;
        private DirtyValue<string> _loanClosingCostGfe800BorPaidAmount;
        private DirtyValue<string> _loanClosingCostLenderCredits;
        private DirtyValue<string> _loanClosingCostSection1000BorrowerTotalPaidAmount;
        private DirtyValue<string> _loanClosingCostsFinanced;
        private DirtyValue<string> _loanClosingCostTotalFeeAmount2015;
        private DirtyValue<string> _loanDownPayment;
        private DirtyValue<string> _loanEstimate2TotalLoanAndOtherCosts;
        private DirtyValue<string> _loanEstimate2TotalLoanCosts;
        private DirtyValue<string> _loanEstimate2TotalOtherCosts;
        private DirtyValue<string> _loanEstimate2UnroundedTotalLoanCosts;
        private DirtyValue<string> _loanEstimate2UnroundedTotalOtherCosts;
        private DirtyValue<string> _loanEstimateLoanProduct;
        private DirtyValue<string> _loanFeesCityTaxBorPaidAmount;
        private DirtyValue<string> _loanFeesStateTaxBorPaidAmount;
        private DirtyValue<string> _loanFundsForBorrower;
        private DirtyValue<string> _loanGfeAgregateAdjustment;
        private DirtyValue<string> _loanGfeGovermentRecordingCharges;
        private DirtyValue<string> _loanLineItemAmount;
        private DirtyValue<string> _loanProgram;
        private DirtyValue<string> _loanPurchaseCreditAmount1;
        private DirtyValue<string> _loanPurchaseCreditAmount2;
        private DirtyValue<string> _loanPurchaseCreditAmount3;
        private DirtyValue<string> _loanPurchaseCreditAmount4;
        private DirtyValue<string> _loanPurchaseCreditType1;
        private DirtyValue<string> _loanPurchaseCreditType2;
        private DirtyValue<string> _loanPurchaseCreditType3;
        private DirtyValue<string> _loanPurchaseCreditType4;
        private DirtyValue<string> _loanRefinanceIncludingDebtsToBePaidOffAmount;
        private DirtyValue<string> _loanSection1000SellerPaidTotalAmount;
        private DirtyValue<string> _loanSellerCreditAmount;
        private DirtyValue<string> _loanTotalClosingCosts;
        private DirtyValue<DateTime?> _lockedBorrowerPresumedReceivedDate;
        private DirtyValue<string> _lockedBorrowerType;
        private DirtyValue<DateTime?> _lockedCoBorrowerPresumedReceivedDate;
        private DirtyValue<string> _lockedCoBorrowerType;
        private DirtyValue<string> _lockedDisclosedAprField;
        private DirtyValue<string> _lockedDisclosedByField;
        private DirtyValue<string> _lockedDisclosedDailyInterestField;
        private DirtyValue<DateTime?> _lockedDisclosedDateField;
        private DirtyValue<string> _lockedDisclosedFinanceChargeField;
        private DirtyValue<DateTime?> _lockedDisclosedReceivedDate;
        private DirtyValue<string> _lockedIntentReceivedByField;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _manuallyCreated;
        private DirtyValue<int?> _numberOfDisclosureDocs;
        private DirtyValue<string> _prepaymentPenaltyIndicator;
        private DirtyValue<DateTime?> _presumedFulfillmentDate;
        private DirtyValue<string> _propertyAddress;
        private DirtyValue<string> _propertyCity;
        private DirtyValue<string> _propertyState;
        private DirtyValue<string> _propertyZip;
        private DirtyValue<bool?> _providerListSent;
        private DirtyValue<string> _purchasePriceAmount;
        private DirtyValue<DateTime?> _receivedDate;
        private DirtyValue<DateTime?> _revisedDueDate;
        private DirtyList<LogSnapshotField> _snapshotFields;
        private DirtyValue<string> _snapshotXml;
        private DirtyValue<string> _systemId;

        /// <summary>
        /// DisclosureTracking2015Log ActualFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ActualFulfillmentDate { get => _actualFulfillmentDate; set => SetField(ref _actualFulfillmentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// DisclosureTracking2015Log AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// DisclosureTracking2015Log ApplicationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log AppliedCureAmount
        /// </summary>
        public string AppliedCureAmount { get => _appliedCureAmount; set => SetField(ref _appliedCureAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log AutomaticFullfillmentServiceName
        /// </summary>
        public string AutomaticFullfillmentServiceName { get => _automaticFullfillmentServiceName; set => SetField(ref _automaticFullfillmentServiceName, value); }

        /// <summary>
        /// DisclosureTracking2015Log BorrowerActualReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BorrowerActualReceivedDate { get => _borrowerActualReceivedDate; set => SetField(ref _borrowerActualReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log BorrowerDisclosedMethod
        /// </summary>
        public string BorrowerDisclosedMethod { get => _borrowerDisclosedMethod; set => SetField(ref _borrowerDisclosedMethod, value); }

        /// <summary>
        /// DisclosureTracking2015Log BorrowerDisclosedMethodOther
        /// </summary>
        public string BorrowerDisclosedMethodOther { get => _borrowerDisclosedMethodOther; set => SetField(ref _borrowerDisclosedMethodOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log BorrowerName
        /// </summary>
        public string BorrowerName { get => _borrowerName; set => SetField(ref _borrowerName, value); }

        /// <summary>
        /// DisclosureTracking2015Log BorrowerPairId
        /// </summary>
        public string BorrowerPairId { get => _borrowerPairId; set => SetField(ref _borrowerPairId, value); }

        /// <summary>
        /// DisclosureTracking2015Log BorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BorrowerPresumedReceivedDate { get => _borrowerPresumedReceivedDate; set => SetField(ref _borrowerPresumedReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log BorrowerType
        /// </summary>
        public string BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

        /// <summary>
        /// DisclosureTracking2015Log BrokerDisclosed
        /// </summary>
        public bool? BrokerDisclosed { get => _brokerDisclosed; set => SetField(ref _brokerDisclosed, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIs24HourAdvancePreview
        /// </summary>
        public bool? CDReasonIs24HourAdvancePreview { get => _cDReasonIs24HourAdvancePreview; set => SetField(ref _cDReasonIs24HourAdvancePreview, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangedCircumstanceEligibility
        /// </summary>
        public bool? CDReasonIsChangedCircumstanceEligibility { get => _cDReasonIsChangedCircumstanceEligibility; set => SetField(ref _cDReasonIsChangedCircumstanceEligibility, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInAPR
        /// </summary>
        public bool? CDReasonIsChangeInAPR { get => _cDReasonIsChangeInAPR; set => SetField(ref _cDReasonIsChangeInAPR, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInLoanProduct
        /// </summary>
        public bool? CDReasonIsChangeInLoanProduct { get => _cDReasonIsChangeInLoanProduct; set => SetField(ref _cDReasonIsChangeInLoanProduct, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInSettlementCharges
        /// </summary>
        public bool? CDReasonIsChangeInSettlementCharges { get => _cDReasonIsChangeInSettlementCharges; set => SetField(ref _cDReasonIsChangeInSettlementCharges, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsClericalErrorCorrection
        /// </summary>
        public bool? CDReasonIsClericalErrorCorrection { get => _cDReasonIsClericalErrorCorrection; set => SetField(ref _cDReasonIsClericalErrorCorrection, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsInterestRateDependentCharges
        /// </summary>
        public bool? CDReasonIsInterestRateDependentCharges { get => _cDReasonIsInterestRateDependentCharges; set => SetField(ref _cDReasonIsInterestRateDependentCharges, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsOther
        /// </summary>
        public bool? CDReasonIsOther { get => _cDReasonIsOther; set => SetField(ref _cDReasonIsOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsPrepaymentPenaltyAdded
        /// </summary>
        public bool? CDReasonIsPrepaymentPenaltyAdded { get => _cDReasonIsPrepaymentPenaltyAdded; set => SetField(ref _cDReasonIsPrepaymentPenaltyAdded, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsRevisionsRequestedByConsumer
        /// </summary>
        public bool? CDReasonIsRevisionsRequestedByConsumer { get => _cDReasonIsRevisionsRequestedByConsumer; set => SetField(ref _cDReasonIsRevisionsRequestedByConsumer, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsToleranceCure
        /// </summary>
        public bool? CDReasonIsToleranceCure { get => _cDReasonIsToleranceCure; set => SetField(ref _cDReasonIsToleranceCure, value); }

        /// <summary>
        /// DisclosureTracking2015Log CDReasonOther
        /// </summary>
        public string CDReasonOther { get => _cDReasonOther; set => SetField(ref _cDReasonOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChangeInCircumstance
        /// </summary>
        public string ChangeInCircumstance { get => _changeInCircumstance; set => SetField(ref _changeInCircumstance, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChangeInCircumstanceComments
        /// </summary>
        public string ChangeInCircumstanceComments { get => _changeInCircumstanceComments; set => SetField(ref _changeInCircumstanceComments, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChangesReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => SetField(ref _changesReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChargesCannotIncrease10Itemization34
        /// </summary>
        public string ChargesCannotIncrease10Itemization34 { get => _chargesCannotIncrease10Itemization34; set => SetField(ref _chargesCannotIncrease10Itemization34, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChargesCannotIncrease10LE32
        /// </summary>
        public string ChargesCannotIncrease10LE32 { get => _chargesCannotIncrease10LE32; set => SetField(ref _chargesCannotIncrease10LE32, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotDecreaseItemization9
        /// </summary>
        public string ChargesThatCannotDecreaseItemization9 { get => _chargesThatCannotDecreaseItemization9; set => SetField(ref _chargesThatCannotDecreaseItemization9, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotDecreaseLE7
        /// </summary>
        public string ChargesThatCannotDecreaseLE7 { get => _chargesThatCannotDecreaseLE7; set => SetField(ref _chargesThatCannotDecreaseLE7, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotIncreaseItemization13
        /// </summary>
        public string ChargesThatCannotIncreaseItemization13 { get => _chargesThatCannotIncreaseItemization13; set => SetField(ref _chargesThatCannotIncreaseItemization13, value); }

        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotIncreaseLE11
        /// </summary>
        public string ChargesThatCannotIncreaseLE11 { get => _chargesThatCannotIncreaseLE11; set => SetField(ref _chargesThatCannotIncreaseLE11, value); }

        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerActualReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CoBorrowerActualReceivedDate { get => _coBorrowerActualReceivedDate; set => SetField(ref _coBorrowerActualReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerDisclosedMethod
        /// </summary>
        public string CoBorrowerDisclosedMethod { get => _coBorrowerDisclosedMethod; set => SetField(ref _coBorrowerDisclosedMethod, value); }

        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerDisclosedMethodOther
        /// </summary>
        public string CoBorrowerDisclosedMethodOther { get => _coBorrowerDisclosedMethodOther; set => SetField(ref _coBorrowerDisclosedMethodOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerName
        /// </summary>
        public string CoBorrowerName { get => _coBorrowerName; set => SetField(ref _coBorrowerName, value); }

        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CoBorrowerPresumedReceivedDate { get => _coBorrowerPresumedReceivedDate; set => SetField(ref _coBorrowerPresumedReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerType
        /// </summary>
        public string CoBorrowerType { get => _coBorrowerType; set => SetField(ref _coBorrowerType, value); }

        /// <summary>
        /// DisclosureTracking2015Log CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// DisclosureTracking2015Log CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// DisclosureTracking2015Log Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// DisclosureTracking2015Log ContainCD
        /// </summary>
        public bool? ContainCD { get => _containCD; set => SetField(ref _containCD, value); }

        /// <summary>
        /// DisclosureTracking2015Log ContainLE
        /// </summary>
        public bool? ContainLE { get => _containLE; set => SetField(ref _containLE, value); }

        /// <summary>
        /// DisclosureTracking2015Log ContainSafeHarbor
        /// </summary>
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => SetField(ref _containSafeHarbor, value); }

        /// <summary>
        /// DisclosureTracking2015Log CureAppliedToLenderCredit
        /// </summary>
        public string CureAppliedToLenderCredit { get => _cureAppliedToLenderCredit; set => SetField(ref _cureAppliedToLenderCredit, value); }

        /// <summary>
        /// DisclosureTracking2015Log CureAppliedToPrincipalReduction
        /// </summary>
        public string CureAppliedToPrincipalReduction { get => _cureAppliedToPrincipalReduction; set => SetField(ref _cureAppliedToPrincipalReduction, value); }

        /// <summary>
        /// DisclosureTracking2015Log DateAdded
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAdded { get => _dateAdded; set => SetField(ref _dateAdded, value); }

        /// <summary>
        /// DisclosureTracking2015Log DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedAPR
        /// </summary>
        public string DisclosedAPR { get => _disclosedAPR; set => SetField(ref _disclosedAPR, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedBy
        /// </summary>
        public string DisclosedBy { get => _disclosedBy; set => SetField(ref _disclosedBy, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedByFullName
        /// </summary>
        public string DisclosedByFullName { get => _disclosedByFullName; set => SetField(ref _disclosedByFullName, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedDailyInterest
        /// </summary>
        public string DisclosedDailyInterest { get => _disclosedDailyInterest; set => SetField(ref _disclosedDailyInterest, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisclosedDate { get => _disclosedDate; set => SetField(ref _disclosedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedForCD
        /// </summary>
        public bool? DisclosedForCD { get => _disclosedForCD; set => SetField(ref _disclosedForCD, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedForLE
        /// </summary>
        public bool? DisclosedForLE { get => _disclosedForLE; set => SetField(ref _disclosedForLE, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethod
        /// </summary>
        public string DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethodName
        /// </summary>
        public string DisclosedMethodName { get => _disclosedMethodName; set => SetField(ref _disclosedMethodName, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethodOther
        /// </summary>
        public string DisclosedMethodOther { get => _disclosedMethodOther; set => SetField(ref _disclosedMethodOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosedSalesPrice
        /// </summary>
        public string DisclosedSalesPrice { get => _disclosedSalesPrice; set => SetField(ref _disclosedSalesPrice, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosureCreatedDttmUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => SetField(ref _disclosureCreatedDttmUtc, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosureMethod
        /// </summary>
        public string DisclosureMethod { get => _disclosureMethod; set => SetField(ref _disclosureMethod, value); }

        /// <summary>
        /// DisclosureTracking2015Log DisclosureType
        /// </summary>
        public string DisclosureType { get => _disclosureType; set => SetField(ref _disclosureType, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureApplicationPackageIndicator
        /// </summary>
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => SetField(ref _eDisclosureApplicationPackageIndicator, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureApprovalPackageIndicator
        /// </summary>
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => SetField(ref _eDisclosureApprovalPackageIndicator, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureBorrowerAcceptConsentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentIP
        /// </summary>
        public string EDisclosureBorrowerAcceptConsentIP { get => _eDisclosureBorrowerAcceptConsentIP; set => SetField(ref _eDisclosureBorrowerAcceptConsentIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerAuthenticatedDate { get => _eDisclosureBorrowerAuthenticatedDate; set => SetField(ref _eDisclosureBorrowerAuthenticatedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedIP
        /// </summary>
        public string EDisclosureBorrowerAuthenticatedIP { get => _eDisclosureBorrowerAuthenticatedIP; set => SetField(ref _eDisclosureBorrowerAuthenticatedIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerDocumentViewedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerDocumentViewedDate { get => _eDisclosureBorrowerDocumentViewedDate; set => SetField(ref _eDisclosureBorrowerDocumentViewedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerEmail
        /// </summary>
        public string EDisclosureBorrowerEmail { get => _eDisclosureBorrowerEmail; set => SetField(ref _eDisclosureBorrowerEmail, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => SetField(ref _eDisclosureBorrowereSignedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowereSignedIP
        /// </summary>
        public string EDisclosureBorrowereSignedIP { get => _eDisclosureBorrowereSignedIP; set => SetField(ref _eDisclosureBorrowereSignedIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerLoanLevelConsent
        /// </summary>
        public string EDisclosureBorrowerLoanLevelConsent { get => _eDisclosureBorrowerLoanLevelConsent; set => SetField(ref _eDisclosureBorrowerLoanLevelConsent, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerName
        /// </summary>
        public string EDisclosureBorrowerName { get => _eDisclosureBorrowerName; set => SetField(ref _eDisclosureBorrowerName, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => SetField(ref _eDisclosureBorrowerRejectConsentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentIP
        /// </summary>
        public string EDisclosureBorrowerRejectConsentIP { get => _eDisclosureBorrowerRejectConsentIP; set => SetField(ref _eDisclosureBorrowerRejectConsentIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => SetField(ref _eDisclosureBorrowerViewConsentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => SetField(ref _eDisclosureBorrowerViewMessageDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerWetSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => SetField(ref _eDisclosureBorrowerWetSignedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureCoBorrowerAcceptConsentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentIP
        /// </summary>
        public string EDisclosureCoBorrowerAcceptConsentIP { get => _eDisclosureCoBorrowerAcceptConsentIP; set => SetField(ref _eDisclosureCoBorrowerAcceptConsentIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerAuthenticatedDate { get => _eDisclosureCoBorrowerAuthenticatedDate; set => SetField(ref _eDisclosureCoBorrowerAuthenticatedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedIP
        /// </summary>
        public string EDisclosureCoBorrowerAuthenticatedIP { get => _eDisclosureCoBorrowerAuthenticatedIP; set => SetField(ref _eDisclosureCoBorrowerAuthenticatedIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerDocumentViewedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerDocumentViewedDate { get => _eDisclosureCoBorrowerDocumentViewedDate; set => SetField(ref _eDisclosureCoBorrowerDocumentViewedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerEmail
        /// </summary>
        public string EDisclosureCoBorrowerEmail { get => _eDisclosureCoBorrowerEmail; set => SetField(ref _eDisclosureCoBorrowerEmail, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => SetField(ref _eDisclosureCoBorrowereSignedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedIP
        /// </summary>
        public string EDisclosureCoBorrowereSignedIP { get => _eDisclosureCoBorrowereSignedIP; set => SetField(ref _eDisclosureCoBorrowereSignedIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerLoanLevelConsent
        /// </summary>
        public string EDisclosureCoBorrowerLoanLevelConsent { get => _eDisclosureCoBorrowerLoanLevelConsent; set => SetField(ref _eDisclosureCoBorrowerLoanLevelConsent, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerName
        /// </summary>
        public string EDisclosureCoBorrowerName { get => _eDisclosureCoBorrowerName; set => SetField(ref _eDisclosureCoBorrowerName, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => SetField(ref _eDisclosureCoBorrowerRejectConsentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentIP
        /// </summary>
        public string EDisclosureCoBorrowerRejectConsentIP { get => _eDisclosureCoBorrowerRejectConsentIP; set => SetField(ref _eDisclosureCoBorrowerRejectConsentIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => SetField(ref _eDisclosureCoBorrowerViewConsentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => SetField(ref _eDisclosureCoBorrowerViewMessageDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerWebSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => SetField(ref _eDisclosureCoBorrowerWebSignedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureConsentPdf
        /// </summary>
        public string EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => SetField(ref _eDisclosureConsentPdf, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureDisclosedMessage
        /// </summary>
        public string EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => SetField(ref _eDisclosureDisclosedMessage, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLockPackageIndicator
        /// </summary>
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => SetField(ref _eDisclosureLockPackageIndicator, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOeSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureLOeSignedDate { get => _eDisclosureLOeSignedDate; set => SetField(ref _eDisclosureLOeSignedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOeSignedIP
        /// </summary>
        public string EDisclosureLOeSignedIP { get => _eDisclosureLOeSignedIP; set => SetField(ref _eDisclosureLOeSignedIP, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOName
        /// </summary>
        public string EDisclosureLOName { get => _eDisclosureLOName; set => SetField(ref _eDisclosureLOName, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureLOViewMessageDate { get => _eDisclosureLOViewMessageDate; set => SetField(ref _eDisclosureLOViewMessageDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentComment
        /// </summary>
        public string EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => SetField(ref _eDisclosureManualFulfillmentComment, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => SetField(ref _eDisclosureManualFulfillmentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentMethod
        /// </summary>
        public string EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => SetField(ref _eDisclosureManualFulfillmentMethod, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManuallyFulfilledBy
        /// </summary>
        public string EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => SetField(ref _eDisclosureManuallyFulfilledBy, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageCreatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => SetField(ref _eDisclosurePackageCreatedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageId
        /// </summary>
        public string EDisclosurePackageId { get => _eDisclosurePackageId; set => SetField(ref _eDisclosurePackageId, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageViewableFile
        /// </summary>
        public string EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => SetField(ref _eDisclosurePackageViewableFile, value); }

        /// <summary>
        /// DisclosureTracking2015Log EDisclosureThreeDayPackageIndicator
        /// </summary>
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => SetField(ref _eDisclosureThreeDayPackageIndicator, value); }

        /// <summary>
        /// DisclosureTracking2015Log EstimatedTotalPayoffsAndPaymentsAmount
        /// </summary>
        public string EstimatedTotalPayoffsAndPaymentsAmount { get => _estimatedTotalPayoffsAndPaymentsAmount; set => SetField(ref _estimatedTotalPayoffsAndPaymentsAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// DisclosureTracking2015Log FinanceCharge
        /// </summary>
        public string FinanceCharge { get => _financeCharge; set => SetField(ref _financeCharge, value); }

        /// <summary>
        /// DisclosureTracking2015Log Forms
        /// </summary>
        public IList<DisclosureForm> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }

        /// <summary>
        /// DisclosureTracking2015Log FormsXml
        /// </summary>
        public string FormsXml { get => _formsXml; set => SetField(ref _formsXml, value); }

        /// <summary>
        /// DisclosureTracking2015Log FulfillmentOrderedBy
        /// </summary>
        public string FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => SetField(ref _fulfillmentOrderedBy, value); }

        /// <summary>
        /// DisclosureTracking2015Log FulfillmentOrderedByCoBorrower
        /// </summary>
        public string FulfillmentOrderedByCoBorrower { get => _fulfillmentOrderedByCoBorrower; set => SetField(ref _fulfillmentOrderedByCoBorrower, value); }

        /// <summary>
        /// DisclosureTracking2015Log FullfillmentProcessedDate
        /// </summary>
        public string FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => SetField(ref _fullfillmentProcessedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log FullfillmentProcessedDateCoBorrower
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FullfillmentProcessedDateCoBorrower { get => _fullfillmentProcessedDateCoBorrower; set => SetField(ref _fullfillmentProcessedDateCoBorrower, value); }

        /// <summary>
        /// DisclosureTracking2015Log Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// DisclosureTracking2015Log Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// DisclosureTracking2015Log IntentToProceed
        /// </summary>
        public bool? IntentToProceed { get => _intentToProceed; set => SetField(ref _intentToProceed, value); }

        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedComments
        /// </summary>
        public string IntentToProceedComments { get => _intentToProceedComments; set => SetField(ref _intentToProceedComments, value); }

        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? IntentToProceedDate { get => _intentToProceedDate; set => SetField(ref _intentToProceedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedBy
        /// </summary>
        public string IntentToProceedReceivedBy { get => _intentToProceedReceivedBy; set => SetField(ref _intentToProceedReceivedBy, value); }

        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedMethod
        /// </summary>
        public string IntentToProceedReceivedMethod { get => _intentToProceedReceivedMethod; set => SetField(ref _intentToProceedReceivedMethod, value); }

        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedMethodOther
        /// </summary>
        public string IntentToProceedReceivedMethodOther { get => _intentToProceedReceivedMethodOther; set => SetField(ref _intentToProceedReceivedMethodOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsBorrowerPresumedDateLocked
        /// </summary>
        public bool? IsBorrowerPresumedDateLocked { get => _isBorrowerPresumedDateLocked; set => SetField(ref _isBorrowerPresumedDateLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsBorrowerTypeLocked
        /// </summary>
        public bool? IsBorrowerTypeLocked { get => _isBorrowerTypeLocked; set => SetField(ref _isBorrowerTypeLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsCoBorrowerPresumedDateLocked
        /// </summary>
        public bool? IsCoBorrowerPresumedDateLocked { get => _isCoBorrowerPresumedDateLocked; set => SetField(ref _isCoBorrowerPresumedDateLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsCoBorrowerTypeLocked
        /// </summary>
        public bool? IsCoBorrowerTypeLocked { get => _isCoBorrowerTypeLocked; set => SetField(ref _isCoBorrowerTypeLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsDisclosed
        /// </summary>
        public string IsDisclosed { get => _isDisclosed; set => SetField(ref _isDisclosed, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedAprLocked
        /// </summary>
        public string IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => SetField(ref _isDisclosedAprLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedByLocked
        /// </summary>
        public string IsDisclosedByLocked { get => _isDisclosedByLocked; set => SetField(ref _isDisclosedByLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedDailyInterestLocked
        /// </summary>
        public bool? IsDisclosedDailyInterestLocked { get => _isDisclosedDailyInterestLocked; set => SetField(ref _isDisclosedDailyInterestLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedFinanceChargeLocked
        /// </summary>
        public string IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => SetField(ref _isDisclosedFinanceChargeLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedReceivedDateLocked
        /// </summary>
        public string IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => SetField(ref _isDisclosedReceivedDateLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsIntentReceivedByLocked
        /// </summary>
        public bool? IsIntentReceivedByLocked { get => _isIntentReceivedByLocked; set => SetField(ref _isIntentReceivedByLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsLocked
        /// </summary>
        public string IsLocked { get => _isLocked; set => SetField(ref _isLocked, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// DisclosureTracking2015Log IsWetSignedIndicator
        /// </summary>
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => SetField(ref _isWetSignedIndicator, value); }

        /// <summary>
        /// DisclosureTracking2015Log LenderCompensationCreditAmount2
        /// </summary>
        public string LenderCompensationCreditAmount2 { get => _lenderCompensationCreditAmount2; set => SetField(ref _lenderCompensationCreditAmount2, value); }

        /// <summary>
        /// DisclosureTracking2015Log LenderTotalPaidOriginatorAmount
        /// </summary>
        public string LenderTotalPaidOriginatorAmount { get => _lenderTotalPaidOriginatorAmount; set => SetField(ref _lenderTotalPaidOriginatorAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceEligibility
        /// </summary>
        public bool? LEReasonIsChangedCircumstanceEligibility { get => _lEReasonIsChangedCircumstanceEligibility; set => SetField(ref _lEReasonIsChangedCircumstanceEligibility, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceSettlementCharges
        /// </summary>
        public bool? LEReasonIsChangedCircumstanceSettlementCharges { get => _lEReasonIsChangedCircumstanceSettlementCharges; set => SetField(ref _lEReasonIsChangedCircumstanceSettlementCharges, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsDelayedSettlementOnConstructionLoans
        /// </summary>
        public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get => _lEReasonIsDelayedSettlementOnConstructionLoans; set => SetField(ref _lEReasonIsDelayedSettlementOnConstructionLoans, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsExpiration
        /// </summary>
        public bool? LEReasonIsExpiration { get => _lEReasonIsExpiration; set => SetField(ref _lEReasonIsExpiration, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsInterestRateDependentCharges
        /// </summary>
        public bool? LEReasonIsInterestRateDependentCharges { get => _lEReasonIsInterestRateDependentCharges; set => SetField(ref _lEReasonIsInterestRateDependentCharges, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsOther
        /// </summary>
        public bool? LEReasonIsOther { get => _lEReasonIsOther; set => SetField(ref _lEReasonIsOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsRevisionsRequestedByConsumer
        /// </summary>
        public bool? LEReasonIsRevisionsRequestedByConsumer { get => _lEReasonIsRevisionsRequestedByConsumer; set => SetField(ref _lEReasonIsRevisionsRequestedByConsumer, value); }

        /// <summary>
        /// DisclosureTracking2015Log LEReasonOther
        /// </summary>
        public string LEReasonOther { get => _lEReasonOther; set => SetField(ref _lEReasonOther, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line802LOCompAdditionalAmount1
        /// </summary>
        public string Line802LOCompAdditionalAmount1 { get => _line802LOCompAdditionalAmount1; set => SetField(ref _line802LOCompAdditionalAmount1, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line802LOCompAdditionalAmount2
        /// </summary>
        public string Line802LOCompAdditionalAmount2 { get => _line802LOCompAdditionalAmount2; set => SetField(ref _line802LOCompAdditionalAmount2, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line907InsuranceIndicator2015
        /// </summary>
        public string Line907InsuranceIndicator2015 { get => _line907InsuranceIndicator2015; set => SetField(ref _line907InsuranceIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line907PropertyIndicator2015
        /// </summary>
        public string Line907PropertyIndicator2015 { get => _line907PropertyIndicator2015; set => SetField(ref _line907PropertyIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line907TaxesIndicator2015
        /// </summary>
        public string Line907TaxesIndicator2015 { get => _line907TaxesIndicator2015; set => SetField(ref _line907TaxesIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line908InsuranceIndicator2015
        /// </summary>
        public string Line908InsuranceIndicator2015 { get => _line908InsuranceIndicator2015; set => SetField(ref _line908InsuranceIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line908PropertyIndicator2015
        /// </summary>
        public string Line908PropertyIndicator2015 { get => _line908PropertyIndicator2015; set => SetField(ref _line908PropertyIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line908TaxesIndicator2015
        /// </summary>
        public string Line908TaxesIndicator2015 { get => _line908TaxesIndicator2015; set => SetField(ref _line908TaxesIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line909InsuranceIndicator2015
        /// </summary>
        public string Line909InsuranceIndicator2015 { get => _line909InsuranceIndicator2015; set => SetField(ref _line909InsuranceIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line909PropertyIndicator2015
        /// </summary>
        public string Line909PropertyIndicator2015 { get => _line909PropertyIndicator2015; set => SetField(ref _line909PropertyIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line909TaxesIndicator2015
        /// </summary>
        public string Line909TaxesIndicator2015 { get => _line909TaxesIndicator2015; set => SetField(ref _line909TaxesIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line910InsuranceIndicator2015
        /// </summary>
        public string Line910InsuranceIndicator2015 { get => _line910InsuranceIndicator2015; set => SetField(ref _line910InsuranceIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line910PropertyIndicator2015
        /// </summary>
        public string Line910PropertyIndicator2015 { get => _line910PropertyIndicator2015; set => SetField(ref _line910PropertyIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line910TaxesIndicator2015
        /// </summary>
        public string Line910TaxesIndicator2015 { get => _line910TaxesIndicator2015; set => SetField(ref _line910TaxesIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line911InsuranceIndicator2015
        /// </summary>
        public string Line911InsuranceIndicator2015 { get => _line911InsuranceIndicator2015; set => SetField(ref _line911InsuranceIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line911PropertyIndicator2015
        /// </summary>
        public string Line911PropertyIndicator2015 { get => _line911PropertyIndicator2015; set => SetField(ref _line911PropertyIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line911TaxesIndicator2015
        /// </summary>
        public string Line911TaxesIndicator2015 { get => _line911TaxesIndicator2015; set => SetField(ref _line911TaxesIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line912InsuranceIndicator2015
        /// </summary>
        public string Line912InsuranceIndicator2015 { get => _line912InsuranceIndicator2015; set => SetField(ref _line912InsuranceIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line912PropertyIndicator2015
        /// </summary>
        public string Line912PropertyIndicator2015 { get => _line912PropertyIndicator2015; set => SetField(ref _line912PropertyIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log Line912TaxesIndicator2015
        /// </summary>
        public string Line912TaxesIndicator2015 { get => _line912TaxesIndicator2015; set => SetField(ref _line912TaxesIndicator2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanAdjustmentsOtherCredits
        /// </summary>
        public string LoanAdjustmentsOtherCredits { get => _loanAdjustmentsOtherCredits; set => SetField(ref _loanAdjustmentsOtherCredits, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2BorrowerClosingCostAtClosing
        /// </summary>
        public string LoanClosingCost2BorrowerClosingCostAtClosing { get => _loanClosingCost2BorrowerClosingCostAtClosing; set => SetField(ref _loanClosingCost2BorrowerClosingCostAtClosing, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2LenderCredits
        /// </summary>
        public string LoanClosingCost2LenderCredits { get => _loanClosingCost2LenderCredits; set => SetField(ref _loanClosingCost2LenderCredits, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2TotalLoanCost
        /// </summary>
        public string LoanClosingCost2TotalLoanCost { get => _loanClosingCost2TotalLoanCost; set => SetField(ref _loanClosingCost2TotalLoanCost, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2TotalOtherCost
        /// </summary>
        public string LoanClosingCost2TotalOtherCost { get => _loanClosingCost2TotalOtherCost; set => SetField(ref _loanClosingCost2TotalOtherCost, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost3StdLegalLimit
        /// </summary>
        public string LoanClosingCost3StdLegalLimit { get => _loanClosingCost3StdLegalLimit; set => SetField(ref _loanClosingCost3StdLegalLimit, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostGfe1200BorPaidAmount
        /// </summary>
        public string LoanClosingCostGfe1200BorPaidAmount { get => _loanClosingCostGfe1200BorPaidAmount; set => SetField(ref _loanClosingCostGfe1200BorPaidAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostGfe800BorPaidAmount
        /// </summary>
        public string LoanClosingCostGfe800BorPaidAmount { get => _loanClosingCostGfe800BorPaidAmount; set => SetField(ref _loanClosingCostGfe800BorPaidAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostLenderCredits
        /// </summary>
        public string LoanClosingCostLenderCredits { get => _loanClosingCostLenderCredits; set => SetField(ref _loanClosingCostLenderCredits, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostSection1000BorrowerTotalPaidAmount
        /// </summary>
        public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get => _loanClosingCostSection1000BorrowerTotalPaidAmount; set => SetField(ref _loanClosingCostSection1000BorrowerTotalPaidAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostsFinanced
        /// </summary>
        public string LoanClosingCostsFinanced { get => _loanClosingCostsFinanced; set => SetField(ref _loanClosingCostsFinanced, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostTotalFeeAmount2015
        /// </summary>
        public string LoanClosingCostTotalFeeAmount2015 { get => _loanClosingCostTotalFeeAmount2015; set => SetField(ref _loanClosingCostTotalFeeAmount2015, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanDownPayment
        /// </summary>
        public string LoanDownPayment { get => _loanDownPayment; set => SetField(ref _loanDownPayment, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalLoanAndOtherCosts
        /// </summary>
        public string LoanEstimate2TotalLoanAndOtherCosts { get => _loanEstimate2TotalLoanAndOtherCosts; set => SetField(ref _loanEstimate2TotalLoanAndOtherCosts, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalLoanCosts
        /// </summary>
        public string LoanEstimate2TotalLoanCosts { get => _loanEstimate2TotalLoanCosts; set => SetField(ref _loanEstimate2TotalLoanCosts, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalOtherCosts
        /// </summary>
        public string LoanEstimate2TotalOtherCosts { get => _loanEstimate2TotalOtherCosts; set => SetField(ref _loanEstimate2TotalOtherCosts, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalLoanCosts
        /// </summary>
        public string LoanEstimate2UnroundedTotalLoanCosts { get => _loanEstimate2UnroundedTotalLoanCosts; set => SetField(ref _loanEstimate2UnroundedTotalLoanCosts, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalOtherCosts
        /// </summary>
        public string LoanEstimate2UnroundedTotalOtherCosts { get => _loanEstimate2UnroundedTotalOtherCosts; set => SetField(ref _loanEstimate2UnroundedTotalOtherCosts, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanEstimateLoanProduct
        /// </summary>
        public string LoanEstimateLoanProduct { get => _loanEstimateLoanProduct; set => SetField(ref _loanEstimateLoanProduct, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanFeesCityTaxBorPaidAmount
        /// </summary>
        public string LoanFeesCityTaxBorPaidAmount { get => _loanFeesCityTaxBorPaidAmount; set => SetField(ref _loanFeesCityTaxBorPaidAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanFeesStateTaxBorPaidAmount
        /// </summary>
        public string LoanFeesStateTaxBorPaidAmount { get => _loanFeesStateTaxBorPaidAmount; set => SetField(ref _loanFeesStateTaxBorPaidAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanFundsForBorrower
        /// </summary>
        public string LoanFundsForBorrower { get => _loanFundsForBorrower; set => SetField(ref _loanFundsForBorrower, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanGfeAgregateAdjustment
        /// </summary>
        public string LoanGfeAgregateAdjustment { get => _loanGfeAgregateAdjustment; set => SetField(ref _loanGfeAgregateAdjustment, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanGfeGovermentRecordingCharges
        /// </summary>
        public string LoanGfeGovermentRecordingCharges { get => _loanGfeGovermentRecordingCharges; set => SetField(ref _loanGfeGovermentRecordingCharges, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanLineItemAmount
        /// </summary>
        public string LoanLineItemAmount { get => _loanLineItemAmount; set => SetField(ref _loanLineItemAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanProgram
        /// </summary>
        public string LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount1
        /// </summary>
        public string LoanPurchaseCreditAmount1 { get => _loanPurchaseCreditAmount1; set => SetField(ref _loanPurchaseCreditAmount1, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount2
        /// </summary>
        public string LoanPurchaseCreditAmount2 { get => _loanPurchaseCreditAmount2; set => SetField(ref _loanPurchaseCreditAmount2, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount3
        /// </summary>
        public string LoanPurchaseCreditAmount3 { get => _loanPurchaseCreditAmount3; set => SetField(ref _loanPurchaseCreditAmount3, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount4
        /// </summary>
        public string LoanPurchaseCreditAmount4 { get => _loanPurchaseCreditAmount4; set => SetField(ref _loanPurchaseCreditAmount4, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType1
        /// </summary>
        public string LoanPurchaseCreditType1 { get => _loanPurchaseCreditType1; set => SetField(ref _loanPurchaseCreditType1, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType2
        /// </summary>
        public string LoanPurchaseCreditType2 { get => _loanPurchaseCreditType2; set => SetField(ref _loanPurchaseCreditType2, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType3
        /// </summary>
        public string LoanPurchaseCreditType3 { get => _loanPurchaseCreditType3; set => SetField(ref _loanPurchaseCreditType3, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType4
        /// </summary>
        public string LoanPurchaseCreditType4 { get => _loanPurchaseCreditType4; set => SetField(ref _loanPurchaseCreditType4, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanRefinanceIncludingDebtsToBePaidOffAmount
        /// </summary>
        public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get => _loanRefinanceIncludingDebtsToBePaidOffAmount; set => SetField(ref _loanRefinanceIncludingDebtsToBePaidOffAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanSection1000SellerPaidTotalAmount
        /// </summary>
        public string LoanSection1000SellerPaidTotalAmount { get => _loanSection1000SellerPaidTotalAmount; set => SetField(ref _loanSection1000SellerPaidTotalAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanSellerCreditAmount
        /// </summary>
        public string LoanSellerCreditAmount { get => _loanSellerCreditAmount; set => SetField(ref _loanSellerCreditAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log LoanTotalClosingCosts
        /// </summary>
        public string LoanTotalClosingCosts { get => _loanTotalClosingCosts; set => SetField(ref _loanTotalClosingCosts, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedBorrowerPresumedReceivedDate { get => _lockedBorrowerPresumedReceivedDate; set => SetField(ref _lockedBorrowerPresumedReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedBorrowerType
        /// </summary>
        public string LockedBorrowerType { get => _lockedBorrowerType; set => SetField(ref _lockedBorrowerType, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedCoBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedCoBorrowerPresumedReceivedDate { get => _lockedCoBorrowerPresumedReceivedDate; set => SetField(ref _lockedCoBorrowerPresumedReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedCoBorrowerType
        /// </summary>
        public string LockedCoBorrowerType { get => _lockedCoBorrowerType; set => SetField(ref _lockedCoBorrowerType, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedAprField
        /// </summary>
        public string LockedDisclosedAprField { get => _lockedDisclosedAprField; set => SetField(ref _lockedDisclosedAprField, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedByField
        /// </summary>
        public string LockedDisclosedByField { get => _lockedDisclosedByField; set => SetField(ref _lockedDisclosedByField, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedDailyInterestField
        /// </summary>
        public string LockedDisclosedDailyInterestField { get => _lockedDisclosedDailyInterestField; set => SetField(ref _lockedDisclosedDailyInterestField, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedDateField
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedDisclosedDateField { get => _lockedDisclosedDateField; set => SetField(ref _lockedDisclosedDateField, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedFinanceChargeField
        /// </summary>
        public string LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => SetField(ref _lockedDisclosedFinanceChargeField, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => SetField(ref _lockedDisclosedReceivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log LockedIntentReceivedByField
        /// </summary>
        public string LockedIntentReceivedByField { get => _lockedIntentReceivedByField; set => SetField(ref _lockedIntentReceivedByField, value); }

        /// <summary>
        /// DisclosureTracking2015Log LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// DisclosureTracking2015Log ManuallyCreated
        /// </summary>
        public string ManuallyCreated { get => _manuallyCreated; set => SetField(ref _manuallyCreated, value); }

        /// <summary>
        /// DisclosureTracking2015Log NumberOfDisclosureDocs
        /// </summary>
        public int? NumberOfDisclosureDocs { get => _numberOfDisclosureDocs; set => SetField(ref _numberOfDisclosureDocs, value); }

        /// <summary>
        /// DisclosureTracking2015Log PrepaymentPenaltyIndicator
        /// </summary>
        public string PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }

        /// <summary>
        /// DisclosureTracking2015Log PresumedFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PresumedFulfillmentDate { get => _presumedFulfillmentDate; set => SetField(ref _presumedFulfillmentDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }

        /// <summary>
        /// DisclosureTracking2015Log PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }

        /// <summary>
        /// DisclosureTracking2015Log PropertyState
        /// </summary>
        public string PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }

        /// <summary>
        /// DisclosureTracking2015Log PropertyZip
        /// </summary>
        public string PropertyZip { get => _propertyZip; set => SetField(ref _propertyZip, value); }

        /// <summary>
        /// DisclosureTracking2015Log ProviderListSent
        /// </summary>
        public bool? ProviderListSent { get => _providerListSent; set => SetField(ref _providerListSent, value); }

        /// <summary>
        /// DisclosureTracking2015Log PurchasePriceAmount
        /// </summary>
        public string PurchasePriceAmount { get => _purchasePriceAmount; set => SetField(ref _purchasePriceAmount, value); }

        /// <summary>
        /// DisclosureTracking2015Log ReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log RevisedDueDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? RevisedDueDate { get => _revisedDueDate; set => SetField(ref _revisedDueDate, value); }

        /// <summary>
        /// DisclosureTracking2015Log SnapshotFields
        /// </summary>
        public IList<LogSnapshotField> SnapshotFields { get => GetField(ref _snapshotFields); set => SetField(ref _snapshotFields, value); }

        /// <summary>
        /// DisclosureTracking2015Log SnapshotXml
        /// </summary>
        public string SnapshotXml { get => _snapshotXml; set => SetField(ref _snapshotXml, value); }

        /// <summary>
        /// DisclosureTracking2015Log SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}