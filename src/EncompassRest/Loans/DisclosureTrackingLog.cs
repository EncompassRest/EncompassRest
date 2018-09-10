using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DisclosureTrackingLog
    /// </summary>
    public sealed partial class DisclosureTrackingLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// DisclosureTrackingLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// DisclosureTrackingLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }
        private DirtyValue<DateTime?> _applicationDate;
        /// <summary>
        /// DisclosureTrackingLog ApplicationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }
        private DirtyValue<string> _borrowerName;
        /// <summary>
        /// DisclosureTrackingLog BorrowerName
        /// </summary>
        public string BorrowerName { get => _borrowerName; set => SetField(ref _borrowerName, value); }
        private DirtyValue<string> _borrowerPairId;
        /// <summary>
        /// DisclosureTrackingLog BorrowerPairId
        /// </summary>
        public string BorrowerPairId { get => _borrowerPairId; set => SetField(ref _borrowerPairId, value); }
        private DirtyValue<string> _coBorrowerName;
        /// <summary>
        /// DisclosureTrackingLog CoBorrowerName
        /// </summary>
        public string CoBorrowerName { get => _coBorrowerName; set => SetField(ref _coBorrowerName, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// DisclosureTrackingLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// DisclosureTrackingLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// DisclosureTrackingLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<bool?> _containGfe;
        /// <summary>
        /// DisclosureTrackingLog ContainGfe
        /// </summary>
        public bool? ContainGfe { get => _containGfe; set => SetField(ref _containGfe, value); }
        private DirtyValue<bool?> _containSafeHarbor;
        /// <summary>
        /// DisclosureTrackingLog ContainSafeHarbor
        /// </summary>
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => SetField(ref _containSafeHarbor, value); }
        private DirtyValue<bool?> _containTil;
        /// <summary>
        /// DisclosureTrackingLog ContainTil
        /// </summary>
        public bool? ContainTil { get => _containTil; set => SetField(ref _containTil, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DisclosureTrackingLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<string> _disclosedAPR;
        /// <summary>
        /// DisclosureTrackingLog DisclosedAPR
        /// </summary>
        public string DisclosedAPR { get => _disclosedAPR; set => SetField(ref _disclosedAPR, value); }
        private DirtyValue<string> _disclosedBy;
        /// <summary>
        /// DisclosureTrackingLog DisclosedBy
        /// </summary>
        public string DisclosedBy { get => _disclosedBy; set => SetField(ref _disclosedBy, value); }
        private DirtyValue<string> _disclosedByFullName;
        /// <summary>
        /// DisclosureTrackingLog DisclosedByFullName
        /// </summary>
        public string DisclosedByFullName { get => _disclosedByFullName; set => SetField(ref _disclosedByFullName, value); }
        private DirtyValue<string> _disclosedMethod;
        /// <summary>
        /// DisclosureTrackingLog DisclosedMethod
        /// </summary>
        public string DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }
        private DirtyValue<DateTime?> _disclosureCreatedDttmUtc;
        /// <summary>
        /// DisclosureTrackingLog DisclosureCreatedDttmUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => SetField(ref _disclosureCreatedDttmUtc, value); }
        private DirtyValue<bool?> _eDisclosureApplicationPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureApplicationPackageIndicator
        /// </summary>
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => SetField(ref _eDisclosureApplicationPackageIndicator, value); }
        private DirtyValue<bool?> _eDisclosureApprovalPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureApprovalPackageIndicator
        /// </summary>
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => SetField(ref _eDisclosureApprovalPackageIndicator, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureBorrowerAcceptConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowereSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => SetField(ref _eDisclosureBorrowereSignedDate, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => SetField(ref _eDisclosureBorrowerRejectConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => SetField(ref _eDisclosureBorrowerViewConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => SetField(ref _eDisclosureBorrowerViewMessageDate, value); }
        private DirtyValue<DateTime?> _eDisclosureBorrowerWetSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerWetSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => SetField(ref _eDisclosureBorrowerWetSignedDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerAcceptConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureCoBorrowerAcceptConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowereSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowereSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => SetField(ref _eDisclosureCoBorrowereSignedDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerRejectConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => SetField(ref _eDisclosureCoBorrowerRejectConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerViewConsentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => SetField(ref _eDisclosureCoBorrowerViewConsentDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerViewMessageDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => SetField(ref _eDisclosureCoBorrowerViewMessageDate, value); }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerWebSignedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => SetField(ref _eDisclosureCoBorrowerWebSignedDate, value); }
        private DirtyValue<string> _eDisclosureConsentPdf;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureConsentPdf
        /// </summary>
        public string EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => SetField(ref _eDisclosureConsentPdf, value); }
        private DirtyValue<string> _eDisclosureDisclosedMessage;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureDisclosedMessage
        /// </summary>
        public string EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => SetField(ref _eDisclosureDisclosedMessage, value); }
        private DirtyValue<bool?> _eDisclosureLockPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureLockPackageIndicator
        /// </summary>
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => SetField(ref _eDisclosureLockPackageIndicator, value); }
        private DirtyValue<string> _eDisclosureManualFulfillmentComment;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentComment
        /// </summary>
        public string EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => SetField(ref _eDisclosureManualFulfillmentComment, value); }
        private DirtyValue<DateTime?> _eDisclosureManualFulfillmentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => SetField(ref _eDisclosureManualFulfillmentDate, value); }
        private DirtyValue<string> _eDisclosureManualFulfillmentMethod;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentMethod
        /// </summary>
        public string EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => SetField(ref _eDisclosureManualFulfillmentMethod, value); }
        private DirtyValue<string> _eDisclosureManuallyFulfilledBy;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManuallyFulfilledBy
        /// </summary>
        public string EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => SetField(ref _eDisclosureManuallyFulfilledBy, value); }
        private DirtyValue<DateTime?> _eDisclosurePackageCreatedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageCreatedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => SetField(ref _eDisclosurePackageCreatedDate, value); }
        private DirtyValue<string> _eDisclosurePackageId;
        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageId
        /// </summary>
        public string EDisclosurePackageId { get => _eDisclosurePackageId; set => SetField(ref _eDisclosurePackageId, value); }
        private DirtyValue<string> _eDisclosurePackageViewableFile;
        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageViewableFile
        /// </summary>
        public string EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => SetField(ref _eDisclosurePackageViewableFile, value); }
        private DirtyValue<bool?> _eDisclosureThreeDayPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureThreeDayPackageIndicator
        /// </summary>
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => SetField(ref _eDisclosureThreeDayPackageIndicator, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// DisclosureTrackingLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _financeCharge;
        /// <summary>
        /// DisclosureTrackingLog FinanceCharge
        /// </summary>
        public string FinanceCharge { get => _financeCharge; set => SetField(ref _financeCharge, value); }
        private DirtyList<DisclosureForm> _forms;
        /// <summary>
        /// DisclosureTrackingLog Forms
        /// </summary>
        public IList<DisclosureForm> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }
        private DirtyValue<string> _formsXml;
        /// <summary>
        /// DisclosureTrackingLog FormsXml
        /// </summary>
        public string FormsXml { get => _formsXml; set => SetField(ref _formsXml, value); }
        private DirtyValue<string> _fulfillmentOrderedBy;
        /// <summary>
        /// DisclosureTrackingLog FulfillmentOrderedBy
        /// </summary>
        public string FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => SetField(ref _fulfillmentOrderedBy, value); }
        private DirtyValue<string> _fullfillmentProcessedDate;
        /// <summary>
        /// DisclosureTrackingLog FullfillmentProcessedDate
        /// </summary>
        public string FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => SetField(ref _fullfillmentProcessedDate, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// DisclosureTrackingLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// DisclosureTrackingLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _isDisclosed;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosed
        /// </summary>
        public string IsDisclosed { get => _isDisclosed; set => SetField(ref _isDisclosed, value); }
        private DirtyValue<string> _isDisclosedAprLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedAprLocked
        /// </summary>
        public string IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => SetField(ref _isDisclosedAprLocked, value); }
        private DirtyValue<string> _isDisclosedByLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedByLocked
        /// </summary>
        public string IsDisclosedByLocked { get => _isDisclosedByLocked; set => SetField(ref _isDisclosedByLocked, value); }
        private DirtyValue<string> _isDisclosedFinanceChargeLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedFinanceChargeLocked
        /// </summary>
        public string IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => SetField(ref _isDisclosedFinanceChargeLocked, value); }
        private DirtyValue<string> _isDisclosedReceivedDateLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedReceivedDateLocked
        /// </summary>
        public string IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => SetField(ref _isDisclosedReceivedDateLocked, value); }
        private DirtyValue<string> _isLocked;
        /// <summary>
        /// DisclosureTrackingLog IsLocked
        /// </summary>
        public string IsLocked { get => _isLocked; set => SetField(ref _isLocked, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// DisclosureTrackingLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<bool?> _isWetSignedIndicator;
        /// <summary>
        /// DisclosureTrackingLog IsWetSignedIndicator
        /// </summary>
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => SetField(ref _isWetSignedIndicator, value); }
        private DirtyValue<string> _loanAmount;
        /// <summary>
        /// DisclosureTrackingLog LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }
        private DirtyValue<string> _loanProgram;
        /// <summary>
        /// DisclosureTrackingLog LoanProgram
        /// </summary>
        public string LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }
        private DirtyValue<string> _lockedDisclosedAprField;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedAprField
        /// </summary>
        public string LockedDisclosedAprField { get => _lockedDisclosedAprField; set => SetField(ref _lockedDisclosedAprField, value); }
        private DirtyValue<string> _lockedDisclosedByField;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedByField
        /// </summary>
        public string LockedDisclosedByField { get => _lockedDisclosedByField; set => SetField(ref _lockedDisclosedByField, value); }
        private DirtyValue<string> _lockedDisclosedFinanceChargeField;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedFinanceChargeField
        /// </summary>
        public string LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => SetField(ref _lockedDisclosedFinanceChargeField, value); }
        private DirtyValue<DateTime?> _lockedDisclosedReceivedDate;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => SetField(ref _lockedDisclosedReceivedDate, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// DisclosureTrackingLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _manuallyCreated;
        /// <summary>
        /// DisclosureTrackingLog ManuallyCreated
        /// </summary>
        public string ManuallyCreated { get => _manuallyCreated; set => SetField(ref _manuallyCreated, value); }
        private DirtyValue<string> _propertyAddress;
        /// <summary>
        /// DisclosureTrackingLog PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }
        private DirtyValue<string> _propertyCity;
        /// <summary>
        /// DisclosureTrackingLog PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }
        private DirtyValue<string> _propertyState;
        /// <summary>
        /// DisclosureTrackingLog PropertyState
        /// </summary>
        public string PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }
        private DirtyValue<string> _propertyZip;
        /// <summary>
        /// DisclosureTrackingLog PropertyZip
        /// </summary>
        public string PropertyZip { get => _propertyZip; set => SetField(ref _propertyZip, value); }
        private DirtyValue<DateTime?> _receivedDate;
        /// <summary>
        /// DisclosureTrackingLog ReceivedDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }
        private DirtyList<LogSnapshotField> _snapshotFields;
        /// <summary>
        /// DisclosureTrackingLog SnapshotFields
        /// </summary>
        public IList<LogSnapshotField> SnapshotFields { get => GetField(ref _snapshotFields); set => SetField(ref _snapshotFields, value); }
        private DirtyValue<string> _snapshotXml;
        /// <summary>
        /// DisclosureTrackingLog SnapshotXml
        /// </summary>
        public string SnapshotXml { get => _snapshotXml; set => SetField(ref _snapshotXml, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// DisclosureTrackingLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}