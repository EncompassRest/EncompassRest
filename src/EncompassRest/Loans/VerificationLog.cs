using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    /// <summary>
    /// VerificationLog
    /// </summary>
    public sealed partial class VerificationLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accessedBy;
        private DirtyValue<DateTime?> _accessedDateUtc;
        private DirtyValue<string> _addedBy;
        private DirtyList<LogAlert> _alerts;
        private DirtyValue<string> _alertsXml;
        private DirtyValue<string> _allowedRoleDelimitedList;
        private DirtyList<EntityReference> _allowedRoles;
        private DirtyValue<string> _allowedRolesXml;
        private DirtyValue<DateTime?> _archiveDateUtc;
        private DirtyValue<string> _archivedBy;
        private DirtyValue<bool?> _closingDocumentIndicator;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _commentListXml;
        private DirtyValue<string> _comments;
        private DirtyValue<string> _company;
        private DirtyList<EntityReference> _conditions;
        private DirtyValue<string> _conditionsXml;
        private DirtyValue<DateTime?> _dateAddedUtc;
        private DirtyValue<DateTime?> _dateExpected;
        private DirtyValue<DateTime?> _dateExpires;
        private DirtyValue<DateTime?> _dateReceived;
        private DirtyValue<DateTime?> _dateRequested;
        private DirtyValue<DateTime?> _dateRerequested;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<int?> _daysDue;
        private DirtyValue<int?> _daysTillExpire;
        private DirtyValue<string> _description;
        private DirtyValue<string> _documentDateTimeType;
        private DirtyValue<string> _docVerificationsXml;
        private DirtyValue<bool?> _eDisclosureIndicator;
        private DirtyValue<string> _ePassSignature;
        private DirtyValue<bool?> _expected;
        private DirtyValue<bool?> _expires;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _fileAttachmentsXml;
        private DirtyValue<string> _groupName;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isAssetVerification;
        private DirtyValue<bool?> _isEmploymentVerification;
        private DirtyValue<bool?> _isEPassIndicator;
        private DirtyValue<bool?> _isExpired;
        private DirtyValue<bool?> _isExternalIndicator;
        private DirtyValue<bool?> _isIncomeVerification;
        private DirtyValue<bool?> _isObligationVerification;
        private DirtyValue<bool?> _isPastDue;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<bool?> _isThirdPartyDocIndicator;
        private DirtyValue<bool?> _isTPOWebcenterPortalIndicator;
        private DirtyValue<bool?> _isWebCenterIndicator;
        private DirtyValue<DateTime?> _lastAttachmentDateUtc;
        private DirtyValue<string> _logId;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<DateTime?> _orderDateUtc;
        private DirtyValue<string> _pairId;
        private DirtyValue<bool?> _preClosingDocumentIndicator;
        private DirtyValue<bool?> _received;
        private DirtyValue<DateTime?> _receiveDateUtc;
        private DirtyValue<string> _receivedBy;
        private DirtyValue<DateTime?> _reorderDateUtc;
        private DirtyValue<bool?> _requested;
        private DirtyValue<string> _requestedBy;
        private DirtyValue<string> _requestedFrom;
        private DirtyValue<bool?> _rerequested;
        private DirtyValue<string> _rerequestedBy;
        private DirtyValue<bool?> _reviewed;
        private DirtyValue<string> _reviewedBy;
        private DirtyValue<DateTime?> _reviewedDateUtc;
        private DirtyValue<bool?> _shippingReady;
        private DirtyValue<string> _shippingReadyBy;
        private DirtyValue<DateTime?> _shippingReadyDateUtc;
        private DirtyValue<string> _stage;
        private DirtyValue<string> _status;
        private DirtyValue<string> _systemId;
        private DirtyValue<string> _title;
        private DirtyValue<bool?> _underwritingReady;
        private DirtyValue<string> _underwritingReadyBy;
        private DirtyValue<DateTime?> _underwritingReadyDateUtc;

        /// <summary>
        /// VerificationLog AccessedBy
        /// </summary>
        public string AccessedBy { get => _accessedBy; set => SetField(ref _accessedBy, value); }

        /// <summary>
        /// VerificationLog AccessedDateUtc
        /// </summary>
        public DateTime? AccessedDateUtc { get => _accessedDateUtc; set => SetField(ref _accessedDateUtc, value); }

        /// <summary>
        /// VerificationLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

        /// <summary>
        /// VerificationLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// VerificationLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// VerificationLog AllowedRoleDelimitedList
        /// </summary>
        public string AllowedRoleDelimitedList { get => _allowedRoleDelimitedList; set => SetField(ref _allowedRoleDelimitedList, value); }

        /// <summary>
        /// VerificationLog AllowedRoles
        /// </summary>
        public IList<EntityReference> AllowedRoles { get => GetField(ref _allowedRoles); set => SetField(ref _allowedRoles, value); }

        /// <summary>
        /// VerificationLog AllowedRolesXml
        /// </summary>
        public string AllowedRolesXml { get => _allowedRolesXml; set => SetField(ref _allowedRolesXml, value); }

        /// <summary>
        /// VerificationLog ArchiveDateUtc
        /// </summary>
        public DateTime? ArchiveDateUtc { get => _archiveDateUtc; set => SetField(ref _archiveDateUtc, value); }

        /// <summary>
        /// VerificationLog ArchivedBy
        /// </summary>
        public string ArchivedBy { get => _archivedBy; set => SetField(ref _archivedBy, value); }

        /// <summary>
        /// VerificationLog ClosingDocumentIndicator
        /// </summary>
        public bool? ClosingDocumentIndicator { get => _closingDocumentIndicator; set => SetField(ref _closingDocumentIndicator, value); }

        /// <summary>
        /// VerificationLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// VerificationLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// VerificationLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// VerificationLog Company
        /// </summary>
        public string Company { get => _company; set => SetField(ref _company, value); }

        /// <summary>
        /// VerificationLog Conditions
        /// </summary>
        public IList<EntityReference> Conditions { get => GetField(ref _conditions); set => SetField(ref _conditions, value); }

        /// <summary>
        /// VerificationLog ConditionsXml
        /// </summary>
        public string ConditionsXml { get => _conditionsXml; set => SetField(ref _conditionsXml, value); }

        /// <summary>
        /// VerificationLog DateAddedUtc
        /// </summary>
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }

        /// <summary>
        /// VerificationLog DateExpected
        /// </summary>
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }

        /// <summary>
        /// VerificationLog DateExpires
        /// </summary>
        public DateTime? DateExpires { get => _dateExpires; set => SetField(ref _dateExpires, value); }

        /// <summary>
        /// VerificationLog DateReceived
        /// </summary>
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        /// <summary>
        /// VerificationLog DateRequested
        /// </summary>
        public DateTime? DateRequested { get => _dateRequested; set => SetField(ref _dateRequested, value); }

        /// <summary>
        /// VerificationLog DateRerequested
        /// </summary>
        public DateTime? DateRerequested { get => _dateRerequested; set => SetField(ref _dateRerequested, value); }

        /// <summary>
        /// VerificationLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// VerificationLog DaysDue
        /// </summary>
        public int? DaysDue { get => _daysDue; set => SetField(ref _daysDue, value); }

        /// <summary>
        /// VerificationLog DaysTillExpire
        /// </summary>
        public int? DaysTillExpire { get => _daysTillExpire; set => SetField(ref _daysTillExpire, value); }

        /// <summary>
        /// VerificationLog Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// VerificationLog DocumentDateTimeType
        /// </summary>
        public string DocumentDateTimeType { get => _documentDateTimeType; set => SetField(ref _documentDateTimeType, value); }

        /// <summary>
        /// VerificationLog DocVerificationsXml
        /// </summary>
        public string DocVerificationsXml { get => _docVerificationsXml; set => SetField(ref _docVerificationsXml, value); }

        /// <summary>
        /// VerificationLog EDisclosureIndicator
        /// </summary>
        public bool? EDisclosureIndicator { get => _eDisclosureIndicator; set => SetField(ref _eDisclosureIndicator, value); }

        /// <summary>
        /// VerificationLog EPassSignature
        /// </summary>
        public string EPassSignature { get => _ePassSignature; set => SetField(ref _ePassSignature, value); }

        /// <summary>
        /// VerificationLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => SetField(ref _expected, value); }

        /// <summary>
        /// VerificationLog Expires
        /// </summary>
        public bool? Expires { get => _expires; set => SetField(ref _expires, value); }

        /// <summary>
        /// VerificationLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// VerificationLog FileAttachmentsXml
        /// </summary>
        public string FileAttachmentsXml { get => _fileAttachmentsXml; set => SetField(ref _fileAttachmentsXml, value); }

        /// <summary>
        /// VerificationLog GroupName
        /// </summary>
        public string GroupName { get => _groupName; set => SetField(ref _groupName, value); }

        /// <summary>
        /// VerificationLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// VerificationLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// VerificationLog IsAssetVerification
        /// </summary>
        public bool? IsAssetVerification { get => _isAssetVerification; set => SetField(ref _isAssetVerification, value); }

        /// <summary>
        /// VerificationLog IsEmploymentVerification
        /// </summary>
        public bool? IsEmploymentVerification { get => _isEmploymentVerification; set => SetField(ref _isEmploymentVerification, value); }

        /// <summary>
        /// VerificationLog IsEPassIndicator
        /// </summary>
        public bool? IsEPassIndicator { get => _isEPassIndicator; set => SetField(ref _isEPassIndicator, value); }

        /// <summary>
        /// VerificationLog IsExpired
        /// </summary>
        public bool? IsExpired { get => _isExpired; set => SetField(ref _isExpired, value); }

        /// <summary>
        /// VerificationLog IsExternalIndicator
        /// </summary>
        public bool? IsExternalIndicator { get => _isExternalIndicator; set => SetField(ref _isExternalIndicator, value); }

        /// <summary>
        /// VerificationLog IsIncomeVerification
        /// </summary>
        public bool? IsIncomeVerification { get => _isIncomeVerification; set => SetField(ref _isIncomeVerification, value); }

        /// <summary>
        /// VerificationLog IsObligationVerification
        /// </summary>
        public bool? IsObligationVerification { get => _isObligationVerification; set => SetField(ref _isObligationVerification, value); }

        /// <summary>
        /// VerificationLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => SetField(ref _isPastDue, value); }

        /// <summary>
        /// VerificationLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// VerificationLog IsThirdPartyDocIndicator
        /// </summary>
        public bool? IsThirdPartyDocIndicator { get => _isThirdPartyDocIndicator; set => SetField(ref _isThirdPartyDocIndicator, value); }

        /// <summary>
        /// VerificationLog IsTPOWebcenterPortalIndicator
        /// </summary>
        public bool? IsTPOWebcenterPortalIndicator { get => _isTPOWebcenterPortalIndicator; set => SetField(ref _isTPOWebcenterPortalIndicator, value); }

        /// <summary>
        /// VerificationLog IsWebCenterIndicator
        /// </summary>
        public bool? IsWebCenterIndicator { get => _isWebCenterIndicator; set => SetField(ref _isWebCenterIndicator, value); }

        /// <summary>
        /// VerificationLog LastAttachmentDateUtc
        /// </summary>
        public DateTime? LastAttachmentDateUtc { get => _lastAttachmentDateUtc; set => SetField(ref _lastAttachmentDateUtc, value); }

        /// <summary>
        /// VerificationLog LogId
        /// </summary>
        public string LogId { get => _logId; set => SetField(ref _logId, value); }

        /// <summary>
        /// VerificationLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// VerificationLog OrderDateUtc
        /// </summary>
        public DateTime? OrderDateUtc { get => _orderDateUtc; set => SetField(ref _orderDateUtc, value); }

        /// <summary>
        /// VerificationLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => SetField(ref _pairId, value); }

        /// <summary>
        /// VerificationLog PreClosingDocumentIndicator
        /// </summary>
        public bool? PreClosingDocumentIndicator { get => _preClosingDocumentIndicator; set => SetField(ref _preClosingDocumentIndicator, value); }

        /// <summary>
        /// VerificationLog Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }

        /// <summary>
        /// VerificationLog ReceiveDateUtc
        /// </summary>
        public DateTime? ReceiveDateUtc { get => _receiveDateUtc; set => SetField(ref _receiveDateUtc, value); }

        /// <summary>
        /// VerificationLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// VerificationLog ReorderDateUtc
        /// </summary>
        public DateTime? ReorderDateUtc { get => _reorderDateUtc; set => SetField(ref _reorderDateUtc, value); }

        /// <summary>
        /// VerificationLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => SetField(ref _requested, value); }

        /// <summary>
        /// VerificationLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// VerificationLog RequestedFrom
        /// </summary>
        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

        /// <summary>
        /// VerificationLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => SetField(ref _rerequested, value); }

        /// <summary>
        /// VerificationLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        /// <summary>
        /// VerificationLog Reviewed
        /// </summary>
        public bool? Reviewed { get => _reviewed; set => SetField(ref _reviewed, value); }

        /// <summary>
        /// VerificationLog ReviewedBy
        /// </summary>
        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        /// <summary>
        /// VerificationLog ReviewedDateUtc
        /// </summary>
        public DateTime? ReviewedDateUtc { get => _reviewedDateUtc; set => SetField(ref _reviewedDateUtc, value); }

        /// <summary>
        /// VerificationLog ShippingReady
        /// </summary>
        public bool? ShippingReady { get => _shippingReady; set => SetField(ref _shippingReady, value); }

        /// <summary>
        /// VerificationLog ShippingReadyBy
        /// </summary>
        public string ShippingReadyBy { get => _shippingReadyBy; set => SetField(ref _shippingReadyBy, value); }

        /// <summary>
        /// VerificationLog ShippingReadyDateUtc
        /// </summary>
        public DateTime? ShippingReadyDateUtc { get => _shippingReadyDateUtc; set => SetField(ref _shippingReadyDateUtc, value); }

        /// <summary>
        /// VerificationLog Stage
        /// </summary>
        public string Stage { get => _stage; set => SetField(ref _stage, value); }

        /// <summary>
        /// VerificationLog Status
        /// </summary>
        public string Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// VerificationLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// VerificationLog Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// VerificationLog UnderwritingReady
        /// </summary>
        public bool? UnderwritingReady { get => _underwritingReady; set => SetField(ref _underwritingReady, value); }

        /// <summary>
        /// VerificationLog UnderwritingReadyBy
        /// </summary>
        public string UnderwritingReadyBy { get => _underwritingReadyBy; set => SetField(ref _underwritingReadyBy, value); }

        /// <summary>
        /// VerificationLog UnderwritingReadyDateUtc
        /// </summary>
        public DateTime? UnderwritingReadyDateUtc { get => _underwritingReadyDateUtc; set => SetField(ref _underwritingReadyDateUtc, value); }
    }
}