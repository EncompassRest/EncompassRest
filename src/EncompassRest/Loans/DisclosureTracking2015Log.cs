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
        /// <summary>
        /// DisclosureTracking2015Log ActualFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ActualFulfillmentDate { get => _actualFulfillmentDate; set => SetField(ref _actualFulfillmentDate, value); }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// DisclosureTracking2015Log Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// DisclosureTracking2015Log AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }
        private DirtyValue<DateTime?> _applicationDate;
        /// <summary>
        /// DisclosureTracking2015Log ApplicationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }
        private DirtyValue<string> _appliedCureAmount;
        /// <summary>
        /// DisclosureTracking2015Log AppliedCureAmount
        /// </summary>
        public string AppliedCureAmount { get => _appliedCureAmount; set => SetField(ref _appliedCureAmount, value); }
        private DirtyValue<string> _automaticFullfillmentServiceName;
        /// <summary>
        /// DisclosureTracking2015Log AutomaticFullfillmentServiceName
        /// </summary>
        public string AutomaticFullfillmentServiceName { get => _automaticFullfillmentServiceName; set => SetField(ref _automaticFullfillmentServiceName, value); }
        private DirtyValue<DateTime?> _borrowerActualReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerActualReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BorrowerActualReceivedDate { get => _borrowerActualReceivedDate; set => SetField(ref _borrowerActualReceivedDate, value); }
        private DirtyValue<string> _borrowerDisclosedMethod;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerDisclosedMethod
        /// </summary>
        public string BorrowerDisclosedMethod { get => _borrowerDisclosedMethod; set => SetField(ref _borrowerDisclosedMethod, value); }
        private DirtyValue<string> _borrowerDisclosedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerDisclosedMethodOther
        /// </summary>
        public string BorrowerDisclosedMethodOther { get => _borrowerDisclosedMethodOther; set => SetField(ref _borrowerDisclosedMethodOther, value); }
        private DirtyValue<string> _borrowerName;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerName
        /// </summary>
        public string BorrowerName { get => _borrowerName; set => SetField(ref _borrowerName, value); }
        private DirtyValue<string> _borrowerPairId;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerPairId
        /// </summary>
        public string BorrowerPairId { get => _borrowerPairId; set => SetField(ref _borrowerPairId, value); }
        private DirtyValue<DateTime?> _borrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BorrowerPresumedReceivedDate { get => _borrowerPresumedReceivedDate; set => SetField(ref _borrowerPresumedReceivedDate, value); }
        private DirtyValue<string> _borrowerType;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerType
        /// </summary>
        public string BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }
        private DirtyValue<bool?> _brokerDisclosed;
        /// <summary>
        /// DisclosureTracking2015Log BrokerDisclosed
        /// </summary>
        public bool? BrokerDisclosed { get => _brokerDisclosed; set => SetField(ref _brokerDisclosed, value); }
        private DirtyValue<bool?> _cDReasonIs24HourAdvancePreview;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIs24HourAdvancePreview
        /// </summary>
        public bool? CDReasonIs24HourAdvancePreview { get => _cDReasonIs24HourAdvancePreview; set => SetField(ref _cDReasonIs24HourAdvancePreview, value); }
        private DirtyValue<bool?> _cDReasonIsChangedCircumstanceEligibility;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangedCircumstanceEligibility
        /// </summary>
        public bool? CDReasonIsChangedCircumstanceEligibility { get => _cDReasonIsChangedCircumstanceEligibility; set => SetField(ref _cDReasonIsChangedCircumstanceEligibility, value); }
        private DirtyValue<bool?> _cDReasonIsChangeInAPR;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInAPR
        /// </summary>
        public bool? CDReasonIsChangeInAPR { get => _cDReasonIsChangeInAPR; set => SetField(ref _cDReasonIsChangeInAPR, value); }
        private DirtyValue<bool?> _cDReasonIsChangeInLoanProduct;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInLoanProduct
        /// </summary>
        public bool? CDReasonIsChangeInLoanProduct { get => _cDReasonIsChangeInLoanProduct; set => SetField(ref _cDReasonIsChangeInLoanProduct, value); }
        private DirtyValue<bool?> _cDReasonIsChangeInSettlementCharges;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInSettlementCharges
        /// </summary>
        public bool? CDReasonIsChangeInSettlementCharges { get => _cDReasonIsChangeInSettlementCharges; set => SetField(ref _cDReasonIsChangeInSettlementCharges, value); }
        private DirtyValue<bool?> _cDReasonIsClericalErrorCorrection;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsClericalErrorCorrection
        /// </summary>
        public bool? CDReasonIsClericalErrorCorrection { get => _cDReasonIsClericalErrorCorrection; set => SetField(ref _cDReasonIsClericalErrorCorrection, value); }
        private DirtyValue<bool?> _cDReasonIsInterestRateDependentCharges;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsInterestRateDependentCharges
        /// </summary>
        public bool? CDReasonIsInterestRateDependentCharges { get => _cDReasonIsInterestRateDependentCharges; set => SetField(ref _cDReasonIsInterestRateDependentCharges, value); }
        private DirtyValue<bool?> _cDReasonIsOther;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsOther
        /// </summary>
        public bool? CDReasonIsOther { get => _cDReasonIsOther; set => SetField(ref _cDReasonIsOther, value); }
        private DirtyValue<bool?> _cDReasonIsPrepaymentPenaltyAdded;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsPrepaymentPenaltyAdded
        /// </summary>
        public bool? CDReasonIsPrepaymentPenaltyAdded { get => _cDReasonIsPrepaymentPenaltyAdded; set => SetField(ref _cDReasonIsPrepaymentPenaltyAdded, value); }
        private DirtyValue<bool?> _cDReasonIsRevisionsRequestedByConsumer;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsRevisionsRequestedByConsumer
        /// </summary>
        public bool? CDReasonIsRevisionsRequestedByConsumer { get => _cDReasonIsRevisionsRequestedByConsumer; set => SetField(ref _cDReasonIsRevisionsRequestedByConsumer, value); }
        private DirtyValue<bool?> _cDReasonIsToleranceCure;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsToleranceCure
        /// </summary>
        public bool? CDReasonIsToleranceCure { get => _cDReasonIsToleranceCure; set => SetField(ref _cDReasonIsToleranceCure, value); }
        private DirtyValue<string> _cDReasonOther;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonOther
        /// </summary>
        public string CDReasonOther { get => _cDReasonOther; set => SetField(ref _cDReasonOther, value); }
        private DirtyValue<string> _changeInCircumstance;
        /// <summary>
        /// DisclosureTracking2015Log ChangeInCircumstance
        /// </summary>
        public string ChangeInCircumstance { get => _changeInCircumstance; set => SetField(ref _changeInCircumstance, value); }
        private DirtyValue<string> _changeInCircumstanceComments;
        /// <summary>
        /// DisclosureTracking2015Log ChangeInCircumstanceComments
        /// </summary>
        public string ChangeInCircumstanceComments { get => _changeInCircumstanceComments; set => SetField(ref _changeInCircumstanceComments, value); }
        private DirtyValue<DateTime?> _changesReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log ChangesReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => SetField(ref _changesReceivedDate, value); }
        private DirtyValue<string> _chargesCannotIncrease10Itemization34;
        /// <summary>
        /// DisclosureTracking2015Log ChargesCannotIncrease10Itemization34
        /// </summary>
        public string ChargesCannotIncrease10Itemization34 { get => _chargesCannotIncrease10Itemization34; set => SetField(ref _chargesCannotIncrease10Itemization34, value); }
        private DirtyValue<string> _chargesCannotIncrease10LE32;
        /// <summary>
        /// DisclosureTracking2015Log ChargesCannotIncrease10LE32
        /// </summary>
        public string ChargesCannotIncrease10LE32 { get => _chargesCannotIncrease10LE32; set => SetField(ref _chargesCannotIncrease10LE32, value); }
        private DirtyValue<string> _chargesThatCannotDecreaseItemization9;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotDecreaseItemization9
        /// </summary>
        public string ChargesThatCannotDecreaseItemization9 { get => _chargesThatCannotDecreaseItemization9; set => SetField(ref _chargesThatCannotDecreaseItemization9, value); }
        private DirtyValue<string> _chargesThatCannotDecreaseLE7;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotDecreaseLE7
        /// </summary>
        public string ChargesThatCannotDecreaseLE7 { get => _chargesThatCannotDecreaseLE7; set => SetField(ref _chargesThatCannotDecreaseLE7, value); }
        private DirtyValue<string> _chargesThatCannotIncreaseItemization13;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotIncreaseItemization13
        /// </summary>
        public string ChargesThatCannotIncreaseItemization13 { get => _chargesThatCannotIncreaseItemization13; set => SetField(ref _chargesThatCannotIncreaseItemization13, value); }
        private DirtyValue<string> _chargesThatCannotIncreaseLE11;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotIncreaseLE11
        /// </summary>
        public string ChargesThatCannotIncreaseLE11 { get => _chargesThatCannotIncreaseLE11; set => SetField(ref _chargesThatCannotIncreaseLE11, value); }
        private DirtyValue<DateTime?> _coBorrowerActualReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerActualReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CoBorrowerActualReceivedDate { get => _coBorrowerActualReceivedDate; set => SetField(ref _coBorrowerActualReceivedDate, value); }
        private DirtyValue<string> _coBorrowerDisclosedMethod;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerDisclosedMethod
        /// </summary>
        public string CoBorrowerDisclosedMethod { get => _coBorrowerDisclosedMethod; set => SetField(ref _coBorrowerDisclosedMethod, value); }
        private DirtyValue<string> _coBorrowerDisclosedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerDisclosedMethodOther
        /// </summary>
        public string CoBorrowerDisclosedMethodOther { get => _coBorrowerDisclosedMethodOther; set => SetField(ref _coBorrowerDisclosedMethodOther, value); }
        private DirtyValue<string> _coBorrowerName;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerName
        /// </summary>
        public string CoBorrowerName { get => _coBorrowerName; set => SetField(ref _coBorrowerName, value); }
        private DirtyValue<DateTime?> _coBorrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CoBorrowerPresumedReceivedDate { get => _coBorrowerPresumedReceivedDate; set => SetField(ref _coBorrowerPresumedReceivedDate, value); }
        private DirtyValue<string> _coBorrowerType;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerType
        /// </summary>
        public string CoBorrowerType { get => _coBorrowerType; set => SetField(ref _coBorrowerType, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// DisclosureTracking2015Log CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// DisclosureTracking2015Log CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// DisclosureTracking2015Log Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<bool?> _containCD;
        /// <summary>
        /// DisclosureTracking2015Log ContainCD
        /// </summary>
        public bool? ContainCD { get => _containCD; set => SetField(ref _containCD, value); }
        private DirtyValue<bool?> _containLE;
        /// <summary>
        /// DisclosureTracking2015Log ContainLE
        /// </summary>
        public bool? ContainLE { get => _containLE; set => SetField(ref _containLE, value); }
        private DirtyValue<bool?> _containSafeHarbor;
        /// <summary>
        /// DisclosureTracking2015Log ContainSafeHarbor
        /// </summary>
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => SetField(ref _containSafeHarbor, value); }
        private DirtyValue<string> _cureAppliedToLenderCredit;
        /// <summary>
        /// DisclosureTracking2015Log CureAppliedToLenderCredit
        /// </summary>
        public string CureAppliedToLenderCredit { get => _cureAppliedToLenderCredit; set => SetField(ref _cureAppliedToLenderCredit, value); }
        private DirtyValue<string> _cureAppliedToPrincipalReduction;
        /// <summary>
        /// DisclosureTracking2015Log CureAppliedToPrincipalReduction
        /// </summary>
        public string CureAppliedToPrincipalReduction { get => _cureAppliedToPrincipalReduction; set => SetField(ref _cureAppliedToPrincipalReduction, value); }
        private DirtyValue<DateTime?> _dateAdded;
        /// <summary>
        /// DisclosureTracking2015Log DateAdded
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAdded { get => _dateAdded; set => SetField(ref _dateAdded, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DisclosureTracking2015Log DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _disclosedAPR;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedAPR
        /// </summary>
        public string DisclosedAPR { get => _disclosedAPR; set => SetField(ref _disclosedAPR, value); }
        private DirtyValue<string> _disclosedBy;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedBy
        /// </summary>
        public string DisclosedBy { get => _disclosedBy; set => SetField(ref _disclosedBy, value); }
        private DirtyValue<string> _disclosedByFullName;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedByFullName
        /// </summary>
        public string DisclosedByFullName { get => _disclosedByFullName; set => SetField(ref _disclosedByFullName, value); }
        private DirtyValue<string> _disclosedDailyInterest;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedDailyInterest
        /// </summary>
        public string DisclosedDailyInterest { get => _disclosedDailyInterest; set => SetField(ref _disclosedDailyInterest, value); }
        private DirtyValue<DateTime?> _disclosedDate;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisclosedDate { get => _disclosedDate; set => SetField(ref _disclosedDate, value); }
        private DirtyValue<bool?> _disclosedForCD;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedForCD
        /// </summary>
        public bool? DisclosedForCD { get => _disclosedForCD; set => SetField(ref _disclosedForCD, value); }
        private DirtyValue<bool?> _disclosedForLE;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedForLE
        /// </summary>
        public bool? DisclosedForLE { get => _disclosedForLE; set => SetField(ref _disclosedForLE, value); }
        private DirtyValue<string> _disclosedMethod;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethod
        /// </summary>
        public string DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }
        private DirtyValue<string> _disclosedMethodName;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethodName
        /// </summary>
        public string DisclosedMethodName { get => _disclosedMethodName; set => SetField(ref _disclosedMethodName, value); }
        private DirtyValue<string> _disclosedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethodOther
        /// </summary>
        public string DisclosedMethodOther { get => _disclosedMethodOther; set => SetField(ref _disclosedMethodOther, value); }
        private DirtyValue<string> _disclosedSalesPrice;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedSalesPrice
        /// </summary>
        public string DisclosedSalesPrice { get => _disclosedSalesPrice; set => SetField(ref _disclosedSalesPrice, value); }
        private DirtyValue<DateTime?> _disclosureCreatedDttmUtc;
        /// <summary>
        /// DisclosureTracking2015Log DisclosureCreatedDttmUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => SetField(ref _disclosureCreatedDttmUtc, value); }
        private DirtyValue<string> _disclosureMethod;
        /// <summary>
        /// DisclosureTracking2015Log DisclosureMethod
        /// </summary>
        public string DisclosureMethod { get => _disclosureMethod; set => SetField(ref _disclosureMethod, value); }
        private DirtyValue<string> _disclosureType;
        /// <summary>
        /// DisclosureTracking2015Log DisclosureType
        /// </summary>
        public string DisclosureType { get => _disclosureType; set => SetField(ref _disclosureType, value); }
        private DirtyValue<bool?> _eDisclosureApplicationPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureApplicationPackageIndicator
        /// </summary>
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => SetField(ref _eDisclosureApplicationPackageIndicator, value); }
        private DirtyValue<bool?> _eDisclosureApprovalPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureApprovalPackageIndicator
        /// </summary>
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => SetField(ref _eDisclosureApprovalPackageIndicator, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureBorrowerAcceptConsentDate, value); }
        private DirtyValue<string> _eDisclosureBorrowerAcceptConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentIP
        /// </summary>
        public string EDisclosureBorrowerAcceptConsentIP { get => _eDisclosureBorrowerAcceptConsentIP; set => SetField(ref _eDisclosureBorrowerAcceptConsentIP, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAuthenticatedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerAuthenticatedDate { get => _eDisclosureBorrowerAuthenticatedDate; set => SetField(ref _eDisclosureBorrowerAuthenticatedDate, value); }
        private DirtyValue<string> _eDisclosureBorrowerAuthenticatedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedIP
        /// </summary>
        public string EDisclosureBorrowerAuthenticatedIP { get => _eDisclosureBorrowerAuthenticatedIP; set => SetField(ref _eDisclosureBorrowerAuthenticatedIP, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerDocumentViewedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerDocumentViewedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerDocumentViewedDate { get => _eDisclosureBorrowerDocumentViewedDate; set => SetField(ref _eDisclosureBorrowerDocumentViewedDate, value); }
        private DirtyValue<string> _eDisclosureBorrowerEmail;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerEmail
        /// </summary>
        public string EDisclosureBorrowerEmail { get => _eDisclosureBorrowerEmail; set => SetField(ref _eDisclosureBorrowerEmail, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowereSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => SetField(ref _eDisclosureBorrowereSignedDate, value); }
        private DirtyValue<string> _eDisclosureBorrowereSignedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowereSignedIP
        /// </summary>
        public string EDisclosureBorrowereSignedIP { get => _eDisclosureBorrowereSignedIP; set => SetField(ref _eDisclosureBorrowereSignedIP, value); }
        private DirtyValue<string> _eDisclosureBorrowerLoanLevelConsent;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerLoanLevelConsent
        /// </summary>
        public string EDisclosureBorrowerLoanLevelConsent { get => _eDisclosureBorrowerLoanLevelConsent; set => SetField(ref _eDisclosureBorrowerLoanLevelConsent, value); }
        private DirtyValue<string> _eDisclosureBorrowerName;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerName
        /// </summary>
        public string EDisclosureBorrowerName { get => _eDisclosureBorrowerName; set => SetField(ref _eDisclosureBorrowerName, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => SetField(ref _eDisclosureBorrowerRejectConsentDate, value); }
        private DirtyValue<string> _eDisclosureBorrowerRejectConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentIP
        /// </summary>
        public string EDisclosureBorrowerRejectConsentIP { get => _eDisclosureBorrowerRejectConsentIP; set => SetField(ref _eDisclosureBorrowerRejectConsentIP, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => SetField(ref _eDisclosureBorrowerViewConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => SetField(ref _eDisclosureBorrowerViewMessageDate, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerWetSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerWetSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => SetField(ref _eDisclosureBorrowerWetSignedDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureCoBorrowerAcceptConsentDate, value); }
        private DirtyValue<string> _eDisclosureCoBorrowerAcceptConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentIP
        /// </summary>
        public string EDisclosureCoBorrowerAcceptConsentIP { get => _eDisclosureCoBorrowerAcceptConsentIP; set => SetField(ref _eDisclosureCoBorrowerAcceptConsentIP, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAuthenticatedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerAuthenticatedDate { get => _eDisclosureCoBorrowerAuthenticatedDate; set => SetField(ref _eDisclosureCoBorrowerAuthenticatedDate, value); }
        private DirtyValue<string> _eDisclosureCoBorrowerAuthenticatedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedIP
        /// </summary>
        public string EDisclosureCoBorrowerAuthenticatedIP { get => _eDisclosureCoBorrowerAuthenticatedIP; set => SetField(ref _eDisclosureCoBorrowerAuthenticatedIP, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerDocumentViewedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerDocumentViewedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerDocumentViewedDate { get => _eDisclosureCoBorrowerDocumentViewedDate; set => SetField(ref _eDisclosureCoBorrowerDocumentViewedDate, value); }
        private DirtyValue<string> _eDisclosureCoBorrowerEmail;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerEmail
        /// </summary>
        public string EDisclosureCoBorrowerEmail { get => _eDisclosureCoBorrowerEmail; set => SetField(ref _eDisclosureCoBorrowerEmail, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowereSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => SetField(ref _eDisclosureCoBorrowereSignedDate, value); }
        private DirtyValue<string> _eDisclosureCoBorrowereSignedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedIP
        /// </summary>
        public string EDisclosureCoBorrowereSignedIP { get => _eDisclosureCoBorrowereSignedIP; set => SetField(ref _eDisclosureCoBorrowereSignedIP, value); }
        private DirtyValue<string> _eDisclosureCoBorrowerLoanLevelConsent;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerLoanLevelConsent
        /// </summary>
        public string EDisclosureCoBorrowerLoanLevelConsent { get => _eDisclosureCoBorrowerLoanLevelConsent; set => SetField(ref _eDisclosureCoBorrowerLoanLevelConsent, value); }
        private DirtyValue<string> _eDisclosureCoBorrowerName;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerName
        /// </summary>
        public string EDisclosureCoBorrowerName { get => _eDisclosureCoBorrowerName; set => SetField(ref _eDisclosureCoBorrowerName, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => SetField(ref _eDisclosureCoBorrowerRejectConsentDate, value); }
        private DirtyValue<string> _eDisclosureCoBorrowerRejectConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentIP
        /// </summary>
        public string EDisclosureCoBorrowerRejectConsentIP { get => _eDisclosureCoBorrowerRejectConsentIP; set => SetField(ref _eDisclosureCoBorrowerRejectConsentIP, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => SetField(ref _eDisclosureCoBorrowerViewConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => SetField(ref _eDisclosureCoBorrowerViewMessageDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerWebSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => SetField(ref _eDisclosureCoBorrowerWebSignedDate, value); }
        private DirtyValue<string> _eDisclosureConsentPdf;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureConsentPdf
        /// </summary>
        public string EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => SetField(ref _eDisclosureConsentPdf, value); }
        private DirtyValue<string> _eDisclosureDisclosedMessage;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureDisclosedMessage
        /// </summary>
        public string EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => SetField(ref _eDisclosureDisclosedMessage, value); }
        private DirtyValue<bool?> _eDisclosureLockPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLockPackageIndicator
        /// </summary>
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => SetField(ref _eDisclosureLockPackageIndicator, value); }
        private DirtyValue<DateTime?> _eDisclosureLOeSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOeSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureLOeSignedDate { get => _eDisclosureLOeSignedDate; set => SetField(ref _eDisclosureLOeSignedDate, value); }
        private DirtyValue<string> _eDisclosureLOeSignedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOeSignedIP
        /// </summary>
        public string EDisclosureLOeSignedIP { get => _eDisclosureLOeSignedIP; set => SetField(ref _eDisclosureLOeSignedIP, value); }
        private DirtyValue<string> _eDisclosureLOName;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOName
        /// </summary>
        public string EDisclosureLOName { get => _eDisclosureLOName; set => SetField(ref _eDisclosureLOName, value); }
        private DirtyValue<DateTime?> _eDisclosureLOViewMessageDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureLOViewMessageDate { get => _eDisclosureLOViewMessageDate; set => SetField(ref _eDisclosureLOViewMessageDate, value); }
        private DirtyValue<string> _eDisclosureManualFulfillmentComment;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentComment
        /// </summary>
        public string EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => SetField(ref _eDisclosureManualFulfillmentComment, value); }
        private DirtyValue<DateTime?> _eDisclosureManualFulfillmentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => SetField(ref _eDisclosureManualFulfillmentDate, value); }
        private DirtyValue<string> _eDisclosureManualFulfillmentMethod;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentMethod
        /// </summary>
        public string EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => SetField(ref _eDisclosureManualFulfillmentMethod, value); }
        private DirtyValue<string> _eDisclosureManuallyFulfilledBy;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManuallyFulfilledBy
        /// </summary>
        public string EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => SetField(ref _eDisclosureManuallyFulfilledBy, value); }
        private DirtyValue<DateTime?> _eDisclosurePackageCreatedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageCreatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => SetField(ref _eDisclosurePackageCreatedDate, value); }
        private DirtyValue<string> _eDisclosurePackageId;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageId
        /// </summary>
        public string EDisclosurePackageId { get => _eDisclosurePackageId; set => SetField(ref _eDisclosurePackageId, value); }
        private DirtyValue<string> _eDisclosurePackageViewableFile;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageViewableFile
        /// </summary>
        public string EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => SetField(ref _eDisclosurePackageViewableFile, value); }
        private DirtyValue<bool?> _eDisclosureThreeDayPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureThreeDayPackageIndicator
        /// </summary>
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => SetField(ref _eDisclosureThreeDayPackageIndicator, value); }
        private DirtyValue<string> _estimatedTotalPayoffsAndPaymentsAmount;
        /// <summary>
        /// DisclosureTracking2015Log EstimatedTotalPayoffsAndPaymentsAmount
        /// </summary>
        public string EstimatedTotalPayoffsAndPaymentsAmount { get => _estimatedTotalPayoffsAndPaymentsAmount; set => SetField(ref _estimatedTotalPayoffsAndPaymentsAmount, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// DisclosureTracking2015Log FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _financeCharge;
        /// <summary>
        /// DisclosureTracking2015Log FinanceCharge
        /// </summary>
        public string FinanceCharge { get => _financeCharge; set => SetField(ref _financeCharge, value); }
        private DirtyList<DisclosureForm> _forms;
        /// <summary>
        /// DisclosureTracking2015Log Forms
        /// </summary>
        public IList<DisclosureForm> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }
        private DirtyValue<string> _formsXml;
        /// <summary>
        /// DisclosureTracking2015Log FormsXml
        /// </summary>
        public string FormsXml { get => _formsXml; set => SetField(ref _formsXml, value); }
        private DirtyValue<string> _fulfillmentOrderedBy;
        /// <summary>
        /// DisclosureTracking2015Log FulfillmentOrderedBy
        /// </summary>
        public string FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => SetField(ref _fulfillmentOrderedBy, value); }
        private DirtyValue<string> _fulfillmentOrderedByCoBorrower;
        /// <summary>
        /// DisclosureTracking2015Log FulfillmentOrderedByCoBorrower
        /// </summary>
        public string FulfillmentOrderedByCoBorrower { get => _fulfillmentOrderedByCoBorrower; set => SetField(ref _fulfillmentOrderedByCoBorrower, value); }
        private DirtyValue<string> _fullfillmentProcessedDate;
        /// <summary>
        /// DisclosureTracking2015Log FullfillmentProcessedDate
        /// </summary>
        public string FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => SetField(ref _fullfillmentProcessedDate, value); }
        private DirtyValue<DateTime?> _fullfillmentProcessedDateCoBorrower;
        /// <summary>
        /// DisclosureTracking2015Log FullfillmentProcessedDateCoBorrower
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FullfillmentProcessedDateCoBorrower { get => _fullfillmentProcessedDateCoBorrower; set => SetField(ref _fullfillmentProcessedDateCoBorrower, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// DisclosureTracking2015Log Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// DisclosureTracking2015Log Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _intentToProceed;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceed
        /// </summary>
        public bool? IntentToProceed { get => _intentToProceed; set => SetField(ref _intentToProceed, value); }
        private DirtyValue<string> _intentToProceedComments;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedComments
        /// </summary>
        public string IntentToProceedComments { get => _intentToProceedComments; set => SetField(ref _intentToProceedComments, value); }
        private DirtyValue<DateTime?> _intentToProceedDate;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? IntentToProceedDate { get => _intentToProceedDate; set => SetField(ref _intentToProceedDate, value); }
        private DirtyValue<string> _intentToProceedReceivedBy;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedBy
        /// </summary>
        public string IntentToProceedReceivedBy { get => _intentToProceedReceivedBy; set => SetField(ref _intentToProceedReceivedBy, value); }
        private DirtyValue<string> _intentToProceedReceivedMethod;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedMethod
        /// </summary>
        public string IntentToProceedReceivedMethod { get => _intentToProceedReceivedMethod; set => SetField(ref _intentToProceedReceivedMethod, value); }
        private DirtyValue<string> _intentToProceedReceivedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedMethodOther
        /// </summary>
        public string IntentToProceedReceivedMethodOther { get => _intentToProceedReceivedMethodOther; set => SetField(ref _intentToProceedReceivedMethodOther, value); }
        private DirtyValue<bool?> _isBorrowerPresumedDateLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsBorrowerPresumedDateLocked
        /// </summary>
        public bool? IsBorrowerPresumedDateLocked { get => _isBorrowerPresumedDateLocked; set => SetField(ref _isBorrowerPresumedDateLocked, value); }
        private DirtyValue<bool?> _isBorrowerTypeLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsBorrowerTypeLocked
        /// </summary>
        public bool? IsBorrowerTypeLocked { get => _isBorrowerTypeLocked; set => SetField(ref _isBorrowerTypeLocked, value); }
        private DirtyValue<bool?> _isCoBorrowerPresumedDateLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsCoBorrowerPresumedDateLocked
        /// </summary>
        public bool? IsCoBorrowerPresumedDateLocked { get => _isCoBorrowerPresumedDateLocked; set => SetField(ref _isCoBorrowerPresumedDateLocked, value); }
        private DirtyValue<bool?> _isCoBorrowerTypeLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsCoBorrowerTypeLocked
        /// </summary>
        public bool? IsCoBorrowerTypeLocked { get => _isCoBorrowerTypeLocked; set => SetField(ref _isCoBorrowerTypeLocked, value); }
        private DirtyValue<string> _isDisclosed;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosed
        /// </summary>
        public string IsDisclosed { get => _isDisclosed; set => SetField(ref _isDisclosed, value); }
        private DirtyValue<string> _isDisclosedAprLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedAprLocked
        /// </summary>
        public string IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => SetField(ref _isDisclosedAprLocked, value); }
        private DirtyValue<string> _isDisclosedByLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedByLocked
        /// </summary>
        public string IsDisclosedByLocked { get => _isDisclosedByLocked; set => SetField(ref _isDisclosedByLocked, value); }
        private DirtyValue<bool?> _isDisclosedDailyInterestLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedDailyInterestLocked
        /// </summary>
        public bool? IsDisclosedDailyInterestLocked { get => _isDisclosedDailyInterestLocked; set => SetField(ref _isDisclosedDailyInterestLocked, value); }
        private DirtyValue<string> _isDisclosedFinanceChargeLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedFinanceChargeLocked
        /// </summary>
        public string IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => SetField(ref _isDisclosedFinanceChargeLocked, value); }
        private DirtyValue<string> _isDisclosedReceivedDateLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedReceivedDateLocked
        /// </summary>
        public string IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => SetField(ref _isDisclosedReceivedDateLocked, value); }
        private DirtyValue<bool?> _isIntentReceivedByLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsIntentReceivedByLocked
        /// </summary>
        public bool? IsIntentReceivedByLocked { get => _isIntentReceivedByLocked; set => SetField(ref _isIntentReceivedByLocked, value); }
        private DirtyValue<string> _isLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsLocked
        /// </summary>
        public string IsLocked { get => _isLocked; set => SetField(ref _isLocked, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// DisclosureTracking2015Log IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<bool?> _isWetSignedIndicator;
        /// <summary>
        /// DisclosureTracking2015Log IsWetSignedIndicator
        /// </summary>
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => SetField(ref _isWetSignedIndicator, value); }
        private DirtyValue<string> _lenderCompensationCreditAmount2;
        /// <summary>
        /// DisclosureTracking2015Log LenderCompensationCreditAmount2
        /// </summary>
        public string LenderCompensationCreditAmount2 { get => _lenderCompensationCreditAmount2; set => SetField(ref _lenderCompensationCreditAmount2, value); }
        private DirtyValue<string> _lenderTotalPaidOriginatorAmount;
        /// <summary>
        /// DisclosureTracking2015Log LenderTotalPaidOriginatorAmount
        /// </summary>
        public string LenderTotalPaidOriginatorAmount { get => _lenderTotalPaidOriginatorAmount; set => SetField(ref _lenderTotalPaidOriginatorAmount, value); }
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceEligibility;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceEligibility
        /// </summary>
        public bool? LEReasonIsChangedCircumstanceEligibility { get => _lEReasonIsChangedCircumstanceEligibility; set => SetField(ref _lEReasonIsChangedCircumstanceEligibility, value); }
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceSettlementCharges;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceSettlementCharges
        /// </summary>
        public bool? LEReasonIsChangedCircumstanceSettlementCharges { get => _lEReasonIsChangedCircumstanceSettlementCharges; set => SetField(ref _lEReasonIsChangedCircumstanceSettlementCharges, value); }
        private DirtyValue<bool?> _lEReasonIsDelayedSettlementOnConstructionLoans;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsDelayedSettlementOnConstructionLoans
        /// </summary>
        public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get => _lEReasonIsDelayedSettlementOnConstructionLoans; set => SetField(ref _lEReasonIsDelayedSettlementOnConstructionLoans, value); }
        private DirtyValue<bool?> _lEReasonIsExpiration;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsExpiration
        /// </summary>
        public bool? LEReasonIsExpiration { get => _lEReasonIsExpiration; set => SetField(ref _lEReasonIsExpiration, value); }
        private DirtyValue<bool?> _lEReasonIsInterestRateDependentCharges;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsInterestRateDependentCharges
        /// </summary>
        public bool? LEReasonIsInterestRateDependentCharges { get => _lEReasonIsInterestRateDependentCharges; set => SetField(ref _lEReasonIsInterestRateDependentCharges, value); }
        private DirtyValue<bool?> _lEReasonIsOther;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsOther
        /// </summary>
        public bool? LEReasonIsOther { get => _lEReasonIsOther; set => SetField(ref _lEReasonIsOther, value); }
        private DirtyValue<bool?> _lEReasonIsRevisionsRequestedByConsumer;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsRevisionsRequestedByConsumer
        /// </summary>
        public bool? LEReasonIsRevisionsRequestedByConsumer { get => _lEReasonIsRevisionsRequestedByConsumer; set => SetField(ref _lEReasonIsRevisionsRequestedByConsumer, value); }
        private DirtyValue<string> _lEReasonOther;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonOther
        /// </summary>
        public string LEReasonOther { get => _lEReasonOther; set => SetField(ref _lEReasonOther, value); }
        private DirtyValue<string> _line802LOCompAdditionalAmount1;
        /// <summary>
        /// DisclosureTracking2015Log Line802LOCompAdditionalAmount1
        /// </summary>
        public string Line802LOCompAdditionalAmount1 { get => _line802LOCompAdditionalAmount1; set => SetField(ref _line802LOCompAdditionalAmount1, value); }
        private DirtyValue<string> _line802LOCompAdditionalAmount2;
        /// <summary>
        /// DisclosureTracking2015Log Line802LOCompAdditionalAmount2
        /// </summary>
        public string Line802LOCompAdditionalAmount2 { get => _line802LOCompAdditionalAmount2; set => SetField(ref _line802LOCompAdditionalAmount2, value); }
        private DirtyValue<string> _line907InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line907InsuranceIndicator2015
        /// </summary>
        public string Line907InsuranceIndicator2015 { get => _line907InsuranceIndicator2015; set => SetField(ref _line907InsuranceIndicator2015, value); }
        private DirtyValue<string> _line907PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line907PropertyIndicator2015
        /// </summary>
        public string Line907PropertyIndicator2015 { get => _line907PropertyIndicator2015; set => SetField(ref _line907PropertyIndicator2015, value); }
        private DirtyValue<string> _line907TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line907TaxesIndicator2015
        /// </summary>
        public string Line907TaxesIndicator2015 { get => _line907TaxesIndicator2015; set => SetField(ref _line907TaxesIndicator2015, value); }
        private DirtyValue<string> _line908InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line908InsuranceIndicator2015
        /// </summary>
        public string Line908InsuranceIndicator2015 { get => _line908InsuranceIndicator2015; set => SetField(ref _line908InsuranceIndicator2015, value); }
        private DirtyValue<string> _line908PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line908PropertyIndicator2015
        /// </summary>
        public string Line908PropertyIndicator2015 { get => _line908PropertyIndicator2015; set => SetField(ref _line908PropertyIndicator2015, value); }
        private DirtyValue<string> _line908TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line908TaxesIndicator2015
        /// </summary>
        public string Line908TaxesIndicator2015 { get => _line908TaxesIndicator2015; set => SetField(ref _line908TaxesIndicator2015, value); }
        private DirtyValue<string> _line909InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line909InsuranceIndicator2015
        /// </summary>
        public string Line909InsuranceIndicator2015 { get => _line909InsuranceIndicator2015; set => SetField(ref _line909InsuranceIndicator2015, value); }
        private DirtyValue<string> _line909PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line909PropertyIndicator2015
        /// </summary>
        public string Line909PropertyIndicator2015 { get => _line909PropertyIndicator2015; set => SetField(ref _line909PropertyIndicator2015, value); }
        private DirtyValue<string> _line909TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line909TaxesIndicator2015
        /// </summary>
        public string Line909TaxesIndicator2015 { get => _line909TaxesIndicator2015; set => SetField(ref _line909TaxesIndicator2015, value); }
        private DirtyValue<string> _line910InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line910InsuranceIndicator2015
        /// </summary>
        public string Line910InsuranceIndicator2015 { get => _line910InsuranceIndicator2015; set => SetField(ref _line910InsuranceIndicator2015, value); }
        private DirtyValue<string> _line910PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line910PropertyIndicator2015
        /// </summary>
        public string Line910PropertyIndicator2015 { get => _line910PropertyIndicator2015; set => SetField(ref _line910PropertyIndicator2015, value); }
        private DirtyValue<string> _line910TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line910TaxesIndicator2015
        /// </summary>
        public string Line910TaxesIndicator2015 { get => _line910TaxesIndicator2015; set => SetField(ref _line910TaxesIndicator2015, value); }
        private DirtyValue<string> _line911InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line911InsuranceIndicator2015
        /// </summary>
        public string Line911InsuranceIndicator2015 { get => _line911InsuranceIndicator2015; set => SetField(ref _line911InsuranceIndicator2015, value); }
        private DirtyValue<string> _line911PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line911PropertyIndicator2015
        /// </summary>
        public string Line911PropertyIndicator2015 { get => _line911PropertyIndicator2015; set => SetField(ref _line911PropertyIndicator2015, value); }
        private DirtyValue<string> _line911TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line911TaxesIndicator2015
        /// </summary>
        public string Line911TaxesIndicator2015 { get => _line911TaxesIndicator2015; set => SetField(ref _line911TaxesIndicator2015, value); }
        private DirtyValue<string> _line912InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line912InsuranceIndicator2015
        /// </summary>
        public string Line912InsuranceIndicator2015 { get => _line912InsuranceIndicator2015; set => SetField(ref _line912InsuranceIndicator2015, value); }
        private DirtyValue<string> _line912PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line912PropertyIndicator2015
        /// </summary>
        public string Line912PropertyIndicator2015 { get => _line912PropertyIndicator2015; set => SetField(ref _line912PropertyIndicator2015, value); }
        private DirtyValue<string> _line912TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line912TaxesIndicator2015
        /// </summary>
        public string Line912TaxesIndicator2015 { get => _line912TaxesIndicator2015; set => SetField(ref _line912TaxesIndicator2015, value); }
        private DirtyValue<string> _loanAdjustmentsOtherCredits;
        /// <summary>
        /// DisclosureTracking2015Log LoanAdjustmentsOtherCredits
        /// </summary>
        public string LoanAdjustmentsOtherCredits { get => _loanAdjustmentsOtherCredits; set => SetField(ref _loanAdjustmentsOtherCredits, value); }
        private DirtyValue<string> _loanAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }
        private DirtyValue<string> _loanClosingCost2BorrowerClosingCostAtClosing;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2BorrowerClosingCostAtClosing
        /// </summary>
        public string LoanClosingCost2BorrowerClosingCostAtClosing { get => _loanClosingCost2BorrowerClosingCostAtClosing; set => SetField(ref _loanClosingCost2BorrowerClosingCostAtClosing, value); }
        private DirtyValue<string> _loanClosingCost2LenderCredits;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2LenderCredits
        /// </summary>
        public string LoanClosingCost2LenderCredits { get => _loanClosingCost2LenderCredits; set => SetField(ref _loanClosingCost2LenderCredits, value); }
        private DirtyValue<string> _loanClosingCost2TotalLoanCost;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2TotalLoanCost
        /// </summary>
        public string LoanClosingCost2TotalLoanCost { get => _loanClosingCost2TotalLoanCost; set => SetField(ref _loanClosingCost2TotalLoanCost, value); }
        private DirtyValue<string> _loanClosingCost2TotalOtherCost;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2TotalOtherCost
        /// </summary>
        public string LoanClosingCost2TotalOtherCost { get => _loanClosingCost2TotalOtherCost; set => SetField(ref _loanClosingCost2TotalOtherCost, value); }
        private DirtyValue<string> _loanClosingCost3StdLegalLimit;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost3StdLegalLimit
        /// </summary>
        public string LoanClosingCost3StdLegalLimit { get => _loanClosingCost3StdLegalLimit; set => SetField(ref _loanClosingCost3StdLegalLimit, value); }
        private DirtyValue<string> _loanClosingCostGfe1200BorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostGfe1200BorPaidAmount
        /// </summary>
        public string LoanClosingCostGfe1200BorPaidAmount { get => _loanClosingCostGfe1200BorPaidAmount; set => SetField(ref _loanClosingCostGfe1200BorPaidAmount, value); }
        private DirtyValue<string> _loanClosingCostGfe800BorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostGfe800BorPaidAmount
        /// </summary>
        public string LoanClosingCostGfe800BorPaidAmount { get => _loanClosingCostGfe800BorPaidAmount; set => SetField(ref _loanClosingCostGfe800BorPaidAmount, value); }
        private DirtyValue<string> _loanClosingCostLenderCredits;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostLenderCredits
        /// </summary>
        public string LoanClosingCostLenderCredits { get => _loanClosingCostLenderCredits; set => SetField(ref _loanClosingCostLenderCredits, value); }
        private DirtyValue<string> _loanClosingCostSection1000BorrowerTotalPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostSection1000BorrowerTotalPaidAmount
        /// </summary>
        public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get => _loanClosingCostSection1000BorrowerTotalPaidAmount; set => SetField(ref _loanClosingCostSection1000BorrowerTotalPaidAmount, value); }
        private DirtyValue<string> _loanClosingCostsFinanced;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostsFinanced
        /// </summary>
        public string LoanClosingCostsFinanced { get => _loanClosingCostsFinanced; set => SetField(ref _loanClosingCostsFinanced, value); }
        private DirtyValue<string> _loanClosingCostTotalFeeAmount2015;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostTotalFeeAmount2015
        /// </summary>
        public string LoanClosingCostTotalFeeAmount2015 { get => _loanClosingCostTotalFeeAmount2015; set => SetField(ref _loanClosingCostTotalFeeAmount2015, value); }
        private DirtyValue<string> _loanDownPayment;
        /// <summary>
        /// DisclosureTracking2015Log LoanDownPayment
        /// </summary>
        public string LoanDownPayment { get => _loanDownPayment; set => SetField(ref _loanDownPayment, value); }
        private DirtyValue<string> _loanEstimate2TotalLoanAndOtherCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalLoanAndOtherCosts
        /// </summary>
        public string LoanEstimate2TotalLoanAndOtherCosts { get => _loanEstimate2TotalLoanAndOtherCosts; set => SetField(ref _loanEstimate2TotalLoanAndOtherCosts, value); }
        private DirtyValue<string> _loanEstimate2TotalLoanCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalLoanCosts
        /// </summary>
        public string LoanEstimate2TotalLoanCosts { get => _loanEstimate2TotalLoanCosts; set => SetField(ref _loanEstimate2TotalLoanCosts, value); }
        private DirtyValue<string> _loanEstimate2TotalOtherCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalOtherCosts
        /// </summary>
        public string LoanEstimate2TotalOtherCosts { get => _loanEstimate2TotalOtherCosts; set => SetField(ref _loanEstimate2TotalOtherCosts, value); }
        private DirtyValue<string> _loanEstimate2UnroundedTotalLoanCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalLoanCosts
        /// </summary>
        public string LoanEstimate2UnroundedTotalLoanCosts { get => _loanEstimate2UnroundedTotalLoanCosts; set => SetField(ref _loanEstimate2UnroundedTotalLoanCosts, value); }
        private DirtyValue<string> _loanEstimate2UnroundedTotalOtherCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalOtherCosts
        /// </summary>
        public string LoanEstimate2UnroundedTotalOtherCosts { get => _loanEstimate2UnroundedTotalOtherCosts; set => SetField(ref _loanEstimate2UnroundedTotalOtherCosts, value); }
        private DirtyValue<string> _loanEstimateLoanProduct;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimateLoanProduct
        /// </summary>
        public string LoanEstimateLoanProduct { get => _loanEstimateLoanProduct; set => SetField(ref _loanEstimateLoanProduct, value); }
        private DirtyValue<string> _loanFeesCityTaxBorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanFeesCityTaxBorPaidAmount
        /// </summary>
        public string LoanFeesCityTaxBorPaidAmount { get => _loanFeesCityTaxBorPaidAmount; set => SetField(ref _loanFeesCityTaxBorPaidAmount, value); }
        private DirtyValue<string> _loanFeesStateTaxBorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanFeesStateTaxBorPaidAmount
        /// </summary>
        public string LoanFeesStateTaxBorPaidAmount { get => _loanFeesStateTaxBorPaidAmount; set => SetField(ref _loanFeesStateTaxBorPaidAmount, value); }
        private DirtyValue<string> _loanFundsForBorrower;
        /// <summary>
        /// DisclosureTracking2015Log LoanFundsForBorrower
        /// </summary>
        public string LoanFundsForBorrower { get => _loanFundsForBorrower; set => SetField(ref _loanFundsForBorrower, value); }
        private DirtyValue<string> _loanGfeAgregateAdjustment;
        /// <summary>
        /// DisclosureTracking2015Log LoanGfeAgregateAdjustment
        /// </summary>
        public string LoanGfeAgregateAdjustment { get => _loanGfeAgregateAdjustment; set => SetField(ref _loanGfeAgregateAdjustment, value); }
        private DirtyValue<string> _loanGfeGovermentRecordingCharges;
        /// <summary>
        /// DisclosureTracking2015Log LoanGfeGovermentRecordingCharges
        /// </summary>
        public string LoanGfeGovermentRecordingCharges { get => _loanGfeGovermentRecordingCharges; set => SetField(ref _loanGfeGovermentRecordingCharges, value); }
        private DirtyValue<string> _loanLineItemAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanLineItemAmount
        /// </summary>
        public string LoanLineItemAmount { get => _loanLineItemAmount; set => SetField(ref _loanLineItemAmount, value); }
        private DirtyValue<string> _loanProgram;
        /// <summary>
        /// DisclosureTracking2015Log LoanProgram
        /// </summary>
        public string LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }
        private DirtyValue<string> _loanPurchaseCreditAmount1;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount1
        /// </summary>
        public string LoanPurchaseCreditAmount1 { get => _loanPurchaseCreditAmount1; set => SetField(ref _loanPurchaseCreditAmount1, value); }
        private DirtyValue<string> _loanPurchaseCreditAmount2;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount2
        /// </summary>
        public string LoanPurchaseCreditAmount2 { get => _loanPurchaseCreditAmount2; set => SetField(ref _loanPurchaseCreditAmount2, value); }
        private DirtyValue<string> _loanPurchaseCreditAmount3;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount3
        /// </summary>
        public string LoanPurchaseCreditAmount3 { get => _loanPurchaseCreditAmount3; set => SetField(ref _loanPurchaseCreditAmount3, value); }
        private DirtyValue<string> _loanPurchaseCreditAmount4;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount4
        /// </summary>
        public string LoanPurchaseCreditAmount4 { get => _loanPurchaseCreditAmount4; set => SetField(ref _loanPurchaseCreditAmount4, value); }
        private DirtyValue<string> _loanPurchaseCreditType1;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType1
        /// </summary>
        public string LoanPurchaseCreditType1 { get => _loanPurchaseCreditType1; set => SetField(ref _loanPurchaseCreditType1, value); }
        private DirtyValue<string> _loanPurchaseCreditType2;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType2
        /// </summary>
        public string LoanPurchaseCreditType2 { get => _loanPurchaseCreditType2; set => SetField(ref _loanPurchaseCreditType2, value); }
        private DirtyValue<string> _loanPurchaseCreditType3;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType3
        /// </summary>
        public string LoanPurchaseCreditType3 { get => _loanPurchaseCreditType3; set => SetField(ref _loanPurchaseCreditType3, value); }
        private DirtyValue<string> _loanPurchaseCreditType4;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType4
        /// </summary>
        public string LoanPurchaseCreditType4 { get => _loanPurchaseCreditType4; set => SetField(ref _loanPurchaseCreditType4, value); }
        private DirtyValue<string> _loanRefinanceIncludingDebtsToBePaidOffAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanRefinanceIncludingDebtsToBePaidOffAmount
        /// </summary>
        public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get => _loanRefinanceIncludingDebtsToBePaidOffAmount; set => SetField(ref _loanRefinanceIncludingDebtsToBePaidOffAmount, value); }
        private DirtyValue<string> _loanSection1000SellerPaidTotalAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanSection1000SellerPaidTotalAmount
        /// </summary>
        public string LoanSection1000SellerPaidTotalAmount { get => _loanSection1000SellerPaidTotalAmount; set => SetField(ref _loanSection1000SellerPaidTotalAmount, value); }
        private DirtyValue<string> _loanSellerCreditAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanSellerCreditAmount
        /// </summary>
        public string LoanSellerCreditAmount { get => _loanSellerCreditAmount; set => SetField(ref _loanSellerCreditAmount, value); }
        private DirtyValue<string> _loanTotalClosingCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanTotalClosingCosts
        /// </summary>
        public string LoanTotalClosingCosts { get => _loanTotalClosingCosts; set => SetField(ref _loanTotalClosingCosts, value); }
        private DirtyValue<DateTime?> _lockedBorrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log LockedBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedBorrowerPresumedReceivedDate { get => _lockedBorrowerPresumedReceivedDate; set => SetField(ref _lockedBorrowerPresumedReceivedDate, value); }
        private DirtyValue<string> _lockedBorrowerType;
        /// <summary>
        /// DisclosureTracking2015Log LockedBorrowerType
        /// </summary>
        public string LockedBorrowerType { get => _lockedBorrowerType; set => SetField(ref _lockedBorrowerType, value); }
        private DirtyValue<DateTime?> _lockedCoBorrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log LockedCoBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedCoBorrowerPresumedReceivedDate { get => _lockedCoBorrowerPresumedReceivedDate; set => SetField(ref _lockedCoBorrowerPresumedReceivedDate, value); }
        private DirtyValue<string> _lockedCoBorrowerType;
        /// <summary>
        /// DisclosureTracking2015Log LockedCoBorrowerType
        /// </summary>
        public string LockedCoBorrowerType { get => _lockedCoBorrowerType; set => SetField(ref _lockedCoBorrowerType, value); }
        private DirtyValue<string> _lockedDisclosedAprField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedAprField
        /// </summary>
        public string LockedDisclosedAprField { get => _lockedDisclosedAprField; set => SetField(ref _lockedDisclosedAprField, value); }
        private DirtyValue<string> _lockedDisclosedByField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedByField
        /// </summary>
        public string LockedDisclosedByField { get => _lockedDisclosedByField; set => SetField(ref _lockedDisclosedByField, value); }
        private DirtyValue<string> _lockedDisclosedDailyInterestField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedDailyInterestField
        /// </summary>
        public string LockedDisclosedDailyInterestField { get => _lockedDisclosedDailyInterestField; set => SetField(ref _lockedDisclosedDailyInterestField, value); }
        private DirtyValue<DateTime?> _lockedDisclosedDateField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedDateField
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedDisclosedDateField { get => _lockedDisclosedDateField; set => SetField(ref _lockedDisclosedDateField, value); }
        private DirtyValue<string> _lockedDisclosedFinanceChargeField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedFinanceChargeField
        /// </summary>
        public string LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => SetField(ref _lockedDisclosedFinanceChargeField, value); }
        private DirtyValue<DateTime?> _lockedDisclosedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => SetField(ref _lockedDisclosedReceivedDate, value); }
        private DirtyValue<string> _lockedIntentReceivedByField;
        /// <summary>
        /// DisclosureTracking2015Log LockedIntentReceivedByField
        /// </summary>
        public string LockedIntentReceivedByField { get => _lockedIntentReceivedByField; set => SetField(ref _lockedIntentReceivedByField, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// DisclosureTracking2015Log LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _manuallyCreated;
        /// <summary>
        /// DisclosureTracking2015Log ManuallyCreated
        /// </summary>
        public string ManuallyCreated { get => _manuallyCreated; set => SetField(ref _manuallyCreated, value); }
        private DirtyValue<int?> _numberOfDisclosureDocs;
        /// <summary>
        /// DisclosureTracking2015Log NumberOfDisclosureDocs
        /// </summary>
        public int? NumberOfDisclosureDocs { get => _numberOfDisclosureDocs; set => SetField(ref _numberOfDisclosureDocs, value); }
        private DirtyValue<string> _prepaymentPenaltyIndicator;
        /// <summary>
        /// DisclosureTracking2015Log PrepaymentPenaltyIndicator
        /// </summary>
        public string PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }
        private DirtyValue<DateTime?> _presumedFulfillmentDate;
        /// <summary>
        /// DisclosureTracking2015Log PresumedFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PresumedFulfillmentDate { get => _presumedFulfillmentDate; set => SetField(ref _presumedFulfillmentDate, value); }
        private DirtyValue<string> _propertyAddress;
        /// <summary>
        /// DisclosureTracking2015Log PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }
        private DirtyValue<string> _propertyCity;
        /// <summary>
        /// DisclosureTracking2015Log PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }
        private DirtyValue<string> _propertyState;
        /// <summary>
        /// DisclosureTracking2015Log PropertyState
        /// </summary>
        public string PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }
        private DirtyValue<string> _propertyZip;
        /// <summary>
        /// DisclosureTracking2015Log PropertyZip
        /// </summary>
        public string PropertyZip { get => _propertyZip; set => SetField(ref _propertyZip, value); }
        private DirtyValue<bool?> _providerListSent;
        /// <summary>
        /// DisclosureTracking2015Log ProviderListSent
        /// </summary>
        public bool? ProviderListSent { get => _providerListSent; set => SetField(ref _providerListSent, value); }
        private DirtyValue<string> _purchasePriceAmount;
        /// <summary>
        /// DisclosureTracking2015Log PurchasePriceAmount
        /// </summary>
        public string PurchasePriceAmount { get => _purchasePriceAmount; set => SetField(ref _purchasePriceAmount, value); }
        private DirtyValue<DateTime?> _receivedDate;
        /// <summary>
        /// DisclosureTracking2015Log ReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }
        private DirtyValue<DateTime?> _revisedDueDate;
        /// <summary>
        /// DisclosureTracking2015Log RevisedDueDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? RevisedDueDate { get => _revisedDueDate; set => SetField(ref _revisedDueDate, value); }
        private DirtyList<LogSnapshotField> _snapshotFields;
        /// <summary>
        /// DisclosureTracking2015Log SnapshotFields
        /// </summary>
        public IList<LogSnapshotField> SnapshotFields { get => GetField(ref _snapshotFields); set => SetField(ref _snapshotFields, value); }
        private DirtyValue<string> _snapshotXml;
        /// <summary>
        /// DisclosureTracking2015Log SnapshotXml
        /// </summary>
        public string SnapshotXml { get => _snapshotXml; set => SetField(ref _snapshotXml, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// DisclosureTracking2015Log SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}