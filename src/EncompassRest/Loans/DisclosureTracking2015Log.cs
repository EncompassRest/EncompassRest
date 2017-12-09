#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTracking2015Log : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get => _applicationDate; set => _applicationDate = value; }
        private DirtyValue<string> _appliedCureAmount;
        public string AppliedCureAmount { get => _appliedCureAmount; set => _appliedCureAmount = value; }
        private DirtyValue<DateTime?> _borrowerActualReceivedDate;
        public DateTime? BorrowerActualReceivedDate { get => _borrowerActualReceivedDate; set => _borrowerActualReceivedDate = value; }
        private DirtyValue<string> _borrowerDisclosedMethod;
        public string BorrowerDisclosedMethod { get => _borrowerDisclosedMethod; set => _borrowerDisclosedMethod = value; }
        private DirtyValue<string> _borrowerDisclosedMethodOther;
        public string BorrowerDisclosedMethodOther { get => _borrowerDisclosedMethodOther; set => _borrowerDisclosedMethodOther = value; }
        private DirtyValue<string> _borrowerName;
        public string BorrowerName { get => _borrowerName; set => _borrowerName = value; }
        private DirtyValue<string> _borrowerPairId;
        public string BorrowerPairId { get => _borrowerPairId; set => _borrowerPairId = value; }
        private DirtyValue<DateTime?> _borrowerPresumedReceivedDate;
        public DateTime? BorrowerPresumedReceivedDate { get => _borrowerPresumedReceivedDate; set => _borrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _borrowerType;
        public string BorrowerType { get => _borrowerType; set => _borrowerType = value; }
        private DirtyValue<bool?> _cDReasonIs24HourAdvancePreview;
        public bool? CDReasonIs24HourAdvancePreview { get => _cDReasonIs24HourAdvancePreview; set => _cDReasonIs24HourAdvancePreview = value; }
        private DirtyValue<bool?> _cDReasonIsChangeInAPR;
        public bool? CDReasonIsChangeInAPR { get => _cDReasonIsChangeInAPR; set => _cDReasonIsChangeInAPR = value; }
        private DirtyValue<bool?> _cDReasonIsChangeInLoanProduct;
        public bool? CDReasonIsChangeInLoanProduct { get => _cDReasonIsChangeInLoanProduct; set => _cDReasonIsChangeInLoanProduct = value; }
        private DirtyValue<bool?> _cDReasonIsChangeInSettlementCharges;
        public bool? CDReasonIsChangeInSettlementCharges { get => _cDReasonIsChangeInSettlementCharges; set => _cDReasonIsChangeInSettlementCharges = value; }
        private DirtyValue<bool?> _cDReasonIsClericalErrorCorrection;
        public bool? CDReasonIsClericalErrorCorrection { get => _cDReasonIsClericalErrorCorrection; set => _cDReasonIsClericalErrorCorrection = value; }
        private DirtyValue<bool?> _cDReasonIsOther;
        public bool? CDReasonIsOther { get => _cDReasonIsOther; set => _cDReasonIsOther = value; }
        private DirtyValue<bool?> _cDReasonIsPrepaymentPenaltyAdded;
        public bool? CDReasonIsPrepaymentPenaltyAdded { get => _cDReasonIsPrepaymentPenaltyAdded; set => _cDReasonIsPrepaymentPenaltyAdded = value; }
        private DirtyValue<bool?> _cDReasonIsToleranceCure;
        public bool? CDReasonIsToleranceCure { get => _cDReasonIsToleranceCure; set => _cDReasonIsToleranceCure = value; }
        private DirtyValue<string> _cDReasonOther;
        public string CDReasonOther { get => _cDReasonOther; set => _cDReasonOther = value; }
        private DirtyValue<string> _changeInCircumstance;
        public string ChangeInCircumstance { get => _changeInCircumstance; set => _changeInCircumstance = value; }
        private DirtyValue<string> _changeInCircumstanceComments;
        public string ChangeInCircumstanceComments { get => _changeInCircumstanceComments; set => _changeInCircumstanceComments = value; }
        private DirtyValue<string> _chargesCannotIncrease10Itemization34;
        public string ChargesCannotIncrease10Itemization34 { get => _chargesCannotIncrease10Itemization34; set => _chargesCannotIncrease10Itemization34 = value; }
        private DirtyValue<string> _chargesCannotIncrease10LE32;
        public string ChargesCannotIncrease10LE32 { get => _chargesCannotIncrease10LE32; set => _chargesCannotIncrease10LE32 = value; }
        private DirtyValue<string> _chargesThatCannotDecreaseItemization9;
        public string ChargesThatCannotDecreaseItemization9 { get => _chargesThatCannotDecreaseItemization9; set => _chargesThatCannotDecreaseItemization9 = value; }
        private DirtyValue<string> _chargesThatCannotDecreaseLE7;
        public string ChargesThatCannotDecreaseLE7 { get => _chargesThatCannotDecreaseLE7; set => _chargesThatCannotDecreaseLE7 = value; }
        private DirtyValue<string> _chargesThatCannotIncreaseItemization13;
        public string ChargesThatCannotIncreaseItemization13 { get => _chargesThatCannotIncreaseItemization13; set => _chargesThatCannotIncreaseItemization13 = value; }
        private DirtyValue<string> _chargesThatCannotIncreaseLE11;
        public string ChargesThatCannotIncreaseLE11 { get => _chargesThatCannotIncreaseLE11; set => _chargesThatCannotIncreaseLE11 = value; }
        private DirtyValue<DateTime?> _coBorrowerActualReceivedDate;
        public DateTime? CoBorrowerActualReceivedDate { get => _coBorrowerActualReceivedDate; set => _coBorrowerActualReceivedDate = value; }
        private DirtyValue<string> _coBorrowerDisclosedMethod;
        public string CoBorrowerDisclosedMethod { get => _coBorrowerDisclosedMethod; set => _coBorrowerDisclosedMethod = value; }
        private DirtyValue<string> _coBorrowerDisclosedMethodOther;
        public string CoBorrowerDisclosedMethodOther { get => _coBorrowerDisclosedMethodOther; set => _coBorrowerDisclosedMethodOther = value; }
        private DirtyValue<string> _coBorrowerName;
        public string CoBorrowerName { get => _coBorrowerName; set => _coBorrowerName = value; }
        private DirtyValue<DateTime?> _coBorrowerPresumedReceivedDate;
        public DateTime? CoBorrowerPresumedReceivedDate { get => _coBorrowerPresumedReceivedDate; set => _coBorrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _coBorrowerType;
        public string CoBorrowerType { get => _coBorrowerType; set => _coBorrowerType = value; }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<bool?> _containCD;
        public bool? ContainCD { get => _containCD; set => _containCD = value; }
        private DirtyValue<bool?> _containLE;
        public bool? ContainLE { get => _containLE; set => _containLE = value; }
        private DirtyValue<bool?> _containSafeHarbor;
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => _containSafeHarbor = value; }
        private DirtyValue<DateTime?> _dateAdded;
        public DateTime? DateAdded { get => _dateAdded; set => _dateAdded = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _disclosedAPR;
        public string DisclosedAPR { get => _disclosedAPR; set => _disclosedAPR = value; }
        private DirtyValue<string> _disclosedBy;
        public string DisclosedBy { get => _disclosedBy; set => _disclosedBy = value; }
        private DirtyValue<string> _disclosedByFullName;
        public string DisclosedByFullName { get => _disclosedByFullName; set => _disclosedByFullName = value; }
        private DirtyValue<string> _disclosedDailyInterest;
        public string DisclosedDailyInterest { get => _disclosedDailyInterest; set => _disclosedDailyInterest = value; }
        private DirtyValue<DateTime?> _disclosedDate;
        public DateTime? DisclosedDate { get => _disclosedDate; set => _disclosedDate = value; }
        private DirtyValue<bool?> _disclosedForCD;
        public bool? DisclosedForCD { get => _disclosedForCD; set => _disclosedForCD = value; }
        private DirtyValue<bool?> _disclosedForLE;
        public bool? DisclosedForLE { get => _disclosedForLE; set => _disclosedForLE = value; }
        private DirtyValue<string> _disclosedMethod;
        public string DisclosedMethod { get => _disclosedMethod; set => _disclosedMethod = value; }
        private DirtyValue<string> _disclosedMethodName;
        public string DisclosedMethodName { get => _disclosedMethodName; set => _disclosedMethodName = value; }
        private DirtyValue<string> _disclosedMethodOther;
        public string DisclosedMethodOther { get => _disclosedMethodOther; set => _disclosedMethodOther = value; }
        private DirtyValue<string> _disclosedSalesPrice;
        public string DisclosedSalesPrice { get => _disclosedSalesPrice; set => _disclosedSalesPrice = value; }
        private DirtyValue<DateTime?> _disclosureCreatedDttmUtc;
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => _disclosureCreatedDttmUtc = value; }
        private DirtyValue<string> _disclosureMethod;
        public string DisclosureMethod { get => _disclosureMethod; set => _disclosureMethod = value; }
        private DirtyValue<string> _disclosureType;
        public string DisclosureType { get => _disclosureType; set => _disclosureType = value; }
        private DirtyValue<bool?> _eDisclosureApplicationPackageIndicator;
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => _eDisclosureApplicationPackageIndicator = value; }
        private DirtyValue<bool?> _eDisclosureApprovalPackageIndicator;
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => _eDisclosureApprovalPackageIndicator = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => _eDisclosureBorrowerAcceptConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowereSignedDate;
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => _eDisclosureBorrowereSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => _eDisclosureBorrowerRejectConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewConsentDate;
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => _eDisclosureBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewMessageDate;
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => _eDisclosureBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerWetSignedDate;
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => _eDisclosureBorrowerWetSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => _eDisclosureCoBorrowerAcceptConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowereSignedDate;
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => _eDisclosureCoBorrowereSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => _eDisclosureCoBorrowerRejectConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => _eDisclosureCoBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => _eDisclosureCoBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => _eDisclosureCoBorrowerWebSignedDate = value; }
        private DirtyValue<string> _eDisclosureConsentPdf;
        public string EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => _eDisclosureConsentPdf = value; }
        private DirtyValue<string> _eDisclosureDisclosedMessage;
        public string EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => _eDisclosureDisclosedMessage = value; }
        private DirtyValue<bool?> _eDisclosureLockPackageIndicator;
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => _eDisclosureLockPackageIndicator = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentComment;
        public string EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => _eDisclosureManualFulfillmentComment = value; }
        private DirtyValue<DateTime?> _eDisclosureManualFulfillmentDate;
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => _eDisclosureManualFulfillmentDate = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentMethod;
        public string EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => _eDisclosureManualFulfillmentMethod = value; }
        private DirtyValue<string> _eDisclosureManuallyFulfilledBy;
        public string EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => _eDisclosureManuallyFulfilledBy = value; }
        private DirtyValue<DateTime?> _eDisclosurePackageCreatedDate;
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => _eDisclosurePackageCreatedDate = value; }
        private DirtyValue<string> _eDisclosurePackageId;
        public string EDisclosurePackageId { get => _eDisclosurePackageId; set => _eDisclosurePackageId = value; }
        private DirtyValue<string> _eDisclosurePackageViewableFile;
        public string EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => _eDisclosurePackageViewableFile = value; }
        private DirtyValue<bool?> _eDisclosureThreeDayPackageIndicator;
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => _eDisclosureThreeDayPackageIndicator = value; }
        private DirtyValue<string> _estimatedTotalPayoffsAndPaymentsAmount;
        public string EstimatedTotalPayoffsAndPaymentsAmount { get => _estimatedTotalPayoffsAndPaymentsAmount; set => _estimatedTotalPayoffsAndPaymentsAmount = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _financeCharge;
        public string FinanceCharge { get => _financeCharge; set => _financeCharge = value; }
        private DirtyList<DisclosureForm> _forms;
        public IList<DisclosureForm> Forms { get => _forms ?? (_forms = new DirtyList<DisclosureForm>()); set => _forms = new DirtyList<DisclosureForm>(value); }
        private DirtyValue<string> _formsXml;
        public string FormsXml { get => _formsXml; set => _formsXml = value; }
        private DirtyValue<string> _fulfillmentOrderedBy;
        public string FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => _fulfillmentOrderedBy = value; }
        private DirtyValue<string> _fullfillmentProcessedDate;
        public string FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => _fullfillmentProcessedDate = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _intentToProceed;
        public bool? IntentToProceed { get => _intentToProceed; set => _intentToProceed = value; }
        private DirtyValue<string> _intentToProceedComments;
        public string IntentToProceedComments { get => _intentToProceedComments; set => _intentToProceedComments = value; }
        private DirtyValue<DateTime?> _intentToProceedDate;
        public DateTime? IntentToProceedDate { get => _intentToProceedDate; set => _intentToProceedDate = value; }
        private DirtyValue<string> _intentToProceedReceivedBy;
        public string IntentToProceedReceivedBy { get => _intentToProceedReceivedBy; set => _intentToProceedReceivedBy = value; }
        private DirtyValue<string> _intentToProceedReceivedMethod;
        public string IntentToProceedReceivedMethod { get => _intentToProceedReceivedMethod; set => _intentToProceedReceivedMethod = value; }
        private DirtyValue<string> _intentToProceedReceivedMethodOther;
        public string IntentToProceedReceivedMethodOther { get => _intentToProceedReceivedMethodOther; set => _intentToProceedReceivedMethodOther = value; }
        private DirtyValue<bool?> _isBorrowerPresumedDateLocked;
        public bool? IsBorrowerPresumedDateLocked { get => _isBorrowerPresumedDateLocked; set => _isBorrowerPresumedDateLocked = value; }
        private DirtyValue<bool?> _isBorrowerTypeLocked;
        public bool? IsBorrowerTypeLocked { get => _isBorrowerTypeLocked; set => _isBorrowerTypeLocked = value; }
        private DirtyValue<bool?> _isCoBorrowerPresumedDateLocked;
        public bool? IsCoBorrowerPresumedDateLocked { get => _isCoBorrowerPresumedDateLocked; set => _isCoBorrowerPresumedDateLocked = value; }
        private DirtyValue<bool?> _isCoBorrowerTypeLocked;
        public bool? IsCoBorrowerTypeLocked { get => _isCoBorrowerTypeLocked; set => _isCoBorrowerTypeLocked = value; }
        private DirtyValue<string> _isDisclosed;
        public string IsDisclosed { get => _isDisclosed; set => _isDisclosed = value; }
        private DirtyValue<string> _isDisclosedAprLocked;
        public string IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => _isDisclosedAprLocked = value; }
        private DirtyValue<string> _isDisclosedByLocked;
        public string IsDisclosedByLocked { get => _isDisclosedByLocked; set => _isDisclosedByLocked = value; }
        private DirtyValue<string> _isDisclosedFinanceChargeLocked;
        public string IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => _isDisclosedFinanceChargeLocked = value; }
        private DirtyValue<string> _isDisclosedReceivedDateLocked;
        public string IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => _isDisclosedReceivedDateLocked = value; }
        private DirtyValue<string> _isLocked;
        public string IsLocked { get => _isLocked; set => _isLocked = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<bool?> _isWetSignedIndicator;
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => _isWetSignedIndicator = value; }
        private DirtyValue<string> _lenderCompensationCreditAmount2;
        public string LenderCompensationCreditAmount2 { get => _lenderCompensationCreditAmount2; set => _lenderCompensationCreditAmount2 = value; }
        private DirtyValue<string> _lenderTotalPaidOriginatorAmount;
        public string LenderTotalPaidOriginatorAmount { get => _lenderTotalPaidOriginatorAmount; set => _lenderTotalPaidOriginatorAmount = value; }
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceEligibility;
        public bool? LEReasonIsChangedCircumstanceEligibility { get => _lEReasonIsChangedCircumstanceEligibility; set => _lEReasonIsChangedCircumstanceEligibility = value; }
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceSettlementCharges;
        public bool? LEReasonIsChangedCircumstanceSettlementCharges { get => _lEReasonIsChangedCircumstanceSettlementCharges; set => _lEReasonIsChangedCircumstanceSettlementCharges = value; }
        private DirtyValue<bool?> _lEReasonIsDelayedSettlementOnConstructionLoans;
        public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get => _lEReasonIsDelayedSettlementOnConstructionLoans; set => _lEReasonIsDelayedSettlementOnConstructionLoans = value; }
        private DirtyValue<bool?> _lEReasonIsExpiration;
        public bool? LEReasonIsExpiration { get => _lEReasonIsExpiration; set => _lEReasonIsExpiration = value; }
        private DirtyValue<bool?> _lEReasonIsInterestRateDependentCharges;
        public bool? LEReasonIsInterestRateDependentCharges { get => _lEReasonIsInterestRateDependentCharges; set => _lEReasonIsInterestRateDependentCharges = value; }
        private DirtyValue<bool?> _lEReasonIsOther;
        public bool? LEReasonIsOther { get => _lEReasonIsOther; set => _lEReasonIsOther = value; }
        private DirtyValue<bool?> _lEReasonIsRevisionsRequestedByConsumer;
        public bool? LEReasonIsRevisionsRequestedByConsumer { get => _lEReasonIsRevisionsRequestedByConsumer; set => _lEReasonIsRevisionsRequestedByConsumer = value; }
        private DirtyValue<string> _lEReasonOther;
        public string LEReasonOther { get => _lEReasonOther; set => _lEReasonOther = value; }
        private DirtyValue<string> _line802LOCompAdditionalAmount1;
        public string Line802LOCompAdditionalAmount1 { get => _line802LOCompAdditionalAmount1; set => _line802LOCompAdditionalAmount1 = value; }
        private DirtyValue<string> _line802LOCompAdditionalAmount2;
        public string Line802LOCompAdditionalAmount2 { get => _line802LOCompAdditionalAmount2; set => _line802LOCompAdditionalAmount2 = value; }
        private DirtyValue<string> _line907InsuranceIndicator2015;
        public string Line907InsuranceIndicator2015 { get => _line907InsuranceIndicator2015; set => _line907InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line907PropertyIndicator2015;
        public string Line907PropertyIndicator2015 { get => _line907PropertyIndicator2015; set => _line907PropertyIndicator2015 = value; }
        private DirtyValue<string> _line907TaxesIndicator2015;
        public string Line907TaxesIndicator2015 { get => _line907TaxesIndicator2015; set => _line907TaxesIndicator2015 = value; }
        private DirtyValue<string> _line908InsuranceIndicator2015;
        public string Line908InsuranceIndicator2015 { get => _line908InsuranceIndicator2015; set => _line908InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line908PropertyIndicator2015;
        public string Line908PropertyIndicator2015 { get => _line908PropertyIndicator2015; set => _line908PropertyIndicator2015 = value; }
        private DirtyValue<string> _line908TaxesIndicator2015;
        public string Line908TaxesIndicator2015 { get => _line908TaxesIndicator2015; set => _line908TaxesIndicator2015 = value; }
        private DirtyValue<string> _line909InsuranceIndicator2015;
        public string Line909InsuranceIndicator2015 { get => _line909InsuranceIndicator2015; set => _line909InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line909PropertyIndicator2015;
        public string Line909PropertyIndicator2015 { get => _line909PropertyIndicator2015; set => _line909PropertyIndicator2015 = value; }
        private DirtyValue<string> _line909TaxesIndicator2015;
        public string Line909TaxesIndicator2015 { get => _line909TaxesIndicator2015; set => _line909TaxesIndicator2015 = value; }
        private DirtyValue<string> _line910InsuranceIndicator2015;
        public string Line910InsuranceIndicator2015 { get => _line910InsuranceIndicator2015; set => _line910InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line910PropertyIndicator2015;
        public string Line910PropertyIndicator2015 { get => _line910PropertyIndicator2015; set => _line910PropertyIndicator2015 = value; }
        private DirtyValue<string> _line910TaxesIndicator2015;
        public string Line910TaxesIndicator2015 { get => _line910TaxesIndicator2015; set => _line910TaxesIndicator2015 = value; }
        private DirtyValue<string> _line911InsuranceIndicator2015;
        public string Line911InsuranceIndicator2015 { get => _line911InsuranceIndicator2015; set => _line911InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line911PropertyIndicator2015;
        public string Line911PropertyIndicator2015 { get => _line911PropertyIndicator2015; set => _line911PropertyIndicator2015 = value; }
        private DirtyValue<string> _line911TaxesIndicator2015;
        public string Line911TaxesIndicator2015 { get => _line911TaxesIndicator2015; set => _line911TaxesIndicator2015 = value; }
        private DirtyValue<string> _line912InsuranceIndicator2015;
        public string Line912InsuranceIndicator2015 { get => _line912InsuranceIndicator2015; set => _line912InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line912PropertyIndicator2015;
        public string Line912PropertyIndicator2015 { get => _line912PropertyIndicator2015; set => _line912PropertyIndicator2015 = value; }
        private DirtyValue<string> _line912TaxesIndicator2015;
        public string Line912TaxesIndicator2015 { get => _line912TaxesIndicator2015; set => _line912TaxesIndicator2015 = value; }
        private DirtyValue<string> _loanAdjustmentsOtherCredits;
        public string LoanAdjustmentsOtherCredits { get => _loanAdjustmentsOtherCredits; set => _loanAdjustmentsOtherCredits = value; }
        private DirtyValue<string> _loanAmount;
        public string LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<string> _loanClosingCost2BorrowerClosingCostAtClosing;
        public string LoanClosingCost2BorrowerClosingCostAtClosing { get => _loanClosingCost2BorrowerClosingCostAtClosing; set => _loanClosingCost2BorrowerClosingCostAtClosing = value; }
        private DirtyValue<string> _loanClosingCost2LenderCredits;
        public string LoanClosingCost2LenderCredits { get => _loanClosingCost2LenderCredits; set => _loanClosingCost2LenderCredits = value; }
        private DirtyValue<string> _loanClosingCost2TotalLoanCost;
        public string LoanClosingCost2TotalLoanCost { get => _loanClosingCost2TotalLoanCost; set => _loanClosingCost2TotalLoanCost = value; }
        private DirtyValue<string> _loanClosingCost2TotalOtherCost;
        public string LoanClosingCost2TotalOtherCost { get => _loanClosingCost2TotalOtherCost; set => _loanClosingCost2TotalOtherCost = value; }
        private DirtyValue<string> _loanClosingCost3StdLegalLimit;
        public string LoanClosingCost3StdLegalLimit { get => _loanClosingCost3StdLegalLimit; set => _loanClosingCost3StdLegalLimit = value; }
        private DirtyValue<string> _loanClosingCostGfe1200BorPaidAmount;
        public string LoanClosingCostGfe1200BorPaidAmount { get => _loanClosingCostGfe1200BorPaidAmount; set => _loanClosingCostGfe1200BorPaidAmount = value; }
        private DirtyValue<string> _loanClosingCostGfe800BorPaidAmount;
        public string LoanClosingCostGfe800BorPaidAmount { get => _loanClosingCostGfe800BorPaidAmount; set => _loanClosingCostGfe800BorPaidAmount = value; }
        private DirtyValue<string> _loanClosingCostLenderCredits;
        public string LoanClosingCostLenderCredits { get => _loanClosingCostLenderCredits; set => _loanClosingCostLenderCredits = value; }
        private DirtyValue<string> _loanClosingCostSection1000BorrowerTotalPaidAmount;
        public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get => _loanClosingCostSection1000BorrowerTotalPaidAmount; set => _loanClosingCostSection1000BorrowerTotalPaidAmount = value; }
        private DirtyValue<string> _loanClosingCostsFinanced;
        public string LoanClosingCostsFinanced { get => _loanClosingCostsFinanced; set => _loanClosingCostsFinanced = value; }
        private DirtyValue<string> _loanClosingCostTotalFeeAmount2015;
        public string LoanClosingCostTotalFeeAmount2015 { get => _loanClosingCostTotalFeeAmount2015; set => _loanClosingCostTotalFeeAmount2015 = value; }
        private DirtyValue<string> _loanDownPayment;
        public string LoanDownPayment { get => _loanDownPayment; set => _loanDownPayment = value; }
        private DirtyValue<string> _loanEstimate2TotalLoanAndOtherCosts;
        public string LoanEstimate2TotalLoanAndOtherCosts { get => _loanEstimate2TotalLoanAndOtherCosts; set => _loanEstimate2TotalLoanAndOtherCosts = value; }
        private DirtyValue<string> _loanEstimate2TotalLoanCosts;
        public string LoanEstimate2TotalLoanCosts { get => _loanEstimate2TotalLoanCosts; set => _loanEstimate2TotalLoanCosts = value; }
        private DirtyValue<string> _loanEstimate2TotalOtherCosts;
        public string LoanEstimate2TotalOtherCosts { get => _loanEstimate2TotalOtherCosts; set => _loanEstimate2TotalOtherCosts = value; }
        private DirtyValue<string> _loanEstimate2UnroundedTotalLoanCosts;
        public string LoanEstimate2UnroundedTotalLoanCosts { get => _loanEstimate2UnroundedTotalLoanCosts; set => _loanEstimate2UnroundedTotalLoanCosts = value; }
        private DirtyValue<string> _loanEstimate2UnroundedTotalOtherCosts;
        public string LoanEstimate2UnroundedTotalOtherCosts { get => _loanEstimate2UnroundedTotalOtherCosts; set => _loanEstimate2UnroundedTotalOtherCosts = value; }
        private DirtyValue<string> _loanEstimateLoanProduct;
        public string LoanEstimateLoanProduct { get => _loanEstimateLoanProduct; set => _loanEstimateLoanProduct = value; }
        private DirtyValue<string> _loanFeesCityTaxBorPaidAmount;
        public string LoanFeesCityTaxBorPaidAmount { get => _loanFeesCityTaxBorPaidAmount; set => _loanFeesCityTaxBorPaidAmount = value; }
        private DirtyValue<string> _loanFeesStateTaxBorPaidAmount;
        public string LoanFeesStateTaxBorPaidAmount { get => _loanFeesStateTaxBorPaidAmount; set => _loanFeesStateTaxBorPaidAmount = value; }
        private DirtyValue<string> _loanFundsForBorrower;
        public string LoanFundsForBorrower { get => _loanFundsForBorrower; set => _loanFundsForBorrower = value; }
        private DirtyValue<string> _loanGfeAgregateAdjustment;
        public string LoanGfeAgregateAdjustment { get => _loanGfeAgregateAdjustment; set => _loanGfeAgregateAdjustment = value; }
        private DirtyValue<string> _loanGfeGovermentRecordingCharges;
        public string LoanGfeGovermentRecordingCharges { get => _loanGfeGovermentRecordingCharges; set => _loanGfeGovermentRecordingCharges = value; }
        private DirtyValue<string> _loanLineItemAmount;
        public string LoanLineItemAmount { get => _loanLineItemAmount; set => _loanLineItemAmount = value; }
        private DirtyValue<string> _loanProgram;
        public string LoanProgram { get => _loanProgram; set => _loanProgram = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount1;
        public string LoanPurchaseCreditAmount1 { get => _loanPurchaseCreditAmount1; set => _loanPurchaseCreditAmount1 = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount2;
        public string LoanPurchaseCreditAmount2 { get => _loanPurchaseCreditAmount2; set => _loanPurchaseCreditAmount2 = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount3;
        public string LoanPurchaseCreditAmount3 { get => _loanPurchaseCreditAmount3; set => _loanPurchaseCreditAmount3 = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount4;
        public string LoanPurchaseCreditAmount4 { get => _loanPurchaseCreditAmount4; set => _loanPurchaseCreditAmount4 = value; }
        private DirtyValue<string> _loanPurchaseCreditType1;
        public string LoanPurchaseCreditType1 { get => _loanPurchaseCreditType1; set => _loanPurchaseCreditType1 = value; }
        private DirtyValue<string> _loanPurchaseCreditType2;
        public string LoanPurchaseCreditType2 { get => _loanPurchaseCreditType2; set => _loanPurchaseCreditType2 = value; }
        private DirtyValue<string> _loanPurchaseCreditType3;
        public string LoanPurchaseCreditType3 { get => _loanPurchaseCreditType3; set => _loanPurchaseCreditType3 = value; }
        private DirtyValue<string> _loanPurchaseCreditType4;
        public string LoanPurchaseCreditType4 { get => _loanPurchaseCreditType4; set => _loanPurchaseCreditType4 = value; }
        private DirtyValue<string> _loanRefinanceIncludingDebtsToBePaidOffAmount;
        public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get => _loanRefinanceIncludingDebtsToBePaidOffAmount; set => _loanRefinanceIncludingDebtsToBePaidOffAmount = value; }
        private DirtyValue<string> _loanSection1000SellerPaidTotalAmount;
        public string LoanSection1000SellerPaidTotalAmount { get => _loanSection1000SellerPaidTotalAmount; set => _loanSection1000SellerPaidTotalAmount = value; }
        private DirtyValue<string> _loanSellerCreditAmount;
        public string LoanSellerCreditAmount { get => _loanSellerCreditAmount; set => _loanSellerCreditAmount = value; }
        private DirtyValue<string> _loanTotalClosingCosts;
        public string LoanTotalClosingCosts { get => _loanTotalClosingCosts; set => _loanTotalClosingCosts = value; }
        private DirtyValue<DateTime?> _lockedBorrowerPresumedReceivedDate;
        public DateTime? LockedBorrowerPresumedReceivedDate { get => _lockedBorrowerPresumedReceivedDate; set => _lockedBorrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _lockedBorrowerType;
        public string LockedBorrowerType { get => _lockedBorrowerType; set => _lockedBorrowerType = value; }
        private DirtyValue<DateTime?> _lockedCoBorrowerPresumedReceivedDate;
        public DateTime? LockedCoBorrowerPresumedReceivedDate { get => _lockedCoBorrowerPresumedReceivedDate; set => _lockedCoBorrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _lockedCoBorrowerType;
        public string LockedCoBorrowerType { get => _lockedCoBorrowerType; set => _lockedCoBorrowerType = value; }
        private DirtyValue<string> _lockedDisclosedAprField;
        public string LockedDisclosedAprField { get => _lockedDisclosedAprField; set => _lockedDisclosedAprField = value; }
        private DirtyValue<string> _lockedDisclosedByField;
        public string LockedDisclosedByField { get => _lockedDisclosedByField; set => _lockedDisclosedByField = value; }
        private DirtyValue<string> _lockedDisclosedFinanceChargeField;
        public string LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => _lockedDisclosedFinanceChargeField = value; }
        private DirtyValue<DateTime?> _lockedDisclosedReceivedDate;
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => _lockedDisclosedReceivedDate = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _manuallyCreated;
        public string ManuallyCreated { get => _manuallyCreated; set => _manuallyCreated = value; }
        private DirtyValue<string> _prepaymentPenaltyIndicator;
        public string PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => _prepaymentPenaltyIndicator = value; }
        private DirtyValue<string> _propertyAddress;
        public string PropertyAddress { get => _propertyAddress; set => _propertyAddress = value; }
        private DirtyValue<string> _propertyCity;
        public string PropertyCity { get => _propertyCity; set => _propertyCity = value; }
        private DirtyValue<string> _propertyState;
        public string PropertyState { get => _propertyState; set => _propertyState = value; }
        private DirtyValue<string> _propertyZip;
        public string PropertyZip { get => _propertyZip; set => _propertyZip = value; }
        private DirtyValue<bool?> _providerListSent;
        public bool? ProviderListSent { get => _providerListSent; set => _providerListSent = value; }
        private DirtyValue<string> _purchasePriceAmount;
        public string PurchasePriceAmount { get => _purchasePriceAmount; set => _purchasePriceAmount = value; }
        private DirtyValue<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get => _receivedDate; set => _receivedDate = value; }
        private DirtyList<LogSnapshotField> _snapshotFields;
        public IList<LogSnapshotField> SnapshotFields { get => _snapshotFields ?? (_snapshotFields = new DirtyList<LogSnapshotField>()); set => _snapshotFields = new DirtyList<LogSnapshotField>(value); }
        private DirtyValue<string> _snapshotXml;
        public string SnapshotXml { get => _snapshotXml; set => _snapshotXml = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _alertsXml.Dirty
                    || _applicationDate.Dirty
                    || _appliedCureAmount.Dirty
                    || _borrowerActualReceivedDate.Dirty
                    || _borrowerDisclosedMethod.Dirty
                    || _borrowerDisclosedMethodOther.Dirty
                    || _borrowerName.Dirty
                    || _borrowerPairId.Dirty
                    || _borrowerPresumedReceivedDate.Dirty
                    || _borrowerType.Dirty
                    || _cDReasonIs24HourAdvancePreview.Dirty
                    || _cDReasonIsChangeInAPR.Dirty
                    || _cDReasonIsChangeInLoanProduct.Dirty
                    || _cDReasonIsChangeInSettlementCharges.Dirty
                    || _cDReasonIsClericalErrorCorrection.Dirty
                    || _cDReasonIsOther.Dirty
                    || _cDReasonIsPrepaymentPenaltyAdded.Dirty
                    || _cDReasonIsToleranceCure.Dirty
                    || _cDReasonOther.Dirty
                    || _changeInCircumstance.Dirty
                    || _changeInCircumstanceComments.Dirty
                    || _chargesCannotIncrease10Itemization34.Dirty
                    || _chargesCannotIncrease10LE32.Dirty
                    || _chargesThatCannotDecreaseItemization9.Dirty
                    || _chargesThatCannotDecreaseLE7.Dirty
                    || _chargesThatCannotIncreaseItemization13.Dirty
                    || _chargesThatCannotIncreaseLE11.Dirty
                    || _coBorrowerActualReceivedDate.Dirty
                    || _coBorrowerDisclosedMethod.Dirty
                    || _coBorrowerDisclosedMethodOther.Dirty
                    || _coBorrowerName.Dirty
                    || _coBorrowerPresumedReceivedDate.Dirty
                    || _coBorrowerType.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _containCD.Dirty
                    || _containLE.Dirty
                    || _containSafeHarbor.Dirty
                    || _dateAdded.Dirty
                    || _dateUtc.Dirty
                    || _disclosedAPR.Dirty
                    || _disclosedBy.Dirty
                    || _disclosedByFullName.Dirty
                    || _disclosedDailyInterest.Dirty
                    || _disclosedDate.Dirty
                    || _disclosedForCD.Dirty
                    || _disclosedForLE.Dirty
                    || _disclosedMethod.Dirty
                    || _disclosedMethodName.Dirty
                    || _disclosedMethodOther.Dirty
                    || _disclosedSalesPrice.Dirty
                    || _disclosureCreatedDttmUtc.Dirty
                    || _disclosureMethod.Dirty
                    || _disclosureType.Dirty
                    || _eDisclosureApplicationPackageIndicator.Dirty
                    || _eDisclosureApprovalPackageIndicator.Dirty
                    || _eDisclosureBorrowerAcceptConsentDate.Dirty
                    || _eDisclosureBorrowereSignedDate.Dirty
                    || _eDisclosureBorrowerRejectConsentDate.Dirty
                    || _eDisclosureBorrowerViewConsentDate.Dirty
                    || _eDisclosureBorrowerViewMessageDate.Dirty
                    || _eDisclosureBorrowerWetSignedDate.Dirty
                    || _eDisclosureCoBorrowerAcceptConsentDate.Dirty
                    || _eDisclosureCoBorrowereSignedDate.Dirty
                    || _eDisclosureCoBorrowerRejectConsentDate.Dirty
                    || _eDisclosureCoBorrowerViewConsentDate.Dirty
                    || _eDisclosureCoBorrowerViewMessageDate.Dirty
                    || _eDisclosureCoBorrowerWebSignedDate.Dirty
                    || _eDisclosureConsentPdf.Dirty
                    || _eDisclosureDisclosedMessage.Dirty
                    || _eDisclosureLockPackageIndicator.Dirty
                    || _eDisclosureManualFulfillmentComment.Dirty
                    || _eDisclosureManualFulfillmentDate.Dirty
                    || _eDisclosureManualFulfillmentMethod.Dirty
                    || _eDisclosureManuallyFulfilledBy.Dirty
                    || _eDisclosurePackageCreatedDate.Dirty
                    || _eDisclosurePackageId.Dirty
                    || _eDisclosurePackageViewableFile.Dirty
                    || _eDisclosureThreeDayPackageIndicator.Dirty
                    || _estimatedTotalPayoffsAndPaymentsAmount.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _financeCharge.Dirty
                    || _formsXml.Dirty
                    || _fulfillmentOrderedBy.Dirty
                    || _fullfillmentProcessedDate.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _intentToProceed.Dirty
                    || _intentToProceedComments.Dirty
                    || _intentToProceedDate.Dirty
                    || _intentToProceedReceivedBy.Dirty
                    || _intentToProceedReceivedMethod.Dirty
                    || _intentToProceedReceivedMethodOther.Dirty
                    || _isBorrowerPresumedDateLocked.Dirty
                    || _isBorrowerTypeLocked.Dirty
                    || _isCoBorrowerPresumedDateLocked.Dirty
                    || _isCoBorrowerTypeLocked.Dirty
                    || _isDisclosed.Dirty
                    || _isDisclosedAprLocked.Dirty
                    || _isDisclosedByLocked.Dirty
                    || _isDisclosedFinanceChargeLocked.Dirty
                    || _isDisclosedReceivedDateLocked.Dirty
                    || _isLocked.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _isWetSignedIndicator.Dirty
                    || _lenderCompensationCreditAmount2.Dirty
                    || _lenderTotalPaidOriginatorAmount.Dirty
                    || _lEReasonIsChangedCircumstanceEligibility.Dirty
                    || _lEReasonIsChangedCircumstanceSettlementCharges.Dirty
                    || _lEReasonIsDelayedSettlementOnConstructionLoans.Dirty
                    || _lEReasonIsExpiration.Dirty
                    || _lEReasonIsInterestRateDependentCharges.Dirty
                    || _lEReasonIsOther.Dirty
                    || _lEReasonIsRevisionsRequestedByConsumer.Dirty
                    || _lEReasonOther.Dirty
                    || _line802LOCompAdditionalAmount1.Dirty
                    || _line802LOCompAdditionalAmount2.Dirty
                    || _line907InsuranceIndicator2015.Dirty
                    || _line907PropertyIndicator2015.Dirty
                    || _line907TaxesIndicator2015.Dirty
                    || _line908InsuranceIndicator2015.Dirty
                    || _line908PropertyIndicator2015.Dirty
                    || _line908TaxesIndicator2015.Dirty
                    || _line909InsuranceIndicator2015.Dirty
                    || _line909PropertyIndicator2015.Dirty
                    || _line909TaxesIndicator2015.Dirty
                    || _line910InsuranceIndicator2015.Dirty
                    || _line910PropertyIndicator2015.Dirty
                    || _line910TaxesIndicator2015.Dirty
                    || _line911InsuranceIndicator2015.Dirty
                    || _line911PropertyIndicator2015.Dirty
                    || _line911TaxesIndicator2015.Dirty
                    || _line912InsuranceIndicator2015.Dirty
                    || _line912PropertyIndicator2015.Dirty
                    || _line912TaxesIndicator2015.Dirty
                    || _loanAdjustmentsOtherCredits.Dirty
                    || _loanAmount.Dirty
                    || _loanClosingCost2BorrowerClosingCostAtClosing.Dirty
                    || _loanClosingCost2LenderCredits.Dirty
                    || _loanClosingCost2TotalLoanCost.Dirty
                    || _loanClosingCost2TotalOtherCost.Dirty
                    || _loanClosingCost3StdLegalLimit.Dirty
                    || _loanClosingCostGfe1200BorPaidAmount.Dirty
                    || _loanClosingCostGfe800BorPaidAmount.Dirty
                    || _loanClosingCostLenderCredits.Dirty
                    || _loanClosingCostSection1000BorrowerTotalPaidAmount.Dirty
                    || _loanClosingCostsFinanced.Dirty
                    || _loanClosingCostTotalFeeAmount2015.Dirty
                    || _loanDownPayment.Dirty
                    || _loanEstimate2TotalLoanAndOtherCosts.Dirty
                    || _loanEstimate2TotalLoanCosts.Dirty
                    || _loanEstimate2TotalOtherCosts.Dirty
                    || _loanEstimate2UnroundedTotalLoanCosts.Dirty
                    || _loanEstimate2UnroundedTotalOtherCosts.Dirty
                    || _loanEstimateLoanProduct.Dirty
                    || _loanFeesCityTaxBorPaidAmount.Dirty
                    || _loanFeesStateTaxBorPaidAmount.Dirty
                    || _loanFundsForBorrower.Dirty
                    || _loanGfeAgregateAdjustment.Dirty
                    || _loanGfeGovermentRecordingCharges.Dirty
                    || _loanLineItemAmount.Dirty
                    || _loanProgram.Dirty
                    || _loanPurchaseCreditAmount1.Dirty
                    || _loanPurchaseCreditAmount2.Dirty
                    || _loanPurchaseCreditAmount3.Dirty
                    || _loanPurchaseCreditAmount4.Dirty
                    || _loanPurchaseCreditType1.Dirty
                    || _loanPurchaseCreditType2.Dirty
                    || _loanPurchaseCreditType3.Dirty
                    || _loanPurchaseCreditType4.Dirty
                    || _loanRefinanceIncludingDebtsToBePaidOffAmount.Dirty
                    || _loanSection1000SellerPaidTotalAmount.Dirty
                    || _loanSellerCreditAmount.Dirty
                    || _loanTotalClosingCosts.Dirty
                    || _lockedBorrowerPresumedReceivedDate.Dirty
                    || _lockedBorrowerType.Dirty
                    || _lockedCoBorrowerPresumedReceivedDate.Dirty
                    || _lockedCoBorrowerType.Dirty
                    || _lockedDisclosedAprField.Dirty
                    || _lockedDisclosedByField.Dirty
                    || _lockedDisclosedFinanceChargeField.Dirty
                    || _lockedDisclosedReceivedDate.Dirty
                    || _logRecordIndex.Dirty
                    || _manuallyCreated.Dirty
                    || _prepaymentPenaltyIndicator.Dirty
                    || _propertyAddress.Dirty
                    || _propertyCity.Dirty
                    || _propertyState.Dirty
                    || _propertyZip.Dirty
                    || _providerListSent.Dirty
                    || _purchasePriceAmount.Dirty
                    || _receivedDate.Dirty
                    || _snapshotXml.Dirty
                    || _systemId.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true
                    || _forms?.Dirty == true
                    || _snapshotFields?.Dirty == true;
            }
            set
            {
                _alertsXml.Dirty = value;
                _applicationDate.Dirty = value;
                _appliedCureAmount.Dirty = value;
                _borrowerActualReceivedDate.Dirty = value;
                _borrowerDisclosedMethod.Dirty = value;
                _borrowerDisclosedMethodOther.Dirty = value;
                _borrowerName.Dirty = value;
                _borrowerPairId.Dirty = value;
                _borrowerPresumedReceivedDate.Dirty = value;
                _borrowerType.Dirty = value;
                _cDReasonIs24HourAdvancePreview.Dirty = value;
                _cDReasonIsChangeInAPR.Dirty = value;
                _cDReasonIsChangeInLoanProduct.Dirty = value;
                _cDReasonIsChangeInSettlementCharges.Dirty = value;
                _cDReasonIsClericalErrorCorrection.Dirty = value;
                _cDReasonIsOther.Dirty = value;
                _cDReasonIsPrepaymentPenaltyAdded.Dirty = value;
                _cDReasonIsToleranceCure.Dirty = value;
                _cDReasonOther.Dirty = value;
                _changeInCircumstance.Dirty = value;
                _changeInCircumstanceComments.Dirty = value;
                _chargesCannotIncrease10Itemization34.Dirty = value;
                _chargesCannotIncrease10LE32.Dirty = value;
                _chargesThatCannotDecreaseItemization9.Dirty = value;
                _chargesThatCannotDecreaseLE7.Dirty = value;
                _chargesThatCannotIncreaseItemization13.Dirty = value;
                _chargesThatCannotIncreaseLE11.Dirty = value;
                _coBorrowerActualReceivedDate.Dirty = value;
                _coBorrowerDisclosedMethod.Dirty = value;
                _coBorrowerDisclosedMethodOther.Dirty = value;
                _coBorrowerName.Dirty = value;
                _coBorrowerPresumedReceivedDate.Dirty = value;
                _coBorrowerType.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _containCD.Dirty = value;
                _containLE.Dirty = value;
                _containSafeHarbor.Dirty = value;
                _dateAdded.Dirty = value;
                _dateUtc.Dirty = value;
                _disclosedAPR.Dirty = value;
                _disclosedBy.Dirty = value;
                _disclosedByFullName.Dirty = value;
                _disclosedDailyInterest.Dirty = value;
                _disclosedDate.Dirty = value;
                _disclosedForCD.Dirty = value;
                _disclosedForLE.Dirty = value;
                _disclosedMethod.Dirty = value;
                _disclosedMethodName.Dirty = value;
                _disclosedMethodOther.Dirty = value;
                _disclosedSalesPrice.Dirty = value;
                _disclosureCreatedDttmUtc.Dirty = value;
                _disclosureMethod.Dirty = value;
                _disclosureType.Dirty = value;
                _eDisclosureApplicationPackageIndicator.Dirty = value;
                _eDisclosureApprovalPackageIndicator.Dirty = value;
                _eDisclosureBorrowerAcceptConsentDate.Dirty = value;
                _eDisclosureBorrowereSignedDate.Dirty = value;
                _eDisclosureBorrowerRejectConsentDate.Dirty = value;
                _eDisclosureBorrowerViewConsentDate.Dirty = value;
                _eDisclosureBorrowerViewMessageDate.Dirty = value;
                _eDisclosureBorrowerWetSignedDate.Dirty = value;
                _eDisclosureCoBorrowerAcceptConsentDate.Dirty = value;
                _eDisclosureCoBorrowereSignedDate.Dirty = value;
                _eDisclosureCoBorrowerRejectConsentDate.Dirty = value;
                _eDisclosureCoBorrowerViewConsentDate.Dirty = value;
                _eDisclosureCoBorrowerViewMessageDate.Dirty = value;
                _eDisclosureCoBorrowerWebSignedDate.Dirty = value;
                _eDisclosureConsentPdf.Dirty = value;
                _eDisclosureDisclosedMessage.Dirty = value;
                _eDisclosureLockPackageIndicator.Dirty = value;
                _eDisclosureManualFulfillmentComment.Dirty = value;
                _eDisclosureManualFulfillmentDate.Dirty = value;
                _eDisclosureManualFulfillmentMethod.Dirty = value;
                _eDisclosureManuallyFulfilledBy.Dirty = value;
                _eDisclosurePackageCreatedDate.Dirty = value;
                _eDisclosurePackageId.Dirty = value;
                _eDisclosurePackageViewableFile.Dirty = value;
                _eDisclosureThreeDayPackageIndicator.Dirty = value;
                _estimatedTotalPayoffsAndPaymentsAmount.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _financeCharge.Dirty = value;
                _formsXml.Dirty = value;
                _fulfillmentOrderedBy.Dirty = value;
                _fullfillmentProcessedDate.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _intentToProceed.Dirty = value;
                _intentToProceedComments.Dirty = value;
                _intentToProceedDate.Dirty = value;
                _intentToProceedReceivedBy.Dirty = value;
                _intentToProceedReceivedMethod.Dirty = value;
                _intentToProceedReceivedMethodOther.Dirty = value;
                _isBorrowerPresumedDateLocked.Dirty = value;
                _isBorrowerTypeLocked.Dirty = value;
                _isCoBorrowerPresumedDateLocked.Dirty = value;
                _isCoBorrowerTypeLocked.Dirty = value;
                _isDisclosed.Dirty = value;
                _isDisclosedAprLocked.Dirty = value;
                _isDisclosedByLocked.Dirty = value;
                _isDisclosedFinanceChargeLocked.Dirty = value;
                _isDisclosedReceivedDateLocked.Dirty = value;
                _isLocked.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _isWetSignedIndicator.Dirty = value;
                _lenderCompensationCreditAmount2.Dirty = value;
                _lenderTotalPaidOriginatorAmount.Dirty = value;
                _lEReasonIsChangedCircumstanceEligibility.Dirty = value;
                _lEReasonIsChangedCircumstanceSettlementCharges.Dirty = value;
                _lEReasonIsDelayedSettlementOnConstructionLoans.Dirty = value;
                _lEReasonIsExpiration.Dirty = value;
                _lEReasonIsInterestRateDependentCharges.Dirty = value;
                _lEReasonIsOther.Dirty = value;
                _lEReasonIsRevisionsRequestedByConsumer.Dirty = value;
                _lEReasonOther.Dirty = value;
                _line802LOCompAdditionalAmount1.Dirty = value;
                _line802LOCompAdditionalAmount2.Dirty = value;
                _line907InsuranceIndicator2015.Dirty = value;
                _line907PropertyIndicator2015.Dirty = value;
                _line907TaxesIndicator2015.Dirty = value;
                _line908InsuranceIndicator2015.Dirty = value;
                _line908PropertyIndicator2015.Dirty = value;
                _line908TaxesIndicator2015.Dirty = value;
                _line909InsuranceIndicator2015.Dirty = value;
                _line909PropertyIndicator2015.Dirty = value;
                _line909TaxesIndicator2015.Dirty = value;
                _line910InsuranceIndicator2015.Dirty = value;
                _line910PropertyIndicator2015.Dirty = value;
                _line910TaxesIndicator2015.Dirty = value;
                _line911InsuranceIndicator2015.Dirty = value;
                _line911PropertyIndicator2015.Dirty = value;
                _line911TaxesIndicator2015.Dirty = value;
                _line912InsuranceIndicator2015.Dirty = value;
                _line912PropertyIndicator2015.Dirty = value;
                _line912TaxesIndicator2015.Dirty = value;
                _loanAdjustmentsOtherCredits.Dirty = value;
                _loanAmount.Dirty = value;
                _loanClosingCost2BorrowerClosingCostAtClosing.Dirty = value;
                _loanClosingCost2LenderCredits.Dirty = value;
                _loanClosingCost2TotalLoanCost.Dirty = value;
                _loanClosingCost2TotalOtherCost.Dirty = value;
                _loanClosingCost3StdLegalLimit.Dirty = value;
                _loanClosingCostGfe1200BorPaidAmount.Dirty = value;
                _loanClosingCostGfe800BorPaidAmount.Dirty = value;
                _loanClosingCostLenderCredits.Dirty = value;
                _loanClosingCostSection1000BorrowerTotalPaidAmount.Dirty = value;
                _loanClosingCostsFinanced.Dirty = value;
                _loanClosingCostTotalFeeAmount2015.Dirty = value;
                _loanDownPayment.Dirty = value;
                _loanEstimate2TotalLoanAndOtherCosts.Dirty = value;
                _loanEstimate2TotalLoanCosts.Dirty = value;
                _loanEstimate2TotalOtherCosts.Dirty = value;
                _loanEstimate2UnroundedTotalLoanCosts.Dirty = value;
                _loanEstimate2UnroundedTotalOtherCosts.Dirty = value;
                _loanEstimateLoanProduct.Dirty = value;
                _loanFeesCityTaxBorPaidAmount.Dirty = value;
                _loanFeesStateTaxBorPaidAmount.Dirty = value;
                _loanFundsForBorrower.Dirty = value;
                _loanGfeAgregateAdjustment.Dirty = value;
                _loanGfeGovermentRecordingCharges.Dirty = value;
                _loanLineItemAmount.Dirty = value;
                _loanProgram.Dirty = value;
                _loanPurchaseCreditAmount1.Dirty = value;
                _loanPurchaseCreditAmount2.Dirty = value;
                _loanPurchaseCreditAmount3.Dirty = value;
                _loanPurchaseCreditAmount4.Dirty = value;
                _loanPurchaseCreditType1.Dirty = value;
                _loanPurchaseCreditType2.Dirty = value;
                _loanPurchaseCreditType3.Dirty = value;
                _loanPurchaseCreditType4.Dirty = value;
                _loanRefinanceIncludingDebtsToBePaidOffAmount.Dirty = value;
                _loanSection1000SellerPaidTotalAmount.Dirty = value;
                _loanSellerCreditAmount.Dirty = value;
                _loanTotalClosingCosts.Dirty = value;
                _lockedBorrowerPresumedReceivedDate.Dirty = value;
                _lockedBorrowerType.Dirty = value;
                _lockedCoBorrowerPresumedReceivedDate.Dirty = value;
                _lockedCoBorrowerType.Dirty = value;
                _lockedDisclosedAprField.Dirty = value;
                _lockedDisclosedByField.Dirty = value;
                _lockedDisclosedFinanceChargeField.Dirty = value;
                _lockedDisclosedReceivedDate.Dirty = value;
                _logRecordIndex.Dirty = value;
                _manuallyCreated.Dirty = value;
                _prepaymentPenaltyIndicator.Dirty = value;
                _propertyAddress.Dirty = value;
                _propertyCity.Dirty = value;
                _propertyState.Dirty = value;
                _propertyZip.Dirty = value;
                _providerListSent.Dirty = value;
                _purchasePriceAmount.Dirty = value;
                _receivedDate.Dirty = value;
                _snapshotXml.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_forms != null) _forms.Dirty = value;
                if (_snapshotFields != null) _snapshotFields.Dirty = value;
            }
        }
    }
}