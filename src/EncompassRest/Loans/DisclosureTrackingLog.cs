using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTrackingLog : IClean
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        private Value<string> _borrowerName;
        public string BorrowerName { get { return _borrowerName; } set { _borrowerName = value; } }
        private Value<string> _borrowerPairId;
        public string BorrowerPairId { get { return _borrowerPairId; } set { _borrowerPairId = value; } }
        private Value<string> _coBorrowerName;
        public string CoBorrowerName { get { return _coBorrowerName; } set { _coBorrowerName = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<bool?> _containGfe;
        public bool? ContainGfe { get { return _containGfe; } set { _containGfe = value; } }
        private Value<bool?> _containSafeHarbor;
        public bool? ContainSafeHarbor { get { return _containSafeHarbor; } set { _containSafeHarbor = value; } }
        private Value<bool?> _containTil;
        public bool? ContainTil { get { return _containTil; } set { _containTil = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<string> _disclosedAPR;
        public string DisclosedAPR { get { return _disclosedAPR; } set { _disclosedAPR = value; } }
        private Value<string> _disclosedBy;
        public string DisclosedBy { get { return _disclosedBy; } set { _disclosedBy = value; } }
        private Value<string> _disclosedByFullName;
        public string DisclosedByFullName { get { return _disclosedByFullName; } set { _disclosedByFullName = value; } }
        private Value<string> _disclosedMethod;
        public string DisclosedMethod { get { return _disclosedMethod; } set { _disclosedMethod = value; } }
        private Value<DateTime?> _disclosureCreatedDttmUtc;
        public DateTime? DisclosureCreatedDttmUtc { get { return _disclosureCreatedDttmUtc; } set { _disclosureCreatedDttmUtc = value; } }
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
        private Value<string> _loanAmount;
        public string LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private Value<string> _loanProgram;
        public string LoanProgram { get { return _loanProgram; } set { _loanProgram = value; } }
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
        private Value<string> _propertyAddress;
        public string PropertyAddress { get { return _propertyAddress; } set { _propertyAddress = value; } }
        private Value<string> _propertyCity;
        public string PropertyCity { get { return _propertyCity; } set { _propertyCity = value; } }
        private Value<string> _propertyState;
        public string PropertyState { get { return _propertyState; } set { _propertyState = value; } }
        private Value<string> _propertyZip;
        public string PropertyZip { get { return _propertyZip; } set { _propertyZip = value; } }
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
                    && _borrowerName.Clean
                    && _borrowerPairId.Clean
                    && _coBorrowerName.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _containGfe.Clean
                    && _containSafeHarbor.Clean
                    && _containTil.Clean
                    && _dateUtc.Clean
                    && _disclosedAPR.Clean
                    && _disclosedBy.Clean
                    && _disclosedByFullName.Clean
                    && _disclosedMethod.Clean
                    && _disclosureCreatedDttmUtc.Clean
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
                    && _fileAttachmentsMigrated.Clean
                    && _financeCharge.Clean
                    && _forms.Clean
                    && _formsXml.Clean
                    && _fulfillmentOrderedBy.Clean
                    && _fullfillmentProcessedDate.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isDisclosed.Clean
                    && _isDisclosedAprLocked.Clean
                    && _isDisclosedByLocked.Clean
                    && _isDisclosedFinanceChargeLocked.Clean
                    && _isDisclosedReceivedDateLocked.Clean
                    && _isLocked.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _isWetSignedIndicator.Clean
                    && _loanAmount.Clean
                    && _loanProgram.Clean
                    && _lockedDisclosedAprField.Clean
                    && _lockedDisclosedByField.Clean
                    && _lockedDisclosedFinanceChargeField.Clean
                    && _lockedDisclosedReceivedDate.Clean
                    && _logRecordIndex.Clean
                    && _manuallyCreated.Clean
                    && _propertyAddress.Clean
                    && _propertyCity.Clean
                    && _propertyState.Clean
                    && _propertyZip.Clean
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
                var borrowerName = _borrowerName; borrowerName.Clean = value; _borrowerName = borrowerName;
                var borrowerPairId = _borrowerPairId; borrowerPairId.Clean = value; _borrowerPairId = borrowerPairId;
                var coBorrowerName = _coBorrowerName; coBorrowerName.Clean = value; _coBorrowerName = coBorrowerName;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var commentListXml = _commentListXml; commentListXml.Clean = value; _commentListXml = commentListXml;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var containGfe = _containGfe; containGfe.Clean = value; _containGfe = containGfe;
                var containSafeHarbor = _containSafeHarbor; containSafeHarbor.Clean = value; _containSafeHarbor = containSafeHarbor;
                var containTil = _containTil; containTil.Clean = value; _containTil = containTil;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var disclosedAPR = _disclosedAPR; disclosedAPR.Clean = value; _disclosedAPR = disclosedAPR;
                var disclosedBy = _disclosedBy; disclosedBy.Clean = value; _disclosedBy = disclosedBy;
                var disclosedByFullName = _disclosedByFullName; disclosedByFullName.Clean = value; _disclosedByFullName = disclosedByFullName;
                var disclosedMethod = _disclosedMethod; disclosedMethod.Clean = value; _disclosedMethod = disclosedMethod;
                var disclosureCreatedDttmUtc = _disclosureCreatedDttmUtc; disclosureCreatedDttmUtc.Clean = value; _disclosureCreatedDttmUtc = disclosureCreatedDttmUtc;
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
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var financeCharge = _financeCharge; financeCharge.Clean = value; _financeCharge = financeCharge;
                var forms = _forms; forms.Clean = value; _forms = forms;
                var formsXml = _formsXml; formsXml.Clean = value; _formsXml = formsXml;
                var fulfillmentOrderedBy = _fulfillmentOrderedBy; fulfillmentOrderedBy.Clean = value; _fulfillmentOrderedBy = fulfillmentOrderedBy;
                var fullfillmentProcessedDate = _fullfillmentProcessedDate; fullfillmentProcessedDate.Clean = value; _fullfillmentProcessedDate = fullfillmentProcessedDate;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isDisclosed = _isDisclosed; isDisclosed.Clean = value; _isDisclosed = isDisclosed;
                var isDisclosedAprLocked = _isDisclosedAprLocked; isDisclosedAprLocked.Clean = value; _isDisclosedAprLocked = isDisclosedAprLocked;
                var isDisclosedByLocked = _isDisclosedByLocked; isDisclosedByLocked.Clean = value; _isDisclosedByLocked = isDisclosedByLocked;
                var isDisclosedFinanceChargeLocked = _isDisclosedFinanceChargeLocked; isDisclosedFinanceChargeLocked.Clean = value; _isDisclosedFinanceChargeLocked = isDisclosedFinanceChargeLocked;
                var isDisclosedReceivedDateLocked = _isDisclosedReceivedDateLocked; isDisclosedReceivedDateLocked.Clean = value; _isDisclosedReceivedDateLocked = isDisclosedReceivedDateLocked;
                var isLocked = _isLocked; isLocked.Clean = value; _isLocked = isLocked;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var isWetSignedIndicator = _isWetSignedIndicator; isWetSignedIndicator.Clean = value; _isWetSignedIndicator = isWetSignedIndicator;
                var loanAmount = _loanAmount; loanAmount.Clean = value; _loanAmount = loanAmount;
                var loanProgram = _loanProgram; loanProgram.Clean = value; _loanProgram = loanProgram;
                var lockedDisclosedAprField = _lockedDisclosedAprField; lockedDisclosedAprField.Clean = value; _lockedDisclosedAprField = lockedDisclosedAprField;
                var lockedDisclosedByField = _lockedDisclosedByField; lockedDisclosedByField.Clean = value; _lockedDisclosedByField = lockedDisclosedByField;
                var lockedDisclosedFinanceChargeField = _lockedDisclosedFinanceChargeField; lockedDisclosedFinanceChargeField.Clean = value; _lockedDisclosedFinanceChargeField = lockedDisclosedFinanceChargeField;
                var lockedDisclosedReceivedDate = _lockedDisclosedReceivedDate; lockedDisclosedReceivedDate.Clean = value; _lockedDisclosedReceivedDate = lockedDisclosedReceivedDate;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var manuallyCreated = _manuallyCreated; manuallyCreated.Clean = value; _manuallyCreated = manuallyCreated;
                var propertyAddress = _propertyAddress; propertyAddress.Clean = value; _propertyAddress = propertyAddress;
                var propertyCity = _propertyCity; propertyCity.Clean = value; _propertyCity = propertyCity;
                var propertyState = _propertyState; propertyState.Clean = value; _propertyState = propertyState;
                var propertyZip = _propertyZip; propertyZip.Clean = value; _propertyZip = propertyZip;
                var receivedDate = _receivedDate; receivedDate.Clean = value; _receivedDate = receivedDate;
                var snapshotFields = _snapshotFields; snapshotFields.Clean = value; _snapshotFields = snapshotFields;
                var snapshotXml = _snapshotXml; snapshotXml.Clean = value; _snapshotXml = snapshotXml;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public DisclosureTrackingLog()
        {
            Clean = true;
        }
    }
}