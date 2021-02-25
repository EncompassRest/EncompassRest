using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// DisclosureTrackingLog
    /// </summary>
    public sealed partial class DisclosureTrackingLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert>? _alerts;
        private DirtyValue<string?>? _alertsXml;
        private DirtyValue<DateTime?>? _applicationDate;
        private DirtyValue<string?>? _borrowerName;
        private DirtyValue<string?>? _borrowerPairId;
        private DirtyValue<string?>? _coBorrowerName;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _commentListXml;
        private DirtyValue<string?>? _comments;
        private DirtyValue<bool?>? _containGfe;
        private DirtyValue<bool?>? _containSafeHarbor;
        private DirtyValue<bool?>? _containTil;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<string?>? _disclosedAPR;
        private DirtyValue<string?>? _disclosedBy;
        private DirtyValue<string?>? _disclosedByFullName;
        private DirtyValue<string?>? _disclosedMethod;
        private DirtyValue<DateTime?>? _disclosureCreatedDttmUtc;
        private DirtyValue<bool?>? _eDisclosureApplicationPackageIndicator;
        private DirtyValue<bool?>? _eDisclosureApprovalPackageIndicator;
        private DirtyValue<DateTime?>? _eDisclosureBorrowerAcceptConsentDate;
        private DirtyValue<DateTime?>? _eDisclosureBorrowereSignedDate;
        private DirtyValue<DateTime?>? _eDisclosureBorrowerRejectConsentDate;
        private DirtyValue<DateTime?>? _eDisclosureBorrowerViewConsentDate;
        private DirtyValue<DateTime?>? _eDisclosureBorrowerViewMessageDate;
        private DirtyValue<DateTime?>? _eDisclosureBorrowerWetSignedDate;
        private DirtyValue<DateTime?>? _eDisclosureCoBorrowerAcceptConsentDate;
        private DirtyValue<DateTime?>? _eDisclosureCoBorrowereSignedDate;
        private DirtyValue<DateTime?>? _eDisclosureCoBorrowerRejectConsentDate;
        private DirtyValue<DateTime?>? _eDisclosureCoBorrowerViewConsentDate;
        private DirtyValue<DateTime?>? _eDisclosureCoBorrowerViewMessageDate;
        private DirtyValue<DateTime?>? _eDisclosureCoBorrowerWebSignedDate;
        private DirtyValue<string?>? _eDisclosureConsentPdf;
        private DirtyValue<string?>? _eDisclosureDisclosedMessage;
        private DirtyValue<bool?>? _eDisclosureLockPackageIndicator;
        private DirtyValue<string?>? _eDisclosureManualFulfillmentComment;
        private DirtyValue<DateTime?>? _eDisclosureManualFulfillmentDate;
        private DirtyValue<string?>? _eDisclosureManualFulfillmentMethod;
        private DirtyValue<string?>? _eDisclosureManuallyFulfilledBy;
        private DirtyValue<DateTime?>? _eDisclosurePackageCreatedDate;
        private DirtyValue<string?>? _eDisclosurePackageId;
        private DirtyValue<string?>? _eDisclosurePackageViewableFile;
        private DirtyValue<bool?>? _eDisclosureThreeDayPackageIndicator;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<string?>? _financeCharge;
        private DirtyList<DisclosureForm>? _forms;
        private DirtyValue<string?>? _formsXml;
        private DirtyValue<string?>? _fulfillmentOrderedBy;
        private DirtyValue<string?>? _fullfillmentProcessedDate;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _isDisclosed;
        private DirtyValue<string?>? _isDisclosedAprLocked;
        private DirtyValue<string?>? _isDisclosedByLocked;
        private DirtyValue<string?>? _isDisclosedFinanceChargeLocked;
        private DirtyValue<string?>? _isDisclosedReceivedDateLocked;
        private DirtyValue<string?>? _isLocked;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<bool?>? _isWetSignedIndicator;
        private DirtyValue<string?>? _loanAmount;
        private DirtyValue<string?>? _loanProgram;
        private DirtyValue<string?>? _lockedDisclosedAprField;
        private DirtyValue<string?>? _lockedDisclosedByField;
        private DirtyValue<string?>? _lockedDisclosedFinanceChargeField;
        private DirtyValue<DateTime?>? _lockedDisclosedReceivedDate;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<string?>? _manuallyCreated;
        private DirtyValue<string?>? _propertyAddress;
        private DirtyValue<string?>? _propertyCity;
        private DirtyValue<string?>? _propertyState;
        private DirtyValue<string?>? _propertyZip;
        private DirtyValue<DateTime?>? _receivedDate;
        private DirtyList<LogSnapshotField>? _snapshotFields;
        private DirtyValue<string?>? _snapshotXml;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<DateTime?>? _updatedDateUtc;

        /// <summary>
        /// DisclosureTrackingLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// DisclosureTrackingLog AlertsXml
        /// </summary>
        public string? AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// DisclosureTrackingLog ApplicationDate
        /// </summary>
        public DateTime? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }

        /// <summary>
        /// DisclosureTrackingLog BorrowerName
        /// </summary>
        public string? BorrowerName { get => _borrowerName; set => SetField(ref _borrowerName, value); }

        /// <summary>
        /// DisclosureTrackingLog BorrowerPairId
        /// </summary>
        public string? BorrowerPairId { get => _borrowerPairId; set => SetField(ref _borrowerPairId, value); }

        /// <summary>
        /// DisclosureTrackingLog CoBorrowerName
        /// </summary>
        public string? CoBorrowerName { get => _coBorrowerName; set => SetField(ref _coBorrowerName, value); }

        /// <summary>
        /// DisclosureTrackingLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// DisclosureTrackingLog CommentListXml
        /// </summary>
        public string? CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// DisclosureTrackingLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// DisclosureTrackingLog ContainGfe
        /// </summary>
        public bool? ContainGfe { get => _containGfe; set => SetField(ref _containGfe, value); }

        /// <summary>
        /// DisclosureTrackingLog ContainSafeHarbor
        /// </summary>
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => SetField(ref _containSafeHarbor, value); }

        /// <summary>
        /// DisclosureTrackingLog ContainTil
        /// </summary>
        public bool? ContainTil { get => _containTil; set => SetField(ref _containTil, value); }

        /// <summary>
        /// DisclosureTrackingLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// DisclosureTrackingLog DisclosedAPR
        /// </summary>
        public string? DisclosedAPR { get => _disclosedAPR; set => SetField(ref _disclosedAPR, value); }

        /// <summary>
        /// DisclosureTrackingLog DisclosedBy
        /// </summary>
        public string? DisclosedBy { get => _disclosedBy; set => SetField(ref _disclosedBy, value); }

        /// <summary>
        /// DisclosureTrackingLog DisclosedByFullName
        /// </summary>
        public string? DisclosedByFullName { get => _disclosedByFullName; set => SetField(ref _disclosedByFullName, value); }

        /// <summary>
        /// DisclosureTrackingLog DisclosedMethod
        /// </summary>
        public string? DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }

        /// <summary>
        /// DisclosureTrackingLog DisclosureCreatedDttmUtc
        /// </summary>
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => SetField(ref _disclosureCreatedDttmUtc, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureApplicationPackageIndicator
        /// </summary>
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => SetField(ref _eDisclosureApplicationPackageIndicator, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureApprovalPackageIndicator
        /// </summary>
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => SetField(ref _eDisclosureApprovalPackageIndicator, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerAcceptConsentDate
        /// </summary>
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureBorrowerAcceptConsentDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowereSignedDate
        /// </summary>
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => SetField(ref _eDisclosureBorrowereSignedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerRejectConsentDate
        /// </summary>
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => SetField(ref _eDisclosureBorrowerRejectConsentDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerViewConsentDate
        /// </summary>
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => SetField(ref _eDisclosureBorrowerViewConsentDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerViewMessageDate
        /// </summary>
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => SetField(ref _eDisclosureBorrowerViewMessageDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerWetSignedDate
        /// </summary>
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => SetField(ref _eDisclosureBorrowerWetSignedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerAcceptConsentDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureCoBorrowerAcceptConsentDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowereSignedDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => SetField(ref _eDisclosureCoBorrowereSignedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerRejectConsentDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => SetField(ref _eDisclosureCoBorrowerRejectConsentDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerViewConsentDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => SetField(ref _eDisclosureCoBorrowerViewConsentDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerViewMessageDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => SetField(ref _eDisclosureCoBorrowerViewMessageDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerWebSignedDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => SetField(ref _eDisclosureCoBorrowerWebSignedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureConsentPdf
        /// </summary>
        public string? EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => SetField(ref _eDisclosureConsentPdf, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureDisclosedMessage
        /// </summary>
        public string? EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => SetField(ref _eDisclosureDisclosedMessage, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureLockPackageIndicator
        /// </summary>
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => SetField(ref _eDisclosureLockPackageIndicator, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentComment
        /// </summary>
        public string? EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => SetField(ref _eDisclosureManualFulfillmentComment, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentDate
        /// </summary>
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => SetField(ref _eDisclosureManualFulfillmentDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentMethod
        /// </summary>
        public string? EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => SetField(ref _eDisclosureManualFulfillmentMethod, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureManuallyFulfilledBy
        /// </summary>
        public string? EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => SetField(ref _eDisclosureManuallyFulfilledBy, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageCreatedDate
        /// </summary>
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => SetField(ref _eDisclosurePackageCreatedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageId
        /// </summary>
        public string? EDisclosurePackageId { get => _eDisclosurePackageId; set => SetField(ref _eDisclosurePackageId, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageViewableFile
        /// </summary>
        public string? EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => SetField(ref _eDisclosurePackageViewableFile, value); }

        /// <summary>
        /// DisclosureTrackingLog EDisclosureThreeDayPackageIndicator
        /// </summary>
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => SetField(ref _eDisclosureThreeDayPackageIndicator, value); }

        /// <summary>
        /// DisclosureTrackingLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// DisclosureTrackingLog FinanceCharge
        /// </summary>
        public string? FinanceCharge { get => _financeCharge; set => SetField(ref _financeCharge, value); }

        /// <summary>
        /// DisclosureTrackingLog Forms
        /// </summary>
        [AllowNull]
        public IList<DisclosureForm> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }

        /// <summary>
        /// DisclosureTrackingLog FormsXml
        /// </summary>
        public string? FormsXml { get => _formsXml; set => SetField(ref _formsXml, value); }

        /// <summary>
        /// DisclosureTrackingLog FulfillmentOrderedBy
        /// </summary>
        public string? FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => SetField(ref _fulfillmentOrderedBy, value); }

        /// <summary>
        /// DisclosureTrackingLog FullfillmentProcessedDate
        /// </summary>
        public string? FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => SetField(ref _fullfillmentProcessedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// DisclosureTrackingLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// DisclosureTrackingLog IsDisclosed
        /// </summary>
        public string? IsDisclosed { get => _isDisclosed; set => SetField(ref _isDisclosed, value); }

        /// <summary>
        /// DisclosureTrackingLog IsDisclosedAprLocked
        /// </summary>
        public string? IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => SetField(ref _isDisclosedAprLocked, value); }

        /// <summary>
        /// DisclosureTrackingLog IsDisclosedByLocked
        /// </summary>
        public string? IsDisclosedByLocked { get => _isDisclosedByLocked; set => SetField(ref _isDisclosedByLocked, value); }

        /// <summary>
        /// DisclosureTrackingLog IsDisclosedFinanceChargeLocked
        /// </summary>
        public string? IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => SetField(ref _isDisclosedFinanceChargeLocked, value); }

        /// <summary>
        /// DisclosureTrackingLog IsDisclosedReceivedDateLocked
        /// </summary>
        public string? IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => SetField(ref _isDisclosedReceivedDateLocked, value); }

        /// <summary>
        /// DisclosureTrackingLog IsLocked
        /// </summary>
        public string? IsLocked { get => _isLocked; set => SetField(ref _isLocked, value); }

        /// <summary>
        /// DisclosureTrackingLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// DisclosureTrackingLog IsWetSignedIndicator
        /// </summary>
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => SetField(ref _isWetSignedIndicator, value); }

        /// <summary>
        /// DisclosureTrackingLog LoanAmount
        /// </summary>
        public string? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

        /// <summary>
        /// DisclosureTrackingLog LoanProgram
        /// </summary>
        public string? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }

        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedAprField
        /// </summary>
        public string? LockedDisclosedAprField { get => _lockedDisclosedAprField; set => SetField(ref _lockedDisclosedAprField, value); }

        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedByField
        /// </summary>
        public string? LockedDisclosedByField { get => _lockedDisclosedByField; set => SetField(ref _lockedDisclosedByField, value); }

        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedFinanceChargeField
        /// </summary>
        public string? LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => SetField(ref _lockedDisclosedFinanceChargeField, value); }

        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedReceivedDate
        /// </summary>
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => SetField(ref _lockedDisclosedReceivedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// DisclosureTrackingLog ManuallyCreated
        /// </summary>
        public string? ManuallyCreated { get => _manuallyCreated; set => SetField(ref _manuallyCreated, value); }

        /// <summary>
        /// DisclosureTrackingLog PropertyAddress
        /// </summary>
        public string? PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }

        /// <summary>
        /// DisclosureTrackingLog PropertyCity
        /// </summary>
        public string? PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }

        /// <summary>
        /// DisclosureTrackingLog PropertyState
        /// </summary>
        public string? PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }

        /// <summary>
        /// DisclosureTrackingLog PropertyZip
        /// </summary>
        public string? PropertyZip { get => _propertyZip; set => SetField(ref _propertyZip, value); }

        /// <summary>
        /// DisclosureTrackingLog ReceivedDate
        /// </summary>
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

        /// <summary>
        /// DisclosureTrackingLog SnapshotFields
        /// </summary>
        [AllowNull]
        public IList<LogSnapshotField> SnapshotFields { get => GetField(ref _snapshotFields); set => SetField(ref _snapshotFields, value); }

        /// <summary>
        /// DisclosureTrackingLog SnapshotXml
        /// </summary>
        public string? SnapshotXml { get => _snapshotXml; set => SetField(ref _snapshotXml, value); }

        /// <summary>
        /// DisclosureTrackingLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// DisclosureTrackingLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}