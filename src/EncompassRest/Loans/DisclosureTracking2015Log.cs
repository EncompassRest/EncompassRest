using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTracking2015Log : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
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
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
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
        private Value<List<DisclosureForm>> _forms;
        public List<DisclosureForm> Forms { get { return _forms; } set { _forms = value; } }
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
        private Value<List<LogSnapshotField>> _snapshotFields;
        public List<LogSnapshotField> SnapshotFields { get { return _snapshotFields; } set { _snapshotFields = value; } }
        private Value<string> _snapshotXml;
        public string SnapshotXml { get { return _snapshotXml; } set { _snapshotXml = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _alertsXml.Clean
                    && _applicationDate.Clean
                    && _appliedCureAmount.Clean
                    && _borrowerActualReceivedDate.Clean
                    && _borrowerDisclosedMethod.Clean
                    && _borrowerDisclosedMethodOther.Clean
                    && _borrowerName.Clean
                    && _borrowerPairId.Clean
                    && _borrowerPresumedReceivedDate.Clean
                    && _borrowerType.Clean
                    && _cDReasonIs24HourAdvancePreview.Clean
                    && _cDReasonIsChangeInAPR.Clean
                    && _cDReasonIsChangeInLoanProduct.Clean
                    && _cDReasonIsChangeInSettlementCharges.Clean
                    && _cDReasonIsClericalErrorCorrection.Clean
                    && _cDReasonIsOther.Clean
                    && _cDReasonIsPrepaymentPenaltyAdded.Clean
                    && _cDReasonIsToleranceCure.Clean
                    && _cDReasonOther.Clean
                    && _changeInCircumstance.Clean
                    && _changeInCircumstanceComments.Clean
                    && _chargesCannotIncrease10Itemization34.Clean
                    && _chargesCannotIncrease10LE32.Clean
                    && _chargesThatCannotDecreaseItemization9.Clean
                    && _chargesThatCannotDecreaseLE7.Clean
                    && _chargesThatCannotIncreaseItemization13.Clean
                    && _chargesThatCannotIncreaseLE11.Clean
                    && _coBorrowerActualReceivedDate.Clean
                    && _coBorrowerDisclosedMethod.Clean
                    && _coBorrowerDisclosedMethodOther.Clean
                    && _coBorrowerName.Clean
                    && _coBorrowerPresumedReceivedDate.Clean
                    && _coBorrowerType.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _containCD.Clean
                    && _containLE.Clean
                    && _containSafeHarbor.Clean
                    && _dateAdded.Clean
                    && _dateUtc.Clean
                    && _disclosedAPR.Clean
                    && _disclosedBy.Clean
                    && _disclosedByFullName.Clean
                    && _disclosedDailyInterest.Clean
                    && _disclosedDate.Clean
                    && _disclosedForCD.Clean
                    && _disclosedForLE.Clean
                    && _disclosedMethod.Clean
                    && _disclosedMethodName.Clean
                    && _disclosedMethodOther.Clean
                    && _disclosedSalesPrice.Clean
                    && _disclosureCreatedDttmUtc.Clean
                    && _disclosureMethod.Clean
                    && _disclosureType.Clean
                    && _eDisclosureApplicationPackageIndicator.Clean
                    && _eDisclosureApprovalPackageIndicator.Clean
                    && _eDisclosureBorrowerAcceptConsentDate.Clean
                    && _eDisclosureBorrowereSignedDate.Clean
                    && _eDisclosureBorrowerRejectConsentDate.Clean
                    && _eDisclosureBorrowerViewConsentDate.Clean
                    && _eDisclosureBorrowerViewMessageDate.Clean
                    && _eDisclosureBorrowerWetSignedDate.Clean
                    && _eDisclosureCoBorrowerAcceptConsentDate.Clean
                    && _eDisclosureCoBorrowereSignedDate.Clean
                    && _eDisclosureCoBorrowerRejectConsentDate.Clean
                    && _eDisclosureCoBorrowerViewConsentDate.Clean
                    && _eDisclosureCoBorrowerViewMessageDate.Clean
                    && _eDisclosureCoBorrowerWebSignedDate.Clean
                    && _eDisclosureConsentPdf.Clean
                    && _eDisclosureDisclosedMessage.Clean
                    && _eDisclosureLockPackageIndicator.Clean
                    && _eDisclosureManualFulfillmentComment.Clean
                    && _eDisclosureManualFulfillmentDate.Clean
                    && _eDisclosureManualFulfillmentMethod.Clean
                    && _eDisclosureManuallyFulfilledBy.Clean
                    && _eDisclosurePackageCreatedDate.Clean
                    && _eDisclosurePackageId.Clean
                    && _eDisclosurePackageViewableFile.Clean
                    && _eDisclosureThreeDayPackageIndicator.Clean
                    && _estimatedTotalPayoffsAndPaymentsAmount.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _financeCharge.Clean
                    && _forms.Clean
                    && _formsXml.Clean
                    && _fulfillmentOrderedBy.Clean
                    && _fullfillmentProcessedDate.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _intentToProceed.Clean
                    && _intentToProceedComments.Clean
                    && _intentToProceedDate.Clean
                    && _intentToProceedReceivedBy.Clean
                    && _intentToProceedReceivedMethod.Clean
                    && _intentToProceedReceivedMethodOther.Clean
                    && _isBorrowerPresumedDateLocked.Clean
                    && _isBorrowerTypeLocked.Clean
                    && _isCoBorrowerPresumedDateLocked.Clean
                    && _isCoBorrowerTypeLocked.Clean
                    && _isDisclosed.Clean
                    && _isDisclosedAprLocked.Clean
                    && _isDisclosedByLocked.Clean
                    && _isDisclosedFinanceChargeLocked.Clean
                    && _isDisclosedReceivedDateLocked.Clean
                    && _isLocked.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _isWetSignedIndicator.Clean
                    && _lenderCompensationCreditAmount2.Clean
                    && _lenderTotalPaidOriginatorAmount.Clean
                    && _lEReasonIsChangedCircumstanceEligibility.Clean
                    && _lEReasonIsChangedCircumstanceSettlementCharges.Clean
                    && _lEReasonIsDelayedSettlementOnConstructionLoans.Clean
                    && _lEReasonIsExpiration.Clean
                    && _lEReasonIsInterestRateDependentCharges.Clean
                    && _lEReasonIsOther.Clean
                    && _lEReasonIsRevisionsRequestedByConsumer.Clean
                    && _lEReasonOther.Clean
                    && _line802LOCompAdditionalAmount1.Clean
                    && _line802LOCompAdditionalAmount2.Clean
                    && _line907InsuranceIndicator2015.Clean
                    && _line907PropertyIndicator2015.Clean
                    && _line907TaxesIndicator2015.Clean
                    && _line908InsuranceIndicator2015.Clean
                    && _line908PropertyIndicator2015.Clean
                    && _line908TaxesIndicator2015.Clean
                    && _line909InsuranceIndicator2015.Clean
                    && _line909PropertyIndicator2015.Clean
                    && _line909TaxesIndicator2015.Clean
                    && _line910InsuranceIndicator2015.Clean
                    && _line910PropertyIndicator2015.Clean
                    && _line910TaxesIndicator2015.Clean
                    && _line911InsuranceIndicator2015.Clean
                    && _line911PropertyIndicator2015.Clean
                    && _line911TaxesIndicator2015.Clean
                    && _line912InsuranceIndicator2015.Clean
                    && _line912PropertyIndicator2015.Clean
                    && _line912TaxesIndicator2015.Clean
                    && _loanAdjustmentsOtherCredits.Clean
                    && _loanAmount.Clean
                    && _loanClosingCost2BorrowerClosingCostAtClosing.Clean
                    && _loanClosingCost2LenderCredits.Clean
                    && _loanClosingCost2TotalLoanCost.Clean
                    && _loanClosingCost2TotalOtherCost.Clean
                    && _loanClosingCost3StdLegalLimit.Clean
                    && _loanClosingCostGfe1200BorPaidAmount.Clean
                    && _loanClosingCostGfe800BorPaidAmount.Clean
                    && _loanClosingCostLenderCredits.Clean
                    && _loanClosingCostSection1000BorrowerTotalPaidAmount.Clean
                    && _loanClosingCostsFinanced.Clean
                    && _loanClosingCostTotalFeeAmount2015.Clean
                    && _loanDownPayment.Clean
                    && _loanEstimate2TotalLoanAndOtherCosts.Clean
                    && _loanEstimate2TotalLoanCosts.Clean
                    && _loanEstimate2TotalOtherCosts.Clean
                    && _loanEstimate2UnroundedTotalLoanCosts.Clean
                    && _loanEstimate2UnroundedTotalOtherCosts.Clean
                    && _loanEstimateLoanProduct.Clean
                    && _loanFeesCityTaxBorPaidAmount.Clean
                    && _loanFeesStateTaxBorPaidAmount.Clean
                    && _loanFundsForBorrower.Clean
                    && _loanGfeAgregateAdjustment.Clean
                    && _loanGfeGovermentRecordingCharges.Clean
                    && _loanLineItemAmount.Clean
                    && _loanProgram.Clean
                    && _loanPurchaseCreditAmount1.Clean
                    && _loanPurchaseCreditAmount2.Clean
                    && _loanPurchaseCreditAmount3.Clean
                    && _loanPurchaseCreditAmount4.Clean
                    && _loanPurchaseCreditType1.Clean
                    && _loanPurchaseCreditType2.Clean
                    && _loanPurchaseCreditType3.Clean
                    && _loanPurchaseCreditType4.Clean
                    && _loanRefinanceIncludingDebtsToBePaidOffAmount.Clean
                    && _loanSection1000SellerPaidTotalAmount.Clean
                    && _loanSellerCreditAmount.Clean
                    && _loanTotalClosingCosts.Clean
                    && _lockedBorrowerPresumedReceivedDate.Clean
                    && _lockedBorrowerType.Clean
                    && _lockedCoBorrowerPresumedReceivedDate.Clean
                    && _lockedCoBorrowerType.Clean
                    && _lockedDisclosedAprField.Clean
                    && _lockedDisclosedByField.Clean
                    && _lockedDisclosedFinanceChargeField.Clean
                    && _lockedDisclosedReceivedDate.Clean
                    && _logRecordIndex.Clean
                    && _manuallyCreated.Clean
                    && _prepaymentPenaltyIndicator.Clean
                    && _propertyAddress.Clean
                    && _propertyCity.Clean
                    && _propertyState.Clean
                    && _propertyZip.Clean
                    && _providerListSent.Clean
                    && _purchasePriceAmount.Clean
                    && _receivedDate.Clean
                    && _snapshotFields.Clean
                    && _snapshotXml.Clean
                    && _systemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var alertsXml = _alertsXml; alertsXml.Clean = value; _alertsXml = alertsXml;
                var applicationDate = _applicationDate; applicationDate.Clean = value; _applicationDate = applicationDate;
                var appliedCureAmount = _appliedCureAmount; appliedCureAmount.Clean = value; _appliedCureAmount = appliedCureAmount;
                var borrowerActualReceivedDate = _borrowerActualReceivedDate; borrowerActualReceivedDate.Clean = value; _borrowerActualReceivedDate = borrowerActualReceivedDate;
                var borrowerDisclosedMethod = _borrowerDisclosedMethod; borrowerDisclosedMethod.Clean = value; _borrowerDisclosedMethod = borrowerDisclosedMethod;
                var borrowerDisclosedMethodOther = _borrowerDisclosedMethodOther; borrowerDisclosedMethodOther.Clean = value; _borrowerDisclosedMethodOther = borrowerDisclosedMethodOther;
                var borrowerName = _borrowerName; borrowerName.Clean = value; _borrowerName = borrowerName;
                var borrowerPairId = _borrowerPairId; borrowerPairId.Clean = value; _borrowerPairId = borrowerPairId;
                var borrowerPresumedReceivedDate = _borrowerPresumedReceivedDate; borrowerPresumedReceivedDate.Clean = value; _borrowerPresumedReceivedDate = borrowerPresumedReceivedDate;
                var borrowerType = _borrowerType; borrowerType.Clean = value; _borrowerType = borrowerType;
                var cDReasonIs24HourAdvancePreview = _cDReasonIs24HourAdvancePreview; cDReasonIs24HourAdvancePreview.Clean = value; _cDReasonIs24HourAdvancePreview = cDReasonIs24HourAdvancePreview;
                var cDReasonIsChangeInAPR = _cDReasonIsChangeInAPR; cDReasonIsChangeInAPR.Clean = value; _cDReasonIsChangeInAPR = cDReasonIsChangeInAPR;
                var cDReasonIsChangeInLoanProduct = _cDReasonIsChangeInLoanProduct; cDReasonIsChangeInLoanProduct.Clean = value; _cDReasonIsChangeInLoanProduct = cDReasonIsChangeInLoanProduct;
                var cDReasonIsChangeInSettlementCharges = _cDReasonIsChangeInSettlementCharges; cDReasonIsChangeInSettlementCharges.Clean = value; _cDReasonIsChangeInSettlementCharges = cDReasonIsChangeInSettlementCharges;
                var cDReasonIsClericalErrorCorrection = _cDReasonIsClericalErrorCorrection; cDReasonIsClericalErrorCorrection.Clean = value; _cDReasonIsClericalErrorCorrection = cDReasonIsClericalErrorCorrection;
                var cDReasonIsOther = _cDReasonIsOther; cDReasonIsOther.Clean = value; _cDReasonIsOther = cDReasonIsOther;
                var cDReasonIsPrepaymentPenaltyAdded = _cDReasonIsPrepaymentPenaltyAdded; cDReasonIsPrepaymentPenaltyAdded.Clean = value; _cDReasonIsPrepaymentPenaltyAdded = cDReasonIsPrepaymentPenaltyAdded;
                var cDReasonIsToleranceCure = _cDReasonIsToleranceCure; cDReasonIsToleranceCure.Clean = value; _cDReasonIsToleranceCure = cDReasonIsToleranceCure;
                var cDReasonOther = _cDReasonOther; cDReasonOther.Clean = value; _cDReasonOther = cDReasonOther;
                var changeInCircumstance = _changeInCircumstance; changeInCircumstance.Clean = value; _changeInCircumstance = changeInCircumstance;
                var changeInCircumstanceComments = _changeInCircumstanceComments; changeInCircumstanceComments.Clean = value; _changeInCircumstanceComments = changeInCircumstanceComments;
                var chargesCannotIncrease10Itemization34 = _chargesCannotIncrease10Itemization34; chargesCannotIncrease10Itemization34.Clean = value; _chargesCannotIncrease10Itemization34 = chargesCannotIncrease10Itemization34;
                var chargesCannotIncrease10LE32 = _chargesCannotIncrease10LE32; chargesCannotIncrease10LE32.Clean = value; _chargesCannotIncrease10LE32 = chargesCannotIncrease10LE32;
                var chargesThatCannotDecreaseItemization9 = _chargesThatCannotDecreaseItemization9; chargesThatCannotDecreaseItemization9.Clean = value; _chargesThatCannotDecreaseItemization9 = chargesThatCannotDecreaseItemization9;
                var chargesThatCannotDecreaseLE7 = _chargesThatCannotDecreaseLE7; chargesThatCannotDecreaseLE7.Clean = value; _chargesThatCannotDecreaseLE7 = chargesThatCannotDecreaseLE7;
                var chargesThatCannotIncreaseItemization13 = _chargesThatCannotIncreaseItemization13; chargesThatCannotIncreaseItemization13.Clean = value; _chargesThatCannotIncreaseItemization13 = chargesThatCannotIncreaseItemization13;
                var chargesThatCannotIncreaseLE11 = _chargesThatCannotIncreaseLE11; chargesThatCannotIncreaseLE11.Clean = value; _chargesThatCannotIncreaseLE11 = chargesThatCannotIncreaseLE11;
                var coBorrowerActualReceivedDate = _coBorrowerActualReceivedDate; coBorrowerActualReceivedDate.Clean = value; _coBorrowerActualReceivedDate = coBorrowerActualReceivedDate;
                var coBorrowerDisclosedMethod = _coBorrowerDisclosedMethod; coBorrowerDisclosedMethod.Clean = value; _coBorrowerDisclosedMethod = coBorrowerDisclosedMethod;
                var coBorrowerDisclosedMethodOther = _coBorrowerDisclosedMethodOther; coBorrowerDisclosedMethodOther.Clean = value; _coBorrowerDisclosedMethodOther = coBorrowerDisclosedMethodOther;
                var coBorrowerName = _coBorrowerName; coBorrowerName.Clean = value; _coBorrowerName = coBorrowerName;
                var coBorrowerPresumedReceivedDate = _coBorrowerPresumedReceivedDate; coBorrowerPresumedReceivedDate.Clean = value; _coBorrowerPresumedReceivedDate = coBorrowerPresumedReceivedDate;
                var coBorrowerType = _coBorrowerType; coBorrowerType.Clean = value; _coBorrowerType = coBorrowerType;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var commentListXml = _commentListXml; commentListXml.Clean = value; _commentListXml = commentListXml;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var containCD = _containCD; containCD.Clean = value; _containCD = containCD;
                var containLE = _containLE; containLE.Clean = value; _containLE = containLE;
                var containSafeHarbor = _containSafeHarbor; containSafeHarbor.Clean = value; _containSafeHarbor = containSafeHarbor;
                var dateAdded = _dateAdded; dateAdded.Clean = value; _dateAdded = dateAdded;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var disclosedAPR = _disclosedAPR; disclosedAPR.Clean = value; _disclosedAPR = disclosedAPR;
                var disclosedBy = _disclosedBy; disclosedBy.Clean = value; _disclosedBy = disclosedBy;
                var disclosedByFullName = _disclosedByFullName; disclosedByFullName.Clean = value; _disclosedByFullName = disclosedByFullName;
                var disclosedDailyInterest = _disclosedDailyInterest; disclosedDailyInterest.Clean = value; _disclosedDailyInterest = disclosedDailyInterest;
                var disclosedDate = _disclosedDate; disclosedDate.Clean = value; _disclosedDate = disclosedDate;
                var disclosedForCD = _disclosedForCD; disclosedForCD.Clean = value; _disclosedForCD = disclosedForCD;
                var disclosedForLE = _disclosedForLE; disclosedForLE.Clean = value; _disclosedForLE = disclosedForLE;
                var disclosedMethod = _disclosedMethod; disclosedMethod.Clean = value; _disclosedMethod = disclosedMethod;
                var disclosedMethodName = _disclosedMethodName; disclosedMethodName.Clean = value; _disclosedMethodName = disclosedMethodName;
                var disclosedMethodOther = _disclosedMethodOther; disclosedMethodOther.Clean = value; _disclosedMethodOther = disclosedMethodOther;
                var disclosedSalesPrice = _disclosedSalesPrice; disclosedSalesPrice.Clean = value; _disclosedSalesPrice = disclosedSalesPrice;
                var disclosureCreatedDttmUtc = _disclosureCreatedDttmUtc; disclosureCreatedDttmUtc.Clean = value; _disclosureCreatedDttmUtc = disclosureCreatedDttmUtc;
                var disclosureMethod = _disclosureMethod; disclosureMethod.Clean = value; _disclosureMethod = disclosureMethod;
                var disclosureType = _disclosureType; disclosureType.Clean = value; _disclosureType = disclosureType;
                var eDisclosureApplicationPackageIndicator = _eDisclosureApplicationPackageIndicator; eDisclosureApplicationPackageIndicator.Clean = value; _eDisclosureApplicationPackageIndicator = eDisclosureApplicationPackageIndicator;
                var eDisclosureApprovalPackageIndicator = _eDisclosureApprovalPackageIndicator; eDisclosureApprovalPackageIndicator.Clean = value; _eDisclosureApprovalPackageIndicator = eDisclosureApprovalPackageIndicator;
                var eDisclosureBorrowerAcceptConsentDate = _eDisclosureBorrowerAcceptConsentDate; eDisclosureBorrowerAcceptConsentDate.Clean = value; _eDisclosureBorrowerAcceptConsentDate = eDisclosureBorrowerAcceptConsentDate;
                var eDisclosureBorrowereSignedDate = _eDisclosureBorrowereSignedDate; eDisclosureBorrowereSignedDate.Clean = value; _eDisclosureBorrowereSignedDate = eDisclosureBorrowereSignedDate;
                var eDisclosureBorrowerRejectConsentDate = _eDisclosureBorrowerRejectConsentDate; eDisclosureBorrowerRejectConsentDate.Clean = value; _eDisclosureBorrowerRejectConsentDate = eDisclosureBorrowerRejectConsentDate;
                var eDisclosureBorrowerViewConsentDate = _eDisclosureBorrowerViewConsentDate; eDisclosureBorrowerViewConsentDate.Clean = value; _eDisclosureBorrowerViewConsentDate = eDisclosureBorrowerViewConsentDate;
                var eDisclosureBorrowerViewMessageDate = _eDisclosureBorrowerViewMessageDate; eDisclosureBorrowerViewMessageDate.Clean = value; _eDisclosureBorrowerViewMessageDate = eDisclosureBorrowerViewMessageDate;
                var eDisclosureBorrowerWetSignedDate = _eDisclosureBorrowerWetSignedDate; eDisclosureBorrowerWetSignedDate.Clean = value; _eDisclosureBorrowerWetSignedDate = eDisclosureBorrowerWetSignedDate;
                var eDisclosureCoBorrowerAcceptConsentDate = _eDisclosureCoBorrowerAcceptConsentDate; eDisclosureCoBorrowerAcceptConsentDate.Clean = value; _eDisclosureCoBorrowerAcceptConsentDate = eDisclosureCoBorrowerAcceptConsentDate;
                var eDisclosureCoBorrowereSignedDate = _eDisclosureCoBorrowereSignedDate; eDisclosureCoBorrowereSignedDate.Clean = value; _eDisclosureCoBorrowereSignedDate = eDisclosureCoBorrowereSignedDate;
                var eDisclosureCoBorrowerRejectConsentDate = _eDisclosureCoBorrowerRejectConsentDate; eDisclosureCoBorrowerRejectConsentDate.Clean = value; _eDisclosureCoBorrowerRejectConsentDate = eDisclosureCoBorrowerRejectConsentDate;
                var eDisclosureCoBorrowerViewConsentDate = _eDisclosureCoBorrowerViewConsentDate; eDisclosureCoBorrowerViewConsentDate.Clean = value; _eDisclosureCoBorrowerViewConsentDate = eDisclosureCoBorrowerViewConsentDate;
                var eDisclosureCoBorrowerViewMessageDate = _eDisclosureCoBorrowerViewMessageDate; eDisclosureCoBorrowerViewMessageDate.Clean = value; _eDisclosureCoBorrowerViewMessageDate = eDisclosureCoBorrowerViewMessageDate;
                var eDisclosureCoBorrowerWebSignedDate = _eDisclosureCoBorrowerWebSignedDate; eDisclosureCoBorrowerWebSignedDate.Clean = value; _eDisclosureCoBorrowerWebSignedDate = eDisclosureCoBorrowerWebSignedDate;
                var eDisclosureConsentPdf = _eDisclosureConsentPdf; eDisclosureConsentPdf.Clean = value; _eDisclosureConsentPdf = eDisclosureConsentPdf;
                var eDisclosureDisclosedMessage = _eDisclosureDisclosedMessage; eDisclosureDisclosedMessage.Clean = value; _eDisclosureDisclosedMessage = eDisclosureDisclosedMessage;
                var eDisclosureLockPackageIndicator = _eDisclosureLockPackageIndicator; eDisclosureLockPackageIndicator.Clean = value; _eDisclosureLockPackageIndicator = eDisclosureLockPackageIndicator;
                var eDisclosureManualFulfillmentComment = _eDisclosureManualFulfillmentComment; eDisclosureManualFulfillmentComment.Clean = value; _eDisclosureManualFulfillmentComment = eDisclosureManualFulfillmentComment;
                var eDisclosureManualFulfillmentDate = _eDisclosureManualFulfillmentDate; eDisclosureManualFulfillmentDate.Clean = value; _eDisclosureManualFulfillmentDate = eDisclosureManualFulfillmentDate;
                var eDisclosureManualFulfillmentMethod = _eDisclosureManualFulfillmentMethod; eDisclosureManualFulfillmentMethod.Clean = value; _eDisclosureManualFulfillmentMethod = eDisclosureManualFulfillmentMethod;
                var eDisclosureManuallyFulfilledBy = _eDisclosureManuallyFulfilledBy; eDisclosureManuallyFulfilledBy.Clean = value; _eDisclosureManuallyFulfilledBy = eDisclosureManuallyFulfilledBy;
                var eDisclosurePackageCreatedDate = _eDisclosurePackageCreatedDate; eDisclosurePackageCreatedDate.Clean = value; _eDisclosurePackageCreatedDate = eDisclosurePackageCreatedDate;
                var eDisclosurePackageId = _eDisclosurePackageId; eDisclosurePackageId.Clean = value; _eDisclosurePackageId = eDisclosurePackageId;
                var eDisclosurePackageViewableFile = _eDisclosurePackageViewableFile; eDisclosurePackageViewableFile.Clean = value; _eDisclosurePackageViewableFile = eDisclosurePackageViewableFile;
                var eDisclosureThreeDayPackageIndicator = _eDisclosureThreeDayPackageIndicator; eDisclosureThreeDayPackageIndicator.Clean = value; _eDisclosureThreeDayPackageIndicator = eDisclosureThreeDayPackageIndicator;
                var estimatedTotalPayoffsAndPaymentsAmount = _estimatedTotalPayoffsAndPaymentsAmount; estimatedTotalPayoffsAndPaymentsAmount.Clean = value; _estimatedTotalPayoffsAndPaymentsAmount = estimatedTotalPayoffsAndPaymentsAmount;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var financeCharge = _financeCharge; financeCharge.Clean = value; _financeCharge = financeCharge;
                var forms = _forms; forms.Clean = value; _forms = forms;
                var formsXml = _formsXml; formsXml.Clean = value; _formsXml = formsXml;
                var fulfillmentOrderedBy = _fulfillmentOrderedBy; fulfillmentOrderedBy.Clean = value; _fulfillmentOrderedBy = fulfillmentOrderedBy;
                var fullfillmentProcessedDate = _fullfillmentProcessedDate; fullfillmentProcessedDate.Clean = value; _fullfillmentProcessedDate = fullfillmentProcessedDate;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var intentToProceed = _intentToProceed; intentToProceed.Clean = value; _intentToProceed = intentToProceed;
                var intentToProceedComments = _intentToProceedComments; intentToProceedComments.Clean = value; _intentToProceedComments = intentToProceedComments;
                var intentToProceedDate = _intentToProceedDate; intentToProceedDate.Clean = value; _intentToProceedDate = intentToProceedDate;
                var intentToProceedReceivedBy = _intentToProceedReceivedBy; intentToProceedReceivedBy.Clean = value; _intentToProceedReceivedBy = intentToProceedReceivedBy;
                var intentToProceedReceivedMethod = _intentToProceedReceivedMethod; intentToProceedReceivedMethod.Clean = value; _intentToProceedReceivedMethod = intentToProceedReceivedMethod;
                var intentToProceedReceivedMethodOther = _intentToProceedReceivedMethodOther; intentToProceedReceivedMethodOther.Clean = value; _intentToProceedReceivedMethodOther = intentToProceedReceivedMethodOther;
                var isBorrowerPresumedDateLocked = _isBorrowerPresumedDateLocked; isBorrowerPresumedDateLocked.Clean = value; _isBorrowerPresumedDateLocked = isBorrowerPresumedDateLocked;
                var isBorrowerTypeLocked = _isBorrowerTypeLocked; isBorrowerTypeLocked.Clean = value; _isBorrowerTypeLocked = isBorrowerTypeLocked;
                var isCoBorrowerPresumedDateLocked = _isCoBorrowerPresumedDateLocked; isCoBorrowerPresumedDateLocked.Clean = value; _isCoBorrowerPresumedDateLocked = isCoBorrowerPresumedDateLocked;
                var isCoBorrowerTypeLocked = _isCoBorrowerTypeLocked; isCoBorrowerTypeLocked.Clean = value; _isCoBorrowerTypeLocked = isCoBorrowerTypeLocked;
                var isDisclosed = _isDisclosed; isDisclosed.Clean = value; _isDisclosed = isDisclosed;
                var isDisclosedAprLocked = _isDisclosedAprLocked; isDisclosedAprLocked.Clean = value; _isDisclosedAprLocked = isDisclosedAprLocked;
                var isDisclosedByLocked = _isDisclosedByLocked; isDisclosedByLocked.Clean = value; _isDisclosedByLocked = isDisclosedByLocked;
                var isDisclosedFinanceChargeLocked = _isDisclosedFinanceChargeLocked; isDisclosedFinanceChargeLocked.Clean = value; _isDisclosedFinanceChargeLocked = isDisclosedFinanceChargeLocked;
                var isDisclosedReceivedDateLocked = _isDisclosedReceivedDateLocked; isDisclosedReceivedDateLocked.Clean = value; _isDisclosedReceivedDateLocked = isDisclosedReceivedDateLocked;
                var isLocked = _isLocked; isLocked.Clean = value; _isLocked = isLocked;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var isWetSignedIndicator = _isWetSignedIndicator; isWetSignedIndicator.Clean = value; _isWetSignedIndicator = isWetSignedIndicator;
                var lenderCompensationCreditAmount2 = _lenderCompensationCreditAmount2; lenderCompensationCreditAmount2.Clean = value; _lenderCompensationCreditAmount2 = lenderCompensationCreditAmount2;
                var lenderTotalPaidOriginatorAmount = _lenderTotalPaidOriginatorAmount; lenderTotalPaidOriginatorAmount.Clean = value; _lenderTotalPaidOriginatorAmount = lenderTotalPaidOriginatorAmount;
                var lEReasonIsChangedCircumstanceEligibility = _lEReasonIsChangedCircumstanceEligibility; lEReasonIsChangedCircumstanceEligibility.Clean = value; _lEReasonIsChangedCircumstanceEligibility = lEReasonIsChangedCircumstanceEligibility;
                var lEReasonIsChangedCircumstanceSettlementCharges = _lEReasonIsChangedCircumstanceSettlementCharges; lEReasonIsChangedCircumstanceSettlementCharges.Clean = value; _lEReasonIsChangedCircumstanceSettlementCharges = lEReasonIsChangedCircumstanceSettlementCharges;
                var lEReasonIsDelayedSettlementOnConstructionLoans = _lEReasonIsDelayedSettlementOnConstructionLoans; lEReasonIsDelayedSettlementOnConstructionLoans.Clean = value; _lEReasonIsDelayedSettlementOnConstructionLoans = lEReasonIsDelayedSettlementOnConstructionLoans;
                var lEReasonIsExpiration = _lEReasonIsExpiration; lEReasonIsExpiration.Clean = value; _lEReasonIsExpiration = lEReasonIsExpiration;
                var lEReasonIsInterestRateDependentCharges = _lEReasonIsInterestRateDependentCharges; lEReasonIsInterestRateDependentCharges.Clean = value; _lEReasonIsInterestRateDependentCharges = lEReasonIsInterestRateDependentCharges;
                var lEReasonIsOther = _lEReasonIsOther; lEReasonIsOther.Clean = value; _lEReasonIsOther = lEReasonIsOther;
                var lEReasonIsRevisionsRequestedByConsumer = _lEReasonIsRevisionsRequestedByConsumer; lEReasonIsRevisionsRequestedByConsumer.Clean = value; _lEReasonIsRevisionsRequestedByConsumer = lEReasonIsRevisionsRequestedByConsumer;
                var lEReasonOther = _lEReasonOther; lEReasonOther.Clean = value; _lEReasonOther = lEReasonOther;
                var line802LOCompAdditionalAmount1 = _line802LOCompAdditionalAmount1; line802LOCompAdditionalAmount1.Clean = value; _line802LOCompAdditionalAmount1 = line802LOCompAdditionalAmount1;
                var line802LOCompAdditionalAmount2 = _line802LOCompAdditionalAmount2; line802LOCompAdditionalAmount2.Clean = value; _line802LOCompAdditionalAmount2 = line802LOCompAdditionalAmount2;
                var line907InsuranceIndicator2015 = _line907InsuranceIndicator2015; line907InsuranceIndicator2015.Clean = value; _line907InsuranceIndicator2015 = line907InsuranceIndicator2015;
                var line907PropertyIndicator2015 = _line907PropertyIndicator2015; line907PropertyIndicator2015.Clean = value; _line907PropertyIndicator2015 = line907PropertyIndicator2015;
                var line907TaxesIndicator2015 = _line907TaxesIndicator2015; line907TaxesIndicator2015.Clean = value; _line907TaxesIndicator2015 = line907TaxesIndicator2015;
                var line908InsuranceIndicator2015 = _line908InsuranceIndicator2015; line908InsuranceIndicator2015.Clean = value; _line908InsuranceIndicator2015 = line908InsuranceIndicator2015;
                var line908PropertyIndicator2015 = _line908PropertyIndicator2015; line908PropertyIndicator2015.Clean = value; _line908PropertyIndicator2015 = line908PropertyIndicator2015;
                var line908TaxesIndicator2015 = _line908TaxesIndicator2015; line908TaxesIndicator2015.Clean = value; _line908TaxesIndicator2015 = line908TaxesIndicator2015;
                var line909InsuranceIndicator2015 = _line909InsuranceIndicator2015; line909InsuranceIndicator2015.Clean = value; _line909InsuranceIndicator2015 = line909InsuranceIndicator2015;
                var line909PropertyIndicator2015 = _line909PropertyIndicator2015; line909PropertyIndicator2015.Clean = value; _line909PropertyIndicator2015 = line909PropertyIndicator2015;
                var line909TaxesIndicator2015 = _line909TaxesIndicator2015; line909TaxesIndicator2015.Clean = value; _line909TaxesIndicator2015 = line909TaxesIndicator2015;
                var line910InsuranceIndicator2015 = _line910InsuranceIndicator2015; line910InsuranceIndicator2015.Clean = value; _line910InsuranceIndicator2015 = line910InsuranceIndicator2015;
                var line910PropertyIndicator2015 = _line910PropertyIndicator2015; line910PropertyIndicator2015.Clean = value; _line910PropertyIndicator2015 = line910PropertyIndicator2015;
                var line910TaxesIndicator2015 = _line910TaxesIndicator2015; line910TaxesIndicator2015.Clean = value; _line910TaxesIndicator2015 = line910TaxesIndicator2015;
                var line911InsuranceIndicator2015 = _line911InsuranceIndicator2015; line911InsuranceIndicator2015.Clean = value; _line911InsuranceIndicator2015 = line911InsuranceIndicator2015;
                var line911PropertyIndicator2015 = _line911PropertyIndicator2015; line911PropertyIndicator2015.Clean = value; _line911PropertyIndicator2015 = line911PropertyIndicator2015;
                var line911TaxesIndicator2015 = _line911TaxesIndicator2015; line911TaxesIndicator2015.Clean = value; _line911TaxesIndicator2015 = line911TaxesIndicator2015;
                var line912InsuranceIndicator2015 = _line912InsuranceIndicator2015; line912InsuranceIndicator2015.Clean = value; _line912InsuranceIndicator2015 = line912InsuranceIndicator2015;
                var line912PropertyIndicator2015 = _line912PropertyIndicator2015; line912PropertyIndicator2015.Clean = value; _line912PropertyIndicator2015 = line912PropertyIndicator2015;
                var line912TaxesIndicator2015 = _line912TaxesIndicator2015; line912TaxesIndicator2015.Clean = value; _line912TaxesIndicator2015 = line912TaxesIndicator2015;
                var loanAdjustmentsOtherCredits = _loanAdjustmentsOtherCredits; loanAdjustmentsOtherCredits.Clean = value; _loanAdjustmentsOtherCredits = loanAdjustmentsOtherCredits;
                var loanAmount = _loanAmount; loanAmount.Clean = value; _loanAmount = loanAmount;
                var loanClosingCost2BorrowerClosingCostAtClosing = _loanClosingCost2BorrowerClosingCostAtClosing; loanClosingCost2BorrowerClosingCostAtClosing.Clean = value; _loanClosingCost2BorrowerClosingCostAtClosing = loanClosingCost2BorrowerClosingCostAtClosing;
                var loanClosingCost2LenderCredits = _loanClosingCost2LenderCredits; loanClosingCost2LenderCredits.Clean = value; _loanClosingCost2LenderCredits = loanClosingCost2LenderCredits;
                var loanClosingCost2TotalLoanCost = _loanClosingCost2TotalLoanCost; loanClosingCost2TotalLoanCost.Clean = value; _loanClosingCost2TotalLoanCost = loanClosingCost2TotalLoanCost;
                var loanClosingCost2TotalOtherCost = _loanClosingCost2TotalOtherCost; loanClosingCost2TotalOtherCost.Clean = value; _loanClosingCost2TotalOtherCost = loanClosingCost2TotalOtherCost;
                var loanClosingCost3StdLegalLimit = _loanClosingCost3StdLegalLimit; loanClosingCost3StdLegalLimit.Clean = value; _loanClosingCost3StdLegalLimit = loanClosingCost3StdLegalLimit;
                var loanClosingCostGfe1200BorPaidAmount = _loanClosingCostGfe1200BorPaidAmount; loanClosingCostGfe1200BorPaidAmount.Clean = value; _loanClosingCostGfe1200BorPaidAmount = loanClosingCostGfe1200BorPaidAmount;
                var loanClosingCostGfe800BorPaidAmount = _loanClosingCostGfe800BorPaidAmount; loanClosingCostGfe800BorPaidAmount.Clean = value; _loanClosingCostGfe800BorPaidAmount = loanClosingCostGfe800BorPaidAmount;
                var loanClosingCostLenderCredits = _loanClosingCostLenderCredits; loanClosingCostLenderCredits.Clean = value; _loanClosingCostLenderCredits = loanClosingCostLenderCredits;
                var loanClosingCostSection1000BorrowerTotalPaidAmount = _loanClosingCostSection1000BorrowerTotalPaidAmount; loanClosingCostSection1000BorrowerTotalPaidAmount.Clean = value; _loanClosingCostSection1000BorrowerTotalPaidAmount = loanClosingCostSection1000BorrowerTotalPaidAmount;
                var loanClosingCostsFinanced = _loanClosingCostsFinanced; loanClosingCostsFinanced.Clean = value; _loanClosingCostsFinanced = loanClosingCostsFinanced;
                var loanClosingCostTotalFeeAmount2015 = _loanClosingCostTotalFeeAmount2015; loanClosingCostTotalFeeAmount2015.Clean = value; _loanClosingCostTotalFeeAmount2015 = loanClosingCostTotalFeeAmount2015;
                var loanDownPayment = _loanDownPayment; loanDownPayment.Clean = value; _loanDownPayment = loanDownPayment;
                var loanEstimate2TotalLoanAndOtherCosts = _loanEstimate2TotalLoanAndOtherCosts; loanEstimate2TotalLoanAndOtherCosts.Clean = value; _loanEstimate2TotalLoanAndOtherCosts = loanEstimate2TotalLoanAndOtherCosts;
                var loanEstimate2TotalLoanCosts = _loanEstimate2TotalLoanCosts; loanEstimate2TotalLoanCosts.Clean = value; _loanEstimate2TotalLoanCosts = loanEstimate2TotalLoanCosts;
                var loanEstimate2TotalOtherCosts = _loanEstimate2TotalOtherCosts; loanEstimate2TotalOtherCosts.Clean = value; _loanEstimate2TotalOtherCosts = loanEstimate2TotalOtherCosts;
                var loanEstimate2UnroundedTotalLoanCosts = _loanEstimate2UnroundedTotalLoanCosts; loanEstimate2UnroundedTotalLoanCosts.Clean = value; _loanEstimate2UnroundedTotalLoanCosts = loanEstimate2UnroundedTotalLoanCosts;
                var loanEstimate2UnroundedTotalOtherCosts = _loanEstimate2UnroundedTotalOtherCosts; loanEstimate2UnroundedTotalOtherCosts.Clean = value; _loanEstimate2UnroundedTotalOtherCosts = loanEstimate2UnroundedTotalOtherCosts;
                var loanEstimateLoanProduct = _loanEstimateLoanProduct; loanEstimateLoanProduct.Clean = value; _loanEstimateLoanProduct = loanEstimateLoanProduct;
                var loanFeesCityTaxBorPaidAmount = _loanFeesCityTaxBorPaidAmount; loanFeesCityTaxBorPaidAmount.Clean = value; _loanFeesCityTaxBorPaidAmount = loanFeesCityTaxBorPaidAmount;
                var loanFeesStateTaxBorPaidAmount = _loanFeesStateTaxBorPaidAmount; loanFeesStateTaxBorPaidAmount.Clean = value; _loanFeesStateTaxBorPaidAmount = loanFeesStateTaxBorPaidAmount;
                var loanFundsForBorrower = _loanFundsForBorrower; loanFundsForBorrower.Clean = value; _loanFundsForBorrower = loanFundsForBorrower;
                var loanGfeAgregateAdjustment = _loanGfeAgregateAdjustment; loanGfeAgregateAdjustment.Clean = value; _loanGfeAgregateAdjustment = loanGfeAgregateAdjustment;
                var loanGfeGovermentRecordingCharges = _loanGfeGovermentRecordingCharges; loanGfeGovermentRecordingCharges.Clean = value; _loanGfeGovermentRecordingCharges = loanGfeGovermentRecordingCharges;
                var loanLineItemAmount = _loanLineItemAmount; loanLineItemAmount.Clean = value; _loanLineItemAmount = loanLineItemAmount;
                var loanProgram = _loanProgram; loanProgram.Clean = value; _loanProgram = loanProgram;
                var loanPurchaseCreditAmount1 = _loanPurchaseCreditAmount1; loanPurchaseCreditAmount1.Clean = value; _loanPurchaseCreditAmount1 = loanPurchaseCreditAmount1;
                var loanPurchaseCreditAmount2 = _loanPurchaseCreditAmount2; loanPurchaseCreditAmount2.Clean = value; _loanPurchaseCreditAmount2 = loanPurchaseCreditAmount2;
                var loanPurchaseCreditAmount3 = _loanPurchaseCreditAmount3; loanPurchaseCreditAmount3.Clean = value; _loanPurchaseCreditAmount3 = loanPurchaseCreditAmount3;
                var loanPurchaseCreditAmount4 = _loanPurchaseCreditAmount4; loanPurchaseCreditAmount4.Clean = value; _loanPurchaseCreditAmount4 = loanPurchaseCreditAmount4;
                var loanPurchaseCreditType1 = _loanPurchaseCreditType1; loanPurchaseCreditType1.Clean = value; _loanPurchaseCreditType1 = loanPurchaseCreditType1;
                var loanPurchaseCreditType2 = _loanPurchaseCreditType2; loanPurchaseCreditType2.Clean = value; _loanPurchaseCreditType2 = loanPurchaseCreditType2;
                var loanPurchaseCreditType3 = _loanPurchaseCreditType3; loanPurchaseCreditType3.Clean = value; _loanPurchaseCreditType3 = loanPurchaseCreditType3;
                var loanPurchaseCreditType4 = _loanPurchaseCreditType4; loanPurchaseCreditType4.Clean = value; _loanPurchaseCreditType4 = loanPurchaseCreditType4;
                var loanRefinanceIncludingDebtsToBePaidOffAmount = _loanRefinanceIncludingDebtsToBePaidOffAmount; loanRefinanceIncludingDebtsToBePaidOffAmount.Clean = value; _loanRefinanceIncludingDebtsToBePaidOffAmount = loanRefinanceIncludingDebtsToBePaidOffAmount;
                var loanSection1000SellerPaidTotalAmount = _loanSection1000SellerPaidTotalAmount; loanSection1000SellerPaidTotalAmount.Clean = value; _loanSection1000SellerPaidTotalAmount = loanSection1000SellerPaidTotalAmount;
                var loanSellerCreditAmount = _loanSellerCreditAmount; loanSellerCreditAmount.Clean = value; _loanSellerCreditAmount = loanSellerCreditAmount;
                var loanTotalClosingCosts = _loanTotalClosingCosts; loanTotalClosingCosts.Clean = value; _loanTotalClosingCosts = loanTotalClosingCosts;
                var lockedBorrowerPresumedReceivedDate = _lockedBorrowerPresumedReceivedDate; lockedBorrowerPresumedReceivedDate.Clean = value; _lockedBorrowerPresumedReceivedDate = lockedBorrowerPresumedReceivedDate;
                var lockedBorrowerType = _lockedBorrowerType; lockedBorrowerType.Clean = value; _lockedBorrowerType = lockedBorrowerType;
                var lockedCoBorrowerPresumedReceivedDate = _lockedCoBorrowerPresumedReceivedDate; lockedCoBorrowerPresumedReceivedDate.Clean = value; _lockedCoBorrowerPresumedReceivedDate = lockedCoBorrowerPresumedReceivedDate;
                var lockedCoBorrowerType = _lockedCoBorrowerType; lockedCoBorrowerType.Clean = value; _lockedCoBorrowerType = lockedCoBorrowerType;
                var lockedDisclosedAprField = _lockedDisclosedAprField; lockedDisclosedAprField.Clean = value; _lockedDisclosedAprField = lockedDisclosedAprField;
                var lockedDisclosedByField = _lockedDisclosedByField; lockedDisclosedByField.Clean = value; _lockedDisclosedByField = lockedDisclosedByField;
                var lockedDisclosedFinanceChargeField = _lockedDisclosedFinanceChargeField; lockedDisclosedFinanceChargeField.Clean = value; _lockedDisclosedFinanceChargeField = lockedDisclosedFinanceChargeField;
                var lockedDisclosedReceivedDate = _lockedDisclosedReceivedDate; lockedDisclosedReceivedDate.Clean = value; _lockedDisclosedReceivedDate = lockedDisclosedReceivedDate;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var manuallyCreated = _manuallyCreated; manuallyCreated.Clean = value; _manuallyCreated = manuallyCreated;
                var prepaymentPenaltyIndicator = _prepaymentPenaltyIndicator; prepaymentPenaltyIndicator.Clean = value; _prepaymentPenaltyIndicator = prepaymentPenaltyIndicator;
                var propertyAddress = _propertyAddress; propertyAddress.Clean = value; _propertyAddress = propertyAddress;
                var propertyCity = _propertyCity; propertyCity.Clean = value; _propertyCity = propertyCity;
                var propertyState = _propertyState; propertyState.Clean = value; _propertyState = propertyState;
                var propertyZip = _propertyZip; propertyZip.Clean = value; _propertyZip = propertyZip;
                var providerListSent = _providerListSent; providerListSent.Clean = value; _providerListSent = providerListSent;
                var purchasePriceAmount = _purchasePriceAmount; purchasePriceAmount.Clean = value; _purchasePriceAmount = purchasePriceAmount;
                var receivedDate = _receivedDate; receivedDate.Clean = value; _receivedDate = receivedDate;
                var snapshotFields = _snapshotFields; snapshotFields.Clean = value; _snapshotFields = snapshotFields;
                var snapshotXml = _snapshotXml; snapshotXml.Clean = value; _snapshotXml = snapshotXml;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public DisclosureTracking2015Log()
        {
            Clean = true;
        }
    }
}