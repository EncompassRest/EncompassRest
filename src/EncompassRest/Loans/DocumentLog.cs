using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DocumentLog : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _accessedBy.Dirty
                    || _accessedDateUtc.Dirty
                    || _addedBy.Dirty
                    || _alerts.Dirty
                    || _alertsXml.Dirty
                    || _allowedRoleDelimitedList.Dirty
                    || _allowedRoles.Dirty
                    || _allowedRolesXml.Dirty
                    || _archiveDateUtc.Dirty
                    || _archivedBy.Dirty
                    || _closingDocumentIndicator.Dirty
                    || _commentList.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _company.Dirty
                    || _conditions.Dirty
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
                    || _fileAttachmentReferences.Dirty
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
                    || _underwritingReadyDateUtc.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _accessedBy.Dirty = value;
                _accessedDateUtc.Dirty = value;
                _addedBy.Dirty = value;
                _alerts.Dirty = value;
                _alertsXml.Dirty = value;
                _allowedRoleDelimitedList.Dirty = value;
                _allowedRoles.Dirty = value;
                _allowedRolesXml.Dirty = value;
                _archiveDateUtc.Dirty = value;
                _archivedBy.Dirty = value;
                _closingDocumentIndicator.Dirty = value;
                _commentList.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _company.Dirty = value;
                _conditions.Dirty = value;
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
                _fileAttachmentReferences.Dirty = value;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}