using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DisclosureTrackingLog
    /// </summary>
    public sealed partial class DisclosureTrackingLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// DisclosureTrackingLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// DisclosureTrackingLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<DateTime?> _applicationDate;
        /// <summary>
        /// DisclosureTrackingLog ApplicationDate
        /// </summary>
        public DateTime? ApplicationDate { get => _applicationDate; set => _applicationDate = value; }
        private DirtyValue<string> _borrowerName;
        /// <summary>
        /// DisclosureTrackingLog BorrowerName
        /// </summary>
        public string BorrowerName { get => _borrowerName; set => _borrowerName = value; }
        private DirtyValue<string> _borrowerPairId;
        /// <summary>
        /// DisclosureTrackingLog BorrowerPairId
        /// </summary>
        public string BorrowerPairId { get => _borrowerPairId; set => _borrowerPairId = value; }
        private DirtyValue<string> _coBorrowerName;
        /// <summary>
        /// DisclosureTrackingLog CoBorrowerName
        /// </summary>
        public string CoBorrowerName { get => _coBorrowerName; set => _coBorrowerName = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// DisclosureTrackingLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// DisclosureTrackingLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// DisclosureTrackingLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<bool?> _containGfe;
        /// <summary>
        /// DisclosureTrackingLog ContainGfe
        /// </summary>
        public bool? ContainGfe { get => _containGfe; set => _containGfe = value; }
        private DirtyValue<bool?> _containSafeHarbor;
        /// <summary>
        /// DisclosureTrackingLog ContainSafeHarbor
        /// </summary>
        public bool? ContainSafeHarbor { get => _containSafeHarbor; set => _containSafeHarbor = value; }
        private DirtyValue<bool?> _containTil;
        /// <summary>
        /// DisclosureTrackingLog ContainTil
        /// </summary>
        public bool? ContainTil { get => _containTil; set => _containTil = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DisclosureTrackingLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _disclosedAPR;
        /// <summary>
        /// DisclosureTrackingLog DisclosedAPR
        /// </summary>
        public string DisclosedAPR { get => _disclosedAPR; set => _disclosedAPR = value; }
        private DirtyValue<string> _disclosedBy;
        /// <summary>
        /// DisclosureTrackingLog DisclosedBy
        /// </summary>
        public string DisclosedBy { get => _disclosedBy; set => _disclosedBy = value; }
        private DirtyValue<string> _disclosedByFullName;
        /// <summary>
        /// DisclosureTrackingLog DisclosedByFullName
        /// </summary>
        public string DisclosedByFullName { get => _disclosedByFullName; set => _disclosedByFullName = value; }
        private DirtyValue<string> _disclosedMethod;
        /// <summary>
        /// DisclosureTrackingLog DisclosedMethod
        /// </summary>
        public string DisclosedMethod { get => _disclosedMethod; set => _disclosedMethod = value; }
        private DirtyValue<DateTime?> _disclosureCreatedDttmUtc;
        /// <summary>
        /// DisclosureTrackingLog DisclosureCreatedDttmUtc
        /// </summary>
        public DateTime? DisclosureCreatedDttmUtc { get => _disclosureCreatedDttmUtc; set => _disclosureCreatedDttmUtc = value; }
        private DirtyValue<bool?> _eDisclosureApplicationPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureApplicationPackageIndicator
        /// </summary>
        public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => _eDisclosureApplicationPackageIndicator = value; }
        private DirtyValue<bool?> _eDisclosureApprovalPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureApprovalPackageIndicator
        /// </summary>
        public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => _eDisclosureApprovalPackageIndicator = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerAcceptConsentDate
        /// </summary>
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => _eDisclosureBorrowerAcceptConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowereSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowereSignedDate
        /// </summary>
        public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => _eDisclosureBorrowereSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerRejectConsentDate
        /// </summary>
        public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => _eDisclosureBorrowerRejectConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerViewConsentDate
        /// </summary>
        public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => _eDisclosureBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerViewMessageDate
        /// </summary>
        public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => _eDisclosureBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureBorrowerWetSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureBorrowerWetSignedDate
        /// </summary>
        public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => _eDisclosureBorrowerWetSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerAcceptConsentDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => _eDisclosureCoBorrowerAcceptConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowereSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowereSignedDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => _eDisclosureCoBorrowereSignedDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerRejectConsentDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => _eDisclosureCoBorrowerRejectConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerViewConsentDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => _eDisclosureCoBorrowerViewConsentDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerViewMessageDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => _eDisclosureCoBorrowerViewMessageDate = value; }
        private DirtyValue<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureCoBorrowerWebSignedDate
        /// </summary>
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => _eDisclosureCoBorrowerWebSignedDate = value; }
        private DirtyValue<string> _eDisclosureConsentPdf;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureConsentPdf
        /// </summary>
        public string EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => _eDisclosureConsentPdf = value; }
        private DirtyValue<string> _eDisclosureDisclosedMessage;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureDisclosedMessage
        /// </summary>
        public string EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => _eDisclosureDisclosedMessage = value; }
        private DirtyValue<bool?> _eDisclosureLockPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureLockPackageIndicator
        /// </summary>
        public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => _eDisclosureLockPackageIndicator = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentComment;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentComment
        /// </summary>
        public string EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => _eDisclosureManualFulfillmentComment = value; }
        private DirtyValue<DateTime?> _eDisclosureManualFulfillmentDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentDate
        /// </summary>
        public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => _eDisclosureManualFulfillmentDate = value; }
        private DirtyValue<string> _eDisclosureManualFulfillmentMethod;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManualFulfillmentMethod
        /// </summary>
        public string EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => _eDisclosureManualFulfillmentMethod = value; }
        private DirtyValue<string> _eDisclosureManuallyFulfilledBy;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureManuallyFulfilledBy
        /// </summary>
        public string EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => _eDisclosureManuallyFulfilledBy = value; }
        private DirtyValue<DateTime?> _eDisclosurePackageCreatedDate;
        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageCreatedDate
        /// </summary>
        public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => _eDisclosurePackageCreatedDate = value; }
        private DirtyValue<string> _eDisclosurePackageId;
        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageId
        /// </summary>
        public string EDisclosurePackageId { get => _eDisclosurePackageId; set => _eDisclosurePackageId = value; }
        private DirtyValue<string> _eDisclosurePackageViewableFile;
        /// <summary>
        /// DisclosureTrackingLog EDisclosurePackageViewableFile
        /// </summary>
        public string EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => _eDisclosurePackageViewableFile = value; }
        private DirtyValue<bool?> _eDisclosureThreeDayPackageIndicator;
        /// <summary>
        /// DisclosureTrackingLog EDisclosureThreeDayPackageIndicator
        /// </summary>
        public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => _eDisclosureThreeDayPackageIndicator = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// DisclosureTrackingLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _financeCharge;
        /// <summary>
        /// DisclosureTrackingLog FinanceCharge
        /// </summary>
        public string FinanceCharge { get => _financeCharge; set => _financeCharge = value; }
        private DirtyList<DisclosureForm> _forms;
        /// <summary>
        /// DisclosureTrackingLog Forms
        /// </summary>
        public IList<DisclosureForm> Forms { get => _forms ?? (_forms = new DirtyList<DisclosureForm>()); set => _forms = new DirtyList<DisclosureForm>(value); }
        private DirtyValue<string> _formsXml;
        /// <summary>
        /// DisclosureTrackingLog FormsXml
        /// </summary>
        public string FormsXml { get => _formsXml; set => _formsXml = value; }
        private DirtyValue<string> _fulfillmentOrderedBy;
        /// <summary>
        /// DisclosureTrackingLog FulfillmentOrderedBy
        /// </summary>
        public string FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => _fulfillmentOrderedBy = value; }
        private DirtyValue<string> _fullfillmentProcessedDate;
        /// <summary>
        /// DisclosureTrackingLog FullfillmentProcessedDate
        /// </summary>
        public string FullfillmentProcessedDate { get => _fullfillmentProcessedDate; set => _fullfillmentProcessedDate = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// DisclosureTrackingLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// DisclosureTrackingLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _isDisclosed;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosed
        /// </summary>
        public string IsDisclosed { get => _isDisclosed; set => _isDisclosed = value; }
        private DirtyValue<string> _isDisclosedAprLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedAprLocked
        /// </summary>
        public string IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => _isDisclosedAprLocked = value; }
        private DirtyValue<string> _isDisclosedByLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedByLocked
        /// </summary>
        public string IsDisclosedByLocked { get => _isDisclosedByLocked; set => _isDisclosedByLocked = value; }
        private DirtyValue<string> _isDisclosedFinanceChargeLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedFinanceChargeLocked
        /// </summary>
        public string IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => _isDisclosedFinanceChargeLocked = value; }
        private DirtyValue<string> _isDisclosedReceivedDateLocked;
        /// <summary>
        /// DisclosureTrackingLog IsDisclosedReceivedDateLocked
        /// </summary>
        public string IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => _isDisclosedReceivedDateLocked = value; }
        private DirtyValue<string> _isLocked;
        /// <summary>
        /// DisclosureTrackingLog IsLocked
        /// </summary>
        public string IsLocked { get => _isLocked; set => _isLocked = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// DisclosureTrackingLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<bool?> _isWetSignedIndicator;
        /// <summary>
        /// DisclosureTrackingLog IsWetSignedIndicator
        /// </summary>
        public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => _isWetSignedIndicator = value; }
        private DirtyValue<string> _loanAmount;
        /// <summary>
        /// DisclosureTrackingLog LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<string> _loanProgram;
        /// <summary>
        /// DisclosureTrackingLog LoanProgram
        /// </summary>
        public string LoanProgram { get => _loanProgram; set => _loanProgram = value; }
        private DirtyValue<string> _lockedDisclosedAprField;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedAprField
        /// </summary>
        public string LockedDisclosedAprField { get => _lockedDisclosedAprField; set => _lockedDisclosedAprField = value; }
        private DirtyValue<string> _lockedDisclosedByField;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedByField
        /// </summary>
        public string LockedDisclosedByField { get => _lockedDisclosedByField; set => _lockedDisclosedByField = value; }
        private DirtyValue<string> _lockedDisclosedFinanceChargeField;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedFinanceChargeField
        /// </summary>
        public string LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => _lockedDisclosedFinanceChargeField = value; }
        private DirtyValue<DateTime?> _lockedDisclosedReceivedDate;
        /// <summary>
        /// DisclosureTrackingLog LockedDisclosedReceivedDate
        /// </summary>
        public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => _lockedDisclosedReceivedDate = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// DisclosureTrackingLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _manuallyCreated;
        /// <summary>
        /// DisclosureTrackingLog ManuallyCreated
        /// </summary>
        public string ManuallyCreated { get => _manuallyCreated; set => _manuallyCreated = value; }
        private DirtyValue<string> _propertyAddress;
        /// <summary>
        /// DisclosureTrackingLog PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => _propertyAddress = value; }
        private DirtyValue<string> _propertyCity;
        /// <summary>
        /// DisclosureTrackingLog PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => _propertyCity = value; }
        private DirtyValue<string> _propertyState;
        /// <summary>
        /// DisclosureTrackingLog PropertyState
        /// </summary>
        public string PropertyState { get => _propertyState; set => _propertyState = value; }
        private DirtyValue<string> _propertyZip;
        /// <summary>
        /// DisclosureTrackingLog PropertyZip
        /// </summary>
        public string PropertyZip { get => _propertyZip; set => _propertyZip = value; }
        private DirtyValue<DateTime?> _receivedDate;
        /// <summary>
        /// DisclosureTrackingLog ReceivedDate
        /// </summary>
        public DateTime? ReceivedDate { get => _receivedDate; set => _receivedDate = value; }
        private DirtyList<LogSnapshotField> _snapshotFields;
        /// <summary>
        /// DisclosureTrackingLog SnapshotFields
        /// </summary>
        public IList<LogSnapshotField> SnapshotFields { get => _snapshotFields ?? (_snapshotFields = new DirtyList<LogSnapshotField>()); set => _snapshotFields = new DirtyList<LogSnapshotField>(value); }
        private DirtyValue<string> _snapshotXml;
        /// <summary>
        /// DisclosureTrackingLog SnapshotXml
        /// </summary>
        public string SnapshotXml { get => _snapshotXml; set => _snapshotXml = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// DisclosureTrackingLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get => _alertsXml.Dirty
                || _applicationDate.Dirty
                || _borrowerName.Dirty
                || _borrowerPairId.Dirty
                || _coBorrowerName.Dirty
                || _commentListXml.Dirty
                || _comments.Dirty
                || _containGfe.Dirty
                || _containSafeHarbor.Dirty
                || _containTil.Dirty
                || _dateUtc.Dirty
                || _disclosedAPR.Dirty
                || _disclosedBy.Dirty
                || _disclosedByFullName.Dirty
                || _disclosedMethod.Dirty
                || _disclosureCreatedDttmUtc.Dirty
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
                || _fileAttachmentsMigrated.Dirty
                || _financeCharge.Dirty
                || _formsXml.Dirty
                || _fulfillmentOrderedBy.Dirty
                || _fullfillmentProcessedDate.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _isDisclosed.Dirty
                || _isDisclosedAprLocked.Dirty
                || _isDisclosedByLocked.Dirty
                || _isDisclosedFinanceChargeLocked.Dirty
                || _isDisclosedReceivedDateLocked.Dirty
                || _isLocked.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _isWetSignedIndicator.Dirty
                || _loanAmount.Dirty
                || _loanProgram.Dirty
                || _lockedDisclosedAprField.Dirty
                || _lockedDisclosedByField.Dirty
                || _lockedDisclosedFinanceChargeField.Dirty
                || _lockedDisclosedReceivedDate.Dirty
                || _logRecordIndex.Dirty
                || _manuallyCreated.Dirty
                || _propertyAddress.Dirty
                || _propertyCity.Dirty
                || _propertyState.Dirty
                || _propertyZip.Dirty
                || _receivedDate.Dirty
                || _snapshotXml.Dirty
                || _systemId.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true
                || _forms?.Dirty == true
                || _snapshotFields?.Dirty == true;
            set
            {
                _alertsXml.Dirty = value;
                _applicationDate.Dirty = value;
                _borrowerName.Dirty = value;
                _borrowerPairId.Dirty = value;
                _coBorrowerName.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _containGfe.Dirty = value;
                _containSafeHarbor.Dirty = value;
                _containTil.Dirty = value;
                _dateUtc.Dirty = value;
                _disclosedAPR.Dirty = value;
                _disclosedBy.Dirty = value;
                _disclosedByFullName.Dirty = value;
                _disclosedMethod.Dirty = value;
                _disclosureCreatedDttmUtc.Dirty = value;
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
                _fileAttachmentsMigrated.Dirty = value;
                _financeCharge.Dirty = value;
                _formsXml.Dirty = value;
                _fulfillmentOrderedBy.Dirty = value;
                _fullfillmentProcessedDate.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isDisclosed.Dirty = value;
                _isDisclosedAprLocked.Dirty = value;
                _isDisclosedByLocked.Dirty = value;
                _isDisclosedFinanceChargeLocked.Dirty = value;
                _isDisclosedReceivedDateLocked.Dirty = value;
                _isLocked.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _isWetSignedIndicator.Dirty = value;
                _loanAmount.Dirty = value;
                _loanProgram.Dirty = value;
                _lockedDisclosedAprField.Dirty = value;
                _lockedDisclosedByField.Dirty = value;
                _lockedDisclosedFinanceChargeField.Dirty = value;
                _lockedDisclosedReceivedDate.Dirty = value;
                _logRecordIndex.Dirty = value;
                _manuallyCreated.Dirty = value;
                _propertyAddress.Dirty = value;
                _propertyCity.Dirty = value;
                _propertyState.Dirty = value;
                _propertyZip.Dirty = value;
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