using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DisclosureTracking2015Log
    /// </summary>
    public sealed partial class DisclosureTracking2015Log : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _actualFulfillmentDate;
        /// <summary>
        /// DisclosureTracking2015Log ActualFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ActualFulfillmentDate { get => _actualFulfillmentDate; set => _actualFulfillmentDate = value; }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// DisclosureTracking2015Log Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// DisclosureTracking2015Log AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<DateTime?> _applicationDate;
        /// <summary>
        /// DisclosureTracking2015Log ApplicationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ApplicationDate { get => _applicationDate; set => _applicationDate = value; }
        private DirtyValue<string> _appliedCureAmount;
        /// <summary>
        /// DisclosureTracking2015Log AppliedCureAmount
        /// </summary>
        public string AppliedCureAmount { get => _appliedCureAmount; set => _appliedCureAmount = value; }
        private DirtyValue<string> _automaticFullfillmentServiceName;
        /// <summary>
        /// DisclosureTracking2015Log AutomaticFullfillmentServiceName
        /// </summary>
        public string AutomaticFullfillmentServiceName { get => _automaticFullfillmentServiceName; set => _automaticFullfillmentServiceName = value; }
        private DirtyValue<DateTime?> _borrowerActualReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerActualReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BorrowerActualReceivedDate { get => _borrowerActualReceivedDate; set => _borrowerActualReceivedDate = value; }
        private DirtyValue<string> _borrowerDisclosedMethod;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerDisclosedMethod
        /// </summary>
        public string BorrowerDisclosedMethod { get => _borrowerDisclosedMethod; set => _borrowerDisclosedMethod = value; }
        private DirtyValue<string> _borrowerDisclosedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerDisclosedMethodOther
        /// </summary>
        public string BorrowerDisclosedMethodOther { get => _borrowerDisclosedMethodOther; set => _borrowerDisclosedMethodOther = value; }
        private DirtyValue<string> _borrowerName;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerName
        /// </summary>
        public string BorrowerName { get => _borrowerName; set => _borrowerName = value; }
        private DirtyValue<string> _borrowerPairId;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerPairId
        /// </summary>
        public string BorrowerPairId { get => _borrowerPairId; set => _borrowerPairId = value; }
        private DirtyValue<DateTime?> _borrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BorrowerPresumedReceivedDate { get => _borrowerPresumedReceivedDate; set => _borrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _borrowerType;
        /// <summary>
        /// DisclosureTracking2015Log BorrowerType
        /// </summary>
        public string BorrowerType { get => _borrowerType; set => _borrowerType = value; }
        private DirtyValue<bool?> _brokerDisclosed;
        /// <summary>
        /// DisclosureTracking2015Log BrokerDisclosed
        /// </summary>
        public bool? BrokerDisclosed { get => _brokerDisclosed; set => _brokerDisclosed = value; }
        private DirtyValue<bool?> _cDReasonIs24HourAdvancePreview;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIs24HourAdvancePreview
        /// </summary>
        public bool? CDReasonIs24HourAdvancePreview { get => _cDReasonIs24HourAdvancePreview; set => _cDReasonIs24HourAdvancePreview = value; }
        private DirtyValue<bool?> _cDReasonIsChangedCircumstanceEligibility;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangedCircumstanceEligibility
        /// </summary>
        public bool? CDReasonIsChangedCircumstanceEligibility { get => _cDReasonIsChangedCircumstanceEligibility; set => _cDReasonIsChangedCircumstanceEligibility = value; }
        private DirtyValue<bool?> _cDReasonIsChangeInAPR;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInAPR
        /// </summary>
        public bool? CDReasonIsChangeInAPR { get => _cDReasonIsChangeInAPR; set => _cDReasonIsChangeInAPR = value; }
        private DirtyValue<bool?> _cDReasonIsChangeInLoanProduct;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInLoanProduct
        /// </summary>
        public bool? CDReasonIsChangeInLoanProduct { get => _cDReasonIsChangeInLoanProduct; set => _cDReasonIsChangeInLoanProduct = value; }
        private DirtyValue<bool?> _cDReasonIsChangeInSettlementCharges;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsChangeInSettlementCharges
        /// </summary>
        public bool? CDReasonIsChangeInSettlementCharges { get => _cDReasonIsChangeInSettlementCharges; set => _cDReasonIsChangeInSettlementCharges = value; }
        private DirtyValue<bool?> _cDReasonIsClericalErrorCorrection;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsClericalErrorCorrection
        /// </summary>
        public bool? CDReasonIsClericalErrorCorrection { get => _cDReasonIsClericalErrorCorrection; set => _cDReasonIsClericalErrorCorrection = value; }
        private DirtyValue<bool?> _cDReasonIsInterestRateDependentCharges;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsInterestRateDependentCharges
        /// </summary>
        public bool? CDReasonIsInterestRateDependentCharges { get => _cDReasonIsInterestRateDependentCharges; set => _cDReasonIsInterestRateDependentCharges = value; }
        private DirtyValue<bool?> _cDReasonIsOther;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsOther
        /// </summary>
        public bool? CDReasonIsOther { get => _cDReasonIsOther; set => _cDReasonIsOther = value; }
        private DirtyValue<bool?> _cDReasonIsPrepaymentPenaltyAdded;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsPrepaymentPenaltyAdded
        /// </summary>
        public bool? CDReasonIsPrepaymentPenaltyAdded { get => _cDReasonIsPrepaymentPenaltyAdded; set => _cDReasonIsPrepaymentPenaltyAdded = value; }
        private DirtyValue<bool?> _cDReasonIsRevisionsRequestedByConsumer;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsRevisionsRequestedByConsumer
        /// </summary>
        public bool? CDReasonIsRevisionsRequestedByConsumer { get => _cDReasonIsRevisionsRequestedByConsumer; set => _cDReasonIsRevisionsRequestedByConsumer = value; }
        private DirtyValue<bool?> _cDReasonIsToleranceCure;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonIsToleranceCure
        /// </summary>
        public bool? CDReasonIsToleranceCure { get => _cDReasonIsToleranceCure; set => _cDReasonIsToleranceCure = value; }
        private DirtyValue<string> _cDReasonOther;
        /// <summary>
        /// DisclosureTracking2015Log CDReasonOther
        /// </summary>
        public string CDReasonOther { get => _cDReasonOther; set => _cDReasonOther = value; }
        private DirtyValue<string> _changeInCircumstance;
        /// <summary>
        /// DisclosureTracking2015Log ChangeInCircumstance
        /// </summary>
        public string ChangeInCircumstance { get => _changeInCircumstance; set => _changeInCircumstance = value; }
        private DirtyValue<string> _changeInCircumstanceComments;
        /// <summary>
        /// DisclosureTracking2015Log ChangeInCircumstanceComments
        /// </summary>
        public string ChangeInCircumstanceComments { get => _changeInCircumstanceComments; set => _changeInCircumstanceComments = value; }
        private DirtyValue<DateTime?> _changesReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log ChangesReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => _changesReceivedDate = value; }
        private DirtyValue<string> _chargesCannotIncrease10Itemization34;
        /// <summary>
        /// DisclosureTracking2015Log ChargesCannotIncrease10Itemization34
        /// </summary>
        public string ChargesCannotIncrease10Itemization34 { get => _chargesCannotIncrease10Itemization34; set => _chargesCannotIncrease10Itemization34 = value; }
        private DirtyValue<string> _chargesCannotIncrease10LE32;
        /// <summary>
        /// DisclosureTracking2015Log ChargesCannotIncrease10LE32
        /// </summary>
        public string ChargesCannotIncrease10LE32 { get => _chargesCannotIncrease10LE32; set => _chargesCannotIncrease10LE32 = value; }
        private DirtyValue<string> _chargesThatCannotDecreaseItemization9;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotDecreaseItemization9
        /// </summary>
        public string ChargesThatCannotDecreaseItemization9 { get => _chargesThatCannotDecreaseItemization9; set => _chargesThatCannotDecreaseItemization9 = value; }
        private DirtyValue<string> _chargesThatCannotDecreaseLE7;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotDecreaseLE7
        /// </summary>
        public string ChargesThatCannotDecreaseLE7 { get => _chargesThatCannotDecreaseLE7; set => _chargesThatCannotDecreaseLE7 = value; }
        private DirtyValue<string> _chargesThatCannotIncreaseItemization13;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotIncreaseItemization13
        /// </summary>
        public string ChargesThatCannotIncreaseItemization13 { get => _chargesThatCannotIncreaseItemization13; set => _chargesThatCannotIncreaseItemization13 = value; }
        private DirtyValue<string> _chargesThatCannotIncreaseLE11;
        /// <summary>
        /// DisclosureTracking2015Log ChargesThatCannotIncreaseLE11
        /// </summary>
        public string ChargesThatCannotIncreaseLE11 { get => _chargesThatCannotIncreaseLE11; set => _chargesThatCannotIncreaseLE11 = value; }
        private DirtyValue<DateTime?> _coBorrowerActualReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerActualReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CoBorrowerActualReceivedDate { get => _coBorrowerActualReceivedDate; set => _coBorrowerActualReceivedDate = value; }
        private DirtyValue<string> _coBorrowerDisclosedMethod;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerDisclosedMethod
        /// </summary>
        public string CoBorrowerDisclosedMethod { get => _coBorrowerDisclosedMethod; set => _coBorrowerDisclosedMethod = value; }
        private DirtyValue<string> _coBorrowerDisclosedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerDisclosedMethodOther
        /// </summary>
        public string CoBorrowerDisclosedMethodOther { get => _coBorrowerDisclosedMethodOther; set => _coBorrowerDisclosedMethodOther = value; }
        private DirtyValue<string> _coBorrowerName;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerName
        /// </summary>
        public string CoBorrowerName { get => _coBorrowerName; set => _coBorrowerName = value; }
        private DirtyValue<DateTime?> _coBorrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CoBorrowerPresumedReceivedDate { get => _coBorrowerPresumedReceivedDate; set => _coBorrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _coBorrowerType;
        /// <summary>
        /// DisclosureTracking2015Log CoBorrowerType
        /// </summary>
        public string CoBorrowerType { get => _coBorrowerType; set => _coBorrowerType = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// DisclosureTracking2015Log CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// DisclosureTracking2015Log CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// DisclosureTracking2015Log Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<bool?> _containCD;
        /// <summary>
        /// DisclosureTracking2015Log ContainCD
        /// </summary>
        public bool? ContainCD { get => _containCD; set => _containCD = value; }
        private DirtyValue<bool?> _containLE;
        /// <summary>
        /// DisclosureTracking2015Log ContainLE
        /// </summary>
        public bool? ContainLE { get => _containLE; set => _containLE = value; }
        private DirtyValue<bool?> _containSafeHarbor;
        /// <summary>
        /// DisclosureTracking2015Log ContainSafeHarbor
        /// </summary>
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => _containSafeHarbor = value; }
        private DirtyValue<DateTime?> _dateAdded;
        /// <summary>
        /// DisclosureTracking2015Log DateAdded
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAdded { get => _dateAdded; set => _dateAdded = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DisclosureTracking2015Log DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _disclosedAPR;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedAPR
        /// </summary>
        public string DisclosedAPR { get => _disclosedAPR; set => _disclosedAPR = value; }
        private DirtyValue<string> _disclosedBy;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedBy
        /// </summary>
        public string DisclosedBy { get => _disclosedBy; set => _disclosedBy = value; }
        private DirtyValue<string> _disclosedByFullName;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedByFullName
        /// </summary>
        public string DisclosedByFullName { get => _disclosedByFullName; set => _disclosedByFullName = value; }
        private DirtyValue<string> _disclosedDailyInterest;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedDailyInterest
        /// </summary>
        public string DisclosedDailyInterest { get => _disclosedDailyInterest; set => _disclosedDailyInterest = value; }
        private DirtyValue<DateTime?> _disclosedDate;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisclosedDate { get => _disclosedDate; set => _disclosedDate = value; }
        private DirtyValue<bool?> _disclosedForCD;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedForCD
        /// </summary>
        public bool? DisclosedForCD { get => _disclosedForCD; set => _disclosedForCD = value; }
        private DirtyValue<bool?> _disclosedForLE;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedForLE
        /// </summary>
        public bool? DisclosedForLE { get => _disclosedForLE; set => _disclosedForLE = value; }
        private DirtyValue<string> _disclosedMethod;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethod
        /// </summary>
        public string DisclosedMethod { get => _disclosedMethod; set => _disclosedMethod = value; }
        private DirtyValue<string> _disclosedMethodName;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethodName
        /// </summary>
        public string DisclosedMethodName { get => _disclosedMethodName; set => _disclosedMethodName = value; }
        private DirtyValue<string> _disclosedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedMethodOther
        /// </summary>
        public string DisclosedMethodOther { get => _disclosedMethodOther; set => _disclosedMethodOther = value; }
        private DirtyValue<string> _disclosedSalesPrice;
        /// <summary>
        /// DisclosureTracking2015Log DisclosedSalesPrice
        /// </summary>
        public string DisclosedSalesPrice { get => _disclosedSalesPrice; set => _disclosedSalesPrice = value; }
        private DirtyValue<DateTime?> _disclosureCreatedDttmUtc;
        /// <summary>
        /// DisclosureTracking2015Log DisclosureCreatedDttmUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => _disclosureCreatedDttmUtc = value; }
        private DirtyValue<string> _disclosureMethod;
        /// <summary>
        /// DisclosureTracking2015Log DisclosureMethod
        /// </summary>
        public string DisclosureMethod { get => _disclosureMethod; set => _disclosureMethod = value; }
        private DirtyValue<string> _disclosureType;
        /// <summary>
        /// DisclosureTracking2015Log DisclosureType
        /// </summary>
        public string DisclosureType { get => _disclosureType; set => _disclosureType = value; }
        private DirtyValue<bool?> _eDisclosureApplicationPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureApplicationPackageIndicator
        /// </summary>
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => _eDisclosureApplicationPackageIndicator = value; }
        private DirtyValue<bool?> _eDisclosureApprovalPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureApprovalPackageIndicator
        /// </summary>
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => _eDisclosureApprovalPackageIndicator = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => _eDisclosureBorrowerAcceptConsentDate = value; }
        private DirtyValue<string> _eDisclosureBorrowerAcceptConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAcceptConsentIP
        /// </summary>
        public string EDisclosureBorrowerAcceptConsentIP { get => _eDisclosureBorrowerAcceptConsentIP; set => _eDisclosureBorrowerAcceptConsentIP = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAuthenticatedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerAuthenticatedDate { get => _eDisclosureBorrowerAuthenticatedDate; set => _eDisclosureBorrowerAuthenticatedDate = value; }
        private DirtyValue<string> _eDisclosureBorrowerAuthenticatedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerAuthenticatedIP
        /// </summary>
        public string EDisclosureBorrowerAuthenticatedIP { get => _eDisclosureBorrowerAuthenticatedIP; set => _eDisclosureBorrowerAuthenticatedIP = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerDocumentViewedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerDocumentViewedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerDocumentViewedDate { get => _eDisclosureBorrowerDocumentViewedDate; set => _eDisclosureBorrowerDocumentViewedDate = value; }
        private DirtyValue<string> _eDisclosureBorrowerEmail;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerEmail
        /// </summary>
        public string EDisclosureBorrowerEmail { get => _eDisclosureBorrowerEmail; set => _eDisclosureBorrowerEmail = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowereSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => _eDisclosureBorrowereSignedDate = value; }
        private DirtyValue<string> _eDisclosureBorrowereSignedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowereSignedIP
        /// </summary>
        public string EDisclosureBorrowereSignedIP { get => _eDisclosureBorrowereSignedIP; set => _eDisclosureBorrowereSignedIP = value; }
        private DirtyValue<string> _eDisclosureBorrowerLoanLevelConsent;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerLoanLevelConsent
        /// </summary>
        public string EDisclosureBorrowerLoanLevelConsent { get => _eDisclosureBorrowerLoanLevelConsent; set => _eDisclosureBorrowerLoanLevelConsent = value; }
        private DirtyValue<string> _eDisclosureBorrowerName;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerName
        /// </summary>
        public string EDisclosureBorrowerName { get => _eDisclosureBorrowerName; set => _eDisclosureBorrowerName = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => _eDisclosureBorrowerRejectConsentDate = value; }
        private DirtyValue<string> _eDisclosureBorrowerRejectConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerRejectConsentIP
        /// </summary>
        public string EDisclosureBorrowerRejectConsentIP { get => _eDisclosureBorrowerRejectConsentIP; set => _eDisclosureBorrowerRejectConsentIP = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => _eDisclosureBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => _eDisclosureBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerWetSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureBorrowerWetSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => _eDisclosureBorrowerWetSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => _eDisclosureCoBorrowerAcceptConsentDate = value; }
        private DirtyValue<string> _eDisclosureCoBorrowerAcceptConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAcceptConsentIP
        /// </summary>
        public string EDisclosureCoBorrowerAcceptConsentIP { get => _eDisclosureCoBorrowerAcceptConsentIP; set => _eDisclosureCoBorrowerAcceptConsentIP = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAuthenticatedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerAuthenticatedDate { get => _eDisclosureCoBorrowerAuthenticatedDate; set => _eDisclosureCoBorrowerAuthenticatedDate = value; }
        private DirtyValue<string> _eDisclosureCoBorrowerAuthenticatedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerAuthenticatedIP
        /// </summary>
        public string EDisclosureCoBorrowerAuthenticatedIP { get => _eDisclosureCoBorrowerAuthenticatedIP; set => _eDisclosureCoBorrowerAuthenticatedIP = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerDocumentViewedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerDocumentViewedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerDocumentViewedDate { get => _eDisclosureCoBorrowerDocumentViewedDate; set => _eDisclosureCoBorrowerDocumentViewedDate = value; }
        private DirtyValue<string> _eDisclosureCoBorrowerEmail;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerEmail
        /// </summary>
        public string EDisclosureCoBorrowerEmail { get => _eDisclosureCoBorrowerEmail; set => _eDisclosureCoBorrowerEmail = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowereSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => _eDisclosureCoBorrowereSignedDate = value; }
        private DirtyValue<string> _eDisclosureCoBorrowereSignedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowereSignedIP
        /// </summary>
        public string EDisclosureCoBorrowereSignedIP { get => _eDisclosureCoBorrowereSignedIP; set => _eDisclosureCoBorrowereSignedIP = value; }
        private DirtyValue<string> _eDisclosureCoBorrowerLoanLevelConsent;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerLoanLevelConsent
        /// </summary>
        public string EDisclosureCoBorrowerLoanLevelConsent { get => _eDisclosureCoBorrowerLoanLevelConsent; set => _eDisclosureCoBorrowerLoanLevelConsent = value; }
        private DirtyValue<string> _eDisclosureCoBorrowerName;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerName
        /// </summary>
        public string EDisclosureCoBorrowerName { get => _eDisclosureCoBorrowerName; set => _eDisclosureCoBorrowerName = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => _eDisclosureCoBorrowerRejectConsentDate = value; }
        private DirtyValue<string> _eDisclosureCoBorrowerRejectConsentIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerRejectConsentIP
        /// </summary>
        public string EDisclosureCoBorrowerRejectConsentIP { get => _eDisclosureCoBorrowerRejectConsentIP; set => _eDisclosureCoBorrowerRejectConsentIP = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => _eDisclosureCoBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => _eDisclosureCoBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureCoBorrowerWebSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => _eDisclosureCoBorrowerWebSignedDate = value; }
        private DirtyValue<string> _eDisclosureConsentPdf;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureConsentPdf
        /// </summary>
        public string EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => _eDisclosureConsentPdf = value; }
        private DirtyValue<string> _eDisclosureDisclosedMessage;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureDisclosedMessage
        /// </summary>
        public string EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => _eDisclosureDisclosedMessage = value; }
        private DirtyValue<bool?> _eDisclosureLockPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLockPackageIndicator
        /// </summary>
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => _eDisclosureLockPackageIndicator = value; }
        private DirtyValue<DateTime?> _eDisclosureLOeSignedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOeSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureLOeSignedDate { get => _eDisclosureLOeSignedDate; set => _eDisclosureLOeSignedDate = value; }
        private DirtyValue<string> _eDisclosureLOeSignedIP;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOeSignedIP
        /// </summary>
        public string EDisclosureLOeSignedIP { get => _eDisclosureLOeSignedIP; set => _eDisclosureLOeSignedIP = value; }
        private DirtyValue<string> _eDisclosureLOName;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOName
        /// </summary>
        public string EDisclosureLOName { get => _eDisclosureLOName; set => _eDisclosureLOName = value; }
        private DirtyValue<DateTime?> _eDisclosureLOViewMessageDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureLOViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureLOViewMessageDate { get => _eDisclosureLOViewMessageDate; set => _eDisclosureLOViewMessageDate = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentComment;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentComment
        /// </summary>
        public string EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => _eDisclosureManualFulfillmentComment = value; }
        private DirtyValue<DateTime?> _eDisclosureManualFulfillmentDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => _eDisclosureManualFulfillmentDate = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentMethod;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManualFulfillmentMethod
        /// </summary>
        public string EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => _eDisclosureManualFulfillmentMethod = value; }
        private DirtyValue<string> _eDisclosureManuallyFulfilledBy;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureManuallyFulfilledBy
        /// </summary>
        public string EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => _eDisclosureManuallyFulfilledBy = value; }
        private DirtyValue<DateTime?> _eDisclosurePackageCreatedDate;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageCreatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => _eDisclosurePackageCreatedDate = value; }
        private DirtyValue<string> _eDisclosurePackageId;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageId
        /// </summary>
        public string EDisclosurePackageId { get => _eDisclosurePackageId; set => _eDisclosurePackageId = value; }
        private DirtyValue<string> _eDisclosurePackageViewableFile;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosurePackageViewableFile
        /// </summary>
        public string EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => _eDisclosurePackageViewableFile = value; }
        private DirtyValue<bool?> _eDisclosureThreeDayPackageIndicator;
        /// <summary>
        /// DisclosureTracking2015Log EDisclosureThreeDayPackageIndicator
        /// </summary>
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => _eDisclosureThreeDayPackageIndicator = value; }
        private DirtyValue<string> _estimatedTotalPayoffsAndPaymentsAmount;
        /// <summary>
        /// DisclosureTracking2015Log EstimatedTotalPayoffsAndPaymentsAmount
        /// </summary>
        public string EstimatedTotalPayoffsAndPaymentsAmount { get => _estimatedTotalPayoffsAndPaymentsAmount; set => _estimatedTotalPayoffsAndPaymentsAmount = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// DisclosureTracking2015Log FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _financeCharge;
        /// <summary>
        /// DisclosureTracking2015Log FinanceCharge
        /// </summary>
        public string FinanceCharge { get => _financeCharge; set => _financeCharge = value; }
        private DirtyList<DisclosureForm> _forms;
        /// <summary>
        /// DisclosureTracking2015Log Forms
        /// </summary>
        public IList<DisclosureForm> Forms { get => _forms ?? (_forms = new DirtyList<DisclosureForm>()); set => _forms = new DirtyList<DisclosureForm>(value); }
        private DirtyValue<string> _formsXml;
        /// <summary>
        /// DisclosureTracking2015Log FormsXml
        /// </summary>
        public string FormsXml { get => _formsXml; set => _formsXml = value; }
        private DirtyValue<string> _fulfillmentOrderedBy;
        /// <summary>
        /// DisclosureTracking2015Log FulfillmentOrderedBy
        /// </summary>
        public string FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => _fulfillmentOrderedBy = value; }
        private DirtyValue<string> _fulfillmentOrderedByCoBorrower;
        /// <summary>
        /// DisclosureTracking2015Log FulfillmentOrderedByCoBorrower
        /// </summary>
        public string FulfillmentOrderedByCoBorrower { get => _fulfillmentOrderedByCoBorrower; set => _fulfillmentOrderedByCoBorrower = value; }
        private DirtyValue<string> _fullfillmentProcessedDate;
        /// <summary>
        /// DisclosureTracking2015Log FullfillmentProcessedDate
        /// </summary>
        public string FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => _fullfillmentProcessedDate = value; }
        private DirtyValue<DateTime?> _fullfillmentProcessedDateCoBorrower;
        /// <summary>
        /// DisclosureTracking2015Log FullfillmentProcessedDateCoBorrower
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? FullfillmentProcessedDateCoBorrower { get => _fullfillmentProcessedDateCoBorrower; set => _fullfillmentProcessedDateCoBorrower = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// DisclosureTracking2015Log Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// DisclosureTracking2015Log Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _intentToProceed;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceed
        /// </summary>
        public bool? IntentToProceed { get => _intentToProceed; set => _intentToProceed = value; }
        private DirtyValue<string> _intentToProceedComments;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedComments
        /// </summary>
        public string IntentToProceedComments { get => _intentToProceedComments; set => _intentToProceedComments = value; }
        private DirtyValue<DateTime?> _intentToProceedDate;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? IntentToProceedDate { get => _intentToProceedDate; set => _intentToProceedDate = value; }
        private DirtyValue<string> _intentToProceedReceivedBy;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedBy
        /// </summary>
        public string IntentToProceedReceivedBy { get => _intentToProceedReceivedBy; set => _intentToProceedReceivedBy = value; }
        private DirtyValue<string> _intentToProceedReceivedMethod;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedMethod
        /// </summary>
        public string IntentToProceedReceivedMethod { get => _intentToProceedReceivedMethod; set => _intentToProceedReceivedMethod = value; }
        private DirtyValue<string> _intentToProceedReceivedMethodOther;
        /// <summary>
        /// DisclosureTracking2015Log IntentToProceedReceivedMethodOther
        /// </summary>
        public string IntentToProceedReceivedMethodOther { get => _intentToProceedReceivedMethodOther; set => _intentToProceedReceivedMethodOther = value; }
        private DirtyValue<bool?> _isBorrowerPresumedDateLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsBorrowerPresumedDateLocked
        /// </summary>
        public bool? IsBorrowerPresumedDateLocked { get => _isBorrowerPresumedDateLocked; set => _isBorrowerPresumedDateLocked = value; }
        private DirtyValue<bool?> _isBorrowerTypeLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsBorrowerTypeLocked
        /// </summary>
        public bool? IsBorrowerTypeLocked { get => _isBorrowerTypeLocked; set => _isBorrowerTypeLocked = value; }
        private DirtyValue<bool?> _isCoBorrowerPresumedDateLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsCoBorrowerPresumedDateLocked
        /// </summary>
        public bool? IsCoBorrowerPresumedDateLocked { get => _isCoBorrowerPresumedDateLocked; set => _isCoBorrowerPresumedDateLocked = value; }
        private DirtyValue<bool?> _isCoBorrowerTypeLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsCoBorrowerTypeLocked
        /// </summary>
        public bool? IsCoBorrowerTypeLocked { get => _isCoBorrowerTypeLocked; set => _isCoBorrowerTypeLocked = value; }
        private DirtyValue<string> _isDisclosed;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosed
        /// </summary>
        public string IsDisclosed { get => _isDisclosed; set => _isDisclosed = value; }
        private DirtyValue<string> _isDisclosedAprLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedAprLocked
        /// </summary>
        public string IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => _isDisclosedAprLocked = value; }
        private DirtyValue<string> _isDisclosedByLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedByLocked
        /// </summary>
        public string IsDisclosedByLocked { get => _isDisclosedByLocked; set => _isDisclosedByLocked = value; }
        private DirtyValue<bool?> _isDisclosedDailyInterestLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedDailyInterestLocked
        /// </summary>
        public bool? IsDisclosedDailyInterestLocked { get => _isDisclosedDailyInterestLocked; set => _isDisclosedDailyInterestLocked = value; }
        private DirtyValue<string> _isDisclosedFinanceChargeLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedFinanceChargeLocked
        /// </summary>
        public string IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => _isDisclosedFinanceChargeLocked = value; }
        private DirtyValue<string> _isDisclosedReceivedDateLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsDisclosedReceivedDateLocked
        /// </summary>
        public string IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => _isDisclosedReceivedDateLocked = value; }
        private DirtyValue<bool?> _isIntentReceivedByLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsIntentReceivedByLocked
        /// </summary>
        public bool? IsIntentReceivedByLocked { get => _isIntentReceivedByLocked; set => _isIntentReceivedByLocked = value; }
        private DirtyValue<string> _isLocked;
        /// <summary>
        /// DisclosureTracking2015Log IsLocked
        /// </summary>
        public string IsLocked { get => _isLocked; set => _isLocked = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// DisclosureTracking2015Log IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<bool?> _isWetSignedIndicator;
        /// <summary>
        /// DisclosureTracking2015Log IsWetSignedIndicator
        /// </summary>
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => _isWetSignedIndicator = value; }
        private DirtyValue<string> _lenderCompensationCreditAmount2;
        /// <summary>
        /// DisclosureTracking2015Log LenderCompensationCreditAmount2
        /// </summary>
        public string LenderCompensationCreditAmount2 { get => _lenderCompensationCreditAmount2; set => _lenderCompensationCreditAmount2 = value; }
        private DirtyValue<string> _lenderTotalPaidOriginatorAmount;
        /// <summary>
        /// DisclosureTracking2015Log LenderTotalPaidOriginatorAmount
        /// </summary>
        public string LenderTotalPaidOriginatorAmount { get => _lenderTotalPaidOriginatorAmount; set => _lenderTotalPaidOriginatorAmount = value; }
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceEligibility;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceEligibility
        /// </summary>
        public bool? LEReasonIsChangedCircumstanceEligibility { get => _lEReasonIsChangedCircumstanceEligibility; set => _lEReasonIsChangedCircumstanceEligibility = value; }
        private DirtyValue<bool?> _lEReasonIsChangedCircumstanceSettlementCharges;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsChangedCircumstanceSettlementCharges
        /// </summary>
        public bool? LEReasonIsChangedCircumstanceSettlementCharges { get => _lEReasonIsChangedCircumstanceSettlementCharges; set => _lEReasonIsChangedCircumstanceSettlementCharges = value; }
        private DirtyValue<bool?> _lEReasonIsDelayedSettlementOnConstructionLoans;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsDelayedSettlementOnConstructionLoans
        /// </summary>
        public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get => _lEReasonIsDelayedSettlementOnConstructionLoans; set => _lEReasonIsDelayedSettlementOnConstructionLoans = value; }
        private DirtyValue<bool?> _lEReasonIsExpiration;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsExpiration
        /// </summary>
        public bool? LEReasonIsExpiration { get => _lEReasonIsExpiration; set => _lEReasonIsExpiration = value; }
        private DirtyValue<bool?> _lEReasonIsInterestRateDependentCharges;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsInterestRateDependentCharges
        /// </summary>
        public bool? LEReasonIsInterestRateDependentCharges { get => _lEReasonIsInterestRateDependentCharges; set => _lEReasonIsInterestRateDependentCharges = value; }
        private DirtyValue<bool?> _lEReasonIsOther;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsOther
        /// </summary>
        public bool? LEReasonIsOther { get => _lEReasonIsOther; set => _lEReasonIsOther = value; }
        private DirtyValue<bool?> _lEReasonIsRevisionsRequestedByConsumer;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonIsRevisionsRequestedByConsumer
        /// </summary>
        public bool? LEReasonIsRevisionsRequestedByConsumer { get => _lEReasonIsRevisionsRequestedByConsumer; set => _lEReasonIsRevisionsRequestedByConsumer = value; }
        private DirtyValue<string> _lEReasonOther;
        /// <summary>
        /// DisclosureTracking2015Log LEReasonOther
        /// </summary>
        public string LEReasonOther { get => _lEReasonOther; set => _lEReasonOther = value; }
        private DirtyValue<string> _line802LOCompAdditionalAmount1;
        /// <summary>
        /// DisclosureTracking2015Log Line802LOCompAdditionalAmount1
        /// </summary>
        public string Line802LOCompAdditionalAmount1 { get => _line802LOCompAdditionalAmount1; set => _line802LOCompAdditionalAmount1 = value; }
        private DirtyValue<string> _line802LOCompAdditionalAmount2;
        /// <summary>
        /// DisclosureTracking2015Log Line802LOCompAdditionalAmount2
        /// </summary>
        public string Line802LOCompAdditionalAmount2 { get => _line802LOCompAdditionalAmount2; set => _line802LOCompAdditionalAmount2 = value; }
        private DirtyValue<string> _line907InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line907InsuranceIndicator2015
        /// </summary>
        public string Line907InsuranceIndicator2015 { get => _line907InsuranceIndicator2015; set => _line907InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line907PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line907PropertyIndicator2015
        /// </summary>
        public string Line907PropertyIndicator2015 { get => _line907PropertyIndicator2015; set => _line907PropertyIndicator2015 = value; }
        private DirtyValue<string> _line907TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line907TaxesIndicator2015
        /// </summary>
        public string Line907TaxesIndicator2015 { get => _line907TaxesIndicator2015; set => _line907TaxesIndicator2015 = value; }
        private DirtyValue<string> _line908InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line908InsuranceIndicator2015
        /// </summary>
        public string Line908InsuranceIndicator2015 { get => _line908InsuranceIndicator2015; set => _line908InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line908PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line908PropertyIndicator2015
        /// </summary>
        public string Line908PropertyIndicator2015 { get => _line908PropertyIndicator2015; set => _line908PropertyIndicator2015 = value; }
        private DirtyValue<string> _line908TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line908TaxesIndicator2015
        /// </summary>
        public string Line908TaxesIndicator2015 { get => _line908TaxesIndicator2015; set => _line908TaxesIndicator2015 = value; }
        private DirtyValue<string> _line909InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line909InsuranceIndicator2015
        /// </summary>
        public string Line909InsuranceIndicator2015 { get => _line909InsuranceIndicator2015; set => _line909InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line909PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line909PropertyIndicator2015
        /// </summary>
        public string Line909PropertyIndicator2015 { get => _line909PropertyIndicator2015; set => _line909PropertyIndicator2015 = value; }
        private DirtyValue<string> _line909TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line909TaxesIndicator2015
        /// </summary>
        public string Line909TaxesIndicator2015 { get => _line909TaxesIndicator2015; set => _line909TaxesIndicator2015 = value; }
        private DirtyValue<string> _line910InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line910InsuranceIndicator2015
        /// </summary>
        public string Line910InsuranceIndicator2015 { get => _line910InsuranceIndicator2015; set => _line910InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line910PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line910PropertyIndicator2015
        /// </summary>
        public string Line910PropertyIndicator2015 { get => _line910PropertyIndicator2015; set => _line910PropertyIndicator2015 = value; }
        private DirtyValue<string> _line910TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line910TaxesIndicator2015
        /// </summary>
        public string Line910TaxesIndicator2015 { get => _line910TaxesIndicator2015; set => _line910TaxesIndicator2015 = value; }
        private DirtyValue<string> _line911InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line911InsuranceIndicator2015
        /// </summary>
        public string Line911InsuranceIndicator2015 { get => _line911InsuranceIndicator2015; set => _line911InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line911PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line911PropertyIndicator2015
        /// </summary>
        public string Line911PropertyIndicator2015 { get => _line911PropertyIndicator2015; set => _line911PropertyIndicator2015 = value; }
        private DirtyValue<string> _line911TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line911TaxesIndicator2015
        /// </summary>
        public string Line911TaxesIndicator2015 { get => _line911TaxesIndicator2015; set => _line911TaxesIndicator2015 = value; }
        private DirtyValue<string> _line912InsuranceIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line912InsuranceIndicator2015
        /// </summary>
        public string Line912InsuranceIndicator2015 { get => _line912InsuranceIndicator2015; set => _line912InsuranceIndicator2015 = value; }
        private DirtyValue<string> _line912PropertyIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line912PropertyIndicator2015
        /// </summary>
        public string Line912PropertyIndicator2015 { get => _line912PropertyIndicator2015; set => _line912PropertyIndicator2015 = value; }
        private DirtyValue<string> _line912TaxesIndicator2015;
        /// <summary>
        /// DisclosureTracking2015Log Line912TaxesIndicator2015
        /// </summary>
        public string Line912TaxesIndicator2015 { get => _line912TaxesIndicator2015; set => _line912TaxesIndicator2015 = value; }
        private DirtyValue<string> _loanAdjustmentsOtherCredits;
        /// <summary>
        /// DisclosureTracking2015Log LoanAdjustmentsOtherCredits
        /// </summary>
        public string LoanAdjustmentsOtherCredits { get => _loanAdjustmentsOtherCredits; set => _loanAdjustmentsOtherCredits = value; }
        private DirtyValue<string> _loanAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<string> _loanClosingCost2BorrowerClosingCostAtClosing;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2BorrowerClosingCostAtClosing
        /// </summary>
        public string LoanClosingCost2BorrowerClosingCostAtClosing { get => _loanClosingCost2BorrowerClosingCostAtClosing; set => _loanClosingCost2BorrowerClosingCostAtClosing = value; }
        private DirtyValue<string> _loanClosingCost2LenderCredits;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2LenderCredits
        /// </summary>
        public string LoanClosingCost2LenderCredits { get => _loanClosingCost2LenderCredits; set => _loanClosingCost2LenderCredits = value; }
        private DirtyValue<string> _loanClosingCost2TotalLoanCost;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2TotalLoanCost
        /// </summary>
        public string LoanClosingCost2TotalLoanCost { get => _loanClosingCost2TotalLoanCost; set => _loanClosingCost2TotalLoanCost = value; }
        private DirtyValue<string> _loanClosingCost2TotalOtherCost;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost2TotalOtherCost
        /// </summary>
        public string LoanClosingCost2TotalOtherCost { get => _loanClosingCost2TotalOtherCost; set => _loanClosingCost2TotalOtherCost = value; }
        private DirtyValue<string> _loanClosingCost3StdLegalLimit;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCost3StdLegalLimit
        /// </summary>
        public string LoanClosingCost3StdLegalLimit { get => _loanClosingCost3StdLegalLimit; set => _loanClosingCost3StdLegalLimit = value; }
        private DirtyValue<string> _loanClosingCostGfe1200BorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostGfe1200BorPaidAmount
        /// </summary>
        public string LoanClosingCostGfe1200BorPaidAmount { get => _loanClosingCostGfe1200BorPaidAmount; set => _loanClosingCostGfe1200BorPaidAmount = value; }
        private DirtyValue<string> _loanClosingCostGfe800BorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostGfe800BorPaidAmount
        /// </summary>
        public string LoanClosingCostGfe800BorPaidAmount { get => _loanClosingCostGfe800BorPaidAmount; set => _loanClosingCostGfe800BorPaidAmount = value; }
        private DirtyValue<string> _loanClosingCostLenderCredits;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostLenderCredits
        /// </summary>
        public string LoanClosingCostLenderCredits { get => _loanClosingCostLenderCredits; set => _loanClosingCostLenderCredits = value; }
        private DirtyValue<string> _loanClosingCostSection1000BorrowerTotalPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostSection1000BorrowerTotalPaidAmount
        /// </summary>
        public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get => _loanClosingCostSection1000BorrowerTotalPaidAmount; set => _loanClosingCostSection1000BorrowerTotalPaidAmount = value; }
        private DirtyValue<string> _loanClosingCostsFinanced;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostsFinanced
        /// </summary>
        public string LoanClosingCostsFinanced { get => _loanClosingCostsFinanced; set => _loanClosingCostsFinanced = value; }
        private DirtyValue<string> _loanClosingCostTotalFeeAmount2015;
        /// <summary>
        /// DisclosureTracking2015Log LoanClosingCostTotalFeeAmount2015
        /// </summary>
        public string LoanClosingCostTotalFeeAmount2015 { get => _loanClosingCostTotalFeeAmount2015; set => _loanClosingCostTotalFeeAmount2015 = value; }
        private DirtyValue<string> _loanDownPayment;
        /// <summary>
        /// DisclosureTracking2015Log LoanDownPayment
        /// </summary>
        public string LoanDownPayment { get => _loanDownPayment; set => _loanDownPayment = value; }
        private DirtyValue<string> _loanEstimate2TotalLoanAndOtherCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalLoanAndOtherCosts
        /// </summary>
        public string LoanEstimate2TotalLoanAndOtherCosts { get => _loanEstimate2TotalLoanAndOtherCosts; set => _loanEstimate2TotalLoanAndOtherCosts = value; }
        private DirtyValue<string> _loanEstimate2TotalLoanCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalLoanCosts
        /// </summary>
        public string LoanEstimate2TotalLoanCosts { get => _loanEstimate2TotalLoanCosts; set => _loanEstimate2TotalLoanCosts = value; }
        private DirtyValue<string> _loanEstimate2TotalOtherCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2TotalOtherCosts
        /// </summary>
        public string LoanEstimate2TotalOtherCosts { get => _loanEstimate2TotalOtherCosts; set => _loanEstimate2TotalOtherCosts = value; }
        private DirtyValue<string> _loanEstimate2UnroundedTotalLoanCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalLoanCosts
        /// </summary>
        public string LoanEstimate2UnroundedTotalLoanCosts { get => _loanEstimate2UnroundedTotalLoanCosts; set => _loanEstimate2UnroundedTotalLoanCosts = value; }
        private DirtyValue<string> _loanEstimate2UnroundedTotalOtherCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimate2UnroundedTotalOtherCosts
        /// </summary>
        public string LoanEstimate2UnroundedTotalOtherCosts { get => _loanEstimate2UnroundedTotalOtherCosts; set => _loanEstimate2UnroundedTotalOtherCosts = value; }
        private DirtyValue<string> _loanEstimateLoanProduct;
        /// <summary>
        /// DisclosureTracking2015Log LoanEstimateLoanProduct
        /// </summary>
        public string LoanEstimateLoanProduct { get => _loanEstimateLoanProduct; set => _loanEstimateLoanProduct = value; }
        private DirtyValue<string> _loanFeesCityTaxBorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanFeesCityTaxBorPaidAmount
        /// </summary>
        public string LoanFeesCityTaxBorPaidAmount { get => _loanFeesCityTaxBorPaidAmount; set => _loanFeesCityTaxBorPaidAmount = value; }
        private DirtyValue<string> _loanFeesStateTaxBorPaidAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanFeesStateTaxBorPaidAmount
        /// </summary>
        public string LoanFeesStateTaxBorPaidAmount { get => _loanFeesStateTaxBorPaidAmount; set => _loanFeesStateTaxBorPaidAmount = value; }
        private DirtyValue<string> _loanFundsForBorrower;
        /// <summary>
        /// DisclosureTracking2015Log LoanFundsForBorrower
        /// </summary>
        public string LoanFundsForBorrower { get => _loanFundsForBorrower; set => _loanFundsForBorrower = value; }
        private DirtyValue<string> _loanGfeAgregateAdjustment;
        /// <summary>
        /// DisclosureTracking2015Log LoanGfeAgregateAdjustment
        /// </summary>
        public string LoanGfeAgregateAdjustment { get => _loanGfeAgregateAdjustment; set => _loanGfeAgregateAdjustment = value; }
        private DirtyValue<string> _loanGfeGovermentRecordingCharges;
        /// <summary>
        /// DisclosureTracking2015Log LoanGfeGovermentRecordingCharges
        /// </summary>
        public string LoanGfeGovermentRecordingCharges { get => _loanGfeGovermentRecordingCharges; set => _loanGfeGovermentRecordingCharges = value; }
        private DirtyValue<string> _loanLineItemAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanLineItemAmount
        /// </summary>
        public string LoanLineItemAmount { get => _loanLineItemAmount; set => _loanLineItemAmount = value; }
        private DirtyValue<string> _loanProgram;
        /// <summary>
        /// DisclosureTracking2015Log LoanProgram
        /// </summary>
        public string LoanProgram { get => _loanProgram; set => _loanProgram = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount1;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount1
        /// </summary>
        public string LoanPurchaseCreditAmount1 { get => _loanPurchaseCreditAmount1; set => _loanPurchaseCreditAmount1 = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount2;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount2
        /// </summary>
        public string LoanPurchaseCreditAmount2 { get => _loanPurchaseCreditAmount2; set => _loanPurchaseCreditAmount2 = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount3;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount3
        /// </summary>
        public string LoanPurchaseCreditAmount3 { get => _loanPurchaseCreditAmount3; set => _loanPurchaseCreditAmount3 = value; }
        private DirtyValue<string> _loanPurchaseCreditAmount4;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditAmount4
        /// </summary>
        public string LoanPurchaseCreditAmount4 { get => _loanPurchaseCreditAmount4; set => _loanPurchaseCreditAmount4 = value; }
        private DirtyValue<string> _loanPurchaseCreditType1;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType1
        /// </summary>
        public string LoanPurchaseCreditType1 { get => _loanPurchaseCreditType1; set => _loanPurchaseCreditType1 = value; }
        private DirtyValue<string> _loanPurchaseCreditType2;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType2
        /// </summary>
        public string LoanPurchaseCreditType2 { get => _loanPurchaseCreditType2; set => _loanPurchaseCreditType2 = value; }
        private DirtyValue<string> _loanPurchaseCreditType3;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType3
        /// </summary>
        public string LoanPurchaseCreditType3 { get => _loanPurchaseCreditType3; set => _loanPurchaseCreditType3 = value; }
        private DirtyValue<string> _loanPurchaseCreditType4;
        /// <summary>
        /// DisclosureTracking2015Log LoanPurchaseCreditType4
        /// </summary>
        public string LoanPurchaseCreditType4 { get => _loanPurchaseCreditType4; set => _loanPurchaseCreditType4 = value; }
        private DirtyValue<string> _loanRefinanceIncludingDebtsToBePaidOffAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanRefinanceIncludingDebtsToBePaidOffAmount
        /// </summary>
        public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get => _loanRefinanceIncludingDebtsToBePaidOffAmount; set => _loanRefinanceIncludingDebtsToBePaidOffAmount = value; }
        private DirtyValue<string> _loanSection1000SellerPaidTotalAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanSection1000SellerPaidTotalAmount
        /// </summary>
        public string LoanSection1000SellerPaidTotalAmount { get => _loanSection1000SellerPaidTotalAmount; set => _loanSection1000SellerPaidTotalAmount = value; }
        private DirtyValue<string> _loanSellerCreditAmount;
        /// <summary>
        /// DisclosureTracking2015Log LoanSellerCreditAmount
        /// </summary>
        public string LoanSellerCreditAmount { get => _loanSellerCreditAmount; set => _loanSellerCreditAmount = value; }
        private DirtyValue<string> _loanTotalClosingCosts;
        /// <summary>
        /// DisclosureTracking2015Log LoanTotalClosingCosts
        /// </summary>
        public string LoanTotalClosingCosts { get => _loanTotalClosingCosts; set => _loanTotalClosingCosts = value; }
        private DirtyValue<DateTime?> _lockedBorrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log LockedBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedBorrowerPresumedReceivedDate { get => _lockedBorrowerPresumedReceivedDate; set => _lockedBorrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _lockedBorrowerType;
        /// <summary>
        /// DisclosureTracking2015Log LockedBorrowerType
        /// </summary>
        public string LockedBorrowerType { get => _lockedBorrowerType; set => _lockedBorrowerType = value; }
        private DirtyValue<DateTime?> _lockedCoBorrowerPresumedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log LockedCoBorrowerPresumedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedCoBorrowerPresumedReceivedDate { get => _lockedCoBorrowerPresumedReceivedDate; set => _lockedCoBorrowerPresumedReceivedDate = value; }
        private DirtyValue<string> _lockedCoBorrowerType;
        /// <summary>
        /// DisclosureTracking2015Log LockedCoBorrowerType
        /// </summary>
        public string LockedCoBorrowerType { get => _lockedCoBorrowerType; set => _lockedCoBorrowerType = value; }
        private DirtyValue<string> _lockedDisclosedAprField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedAprField
        /// </summary>
        public string LockedDisclosedAprField { get => _lockedDisclosedAprField; set => _lockedDisclosedAprField = value; }
        private DirtyValue<string> _lockedDisclosedByField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedByField
        /// </summary>
        public string LockedDisclosedByField { get => _lockedDisclosedByField; set => _lockedDisclosedByField = value; }
        private DirtyValue<string> _lockedDisclosedDailyInterestField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedDailyInterestField
        /// </summary>
        public string LockedDisclosedDailyInterestField { get => _lockedDisclosedDailyInterestField; set => _lockedDisclosedDailyInterestField = value; }
        private DirtyValue<DateTime?> _lockedDisclosedDateField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedDateField
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedDisclosedDateField { get => _lockedDisclosedDateField; set => _lockedDisclosedDateField = value; }
        private DirtyValue<string> _lockedDisclosedFinanceChargeField;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedFinanceChargeField
        /// </summary>
        public string LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => _lockedDisclosedFinanceChargeField = value; }
        private DirtyValue<DateTime?> _lockedDisclosedReceivedDate;
        /// <summary>
        /// DisclosureTracking2015Log LockedDisclosedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => _lockedDisclosedReceivedDate = value; }
        private DirtyValue<string> _lockedIntentReceivedByField;
        /// <summary>
        /// DisclosureTracking2015Log LockedIntentReceivedByField
        /// </summary>
        public string LockedIntentReceivedByField { get => _lockedIntentReceivedByField; set => _lockedIntentReceivedByField = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// DisclosureTracking2015Log LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _manuallyCreated;
        /// <summary>
        /// DisclosureTracking2015Log ManuallyCreated
        /// </summary>
        public string ManuallyCreated { get => _manuallyCreated; set => _manuallyCreated = value; }
        private DirtyValue<int?> _numberOfDisclosureDocs;
        /// <summary>
        /// DisclosureTracking2015Log NumberOfDisclosureDocs
        /// </summary>
        public int? NumberOfDisclosureDocs { get => _numberOfDisclosureDocs; set => _numberOfDisclosureDocs = value; }
        private DirtyValue<string> _prepaymentPenaltyIndicator;
        /// <summary>
        /// DisclosureTracking2015Log PrepaymentPenaltyIndicator
        /// </summary>
        public string PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => _prepaymentPenaltyIndicator = value; }
        private DirtyValue<DateTime?> _presumedFulfillmentDate;
        /// <summary>
        /// DisclosureTracking2015Log PresumedFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PresumedFulfillmentDate { get => _presumedFulfillmentDate; set => _presumedFulfillmentDate = value; }
        private DirtyValue<string> _propertyAddress;
        /// <summary>
        /// DisclosureTracking2015Log PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => _propertyAddress = value; }
        private DirtyValue<string> _propertyCity;
        /// <summary>
        /// DisclosureTracking2015Log PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => _propertyCity = value; }
        private DirtyValue<string> _propertyState;
        /// <summary>
        /// DisclosureTracking2015Log PropertyState
        /// </summary>
        public string PropertyState { get => _propertyState; set => _propertyState = value; }
        private DirtyValue<string> _propertyZip;
        /// <summary>
        /// DisclosureTracking2015Log PropertyZip
        /// </summary>
        public string PropertyZip { get => _propertyZip; set => _propertyZip = value; }
        private DirtyValue<bool?> _providerListSent;
        /// <summary>
        /// DisclosureTracking2015Log ProviderListSent
        /// </summary>
        public bool? ProviderListSent { get => _providerListSent; set => _providerListSent = value; }
        private DirtyValue<string> _purchasePriceAmount;
        /// <summary>
        /// DisclosureTracking2015Log PurchasePriceAmount
        /// </summary>
        public string PurchasePriceAmount { get => _purchasePriceAmount; set => _purchasePriceAmount = value; }
        private DirtyValue<DateTime?> _receivedDate;
        /// <summary>
        /// DisclosureTracking2015Log ReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReceivedDate { get => _receivedDate; set => _receivedDate = value; }
        private DirtyValue<DateTime?> _revisedDueDate;
        /// <summary>
        /// DisclosureTracking2015Log RevisedDueDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? RevisedDueDate { get => _revisedDueDate; set => _revisedDueDate = value; }
        private DirtyList<LogSnapshotField> _snapshotFields;
        /// <summary>
        /// DisclosureTracking2015Log SnapshotFields
        /// </summary>
        public IList<LogSnapshotField> SnapshotFields { get => _snapshotFields ?? (_snapshotFields = new DirtyList<LogSnapshotField>()); set => _snapshotFields = new DirtyList<LogSnapshotField>(value); }
        private DirtyValue<string> _snapshotXml;
        /// <summary>
        /// DisclosureTracking2015Log SnapshotXml
        /// </summary>
        public string SnapshotXml { get => _snapshotXml; set => _snapshotXml = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// DisclosureTracking2015Log SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
    }
}