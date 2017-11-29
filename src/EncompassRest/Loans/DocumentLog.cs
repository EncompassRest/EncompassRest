using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DocumentLog : ExtensibleObject
    {
        private DirtyValue<string> _accessedBy;
        public string AccessedBy { get => _accessedBy; set => _accessedBy = value; }
        private DirtyValue<DateTime?> _accessedDateUtc;
        public DateTime? AccessedDateUtc { get => _accessedDateUtc; set => _accessedDateUtc = value; }
        private DirtyValue<string> _addedBy;
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<string> _allowedRoleDelimitedList;
        public string AllowedRoleDelimitedList { get => _allowedRoleDelimitedList; set => _allowedRoleDelimitedList = value; }
        private DirtyList<EntityReference> _allowedRoles;
        public IList<EntityReference> AllowedRoles { get => _allowedRoles ?? (_allowedRoles = new DirtyList<EntityReference>()); set => _allowedRoles = new DirtyList<EntityReference>(value); }
        private DirtyValue<string> _allowedRolesXml;
        public string AllowedRolesXml { get => _allowedRolesXml; set => _allowedRolesXml = value; }
        private DirtyValue<DateTime?> _archiveDateUtc;
        public DateTime? ArchiveDateUtc { get => _archiveDateUtc; set => _archiveDateUtc = value; }
        private DirtyValue<string> _archivedBy;
        public string ArchivedBy { get => _archivedBy; set => _archivedBy = value; }
        private DirtyValue<bool?> _closingDocumentIndicator;
        public bool? ClosingDocumentIndicator { get => _closingDocumentIndicator; set => _closingDocumentIndicator = value; }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _company;
        public string Company { get => _company; set => _company = value; }
        private DirtyList<EntityReference> _conditions;
        public IList<EntityReference> Conditions { get => _conditions ?? (_conditions = new DirtyList<EntityReference>()); set => _conditions = new DirtyList<EntityReference>(value); }
        private DirtyValue<string> _conditionsXml;
        public string ConditionsXml { get => _conditionsXml; set => _conditionsXml = value; }
        private DirtyValue<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => _dateAddedUtc = value; }
        private DirtyValue<DateTime?> _dateExpected;
        public DateTime? DateExpected { get => _dateExpected; set => _dateExpected = value; }
        private DirtyValue<DateTime?> _dateExpires;
        public DateTime? DateExpires { get => _dateExpires; set => _dateExpires = value; }
        private DirtyValue<DateTime?> _dateReceived;
        public DateTime? DateReceived { get => _dateReceived; set => _dateReceived = value; }
        private DirtyValue<DateTime?> _dateRequested;
        public DateTime? DateRequested { get => _dateRequested; set => _dateRequested = value; }
        private DirtyValue<DateTime?> _dateRerequested;
        public DateTime? DateRerequested { get => _dateRerequested; set => _dateRerequested = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<int?> _daysDue;
        public int? DaysDue { get => _daysDue; set => _daysDue = value; }
        private DirtyValue<int?> _daysTillExpire;
        public int? DaysTillExpire { get => _daysTillExpire; set => _daysTillExpire = value; }
        private DirtyValue<string> _documentDateTimeType;
        public string DocumentDateTimeType { get => _documentDateTimeType; set => _documentDateTimeType = value; }
        private DirtyValue<bool?> _eDisclosureIndicator;
        public bool? EDisclosureIndicator { get => _eDisclosureIndicator; set => _eDisclosureIndicator = value; }
        private DirtyValue<string> _ePassSignature;
        public string EPassSignature { get => _ePassSignature; set => _ePassSignature = value; }
        private DirtyValue<bool?> _expected;
        public bool? Expected { get => _expected; set => _expected = value; }
        private DirtyValue<bool?> _expires;
        public bool? Expires { get => _expires; set => _expires = value; }
        private DirtyList<FileAttachmentReference> _fileAttachmentReferences;
        public IList<FileAttachmentReference> FileAttachmentReferences { get => _fileAttachmentReferences ?? (_fileAttachmentReferences = new DirtyList<FileAttachmentReference>()); set => _fileAttachmentReferences = new DirtyList<FileAttachmentReference>(value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _fileAttachmentsXml;
        public string FileAttachmentsXml { get => _fileAttachmentsXml; set => _fileAttachmentsXml = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEPassIndicator;
        public bool? IsEPassIndicator { get => _isEPassIndicator; set => _isEPassIndicator = value; }
        private DirtyValue<bool?> _isExpired;
        public bool? IsExpired { get => _isExpired; set => _isExpired = value; }
        private DirtyValue<bool?> _isPastDue;
        public bool? IsPastDue { get => _isPastDue; set => _isPastDue = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<bool?> _isThirdPartyDocIndicator;
        public bool? IsThirdPartyDocIndicator { get => _isThirdPartyDocIndicator; set => _isThirdPartyDocIndicator = value; }
        private DirtyValue<bool?> _isTPOWebcenterPortalIndicator;
        public bool? IsTPOWebcenterPortalIndicator { get => _isTPOWebcenterPortalIndicator; set => _isTPOWebcenterPortalIndicator = value; }
        private DirtyValue<bool?> _isWebCenterIndicator;
        public bool? IsWebCenterIndicator { get => _isWebCenterIndicator; set => _isWebCenterIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<DateTime?> _orderDateUtc;
        public DateTime? OrderDateUtc { get => _orderDateUtc; set => _orderDateUtc = value; }
        private DirtyValue<string> _pairId;
        public string PairId { get => _pairId; set => _pairId = value; }
        private DirtyValue<bool?> _preClosingDocumentIndicator;
        public bool? PreClosingDocumentIndicator { get => _preClosingDocumentIndicator; set => _preClosingDocumentIndicator = value; }
        private DirtyValue<bool?> _received;
        public bool? Received { get => _received; set => _received = value; }
        private DirtyValue<DateTime?> _receiveDateUtc;
        public DateTime? ReceiveDateUtc { get => _receiveDateUtc; set => _receiveDateUtc = value; }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<DateTime?> _reorderDateUtc;
        public DateTime? ReorderDateUtc { get => _reorderDateUtc; set => _reorderDateUtc = value; }
        private DirtyValue<bool?> _requested;
        public bool? Requested { get => _requested; set => _requested = value; }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<string> _requestedFrom;
        public string RequestedFrom { get => _requestedFrom; set => _requestedFrom = value; }
        private DirtyValue<bool?> _rerequested;
        public bool? Rerequested { get => _rerequested; set => _rerequested = value; }
        private DirtyValue<string> _rerequestedBy;
        public string RerequestedBy { get => _rerequestedBy; set => _rerequestedBy = value; }
        private DirtyValue<bool?> _reviewed;
        public bool? Reviewed { get => _reviewed; set => _reviewed = value; }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get => _reviewedBy; set => _reviewedBy = value; }
        private DirtyValue<DateTime?> _reviewedDateUtc;
        public DateTime? ReviewedDateUtc { get => _reviewedDateUtc; set => _reviewedDateUtc = value; }
        private DirtyValue<bool?> _shippingReady;
        public bool? ShippingReady { get => _shippingReady; set => _shippingReady = value; }
        private DirtyValue<string> _shippingReadyBy;
        public string ShippingReadyBy { get => _shippingReadyBy; set => _shippingReadyBy = value; }
        private DirtyValue<DateTime?> _shippingReadyDateUtc;
        public DateTime? ShippingReadyDateUtc { get => _shippingReadyDateUtc; set => _shippingReadyDateUtc = value; }
        private DirtyValue<string> _stage;
        public string Stage { get => _stage; set => _stage = value; }
        private DirtyValue<string> _status;
        public string Status { get => _status; set => _status = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<bool?> _underwritingReady;
        public bool? UnderwritingReady { get => _underwritingReady; set => _underwritingReady = value; }
        private DirtyValue<string> _underwritingReadyBy;
        public string UnderwritingReadyBy { get => _underwritingReadyBy; set => _underwritingReadyBy = value; }
        private DirtyValue<DateTime?> _underwritingReadyDateUtc;
        public DateTime? UnderwritingReadyDateUtc { get => _underwritingReadyDateUtc; set => _underwritingReadyDateUtc = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _accessedBy.Dirty
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
                    || _documentDateTimeType.Dirty
                    || _eDisclosureIndicator.Dirty
                    || _ePassSignature.Dirty
                    || _expected.Dirty
                    || _expires.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _fileAttachmentsXml.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isEPassIndicator.Dirty
                    || _isExpired.Dirty
                    || _isPastDue.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _isThirdPartyDocIndicator.Dirty
                    || _isTPOWebcenterPortalIndicator.Dirty
                    || _isWebCenterIndicator.Dirty
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
            }
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
                _documentDateTimeType.Dirty = value;
                _eDisclosureIndicator.Dirty = value;
                _ePassSignature.Dirty = value;
                _expected.Dirty = value;
                _expires.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _fileAttachmentsXml.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isEPassIndicator.Dirty = value;
                _isExpired.Dirty = value;
                _isPastDue.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _isThirdPartyDocIndicator.Dirty = value;
                _isTPOWebcenterPortalIndicator.Dirty = value;
                _isWebCenterIndicator.Dirty = value;
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