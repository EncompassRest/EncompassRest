using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTracking2015Log : IDirty
    {
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { var v = _alerts; return v ?? Interlocked.CompareExchange(ref _alerts, (v = new DirtyList<LogAlert>()), null) ?? v; } set { _alerts = new DirtyList<LogAlert>(value); } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        private Value<string> _appliedCureAmount;
        public string AppliedCureAmount { get { return _appliedCureAmount; } set { _appliedCureAmount = value; } }
        private Value<DateTime?> _borrowerActualReceivedDate;
        public DateTime? BorrowerActualReceivedDate { get { return _borrowerActualReceivedDate; } set { _borrowerActualReceivedDate = value; } }
        private Value<string> _borrowerDisclosedMethod;
        public string BorrowerDisclosedMethod { get { return _borrowerDisclosedMethod; } set { _borrowerDisclosedMethod = value; } }
        private Value<string> _borrowerDisclosedMethodOther;
        public string BorrowerDisclosedMethodOther { get { return _borrowerDisclosedMethodOther; } set { _borrowerDisclosedMethodOther = value; } }
        private Value<string> _borrowerName;
        public string BorrowerName { get { return _borrowerName; } set { _borrowerName = value; } }
        private Value<string> _borrowerPairId;
        public string BorrowerPairId { get { return _borrowerPairId; } set { _borrowerPairId = value; } }
        private Value<DateTime?> _borrowerPresumedReceivedDate;
        public DateTime? BorrowerPresumedReceivedDate { get { return _borrowerPresumedReceivedDate; } set { _borrowerPresumedReceivedDate = value; } }
        private Value<string> _borrowerType;
        public string BorrowerType { get { return _borrowerType; } set { _borrowerType = value; } }
        private Value<bool?> _cDReasonIs24HourAdvancePreview;
        public bool? CDReasonIs24HourAdvancePreview { get { return _cDReasonIs24HourAdvancePreview; } set { _cDReasonIs24HourAdvancePreview = value; } }
        private Value<bool?> _cDReasonIsChangeInAPR;
        public bool? CDReasonIsChangeInAPR { get { return _cDReasonIsChangeInAPR; } set { _cDReasonIsChangeInAPR = value; } }
        private Value<bool?> _cDReasonIsChangeInLoanProduct;
        public bool? CDReasonIsChangeInLoanProduct { get { return _cDReasonIsChangeInLoanProduct; } set { _cDReasonIsChangeInLoanProduct = value; } }
        private Value<bool?> _cDReasonIsChangeInSettlementCharges;
        public bool? CDReasonIsChangeInSettlementCharges { get { return _cDReasonIsChangeInSettlementCharges; } set { _cDReasonIsChangeInSettlementCharges = value; } }
        private Value<bool?> _cDReasonIsClericalErrorCorrection;
        public bool? CDReasonIsClericalErrorCorrection { get { return _cDReasonIsClericalErrorCorrection; } set { _cDReasonIsClericalErrorCorrection = value; } }
        private Value<bool?> _cDReasonIsOther;
        public bool? CDReasonIsOther { get { return _cDReasonIsOther; } set { _cDReasonIsOther = value; } }
        private Value<bool?> _cDReasonIsPrepaymentPenaltyAdded;
        public bool? CDReasonIsPrepaymentPenaltyAdded { get { return _cDReasonIsPrepaymentPenaltyAdded; } set { _cDReasonIsPrepaymentPenaltyAdded = value; } }
        private Value<bool?> _cDReasonIsToleranceCure;
        public bool? CDReasonIsToleranceCure { get { return _cDReasonIsToleranceCure; } set { _cDReasonIsToleranceCure = value; } }
        private Value<string> _cDReasonOther;
        public string CDReasonOther { get { return _cDReasonOther; } set { _cDReasonOther = value; } }
        private Value<string> _changeInCircumstance;
        public string ChangeInCircumstance { get { return _changeInCircumstance; } set { _changeInCircumstance = value; } }
        private Value<string> _changeInCircumstanceComments;
        public string ChangeInCircumstanceComments { get { return _changeInCircumstanceComments; } set { _changeInCircumstanceComments = value; } }
        private Value<string> _chargesCannotIncrease10Itemization34;
        public string ChargesCannotIncrease10Itemization34 { get { return _chargesCannotIncrease10Itemization34; } set { _chargesCannotIncrease10Itemization34 = value; } }
        private Value<string> _chargesCannotIncrease10LE32;
        public string ChargesCannotIncrease10LE32 { get { return _chargesCannotIncrease10LE32; } set { _chargesCannotIncrease10LE32 = value; } }
        private Value<string> _chargesThatCannotDecreaseItemization9;
        public string ChargesThatCannotDecreaseItemization9 { get { return _chargesThatCannotDecreaseItemization9; } set { _chargesThatCannotDecreaseItemization9 = value; } }
        private Value<string> _chargesThatCannotDecreaseLE7;
        public string ChargesThatCannotDecreaseLE7 { get { return _chargesThatCannotDecreaseLE7; } set { _chargesThatCannotDecreaseLE7 = value; } }
        private Value<string> _chargesThatCannotIncreaseItemization13;
        public string ChargesThatCannotIncreaseItemization13 { get { return _chargesThatCannotIncreaseItemization13; } set { _chargesThatCannotIncreaseItemization13 = value; } }
        private Value<string> _chargesThatCannotIncreaseLE11;
        public string ChargesThatCannotIncreaseLE11 { get { return _chargesThatCannotIncreaseLE11; } set { _chargesThatCannotIncreaseLE11 = value; } }
        private Value<DateTime?> _coBorrowerActualReceivedDate;
        public DateTime? CoBorrowerActualReceivedDate { get { return _coBorrowerActualReceivedDate; } set { _coBorrowerActualReceivedDate = value; } }
        private Value<string> _coBorrowerDisclosedMethod;
        public string CoBorrowerDisclosedMethod { get { return _coBorrowerDisclosedMethod; } set { _coBorrowerDisclosedMethod = value; } }
        private Value<string> _coBorrowerDisclosedMethodOther;
        public string CoBorrowerDisclosedMethodOther { get { return _coBorrowerDisclosedMethodOther; } set { _coBorrowerDisclosedMethodOther = value; } }
        private Value<string> _coBorrowerName;
        public string CoBorrowerName { get { return _coBorrowerName; } set { _coBorrowerName = value; } }
        private Value<DateTime?> _coBorrowerPresumedReceivedDate;
        public DateTime? CoBorrowerPresumedReceivedDate { get { return _coBorrowerPresumedReceivedDate; } set { _coBorrowerPresumedReceivedDate = value; } }
        private Value<string> _coBorrowerType;
        public string CoBorrowerType { get { return _coBorrowerType; } set { _coBorrowerType = value; } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { var v = _commentList; return v ?? Interlocked.CompareExchange(ref _commentList, (v = new DirtyList<LogComment>()), null) ?? v; } set { _commentList = new DirtyList<LogComment>(value); } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<bool?> _containCD;
        public bool? ContainCD { get { return _containCD; } set { _containCD = value; } }
        private Value<bool?> _containLE;
        public bool? ContainLE { get { return _containLE; } set { _containLE = value; } }
        private Value<bool?> _containSafeHarbor;
        public bool? ContainSafeHarbor { get { return _containSafeHarbor; } set { _containSafeHarbor = value; } }
        private Value<DateTime?> _dateAdded;
        public DateTime? DateAdded { get { return _dateAdded; } set { _dateAdded = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<string> _disclosedAPR;
        public string DisclosedAPR { get { return _disclosedAPR; } set { _disclosedAPR = value; } }
        private Value<string> _disclosedBy;
        public string DisclosedBy { get { return _disclosedBy; } set { _disclosedBy = value; } }
        private Value<string> _disclosedByFullName;
        public string DisclosedByFullName { get { return _disclosedByFullName; } set { _disclosedByFullName = value; } }
        private Value<string> _disclosedDailyInterest;
        public string DisclosedDailyInterest { get { return _disclosedDailyInterest; } set { _disclosedDailyInterest = value; } }
        private Value<DateTime?> _disclosedDate;
        public DateTime? DisclosedDate { get { return _disclosedDate; } set { _disclosedDate = value; } }
        private Value<bool?> _disclosedForCD;
        public bool? DisclosedForCD { get { return _disclosedForCD; } set { _disclosedForCD = value; } }
        private Value<bool?> _disclosedForLE;
        public bool? DisclosedForLE { get { return _disclosedForLE; } set { _disclosedForLE = value; } }
        private Value<string> _disclosedMethod;
        public string DisclosedMethod { get { return _disclosedMethod; } set { _disclosedMethod = value; } }
        private Value<string> _disclosedMethodName;
        public string DisclosedMethodName { get { return _disclosedMethodName; } set { _disclosedMethodName = value; } }
        private Value<string> _disclosedMethodOther;
        public string DisclosedMethodOther { get { return _disclosedMethodOther; } set { _disclosedMethodOther = value; } }
        private Value<string> _disclosedSalesPrice;
        public string DisclosedSalesPrice { get { return _disclosedSalesPrice; } set { _disclosedSalesPrice = value; } }
        private Value<DateTime?> _disclosureCreatedDttmUtc;
        public DateTime? DisclosureCreatedDttmUtc { get { return _disclosureCreatedDttmUtc; } set { _disclosureCreatedDttmUtc = value; } }
        private Value<string> _disclosureMethod;
        public string DisclosureMethod { get { return _disclosureMethod; } set { _disclosureMethod = value; } }
        private Value<string> _disclosureType;
        public string DisclosureType { get { return _disclosureType; } set { _disclosureType = value; } }
        private Value<bool?> _eDisclosureApplicationPackageIndicator;
        public bool? EDisclosureApplicationPackageIndicator { get { return _eDisclosureApplicationPackageIndicator; } set { _eDisclosureApplicationPackageIndicator = value; } }
        private Value<bool?> _eDisclosureApprovalPackageIndicator;
        public bool? EDisclosureApprovalPackageIndicator { get { return _eDisclosureApprovalPackageIndicator; } set { _eDisclosureApprovalPackageIndicator = value; } }
        private Value<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get { return _eDisclosureBorrowerAcceptConsentDate; } set { _eDisclosureBorrowerAcceptConsentDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowereSignedDate;
        public DateTime? EDisclosureBorrowereSignedDate { get { return _eDisclosureBorrowereSignedDate; } set { _eDisclosureBorrowereSignedDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        public DateTime? EDisclosureBorrowerRejectConsentDate { get { return _eDisclosureBorrowerRejectConsentDate; } set { _eDisclosureBorrowerRejectConsentDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerViewConsentDate;
        public DateTime? EDisclosureBorrowerViewConsentDate { get { return _eDisclosureBorrowerViewConsentDate; } set { _eDisclosureBorrowerViewConsentDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerViewMessageDate;
        public DateTime? EDisclosureBorrowerViewMessageDate { get { return _eDisclosureBorrowerViewMessageDate; } set { _eDisclosureBorrowerViewMessageDate = value; } }
        private Value<DateTime?> _eDisclosureBorrowerWetSignedDate;
        public DateTime? EDisclosureBorrowerWetSignedDate { get { return _eDisclosureBorrowerWetSignedDate; } set { _eDisclosureBorrowerWetSignedDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get { return _eDisclosureCoBorrowerAcceptConsentDate; } set { _eDisclosureCoBorrowerAcceptConsentDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowereSignedDate;
        public DateTime? EDisclosureCoBorrowereSignedDate { get { return _eDisclosureCoBorrowereSignedDate; } set { _eDisclosureCoBorrowereSignedDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get { return _eDisclosureCoBorrowerRejectConsentDate; } set { _eDisclosureCoBorrowerRejectConsentDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get { return _eDisclosureCoBorrowerViewConsentDate; } set { _eDisclosureCoBorrowerViewConsentDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get { return _eDisclosureCoBorrowerViewMessageDate; } set { _eDisclosureCoBorrowerViewMessageDate = value; } }
        private Value<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get { return _eDisclosureCoBorrowerWebSignedDate; } set { _eDisclosureCoBorrowerWebSignedDate = value; } }
        private Value<string> _eDisclosureConsentPdf;
        public string EDisclosureConsentPdf { get { return _eDisclosureConsentPdf; } set { _eDisclosureConsentPdf = value; } }
        private Value<string> _eDisclosureDisclosedMessage;
        public string EDisclosureDisclosedMessage { get { return _eDisclosureDisclosedMessage; } set { _eDisclosureDisclosedMessage = value; } }
        private Value<bool?> _eDisclosureLockPackageIndicator;
        public bool? EDisclosureLockPackageIndicator { get { return _eDisclosureLockPackageIndicator; } set { _eDisclosureLockPackageIndicator = value; } }
        private Value<string> _eDisclosureManualFulfillmentComment;
        public string EDisclosureManualFulfillmentComment { get { return _eDisclosureManualFulfillmentComment; } set { _eDisclosureManualFulfillmentComment = value; } }
        private Value<DateTime?> _eDisclosureManualFulfillmentDate;
        public DateTime? EDisclosureManualFulfillmentDate { get { return _eDisclosureManualFulfillmentDate; } set { _eDisclosureManualFulfillmentDate = value; } }
        private Value<string> _eDisclosureManualFulfillmentMethod;
        public string EDisclosureManualFulfillmentMethod { get { return _eDisclosureManualFulfillmentMethod; } set { _eDisclosureManualFulfillmentMethod = value; } }
        private Value<string> _eDisclosureManuallyFulfilledBy;
        public string EDisclosureManuallyFulfilledBy { get { return _eDisclosureManuallyFulfilledBy; } set { _eDisclosureManuallyFulfilledBy = value; } }
        private Value<DateTime?> _eDisclosurePackageCreatedDate;
        public DateTime? EDisclosurePackageCreatedDate { get { return _eDisclosurePackageCreatedDate; } set { _eDisclosurePackageCreatedDate = value; } }
        private Value<string> _eDisclosurePackageId;
        public string EDisclosurePackageId { get { return _eDisclosurePackageId; } set { _eDisclosurePackageId = value; } }
        private Value<string> _eDisclosurePackageViewableFile;
        public string EDisclosurePackageViewableFile { get { return _eDisclosurePackageViewableFile; } set { _eDisclosurePackageViewableFile = value; } }
        private Value<bool?> _eDisclosureThreeDayPackageIndicator;
        public bool? EDisclosureThreeDayPackageIndicator { get { return _eDisclosureThreeDayPackageIndicator; } set { _eDisclosureThreeDayPackageIndicator = value; } }
        private Value<string> _estimatedTotalPayoffsAndPaymentsAmount;
        public string EstimatedTotalPayoffsAndPaymentsAmount { get { return _estimatedTotalPayoffsAndPaymentsAmount; } set { _estimatedTotalPayoffsAndPaymentsAmount = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _financeCharge;
        public string FinanceCharge { get { return _financeCharge; } set { _financeCharge = value; } }
        private DirtyList<DisclosureForm> _forms;
        public IList<DisclosureForm> Forms { get { var v = _forms; return v ?? Interlocked.CompareExchange(ref _forms, (v = new DirtyList<DisclosureForm>()), null) ?? v; } set { _forms = new DirtyList<DisclosureForm>(value); } }
        private Value<string> _formsXml;
        public string FormsXml { get { return _formsXml; } set { _formsXml = value; } }
        private Value<string> _fulfillmentOrderedBy;
        public string FulfillmentOrderedBy { get { return _fulfillmentOrderedBy; } set { _fulfillmentOrderedBy = value; } }
        private Value<string> _fullfillmentProcessedDate;
        public string FullfillmentProcessedDate { get { return _fullfillmentProcessedDate; } set { _fullfillmentProcessedDate = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _intentToProceed;
        public bool? IntentToProceed { get { return _intentToProceed; } set { _intentToProceed = value; } }
        private Value<string> _intentToProceedComments;
        public string IntentToProceedComments { get { return _intentToProceedComments; } set { _intentToProceedComments = value; } }
        private Value<DateTime?> _intentToProceedDate;
        public DateTime? IntentToProceedDate { get { return _intentToProceedDate; } set { _intentToProceedDate = value; } }
        private Value<string> _intentToProceedReceivedBy;
        public string IntentToProceedReceivedBy { get { return _intentToProceedReceivedBy; } set { _intentToProceedReceivedBy = value; } }
        private Value<string> _intentToProceedReceivedMethod;
        public string IntentToProceedReceivedMethod { get { return _intentToProceedReceivedMethod; } set { _intentToProceedReceivedMethod = value; } }
        private Value<string> _intentToProceedReceivedMethodOther;
        public string IntentToProceedReceivedMethodOther { get { return _intentToProceedReceivedMethodOther; } set { _intentToProceedReceivedMethodOther = value; } }
        private Value<bool?> _isBorrowerPresumedDateLocked;
        public bool? IsBorrowerPresumedDateLocked { get { return _isBorrowerPresumedDateLocked; } set { _isBorrowerPresumedDateLocked = value; } }
        private Value<bool?> _isBorrowerTypeLocked;
        public bool? IsBorrowerTypeLocked { get { return _isBorrowerTypeLocked; } set { _isBorrowerTypeLocked = value; } }
        private Value<bool?> _isCoBorrowerPresumedDateLocked;
        public bool? IsCoBorrowerPresumedDateLocked { get { return _isCoBorrowerPresumedDateLocked; } set { _isCoBorrowerPresumedDateLocked = value; } }
        private Value<bool?> _isCoBorrowerTypeLocked;
        public bool? IsCoBorrowerTypeLocked { get { return _isCoBorrowerTypeLocked; } set { _isCoBorrowerTypeLocked = value; } }
        private Value<string> _isDisclosed;
        public string IsDisclosed { get { return _isDisclosed; } set { _isDisclosed = value; } }
        private Value<string> _isDisclosedAprLocked;
        public string IsDisclosedAprLocked { get { return _isDisclosedAprLocked; } set { _isDisclosedAprLocked = value; } }
        private Value<string> _isDisclosedByLocked;
        public string IsDisclosedByLocked { get { return _isDisclosedByLocked; } set { _isDisclosedByLocked = value; } }
        private Value<string> _isDisclosedFinanceChargeLocked;
        public string IsDisclosedFinanceChargeLocked { get { return _isDisclosedFinanceChargeLocked; } set { _isDisclosedFinanceChargeLocked = value; } }
        private Value<string> _isDisclosedReceivedDateLocked;
        public string IsDisclosedReceivedDateLocked { get { return _isDisclosedReceivedDateLocked; } set { _isDisclosedReceivedDateLocked = value; } }
        private Value<string> _isLocked;
        public string IsLocked { get { return _isLocked; } set { _isLocked = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<bool?> _isWetSignedIndicator;
        public bool? IsWetSignedIndicator { get { return _isWetSignedIndicator; } set { _isWetSignedIndicator = value; } }
        private Value<string> _lenderCompensationCreditAmount2;
        public string LenderCompensationCreditAmount2 { get { return _lenderCompensationCreditAmount2; } set { _lenderCompensationCreditAmount2 = value; } }
        private Value<string> _lenderTotalPaidOriginatorAmount;
        public string LenderTotalPaidOriginatorAmount { get { return _lenderTotalPaidOriginatorAmount; } set { _lenderTotalPaidOriginatorAmount = value; } }
        private Value<bool?> _lEReasonIsChangedCircumstanceEligibility;
        public bool? LEReasonIsChangedCircumstanceEligibility { get { return _lEReasonIsChangedCircumstanceEligibility; } set { _lEReasonIsChangedCircumstanceEligibility = value; } }
        private Value<bool?> _lEReasonIsChangedCircumstanceSettlementCharges;
        public bool? LEReasonIsChangedCircumstanceSettlementCharges { get { return _lEReasonIsChangedCircumstanceSettlementCharges; } set { _lEReasonIsChangedCircumstanceSettlementCharges = value; } }
        private Value<bool?> _lEReasonIsDelayedSettlementOnConstructionLoans;
        public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get { return _lEReasonIsDelayedSettlementOnConstructionLoans; } set { _lEReasonIsDelayedSettlementOnConstructionLoans = value; } }
        private Value<bool?> _lEReasonIsExpiration;
        public bool? LEReasonIsExpiration { get { return _lEReasonIsExpiration; } set { _lEReasonIsExpiration = value; } }
        private Value<bool?> _lEReasonIsInterestRateDependentCharges;
        public bool? LEReasonIsInterestRateDependentCharges { get { return _lEReasonIsInterestRateDependentCharges; } set { _lEReasonIsInterestRateDependentCharges = value; } }
        private Value<bool?> _lEReasonIsOther;
        public bool? LEReasonIsOther { get { return _lEReasonIsOther; } set { _lEReasonIsOther = value; } }
        private Value<bool?> _lEReasonIsRevisionsRequestedByConsumer;
        public bool? LEReasonIsRevisionsRequestedByConsumer { get { return _lEReasonIsRevisionsRequestedByConsumer; } set { _lEReasonIsRevisionsRequestedByConsumer = value; } }
        private Value<string> _lEReasonOther;
        public string LEReasonOther { get { return _lEReasonOther; } set { _lEReasonOther = value; } }
        private Value<string> _line802LOCompAdditionalAmount1;
        public string Line802LOCompAdditionalAmount1 { get { return _line802LOCompAdditionalAmount1; } set { _line802LOCompAdditionalAmount1 = value; } }
        private Value<string> _line802LOCompAdditionalAmount2;
        public string Line802LOCompAdditionalAmount2 { get { return _line802LOCompAdditionalAmount2; } set { _line802LOCompAdditionalAmount2 = value; } }
        private Value<string> _line907InsuranceIndicator2015;
        public string Line907InsuranceIndicator2015 { get { return _line907InsuranceIndicator2015; } set { _line907InsuranceIndicator2015 = value; } }
        private Value<string> _line907PropertyIndicator2015;
        public string Line907PropertyIndicator2015 { get { return _line907PropertyIndicator2015; } set { _line907PropertyIndicator2015 = value; } }
        private Value<string> _line907TaxesIndicator2015;
        public string Line907TaxesIndicator2015 { get { return _line907TaxesIndicator2015; } set { _line907TaxesIndicator2015 = value; } }
        private Value<string> _line908InsuranceIndicator2015;
        public string Line908InsuranceIndicator2015 { get { return _line908InsuranceIndicator2015; } set { _line908InsuranceIndicator2015 = value; } }
        private Value<string> _line908PropertyIndicator2015;
        public string Line908PropertyIndicator2015 { get { return _line908PropertyIndicator2015; } set { _line908PropertyIndicator2015 = value; } }
        private Value<string> _line908TaxesIndicator2015;
        public string Line908TaxesIndicator2015 { get { return _line908TaxesIndicator2015; } set { _line908TaxesIndicator2015 = value; } }
        private Value<string> _line909InsuranceIndicator2015;
        public string Line909InsuranceIndicator2015 { get { return _line909InsuranceIndicator2015; } set { _line909InsuranceIndicator2015 = value; } }
        private Value<string> _line909PropertyIndicator2015;
        public string Line909PropertyIndicator2015 { get { return _line909PropertyIndicator2015; } set { _line909PropertyIndicator2015 = value; } }
        private Value<string> _line909TaxesIndicator2015;
        public string Line909TaxesIndicator2015 { get { return _line909TaxesIndicator2015; } set { _line909TaxesIndicator2015 = value; } }
        private Value<string> _line910InsuranceIndicator2015;
        public string Line910InsuranceIndicator2015 { get { return _line910InsuranceIndicator2015; } set { _line910InsuranceIndicator2015 = value; } }
        private Value<string> _line910PropertyIndicator2015;
        public string Line910PropertyIndicator2015 { get { return _line910PropertyIndicator2015; } set { _line910PropertyIndicator2015 = value; } }
        private Value<string> _line910TaxesIndicator2015;
        public string Line910TaxesIndicator2015 { get { return _line910TaxesIndicator2015; } set { _line910TaxesIndicator2015 = value; } }
        private Value<string> _line911InsuranceIndicator2015;
        public string Line911InsuranceIndicator2015 { get { return _line911InsuranceIndicator2015; } set { _line911InsuranceIndicator2015 = value; } }
        private Value<string> _line911PropertyIndicator2015;
        public string Line911PropertyIndicator2015 { get { return _line911PropertyIndicator2015; } set { _line911PropertyIndicator2015 = value; } }
        private Value<string> _line911TaxesIndicator2015;
        public string Line911TaxesIndicator2015 { get { return _line911TaxesIndicator2015; } set { _line911TaxesIndicator2015 = value; } }
        private Value<string> _line912InsuranceIndicator2015;
        public string Line912InsuranceIndicator2015 { get { return _line912InsuranceIndicator2015; } set { _line912InsuranceIndicator2015 = value; } }
        private Value<string> _line912PropertyIndicator2015;
        public string Line912PropertyIndicator2015 { get { return _line912PropertyIndicator2015; } set { _line912PropertyIndicator2015 = value; } }
        private Value<string> _line912TaxesIndicator2015;
        public string Line912TaxesIndicator2015 { get { return _line912TaxesIndicator2015; } set { _line912TaxesIndicator2015 = value; } }
        private Value<string> _loanAdjustmentsOtherCredits;
        public string LoanAdjustmentsOtherCredits { get { return _loanAdjustmentsOtherCredits; } set { _loanAdjustmentsOtherCredits = value; } }
        private Value<string> _loanAmount;
        public string LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private Value<string> _loanClosingCost2BorrowerClosingCostAtClosing;
        public string LoanClosingCost2BorrowerClosingCostAtClosing { get { return _loanClosingCost2BorrowerClosingCostAtClosing; } set { _loanClosingCost2BorrowerClosingCostAtClosing = value; } }
        private Value<string> _loanClosingCost2LenderCredits;
        public string LoanClosingCost2LenderCredits { get { return _loanClosingCost2LenderCredits; } set { _loanClosingCost2LenderCredits = value; } }
        private Value<string> _loanClosingCost2TotalLoanCost;
        public string LoanClosingCost2TotalLoanCost { get { return _loanClosingCost2TotalLoanCost; } set { _loanClosingCost2TotalLoanCost = value; } }
        private Value<string> _loanClosingCost2TotalOtherCost;
        public string LoanClosingCost2TotalOtherCost { get { return _loanClosingCost2TotalOtherCost; } set { _loanClosingCost2TotalOtherCost = value; } }
        private Value<string> _loanClosingCost3StdLegalLimit;
        public string LoanClosingCost3StdLegalLimit { get { return _loanClosingCost3StdLegalLimit; } set { _loanClosingCost3StdLegalLimit = value; } }
        private Value<string> _loanClosingCostGfe1200BorPaidAmount;
        public string LoanClosingCostGfe1200BorPaidAmount { get { return _loanClosingCostGfe1200BorPaidAmount; } set { _loanClosingCostGfe1200BorPaidAmount = value; } }
        private Value<string> _loanClosingCostGfe800BorPaidAmount;
        public string LoanClosingCostGfe800BorPaidAmount { get { return _loanClosingCostGfe800BorPaidAmount; } set { _loanClosingCostGfe800BorPaidAmount = value; } }
        private Value<string> _loanClosingCostLenderCredits;
        public string LoanClosingCostLenderCredits { get { return _loanClosingCostLenderCredits; } set { _loanClosingCostLenderCredits = value; } }
        private Value<string> _loanClosingCostSection1000BorrowerTotalPaidAmount;
        public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get { return _loanClosingCostSection1000BorrowerTotalPaidAmount; } set { _loanClosingCostSection1000BorrowerTotalPaidAmount = value; } }
        private Value<string> _loanClosingCostsFinanced;
        public string LoanClosingCostsFinanced { get { return _loanClosingCostsFinanced; } set { _loanClosingCostsFinanced = value; } }
        private Value<string> _loanClosingCostTotalFeeAmount2015;
        public string LoanClosingCostTotalFeeAmount2015 { get { return _loanClosingCostTotalFeeAmount2015; } set { _loanClosingCostTotalFeeAmount2015 = value; } }
        private Value<string> _loanDownPayment;
        public string LoanDownPayment { get { return _loanDownPayment; } set { _loanDownPayment = value; } }
        private Value<string> _loanEstimate2TotalLoanAndOtherCosts;
        public string LoanEstimate2TotalLoanAndOtherCosts { get { return _loanEstimate2TotalLoanAndOtherCosts; } set { _loanEstimate2TotalLoanAndOtherCosts = value; } }
        private Value<string> _loanEstimate2TotalLoanCosts;
        public string LoanEstimate2TotalLoanCosts { get { return _loanEstimate2TotalLoanCosts; } set { _loanEstimate2TotalLoanCosts = value; } }
        private Value<string> _loanEstimate2TotalOtherCosts;
        public string LoanEstimate2TotalOtherCosts { get { return _loanEstimate2TotalOtherCosts; } set { _loanEstimate2TotalOtherCosts = value; } }
        private Value<string> _loanEstimate2UnroundedTotalLoanCosts;
        public string LoanEstimate2UnroundedTotalLoanCosts { get { return _loanEstimate2UnroundedTotalLoanCosts; } set { _loanEstimate2UnroundedTotalLoanCosts = value; } }
        private Value<string> _loanEstimate2UnroundedTotalOtherCosts;
        public string LoanEstimate2UnroundedTotalOtherCosts { get { return _loanEstimate2UnroundedTotalOtherCosts; } set { _loanEstimate2UnroundedTotalOtherCosts = value; } }
        private Value<string> _loanEstimateLoanProduct;
        public string LoanEstimateLoanProduct { get { return _loanEstimateLoanProduct; } set { _loanEstimateLoanProduct = value; } }
        private Value<string> _loanFeesCityTaxBorPaidAmount;
        public string LoanFeesCityTaxBorPaidAmount { get { return _loanFeesCityTaxBorPaidAmount; } set { _loanFeesCityTaxBorPaidAmount = value; } }
        private Value<string> _loanFeesStateTaxBorPaidAmount;
        public string LoanFeesStateTaxBorPaidAmount { get { return _loanFeesStateTaxBorPaidAmount; } set { _loanFeesStateTaxBorPaidAmount = value; } }
        private Value<string> _loanFundsForBorrower;
        public string LoanFundsForBorrower { get { return _loanFundsForBorrower; } set { _loanFundsForBorrower = value; } }
        private Value<string> _loanGfeAgregateAdjustment;
        public string LoanGfeAgregateAdjustment { get { return _loanGfeAgregateAdjustment; } set { _loanGfeAgregateAdjustment = value; } }
        private Value<string> _loanGfeGovermentRecordingCharges;
        public string LoanGfeGovermentRecordingCharges { get { return _loanGfeGovermentRecordingCharges; } set { _loanGfeGovermentRecordingCharges = value; } }
        private Value<string> _loanLineItemAmount;
        public string LoanLineItemAmount { get { return _loanLineItemAmount; } set { _loanLineItemAmount = value; } }
        private Value<string> _loanProgram;
        public string LoanProgram { get { return _loanProgram; } set { _loanProgram = value; } }
        private Value<string> _loanPurchaseCreditAmount1;
        public string LoanPurchaseCreditAmount1 { get { return _loanPurchaseCreditAmount1; } set { _loanPurchaseCreditAmount1 = value; } }
        private Value<string> _loanPurchaseCreditAmount2;
        public string LoanPurchaseCreditAmount2 { get { return _loanPurchaseCreditAmount2; } set { _loanPurchaseCreditAmount2 = value; } }
        private Value<string> _loanPurchaseCreditAmount3;
        public string LoanPurchaseCreditAmount3 { get { return _loanPurchaseCreditAmount3; } set { _loanPurchaseCreditAmount3 = value; } }
        private Value<string> _loanPurchaseCreditAmount4;
        public string LoanPurchaseCreditAmount4 { get { return _loanPurchaseCreditAmount4; } set { _loanPurchaseCreditAmount4 = value; } }
        private Value<string> _loanPurchaseCreditType1;
        public string LoanPurchaseCreditType1 { get { return _loanPurchaseCreditType1; } set { _loanPurchaseCreditType1 = value; } }
        private Value<string> _loanPurchaseCreditType2;
        public string LoanPurchaseCreditType2 { get { return _loanPurchaseCreditType2; } set { _loanPurchaseCreditType2 = value; } }
        private Value<string> _loanPurchaseCreditType3;
        public string LoanPurchaseCreditType3 { get { return _loanPurchaseCreditType3; } set { _loanPurchaseCreditType3 = value; } }
        private Value<string> _loanPurchaseCreditType4;
        public string LoanPurchaseCreditType4 { get { return _loanPurchaseCreditType4; } set { _loanPurchaseCreditType4 = value; } }
        private Value<string> _loanRefinanceIncludingDebtsToBePaidOffAmount;
        public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get { return _loanRefinanceIncludingDebtsToBePaidOffAmount; } set { _loanRefinanceIncludingDebtsToBePaidOffAmount = value; } }
        private Value<string> _loanSection1000SellerPaidTotalAmount;
        public string LoanSection1000SellerPaidTotalAmount { get { return _loanSection1000SellerPaidTotalAmount; } set { _loanSection1000SellerPaidTotalAmount = value; } }
        private Value<string> _loanSellerCreditAmount;
        public string LoanSellerCreditAmount { get { return _loanSellerCreditAmount; } set { _loanSellerCreditAmount = value; } }
        private Value<string> _loanTotalClosingCosts;
        public string LoanTotalClosingCosts { get { return _loanTotalClosingCosts; } set { _loanTotalClosingCosts = value; } }
        private Value<DateTime?> _lockedBorrowerPresumedReceivedDate;
        public DateTime? LockedBorrowerPresumedReceivedDate { get { return _lockedBorrowerPresumedReceivedDate; } set { _lockedBorrowerPresumedReceivedDate = value; } }
        private Value<string> _lockedBorrowerType;
        public string LockedBorrowerType { get { return _lockedBorrowerType; } set { _lockedBorrowerType = value; } }
        private Value<DateTime?> _lockedCoBorrowerPresumedReceivedDate;
        public DateTime? LockedCoBorrowerPresumedReceivedDate { get { return _lockedCoBorrowerPresumedReceivedDate; } set { _lockedCoBorrowerPresumedReceivedDate = value; } }
        private Value<string> _lockedCoBorrowerType;
        public string LockedCoBorrowerType { get { return _lockedCoBorrowerType; } set { _lockedCoBorrowerType = value; } }
        private Value<string> _lockedDisclosedAprField;
        public string LockedDisclosedAprField { get { return _lockedDisclosedAprField; } set { _lockedDisclosedAprField = value; } }
        private Value<string> _lockedDisclosedByField;
        public string LockedDisclosedByField { get { return _lockedDisclosedByField; } set { _lockedDisclosedByField = value; } }
        private Value<string> _lockedDisclosedFinanceChargeField;
        public string LockedDisclosedFinanceChargeField { get { return _lockedDisclosedFinanceChargeField; } set { _lockedDisclosedFinanceChargeField = value; } }
        private Value<DateTime?> _lockedDisclosedReceivedDate;
        public DateTime? LockedDisclosedReceivedDate { get { return _lockedDisclosedReceivedDate; } set { _lockedDisclosedReceivedDate = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<string> _manuallyCreated;
        public string ManuallyCreated { get { return _manuallyCreated; } set { _manuallyCreated = value; } }
        private Value<string> _prepaymentPenaltyIndicator;
        public string PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        private Value<string> _propertyAddress;
        public string PropertyAddress { get { return _propertyAddress; } set { _propertyAddress = value; } }
        private Value<string> _propertyCity;
        public string PropertyCity { get { return _propertyCity; } set { _propertyCity = value; } }
        private Value<string> _propertyState;
        public string PropertyState { get { return _propertyState; } set { _propertyState = value; } }
        private Value<string> _propertyZip;
        public string PropertyZip { get { return _propertyZip; } set { _propertyZip = value; } }
        private Value<bool?> _providerListSent;
        public bool? ProviderListSent { get { return _providerListSent; } set { _providerListSent = value; } }
        private Value<string> _purchasePriceAmount;
        public string PurchasePriceAmount { get { return _purchasePriceAmount; } set { _purchasePriceAmount = value; } }
        private Value<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get { return _receivedDate; } set { _receivedDate = value; } }
        private DirtyList<LogSnapshotField> _snapshotFields;
        public IList<LogSnapshotField> SnapshotFields { get { var v = _snapshotFields; return v ?? Interlocked.CompareExchange(ref _snapshotFields, (v = new DirtyList<LogSnapshotField>()), null) ?? v; } set { _snapshotFields = new DirtyList<LogSnapshotField>(value); } }
        private Value<string> _snapshotXml;
        public string SnapshotXml { get { return _snapshotXml; } set { _snapshotXml = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _alertsXml.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}