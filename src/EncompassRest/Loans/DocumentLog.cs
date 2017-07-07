using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DocumentLog : IClean
    {
        private Value<string> _accessedBy;
        public string AccessedBy { get { return _accessedBy; } set { _accessedBy = value; } }
        private Value<DateTime?> _accessedDateUtc;
        public DateTime? AccessedDateUtc { get { return _accessedDateUtc; } set { _accessedDateUtc = value; } }
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private Value<string> _allowedRoleDelimitedList;
        public string AllowedRoleDelimitedList { get { return _allowedRoleDelimitedList; } set { _allowedRoleDelimitedList = value; } }
        private Value<List<EntityReference>> _allowedRoles;
        public List<EntityReference> AllowedRoles { get { return _allowedRoles; } set { _allowedRoles = value; } }
        private Value<string> _allowedRolesXml;
        public string AllowedRolesXml { get { return _allowedRolesXml; } set { _allowedRolesXml = value; } }
        private Value<DateTime?> _archiveDateUtc;
        public DateTime? ArchiveDateUtc { get { return _archiveDateUtc; } set { _archiveDateUtc = value; } }
        private Value<string> _archivedBy;
        public string ArchivedBy { get { return _archivedBy; } set { _archivedBy = value; } }
        private Value<bool?> _closingDocumentIndicator;
        public bool? ClosingDocumentIndicator { get { return _closingDocumentIndicator; } set { _closingDocumentIndicator = value; } }
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _company;
        public string Company { get { return _company; } set { _company = value; } }
        private Value<List<EntityReference>> _conditions;
        public List<EntityReference> Conditions { get { return _conditions; } set { _conditions = value; } }
        private Value<string> _conditionsXml;
        public string ConditionsXml { get { return _conditionsXml; } set { _conditionsXml = value; } }
        private Value<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        private Value<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        private Value<DateTime?> _dateExpires;
        public DateTime? DateExpires { get { return _dateExpires; } set { _dateExpires = value; } }
        private Value<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private Value<DateTime?> _dateRequested;
        public DateTime? DateRequested { get { return _dateRequested; } set { _dateRequested = value; } }
        private Value<DateTime?> _dateRerequested;
        public DateTime? DateRerequested { get { return _dateRerequested; } set { _dateRerequested = value; } }
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private Value<int?> _daysDue;
        public int? DaysDue { get { return _daysDue; } set { _daysDue = value; } }
        private Value<int?> _daysTillExpire;
        public int? DaysTillExpire { get { return _daysTillExpire; } set { _daysTillExpire = value; } }
        private Value<string> _documentDateTimeType;
        public string DocumentDateTimeType { get { return _documentDateTimeType; } set { _documentDateTimeType = value; } }
        private Value<bool?> _eDisclosureIndicator;
        public bool? EDisclosureIndicator { get { return _eDisclosureIndicator; } set { _eDisclosureIndicator = value; } }
        private Value<string> _ePassSignature;
        public string EPassSignature { get { return _ePassSignature; } set { _ePassSignature = value; } }
        private Value<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        private Value<bool?> _expires;
        public bool? Expires { get { return _expires; } set { _expires = value; } }
        private Value<List<FileAttachmentReference>> _fileAttachmentReferences;
        public List<FileAttachmentReference> FileAttachmentReferences { get { return _fileAttachmentReferences; } set { _fileAttachmentReferences = value; } }
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private Value<string> _fileAttachmentsXml;
        public string FileAttachmentsXml { get { return _fileAttachmentsXml; } set { _fileAttachmentsXml = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isEPassIndicator;
        public bool? IsEPassIndicator { get { return _isEPassIndicator; } set { _isEPassIndicator = value; } }
        private Value<bool?> _isExpired;
        public bool? IsExpired { get { return _isExpired; } set { _isExpired = value; } }
        private Value<bool?> _isPastDue;
        public bool? IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private Value<bool?> _isThirdPartyDocIndicator;
        public bool? IsThirdPartyDocIndicator { get { return _isThirdPartyDocIndicator; } set { _isThirdPartyDocIndicator = value; } }
        private Value<bool?> _isTPOWebcenterPortalIndicator;
        public bool? IsTPOWebcenterPortalIndicator { get { return _isTPOWebcenterPortalIndicator; } set { _isTPOWebcenterPortalIndicator = value; } }
        private Value<bool?> _isWebCenterIndicator;
        public bool? IsWebCenterIndicator { get { return _isWebCenterIndicator; } set { _isWebCenterIndicator = value; } }
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private Value<DateTime?> _orderDateUtc;
        public DateTime? OrderDateUtc { get { return _orderDateUtc; } set { _orderDateUtc = value; } }
        private Value<string> _pairId;
        public string PairId { get { return _pairId; } set { _pairId = value; } }
        private Value<bool?> _preClosingDocumentIndicator;
        public bool? PreClosingDocumentIndicator { get { return _preClosingDocumentIndicator; } set { _preClosingDocumentIndicator = value; } }
        private Value<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        private Value<DateTime?> _receiveDateUtc;
        public DateTime? ReceiveDateUtc { get { return _receiveDateUtc; } set { _receiveDateUtc = value; } }
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private Value<DateTime?> _reorderDateUtc;
        public DateTime? ReorderDateUtc { get { return _reorderDateUtc; } set { _reorderDateUtc = value; } }
        private Value<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private Value<string> _requestedFrom;
        public string RequestedFrom { get { return _requestedFrom; } set { _requestedFrom = value; } }
        private Value<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        private Value<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private Value<bool?> _reviewed;
        public bool? Reviewed { get { return _reviewed; } set { _reviewed = value; } }
        private Value<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
        private Value<DateTime?> _reviewedDateUtc;
        public DateTime? ReviewedDateUtc { get { return _reviewedDateUtc; } set { _reviewedDateUtc = value; } }
        private Value<bool?> _shippingReady;
        public bool? ShippingReady { get { return _shippingReady; } set { _shippingReady = value; } }
        private Value<string> _shippingReadyBy;
        public string ShippingReadyBy { get { return _shippingReadyBy; } set { _shippingReadyBy = value; } }
        private Value<DateTime?> _shippingReadyDateUtc;
        public DateTime? ShippingReadyDateUtc { get { return _shippingReadyDateUtc; } set { _shippingReadyDateUtc = value; } }
        private Value<string> _stage;
        public string Stage { get { return _stage; } set { _stage = value; } }
        private Value<string> _status;
        public string Status { get { return _status; } set { _status = value; } }
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<bool?> _underwritingReady;
        public bool? UnderwritingReady { get { return _underwritingReady; } set { _underwritingReady = value; } }
        private Value<string> _underwritingReadyBy;
        public string UnderwritingReadyBy { get { return _underwritingReadyBy; } set { _underwritingReadyBy = value; } }
        private Value<DateTime?> _underwritingReadyDateUtc;
        public DateTime? UnderwritingReadyDateUtc { get { return _underwritingReadyDateUtc; } set { _underwritingReadyDateUtc = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accessedBy.Clean
                    && _accessedDateUtc.Clean
                    && _addedBy.Clean
                    && _alerts.Clean
                    && _alertsXml.Clean
                    && _allowedRoleDelimitedList.Clean
                    && _allowedRoles.Clean
                    && _allowedRolesXml.Clean
                    && _archiveDateUtc.Clean
                    && _archivedBy.Clean
                    && _closingDocumentIndicator.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _company.Clean
                    && _conditions.Clean
                    && _conditionsXml.Clean
                    && _dateAddedUtc.Clean
                    && _dateExpected.Clean
                    && _dateExpires.Clean
                    && _dateReceived.Clean
                    && _dateRequested.Clean
                    && _dateRerequested.Clean
                    && _dateUtc.Clean
                    && _daysDue.Clean
                    && _daysTillExpire.Clean
                    && _documentDateTimeType.Clean
                    && _eDisclosureIndicator.Clean
                    && _ePassSignature.Clean
                    && _expected.Clean
                    && _expires.Clean
                    && _fileAttachmentReferences.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _fileAttachmentsXml.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isEPassIndicator.Clean
                    && _isExpired.Clean
                    && _isPastDue.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _isThirdPartyDocIndicator.Clean
                    && _isTPOWebcenterPortalIndicator.Clean
                    && _isWebCenterIndicator.Clean
                    && _logRecordIndex.Clean
                    && _orderDateUtc.Clean
                    && _pairId.Clean
                    && _preClosingDocumentIndicator.Clean
                    && _received.Clean
                    && _receiveDateUtc.Clean
                    && _receivedBy.Clean
                    && _reorderDateUtc.Clean
                    && _requested.Clean
                    && _requestedBy.Clean
                    && _requestedFrom.Clean
                    && _rerequested.Clean
                    && _rerequestedBy.Clean
                    && _reviewed.Clean
                    && _reviewedBy.Clean
                    && _reviewedDateUtc.Clean
                    && _shippingReady.Clean
                    && _shippingReadyBy.Clean
                    && _shippingReadyDateUtc.Clean
                    && _stage.Clean
                    && _status.Clean
                    && _systemId.Clean
                    && _title.Clean
                    && _underwritingReady.Clean
                    && _underwritingReadyBy.Clean
                    && _underwritingReadyDateUtc.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var accessedBy = _accessedBy; accessedBy.Clean = value; _accessedBy = accessedBy;
                var accessedDateUtc = _accessedDateUtc; accessedDateUtc.Clean = value; _accessedDateUtc = accessedDateUtc;
                var addedBy = _addedBy; addedBy.Clean = value; _addedBy = addedBy;
                var alerts = _alerts; alerts.Clean = value; _alerts = alerts;
                var alertsXml = _alertsXml; alertsXml.Clean = value; _alertsXml = alertsXml;
                var allowedRoleDelimitedList = _allowedRoleDelimitedList; allowedRoleDelimitedList.Clean = value; _allowedRoleDelimitedList = allowedRoleDelimitedList;
                var allowedRoles = _allowedRoles; allowedRoles.Clean = value; _allowedRoles = allowedRoles;
                var allowedRolesXml = _allowedRolesXml; allowedRolesXml.Clean = value; _allowedRolesXml = allowedRolesXml;
                var archiveDateUtc = _archiveDateUtc; archiveDateUtc.Clean = value; _archiveDateUtc = archiveDateUtc;
                var archivedBy = _archivedBy; archivedBy.Clean = value; _archivedBy = archivedBy;
                var closingDocumentIndicator = _closingDocumentIndicator; closingDocumentIndicator.Clean = value; _closingDocumentIndicator = closingDocumentIndicator;
                var commentList = _commentList; commentList.Clean = value; _commentList = commentList;
                var commentListXml = _commentListXml; commentListXml.Clean = value; _commentListXml = commentListXml;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var company = _company; company.Clean = value; _company = company;
                var conditions = _conditions; conditions.Clean = value; _conditions = conditions;
                var conditionsXml = _conditionsXml; conditionsXml.Clean = value; _conditionsXml = conditionsXml;
                var dateAddedUtc = _dateAddedUtc; dateAddedUtc.Clean = value; _dateAddedUtc = dateAddedUtc;
                var dateExpected = _dateExpected; dateExpected.Clean = value; _dateExpected = dateExpected;
                var dateExpires = _dateExpires; dateExpires.Clean = value; _dateExpires = dateExpires;
                var dateReceived = _dateReceived; dateReceived.Clean = value; _dateReceived = dateReceived;
                var dateRequested = _dateRequested; dateRequested.Clean = value; _dateRequested = dateRequested;
                var dateRerequested = _dateRerequested; dateRerequested.Clean = value; _dateRerequested = dateRerequested;
                var dateUtc = _dateUtc; dateUtc.Clean = value; _dateUtc = dateUtc;
                var daysDue = _daysDue; daysDue.Clean = value; _daysDue = daysDue;
                var daysTillExpire = _daysTillExpire; daysTillExpire.Clean = value; _daysTillExpire = daysTillExpire;
                var documentDateTimeType = _documentDateTimeType; documentDateTimeType.Clean = value; _documentDateTimeType = documentDateTimeType;
                var eDisclosureIndicator = _eDisclosureIndicator; eDisclosureIndicator.Clean = value; _eDisclosureIndicator = eDisclosureIndicator;
                var ePassSignature = _ePassSignature; ePassSignature.Clean = value; _ePassSignature = ePassSignature;
                var expected = _expected; expected.Clean = value; _expected = expected;
                var expires = _expires; expires.Clean = value; _expires = expires;
                var fileAttachmentReferences = _fileAttachmentReferences; fileAttachmentReferences.Clean = value; _fileAttachmentReferences = fileAttachmentReferences;
                var fileAttachmentsMigrated = _fileAttachmentsMigrated; fileAttachmentsMigrated.Clean = value; _fileAttachmentsMigrated = fileAttachmentsMigrated;
                var fileAttachmentsXml = _fileAttachmentsXml; fileAttachmentsXml.Clean = value; _fileAttachmentsXml = fileAttachmentsXml;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isEPassIndicator = _isEPassIndicator; isEPassIndicator.Clean = value; _isEPassIndicator = isEPassIndicator;
                var isExpired = _isExpired; isExpired.Clean = value; _isExpired = isExpired;
                var isPastDue = _isPastDue; isPastDue.Clean = value; _isPastDue = isPastDue;
                var isSystemSpecificIndicator = _isSystemSpecificIndicator; isSystemSpecificIndicator.Clean = value; _isSystemSpecificIndicator = isSystemSpecificIndicator;
                var isThirdPartyDocIndicator = _isThirdPartyDocIndicator; isThirdPartyDocIndicator.Clean = value; _isThirdPartyDocIndicator = isThirdPartyDocIndicator;
                var isTPOWebcenterPortalIndicator = _isTPOWebcenterPortalIndicator; isTPOWebcenterPortalIndicator.Clean = value; _isTPOWebcenterPortalIndicator = isTPOWebcenterPortalIndicator;
                var isWebCenterIndicator = _isWebCenterIndicator; isWebCenterIndicator.Clean = value; _isWebCenterIndicator = isWebCenterIndicator;
                var logRecordIndex = _logRecordIndex; logRecordIndex.Clean = value; _logRecordIndex = logRecordIndex;
                var orderDateUtc = _orderDateUtc; orderDateUtc.Clean = value; _orderDateUtc = orderDateUtc;
                var pairId = _pairId; pairId.Clean = value; _pairId = pairId;
                var preClosingDocumentIndicator = _preClosingDocumentIndicator; preClosingDocumentIndicator.Clean = value; _preClosingDocumentIndicator = preClosingDocumentIndicator;
                var received = _received; received.Clean = value; _received = received;
                var receiveDateUtc = _receiveDateUtc; receiveDateUtc.Clean = value; _receiveDateUtc = receiveDateUtc;
                var receivedBy = _receivedBy; receivedBy.Clean = value; _receivedBy = receivedBy;
                var reorderDateUtc = _reorderDateUtc; reorderDateUtc.Clean = value; _reorderDateUtc = reorderDateUtc;
                var requested = _requested; requested.Clean = value; _requested = requested;
                var requestedBy = _requestedBy; requestedBy.Clean = value; _requestedBy = requestedBy;
                var requestedFrom = _requestedFrom; requestedFrom.Clean = value; _requestedFrom = requestedFrom;
                var rerequested = _rerequested; rerequested.Clean = value; _rerequested = rerequested;
                var rerequestedBy = _rerequestedBy; rerequestedBy.Clean = value; _rerequestedBy = rerequestedBy;
                var reviewed = _reviewed; reviewed.Clean = value; _reviewed = reviewed;
                var reviewedBy = _reviewedBy; reviewedBy.Clean = value; _reviewedBy = reviewedBy;
                var reviewedDateUtc = _reviewedDateUtc; reviewedDateUtc.Clean = value; _reviewedDateUtc = reviewedDateUtc;
                var shippingReady = _shippingReady; shippingReady.Clean = value; _shippingReady = shippingReady;
                var shippingReadyBy = _shippingReadyBy; shippingReadyBy.Clean = value; _shippingReadyBy = shippingReadyBy;
                var shippingReadyDateUtc = _shippingReadyDateUtc; shippingReadyDateUtc.Clean = value; _shippingReadyDateUtc = shippingReadyDateUtc;
                var stage = _stage; stage.Clean = value; _stage = stage;
                var status = _status; status.Clean = value; _status = status;
                var systemId = _systemId; systemId.Clean = value; _systemId = systemId;
                var title = _title; title.Clean = value; _title = title;
                var underwritingReady = _underwritingReady; underwritingReady.Clean = value; _underwritingReady = underwritingReady;
                var underwritingReadyBy = _underwritingReadyBy; underwritingReadyBy.Clean = value; _underwritingReadyBy = underwritingReadyBy;
                var underwritingReadyDateUtc = _underwritingReadyDateUtc; underwritingReadyDateUtc.Clean = value; _underwritingReadyDateUtc = underwritingReadyDateUtc;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public DocumentLog()
        {
            Clean = true;
        }
    }
}