using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentLog
    /// </summary>
    public sealed partial class DocumentLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accessedBy;
        /// <summary>
        /// DocumentLog AccessedBy
        /// </summary>
        public string AccessedBy { get => _accessedBy; set => SetField(ref _accessedBy, value); }
        private DirtyValue<DateTime?> _accessedDateUtc;
        /// <summary>
        /// DocumentLog AccessedDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? AccessedDateUtc { get => _accessedDateUtc; set => SetField(ref _accessedDateUtc, value); }
        private DirtyValue<string> _addedBy;
        /// <summary>
        /// DocumentLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// DocumentLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<string> _alertsXml;
        /// <summary>
        /// DocumentLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }
        private DirtyValue<string> _allowedRoleDelimitedList;
        /// <summary>
        /// DocumentLog AllowedRoleDelimitedList
        /// </summary>
        public string AllowedRoleDelimitedList { get => _allowedRoleDelimitedList; set => SetField(ref _allowedRoleDelimitedList, value); }
        private DirtyList<EntityReference> _allowedRoles;
        /// <summary>
        /// DocumentLog AllowedRoles
        /// </summary>
        public IList<EntityReference> AllowedRoles { get => GetField(ref _allowedRoles); set => SetField(ref _allowedRoles, value); }
        private DirtyValue<string> _allowedRolesXml;
        /// <summary>
        /// DocumentLog AllowedRolesXml
        /// </summary>
        public string AllowedRolesXml { get => _allowedRolesXml; set => SetField(ref _allowedRolesXml, value); }
        private DirtyValue<DateTime?> _archiveDateUtc;
        /// <summary>
        /// DocumentLog ArchiveDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ArchiveDateUtc { get => _archiveDateUtc; set => SetField(ref _archiveDateUtc, value); }
        private DirtyValue<string> _archivedBy;
        /// <summary>
        /// DocumentLog ArchivedBy
        /// </summary>
        public string ArchivedBy { get => _archivedBy; set => SetField(ref _archivedBy, value); }
        private DirtyValue<bool?> _closingDocumentIndicator;
        /// <summary>
        /// DocumentLog ClosingDocumentIndicator
        /// </summary>
        public bool? ClosingDocumentIndicator { get => _closingDocumentIndicator; set => SetField(ref _closingDocumentIndicator, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// DocumentLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _commentListXml;
        /// <summary>
        /// DocumentLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// DocumentLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _company;
        /// <summary>
        /// DocumentLog Company
        /// </summary>
        public string Company { get => _company; set => SetField(ref _company, value); }
        private DirtyList<EntityReference> _conditions;
        /// <summary>
        /// DocumentLog Conditions
        /// </summary>
        public IList<EntityReference> Conditions { get => GetField(ref _conditions); set => SetField(ref _conditions, value); }
        private DirtyValue<string> _conditionsXml;
        /// <summary>
        /// DocumentLog ConditionsXml
        /// </summary>
        public string ConditionsXml { get => _conditionsXml; set => SetField(ref _conditionsXml, value); }
        private DirtyValue<DateTime?> _dateAddedUtc;
        /// <summary>
        /// DocumentLog DateAddedUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }
        private DirtyValue<DateTime?> _dateExpected;
        /// <summary>
        /// DocumentLog DateExpected
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }
        private DirtyValue<DateTime?> _dateExpires;
        /// <summary>
        /// DocumentLog DateExpires
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateExpires { get => _dateExpires; set => SetField(ref _dateExpires, value); }
        private DirtyValue<DateTime?> _dateReceived;
        /// <summary>
        /// DocumentLog DateReceived
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }
        private DirtyValue<DateTime?> _dateRequested;
        /// <summary>
        /// DocumentLog DateRequested
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRequested { get => _dateRequested; set => SetField(ref _dateRequested, value); }
        private DirtyValue<DateTime?> _dateRerequested;
        /// <summary>
        /// DocumentLog DateRerequested
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateRerequested { get => _dateRerequested; set => SetField(ref _dateRerequested, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// DocumentLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<int?> _daysDue;
        /// <summary>
        /// DocumentLog DaysDue
        /// </summary>
        public int? DaysDue { get => _daysDue; set => SetField(ref _daysDue, value); }
        private DirtyValue<int?> _daysTillExpire;
        /// <summary>
        /// DocumentLog DaysTillExpire
        /// </summary>
        public int? DaysTillExpire { get => _daysTillExpire; set => SetField(ref _daysTillExpire, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// DocumentLog Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _documentDateTimeType;
        /// <summary>
        /// DocumentLog DocumentDateTimeType
        /// </summary>
        public string DocumentDateTimeType { get => _documentDateTimeType; set => SetField(ref _documentDateTimeType, value); }
        private DirtyValue<string> _docVerificationsXml;
        /// <summary>
        /// DocumentLog DocVerificationsXml
        /// </summary>
        public string DocVerificationsXml { get => _docVerificationsXml; set => SetField(ref _docVerificationsXml, value); }
        private DirtyValue<bool?> _eDisclosureIndicator;
        /// <summary>
        /// DocumentLog EDisclosureIndicator
        /// </summary>
        public bool? EDisclosureIndicator { get => _eDisclosureIndicator; set => SetField(ref _eDisclosureIndicator, value); }
        private DirtyValue<string> _ePassSignature;
        /// <summary>
        /// DocumentLog EPassSignature
        /// </summary>
        public string EPassSignature { get => _ePassSignature; set => SetField(ref _ePassSignature, value); }
        private DirtyValue<bool?> _expected;
        /// <summary>
        /// DocumentLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => SetField(ref _expected, value); }
        private DirtyValue<bool?> _expires;
        /// <summary>
        /// DocumentLog Expires
        /// </summary>
        public bool? Expires { get => _expires; set => SetField(ref _expires, value); }
        private DirtyList<FileAttachmentReference> _fileAttachmentReferences;
        /// <summary>
        /// DocumentLog FileAttachmentReferences
        /// </summary>
        public IList<FileAttachmentReference> FileAttachmentReferences { get => GetField(ref _fileAttachmentReferences); set => SetField(ref _fileAttachmentReferences, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// DocumentLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _fileAttachmentsXml;
        /// <summary>
        /// DocumentLog FileAttachmentsXml
        /// </summary>
        public string FileAttachmentsXml { get => _fileAttachmentsXml; set => SetField(ref _fileAttachmentsXml, value); }
        private DirtyValue<string> _groupName;
        /// <summary>
        /// DocumentLog GroupName
        /// </summary>
        public string GroupName { get => _groupName; set => SetField(ref _groupName, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// DocumentLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// DocumentLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isAssetVerification;
        /// <summary>
        /// DocumentLog IsAssetVerification
        /// </summary>
        public bool? IsAssetVerification { get => _isAssetVerification; set => SetField(ref _isAssetVerification, value); }
        private DirtyValue<bool?> _isEmploymentVerification;
        /// <summary>
        /// DocumentLog IsEmploymentVerification
        /// </summary>
        public bool? IsEmploymentVerification { get => _isEmploymentVerification; set => SetField(ref _isEmploymentVerification, value); }
        private DirtyValue<bool?> _isEPassIndicator;
        /// <summary>
        /// DocumentLog IsEPassIndicator
        /// </summary>
        public bool? IsEPassIndicator { get => _isEPassIndicator; set => SetField(ref _isEPassIndicator, value); }
        private DirtyValue<bool?> _isExpired;
        /// <summary>
        /// DocumentLog IsExpired
        /// </summary>
        public bool? IsExpired { get => _isExpired; set => SetField(ref _isExpired, value); }
        private DirtyValue<bool?> _isExternalIndicator;
        /// <summary>
        /// DocumentLog IsExternalIndicator
        /// </summary>
        public bool? IsExternalIndicator { get => _isExternalIndicator; set => SetField(ref _isExternalIndicator, value); }
        private DirtyValue<bool?> _isIncomeVerification;
        /// <summary>
        /// DocumentLog IsIncomeVerification
        /// </summary>
        public bool? IsIncomeVerification { get => _isIncomeVerification; set => SetField(ref _isIncomeVerification, value); }
        private DirtyValue<bool?> _isObligationVerification;
        /// <summary>
        /// DocumentLog IsObligationVerification
        /// </summary>
        public bool? IsObligationVerification { get => _isObligationVerification; set => SetField(ref _isObligationVerification, value); }
        private DirtyValue<bool?> _isPastDue;
        /// <summary>
        /// DocumentLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => SetField(ref _isPastDue, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// DocumentLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<bool?> _isThirdPartyDocIndicator;
        /// <summary>
        /// DocumentLog IsThirdPartyDocIndicator
        /// </summary>
        public bool? IsThirdPartyDocIndicator { get => _isThirdPartyDocIndicator; set => SetField(ref _isThirdPartyDocIndicator, value); }
        private DirtyValue<bool?> _isTPOWebcenterPortalIndicator;
        /// <summary>
        /// DocumentLog IsTPOWebcenterPortalIndicator
        /// </summary>
        public bool? IsTPOWebcenterPortalIndicator { get => _isTPOWebcenterPortalIndicator; set => SetField(ref _isTPOWebcenterPortalIndicator, value); }
        private DirtyValue<bool?> _isWebCenterIndicator;
        /// <summary>
        /// DocumentLog IsWebCenterIndicator
        /// </summary>
        public bool? IsWebCenterIndicator { get => _isWebCenterIndicator; set => SetField(ref _isWebCenterIndicator, value); }
        private DirtyValue<DateTime?> _lastAttachmentDateUtc;
        /// <summary>
        /// DocumentLog LastAttachmentDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LastAttachmentDateUtc { get => _lastAttachmentDateUtc; set => SetField(ref _lastAttachmentDateUtc, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// DocumentLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<DateTime?> _orderDateUtc;
        /// <summary>
        /// DocumentLog OrderDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? OrderDateUtc { get => _orderDateUtc; set => SetField(ref _orderDateUtc, value); }
        private DirtyValue<string> _pairId;
        /// <summary>
        /// DocumentLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => SetField(ref _pairId, value); }
        private DirtyValue<bool?> _preClosingDocumentIndicator;
        /// <summary>
        /// DocumentLog PreClosingDocumentIndicator
        /// </summary>
        public bool? PreClosingDocumentIndicator { get => _preClosingDocumentIndicator; set => SetField(ref _preClosingDocumentIndicator, value); }
        private DirtyValue<bool?> _received;
        /// <summary>
        /// DocumentLog Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }
        private DirtyValue<DateTime?> _receiveDateUtc;
        /// <summary>
        /// DocumentLog ReceiveDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReceiveDateUtc { get => _receiveDateUtc; set => SetField(ref _receiveDateUtc, value); }
        private DirtyValue<string> _receivedBy;
        /// <summary>
        /// DocumentLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }
        private DirtyValue<DateTime?> _reorderDateUtc;
        /// <summary>
        /// DocumentLog ReorderDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReorderDateUtc { get => _reorderDateUtc; set => SetField(ref _reorderDateUtc, value); }
        private DirtyValue<bool?> _requested;
        /// <summary>
        /// DocumentLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => SetField(ref _requested, value); }
        private DirtyValue<string> _requestedBy;
        /// <summary>
        /// DocumentLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }
        private DirtyValue<string> _requestedFrom;
        /// <summary>
        /// DocumentLog RequestedFrom
        /// </summary>
        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }
        private DirtyValue<bool?> _rerequested;
        /// <summary>
        /// DocumentLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => SetField(ref _rerequested, value); }
        private DirtyValue<string> _rerequestedBy;
        /// <summary>
        /// DocumentLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }
        private DirtyValue<bool?> _reviewed;
        /// <summary>
        /// DocumentLog Reviewed
        /// </summary>
        public bool? Reviewed { get => _reviewed; set => SetField(ref _reviewed, value); }
        private DirtyValue<string> _reviewedBy;
        /// <summary>
        /// DocumentLog ReviewedBy
        /// </summary>
        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }
        private DirtyValue<DateTime?> _reviewedDateUtc;
        /// <summary>
        /// DocumentLog ReviewedDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReviewedDateUtc { get => _reviewedDateUtc; set => SetField(ref _reviewedDateUtc, value); }
        private DirtyValue<bool?> _shippingReady;
        /// <summary>
        /// DocumentLog ShippingReady
        /// </summary>
        public bool? ShippingReady { get => _shippingReady; set => SetField(ref _shippingReady, value); }
        private DirtyValue<string> _shippingReadyBy;
        /// <summary>
        /// DocumentLog ShippingReadyBy
        /// </summary>
        public string ShippingReadyBy { get => _shippingReadyBy; set => SetField(ref _shippingReadyBy, value); }
        private DirtyValue<DateTime?> _shippingReadyDateUtc;
        /// <summary>
        /// DocumentLog ShippingReadyDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ShippingReadyDateUtc { get => _shippingReadyDateUtc; set => SetField(ref _shippingReadyDateUtc, value); }
        private DirtyValue<string> _stage;
        /// <summary>
        /// DocumentLog Stage
        /// </summary>
        public string Stage { get => _stage; set => SetField(ref _stage, value); }
        private DirtyValue<string> _status;
        /// <summary>
        /// DocumentLog Status
        /// </summary>
        public string Status { get => _status; set => SetField(ref _status, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// DocumentLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _title;
        /// <summary>
        /// DocumentLog Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<bool?> _underwritingReady;
        /// <summary>
        /// DocumentLog UnderwritingReady
        /// </summary>
        public bool? UnderwritingReady { get => _underwritingReady; set => SetField(ref _underwritingReady, value); }
        private DirtyValue<string> _underwritingReadyBy;
        /// <summary>
        /// DocumentLog UnderwritingReadyBy
        /// </summary>
        public string UnderwritingReadyBy { get => _underwritingReadyBy; set => SetField(ref _underwritingReadyBy, value); }
        private DirtyValue<DateTime?> _underwritingReadyDateUtc;
        /// <summary>
        /// DocumentLog UnderwritingReadyDateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? UnderwritingReadyDateUtc { get => _underwritingReadyDateUtc; set => SetField(ref _underwritingReadyDateUtc, value); }
    }
}