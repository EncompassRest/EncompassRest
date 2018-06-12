using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentLog
    /// </summary>
    public sealed partial class DocumentLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accessedBy;
        /// <summary>
        /// DocumentLog AccessedBy
        /// </summary>
        public string AccessedBy { get => _accessedBy; set => _accessedBy = value; }
        private DirtyValue<DateTime?> _accessedDateUtc;
        /// <summary>
        /// DocumentLog AccessedDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? AccessedDateUtc { get => _accessedDateUtc; set => _accessedDateUtc = value; }
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// DocumentLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// DocumentLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// DocumentLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<string> _allowedRoleDelimitedList;
        /// <summary>
        /// DocumentLog AllowedRoleDelimitedList
        /// </summary>
        public string AllowedRoleDelimitedList { get => _allowedRoleDelimitedList; set => _allowedRoleDelimitedList = value; }
        private DirtyList<EntityReference> _allowedRoles;
        /// <summary>
        /// DocumentLog AllowedRoles
        /// </summary>
        public IList<EntityReference> AllowedRoles { get => _allowedRoles ?? (_allowedRoles = new DirtyList<EntityReference>()); set => _allowedRoles = new DirtyList<EntityReference>(value); }
        private DirtyValue<string> _allowedRolesXml;
        /// <summary>
        /// DocumentLog AllowedRolesXml
        /// </summary>
        public string AllowedRolesXml { get => _allowedRolesXml; set => _allowedRolesXml = value; }
        private DirtyValue<DateTime?> _archiveDateUtc;
        /// <summary>
        /// DocumentLog ArchiveDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ArchiveDateUtc { get => _archiveDateUtc; set => _archiveDateUtc = value; }
        private DirtyValue<string> _archivedBy;
        /// <summary>
        /// DocumentLog ArchivedBy
        /// </summary>
        public string ArchivedBy { get => _archivedBy; set => _archivedBy = value; }
        private DirtyValue<bool?> _closingDocumentIndicator;
        /// <summary>
        /// DocumentLog ClosingDocumentIndicator
        /// </summary>
        public bool? ClosingDocumentIndicator { get => _closingDocumentIndicator; set => _closingDocumentIndicator = value; }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// DocumentLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// DocumentLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// DocumentLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _company;
        /// <summary>
        /// DocumentLog Company
        /// </summary>
        public string Company { get => _company; set => _company = value; }
        private DirtyList<EntityReference> _conditions;
        /// <summary>
        /// DocumentLog Conditions
        /// </summary>
        public IList<EntityReference> Conditions { get => _conditions ?? (_conditions = new DirtyList<EntityReference>()); set => _conditions = new DirtyList<EntityReference>(value); }
        private DirtyValue<string> _conditionsXml;
        /// <summary>
        /// DocumentLog ConditionsXml
        /// </summary>
        public string ConditionsXml { get => _conditionsXml; set => _conditionsXml = value; }
        private DirtyValue<DateTime?> _dateAddedUtc;
        /// <summary>
        /// DocumentLog DateAddedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => _dateAddedUtc = value; }
        private DirtyValue<DateTime?> _dateExpected;
        /// <summary>
        /// DocumentLog DateExpected
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpected { get => _dateExpected; set => _dateExpected = value; }
        private DirtyValue<DateTime?> _dateExpires;
        /// <summary>
        /// DocumentLog DateExpires
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpires { get => _dateExpires; set => _dateExpires = value; }
        private DirtyValue<DateTime?> _dateReceived;
        /// <summary>
        /// DocumentLog DateReceived
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceived { get => _dateReceived; set => _dateReceived = value; }
        private DirtyValue<DateTime?> _dateRequested;
        /// <summary>
        /// DocumentLog DateRequested
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRequested { get => _dateRequested; set => _dateRequested = value; }
        private DirtyValue<DateTime?> _dateRerequested;
        /// <summary>
        /// DocumentLog DateRerequested
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRerequested { get => _dateRerequested; set => _dateRerequested = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DocumentLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<int?> _daysDue;
        /// <summary>
        /// DocumentLog DaysDue
        /// </summary>
        public int? DaysDue { get => _daysDue; set => _daysDue = value; }
        private DirtyValue<int?> _daysTillExpire;
        /// <summary>
        /// DocumentLog DaysTillExpire
        /// </summary>
        public int? DaysTillExpire { get => _daysTillExpire; set => _daysTillExpire = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// DocumentLog Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _documentDateTimeType;
        /// <summary>
        /// DocumentLog DocumentDateTimeType
        /// </summary>
        public string DocumentDateTimeType { get => _documentDateTimeType; set => _documentDateTimeType = value; }
        private DirtyValue<string> _docVerificationsXml;
        /// <summary>
        /// DocumentLog DocVerificationsXml
        /// </summary>
        public string DocVerificationsXml { get => _docVerificationsXml; set => _docVerificationsXml = value; }
        private DirtyValue<bool?> _eDisclosureIndicator;
        /// <summary>
        /// DocumentLog EDisclosureIndicator
        /// </summary>
        public bool? EDisclosureIndicator { get => _eDisclosureIndicator; set => _eDisclosureIndicator = value; }
        private DirtyValue<string> _ePassSignature;
        /// <summary>
        /// DocumentLog EPassSignature
        /// </summary>
        public string EPassSignature { get => _ePassSignature; set => _ePassSignature = value; }
        private DirtyValue<bool?> _expected;
        /// <summary>
        /// DocumentLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => _expected = value; }
        private DirtyValue<bool?> _expires;
        /// <summary>
        /// DocumentLog Expires
        /// </summary>
        public bool? Expires { get => _expires; set => _expires = value; }
        private DirtyList<FileAttachmentReference> _fileAttachmentReferences;
        /// <summary>
        /// DocumentLog FileAttachmentReferences
        /// </summary>
        public IList<FileAttachmentReference> FileAttachmentReferences { get => _fileAttachmentReferences ?? (_fileAttachmentReferences = new DirtyList<FileAttachmentReference>()); set => _fileAttachmentReferences = new DirtyList<FileAttachmentReference>(value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// DocumentLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _fileAttachmentsXml;
        /// <summary>
        /// DocumentLog FileAttachmentsXml
        /// </summary>
        public string FileAttachmentsXml { get => _fileAttachmentsXml; set => _fileAttachmentsXml = value; }
        private DirtyValue<string> _groupName;
        /// <summary>
        /// DocumentLog GroupName
        /// </summary>
        public string GroupName { get => _groupName; set => _groupName = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// DocumentLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// DocumentLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isAssetVerification;
        /// <summary>
        /// DocumentLog IsAssetVerification
        /// </summary>
        public bool? IsAssetVerification { get => _isAssetVerification; set => _isAssetVerification = value; }
        private DirtyValue<bool?> _isEmploymentVerification;
        /// <summary>
        /// DocumentLog IsEmploymentVerification
        /// </summary>
        public bool? IsEmploymentVerification { get => _isEmploymentVerification; set => _isEmploymentVerification = value; }
        private DirtyValue<bool?> _isEPassIndicator;
        /// <summary>
        /// DocumentLog IsEPassIndicator
        /// </summary>
        public bool? IsEPassIndicator { get => _isEPassIndicator; set => _isEPassIndicator = value; }
        private DirtyValue<bool?> _isExpired;
        /// <summary>
        /// DocumentLog IsExpired
        /// </summary>
        public bool? IsExpired { get => _isExpired; set => _isExpired = value; }
        private DirtyValue<bool?> _isExternalIndicator;
        /// <summary>
        /// DocumentLog IsExternalIndicator
        /// </summary>
        public bool? IsExternalIndicator { get => _isExternalIndicator; set => _isExternalIndicator = value; }
        private DirtyValue<bool?> _isIncomeVerification;
        /// <summary>
        /// DocumentLog IsIncomeVerification
        /// </summary>
        public bool? IsIncomeVerification { get => _isIncomeVerification; set => _isIncomeVerification = value; }
        private DirtyValue<bool?> _isObligationVerification;
        /// <summary>
        /// DocumentLog IsObligationVerification
        /// </summary>
        public bool? IsObligationVerification { get => _isObligationVerification; set => _isObligationVerification = value; }
        private DirtyValue<bool?> _isPastDue;
        /// <summary>
        /// DocumentLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => _isPastDue = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// DocumentLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<bool?> _isThirdPartyDocIndicator;
        /// <summary>
        /// DocumentLog IsThirdPartyDocIndicator
        /// </summary>
        public bool? IsThirdPartyDocIndicator { get => _isThirdPartyDocIndicator; set => _isThirdPartyDocIndicator = value; }
        private DirtyValue<bool?> _isTPOWebcenterPortalIndicator;
        /// <summary>
        /// DocumentLog IsTPOWebcenterPortalIndicator
        /// </summary>
        public bool? IsTPOWebcenterPortalIndicator { get => _isTPOWebcenterPortalIndicator; set => _isTPOWebcenterPortalIndicator = value; }
        private DirtyValue<bool?> _isWebCenterIndicator;
        /// <summary>
        /// DocumentLog IsWebCenterIndicator
        /// </summary>
        public bool? IsWebCenterIndicator { get => _isWebCenterIndicator; set => _isWebCenterIndicator = value; }
        private DirtyValue<DateTime?> _lastAttachmentDateUtc;
        /// <summary>
        /// DocumentLog LastAttachmentDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LastAttachmentDateUtc { get => _lastAttachmentDateUtc; set => _lastAttachmentDateUtc = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// DocumentLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<DateTime?> _orderDateUtc;
        /// <summary>
        /// DocumentLog OrderDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? OrderDateUtc { get => _orderDateUtc; set => _orderDateUtc = value; }
        private DirtyValue<string> _pairId;
        /// <summary>
        /// DocumentLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => _pairId = value; }
        private DirtyValue<bool?> _preClosingDocumentIndicator;
        /// <summary>
        /// DocumentLog PreClosingDocumentIndicator
        /// </summary>
        public bool? PreClosingDocumentIndicator { get => _preClosingDocumentIndicator; set => _preClosingDocumentIndicator = value; }
        private DirtyValue<bool?> _received;
        /// <summary>
        /// DocumentLog Received
        /// </summary>
        public bool? Received { get => _received; set => _received = value; }
        private DirtyValue<DateTime?> _receiveDateUtc;
        /// <summary>
        /// DocumentLog ReceiveDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReceiveDateUtc { get => _receiveDateUtc; set => _receiveDateUtc = value; }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// DocumentLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<DateTime?> _reorderDateUtc;
        /// <summary>
        /// DocumentLog ReorderDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReorderDateUtc { get => _reorderDateUtc; set => _reorderDateUtc = value; }
        private DirtyValue<bool?> _requested;
        /// <summary>
        /// DocumentLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => _requested = value; }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// DocumentLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<string> _requestedFrom;
        /// <summary>
        /// DocumentLog RequestedFrom
        /// </summary>
        public string RequestedFrom { get => _requestedFrom; set => _requestedFrom = value; }
        private DirtyValue<bool?> _rerequested;
        /// <summary>
        /// DocumentLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => _rerequested = value; }
        private DirtyValue<string> _rerequestedBy;
        /// <summary>
        /// DocumentLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => _rerequestedBy = value; }
        private DirtyValue<bool?> _reviewed;
        /// <summary>
        /// DocumentLog Reviewed
        /// </summary>
        public bool? Reviewed { get => _reviewed; set => _reviewed = value; }
        private DirtyValue<string> _reviewedBy;
        /// <summary>
        /// DocumentLog ReviewedBy
        /// </summary>
        public string ReviewedBy { get => _reviewedBy; set => _reviewedBy = value; }
        private DirtyValue<DateTime?> _reviewedDateUtc;
        /// <summary>
        /// DocumentLog ReviewedDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReviewedDateUtc { get => _reviewedDateUtc; set => _reviewedDateUtc = value; }
        private DirtyValue<bool?> _shippingReady;
        /// <summary>
        /// DocumentLog ShippingReady
        /// </summary>
        public bool? ShippingReady { get => _shippingReady; set => _shippingReady = value; }
        private DirtyValue<string> _shippingReadyBy;
        /// <summary>
        /// DocumentLog ShippingReadyBy
        /// </summary>
        public string ShippingReadyBy { get => _shippingReadyBy; set => _shippingReadyBy = value; }
        private DirtyValue<DateTime?> _shippingReadyDateUtc;
        /// <summary>
        /// DocumentLog ShippingReadyDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ShippingReadyDateUtc { get => _shippingReadyDateUtc; set => _shippingReadyDateUtc = value; }
        private DirtyValue<string> _stage;
        /// <summary>
        /// DocumentLog Stage
        /// </summary>
        public string Stage { get => _stage; set => _stage = value; }
        private DirtyValue<string> _status;
        /// <summary>
        /// DocumentLog Status
        /// </summary>
        public string Status { get => _status; set => _status = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// DocumentLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// DocumentLog Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<bool?> _underwritingReady;
        /// <summary>
        /// DocumentLog UnderwritingReady
        /// </summary>
        public bool? UnderwritingReady { get => _underwritingReady; set => _underwritingReady = value; }
        private DirtyValue<string> _underwritingReadyBy;
        /// <summary>
        /// DocumentLog UnderwritingReadyBy
        /// </summary>
        public string UnderwritingReadyBy { get => _underwritingReadyBy; set => _underwritingReadyBy = value; }
        private DirtyValue<DateTime?> _underwritingReadyDateUtc;
        /// <summary>
        /// DocumentLog UnderwritingReadyDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? UnderwritingReadyDateUtc { get => _underwritingReadyDateUtc; set => _underwritingReadyDateUtc = value; }
        internal override bool DirtyInternal
        {
            get => _accessedBy.Dirty
                || _accessedDateUtc.Dirty
                || _addedBy.Dirty
                || _alertsXml.Dirty
                || _allowedRoleDelimitedList.Dirty
                || _allowedRolesXml.Dirty
                || _archiveDateUtc.Dirty
                || _archivedBy.Dirty
                || _closingDocumentIndicator.Dirty
                || _commentListXml.Dirty
                || _comments.Dirty
                || _company.Dirty
                || _conditionsXml.Dirty
                || _dateAddedUtc.Dirty
                || _dateExpected.Dirty
                || _dateExpires.Dirty
                || _dateReceived.Dirty
                || _dateRequested.Dirty
                || _dateRerequested.Dirty
                || _dateUtc.Dirty
                || _daysDue.Dirty
                || _daysTillExpire.Dirty
                || _description.Dirty
                || _documentDateTimeType.Dirty
                || _docVerificationsXml.Dirty
                || _eDisclosureIndicator.Dirty
                || _ePassSignature.Dirty
                || _expected.Dirty
                || _expires.Dirty
                || _fileAttachmentsMigrated.Dirty
                || _fileAttachmentsXml.Dirty
                || _groupName.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _isAssetVerification.Dirty
                || _isEmploymentVerification.Dirty
                || _isEPassIndicator.Dirty
                || _isExpired.Dirty
                || _isExternalIndicator.Dirty
                || _isIncomeVerification.Dirty
                || _isObligationVerification.Dirty
                || _isPastDue.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _isThirdPartyDocIndicator.Dirty
                || _isTPOWebcenterPortalIndicator.Dirty
                || _isWebCenterIndicator.Dirty
                || _lastAttachmentDateUtc.Dirty
                || _logRecordIndex.Dirty
                || _orderDateUtc.Dirty
                || _pairId.Dirty
                || _preClosingDocumentIndicator.Dirty
                || _received.Dirty
                || _receiveDateUtc.Dirty
                || _receivedBy.Dirty
                || _reorderDateUtc.Dirty
                || _requested.Dirty
                || _requestedBy.Dirty
                || _requestedFrom.Dirty
                || _rerequested.Dirty
                || _rerequestedBy.Dirty
                || _reviewed.Dirty
                || _reviewedBy.Dirty
                || _reviewedDateUtc.Dirty
                || _shippingReady.Dirty
                || _shippingReadyBy.Dirty
                || _shippingReadyDateUtc.Dirty
                || _stage.Dirty
                || _status.Dirty
                || _systemId.Dirty
                || _title.Dirty
                || _underwritingReady.Dirty
                || _underwritingReadyBy.Dirty
                || _underwritingReadyDateUtc.Dirty
                || _alerts?.Dirty == true
                || _allowedRoles?.Dirty == true
                || _commentList?.Dirty == true
                || _conditions?.Dirty == true
                || _fileAttachmentReferences?.Dirty == true;
            set
            {
                _accessedBy.Dirty = value;
                _accessedDateUtc.Dirty = value;
                _addedBy.Dirty = value;
                _alertsXml.Dirty = value;
                _allowedRoleDelimitedList.Dirty = value;
                _allowedRolesXml.Dirty = value;
                _archiveDateUtc.Dirty = value;
                _archivedBy.Dirty = value;
                _closingDocumentIndicator.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _company.Dirty = value;
                _conditionsXml.Dirty = value;
                _dateAddedUtc.Dirty = value;
                _dateExpected.Dirty = value;
                _dateExpires.Dirty = value;
                _dateReceived.Dirty = value;
                _dateRequested.Dirty = value;
                _dateRerequested.Dirty = value;
                _dateUtc.Dirty = value;
                _daysDue.Dirty = value;
                _daysTillExpire.Dirty = value;
                _description.Dirty = value;
                _documentDateTimeType.Dirty = value;
                _docVerificationsXml.Dirty = value;
                _eDisclosureIndicator.Dirty = value;
                _ePassSignature.Dirty = value;
                _expected.Dirty = value;
                _expires.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _fileAttachmentsXml.Dirty = value;
                _groupName.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isAssetVerification.Dirty = value;
                _isEmploymentVerification.Dirty = value;
                _isEPassIndicator.Dirty = value;
                _isExpired.Dirty = value;
                _isExternalIndicator.Dirty = value;
                _isIncomeVerification.Dirty = value;
                _isObligationVerification.Dirty = value;
                _isPastDue.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _isThirdPartyDocIndicator.Dirty = value;
                _isTPOWebcenterPortalIndicator.Dirty = value;
                _isWebCenterIndicator.Dirty = value;
                _lastAttachmentDateUtc.Dirty = value;
                _logRecordIndex.Dirty = value;
                _orderDateUtc.Dirty = value;
                _pairId.Dirty = value;
                _preClosingDocumentIndicator.Dirty = value;
                _received.Dirty = value;
                _receiveDateUtc.Dirty = value;
                _receivedBy.Dirty = value;
                _reorderDateUtc.Dirty = value;
                _requested.Dirty = value;
                _requestedBy.Dirty = value;
                _requestedFrom.Dirty = value;
                _rerequested.Dirty = value;
                _rerequestedBy.Dirty = value;
                _reviewed.Dirty = value;
                _reviewedBy.Dirty = value;
                _reviewedDateUtc.Dirty = value;
                _shippingReady.Dirty = value;
                _shippingReadyBy.Dirty = value;
                _shippingReadyDateUtc.Dirty = value;
                _stage.Dirty = value;
                _status.Dirty = value;
                _systemId.Dirty = value;
                _title.Dirty = value;
                _underwritingReady.Dirty = value;
                _underwritingReadyBy.Dirty = value;
                _underwritingReadyDateUtc.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_allowedRoles != null) _allowedRoles.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                if (_conditions != null) _conditions.Dirty = value;
                if (_fileAttachmentReferences != null) _fileAttachmentReferences.Dirty = value;
            }
        }
    }
}