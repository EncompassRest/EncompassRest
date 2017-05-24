using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class VerificationLog
    {
        private Value<string> _accessedBy;
        public string AccessedBy { get { return _accessedBy; } set { _accessedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccessedBy() => !_accessedBy.Clean;
        private Value<DateTime?> _accessedDateUtc;
        public DateTime? AccessedDateUtc { get { return _accessedDateUtc; } set { _accessedDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccessedDateUtc() => !_accessedDateUtc.Clean;
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddedBy() => !_addedBy.Clean;
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !_alertsXml.Clean;
        private Value<string> _allowedRoleDelimitedList;
        public string AllowedRoleDelimitedList { get { return _allowedRoleDelimitedList; } set { _allowedRoleDelimitedList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedRoleDelimitedList() => !_allowedRoleDelimitedList.Clean;
        private Value<List<EntityReference>> _allowedRoles;
        public List<EntityReference> AllowedRoles { get { return _allowedRoles; } set { _allowedRoles = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedRoles() => !_allowedRoles.Clean;
        private Value<string> _allowedRolesXml;
        public string AllowedRolesXml { get { return _allowedRolesXml; } set { _allowedRolesXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowedRolesXml() => !_allowedRolesXml.Clean;
        private Value<DateTime?> _archiveDateUtc;
        public DateTime? ArchiveDateUtc { get { return _archiveDateUtc; } set { _archiveDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchiveDateUtc() => !_archiveDateUtc.Clean;
        private Value<string> _archivedBy;
        public string ArchivedBy { get { return _archivedBy; } set { _archivedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchivedBy() => !_archivedBy.Clean;
        private Value<bool?> _closingDocumentIndicator;
        public bool? ClosingDocumentIndicator { get { return _closingDocumentIndicator; } set { _closingDocumentIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDocumentIndicator() => !_closingDocumentIndicator.Clean;
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !_commentList.Clean;
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !_commentListXml.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<string> _company;
        public string Company { get { return _company; } set { _company = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompany() => !_company.Clean;
        private Value<List<EntityReference>> _conditions;
        public List<EntityReference> Conditions { get { return _conditions; } set { _conditions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditions() => !_conditions.Clean;
        private Value<string> _conditionsXml;
        public string ConditionsXml { get { return _conditionsXml; } set { _conditionsXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditionsXml() => !_conditionsXml.Clean;
        private Value<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAddedUtc() => !_dateAddedUtc.Clean;
        private Value<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpected() => !_dateExpected.Clean;
        private Value<DateTime?> _dateExpires;
        public DateTime? DateExpires { get { return _dateExpires; } set { _dateExpires = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateExpires() => !_dateExpires.Clean;
        private Value<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateReceived() => !_dateReceived.Clean;
        private Value<DateTime?> _dateRequested;
        public DateTime? DateRequested { get { return _dateRequested; } set { _dateRequested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRequested() => !_dateRequested.Clean;
        private Value<DateTime?> _dateRerequested;
        public DateTime? DateRerequested { get { return _dateRerequested; } set { _dateRerequested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateRerequested() => !_dateRerequested.Clean;
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !_dateUtc.Clean;
        private Value<int?> _daysDue;
        public int? DaysDue { get { return _daysDue; } set { _daysDue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysDue() => !_daysDue.Clean;
        private Value<int?> _daysTillExpire;
        public int? DaysTillExpire { get { return _daysTillExpire; } set { _daysTillExpire = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysTillExpire() => !_daysTillExpire.Clean;
        private Value<string> _documentDateTimeType;
        public string DocumentDateTimeType { get { return _documentDateTimeType; } set { _documentDateTimeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentDateTimeType() => !_documentDateTimeType.Clean;
        private Value<bool?> _eDisclosureIndicator;
        public bool? EDisclosureIndicator { get { return _eDisclosureIndicator; } set { _eDisclosureIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureIndicator() => !_eDisclosureIndicator.Clean;
        private Value<string> _ePassSignature;
        public string EPassSignature { get { return _ePassSignature; } set { _ePassSignature = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEPassSignature() => !_ePassSignature.Clean;
        private Value<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpected() => !_expected.Clean;
        private Value<bool?> _expires;
        public bool? Expires { get { return _expires; } set { _expires = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpires() => !_expires.Clean;
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !_fileAttachmentsMigrated.Clean;
        private Value<string> _fileAttachmentsXml;
        public string FileAttachmentsXml { get { return _fileAttachmentsXml; } set { _fileAttachmentsXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsXml() => !_fileAttachmentsXml.Clean;
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !_guid.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isEPassIndicator;
        public bool? IsEPassIndicator { get { return _isEPassIndicator; } set { _isEPassIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEPassIndicator() => !_isEPassIndicator.Clean;
        private Value<bool?> _isExpired;
        public bool? IsExpired { get { return _isExpired; } set { _isExpired = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsExpired() => !_isExpired.Clean;
        private Value<bool?> _isExternalIndicator;
        public bool? IsExternalIndicator { get { return _isExternalIndicator; } set { _isExternalIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsExternalIndicator() => !_isExternalIndicator.Clean;
        private Value<bool?> _isPastDue;
        public bool? IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsPastDue() => !_isPastDue.Clean;
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !_isSystemSpecificIndicator.Clean;
        private Value<bool?> _isThirdPartyDocIndicator;
        public bool? IsThirdPartyDocIndicator { get { return _isThirdPartyDocIndicator; } set { _isThirdPartyDocIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsThirdPartyDocIndicator() => !_isThirdPartyDocIndicator.Clean;
        private Value<bool?> _isTPOWebcenterPortalIndicator;
        public bool? IsTPOWebcenterPortalIndicator { get { return _isTPOWebcenterPortalIndicator; } set { _isTPOWebcenterPortalIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsTPOWebcenterPortalIndicator() => !_isTPOWebcenterPortalIndicator.Clean;
        private Value<bool?> _isWebCenterIndicator;
        public bool? IsWebCenterIndicator { get { return _isWebCenterIndicator; } set { _isWebCenterIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsWebCenterIndicator() => !_isWebCenterIndicator.Clean;
        private Value<string> _logId;
        public string LogId { get { return _logId; } set { _logId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogId() => !_logId.Clean;
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !_logRecordIndex.Clean;
        private Value<DateTime?> _orderDateUtc;
        public DateTime? OrderDateUtc { get { return _orderDateUtc; } set { _orderDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderDateUtc() => !_orderDateUtc.Clean;
        private Value<string> _pairId;
        public string PairId { get { return _pairId; } set { _pairId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePairId() => !_pairId.Clean;
        private Value<bool?> _preClosingDocumentIndicator;
        public bool? PreClosingDocumentIndicator { get { return _preClosingDocumentIndicator; } set { _preClosingDocumentIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreClosingDocumentIndicator() => !_preClosingDocumentIndicator.Clean;
        private Value<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceived() => !_received.Clean;
        private Value<DateTime?> _receiveDateUtc;
        public DateTime? ReceiveDateUtc { get { return _receiveDateUtc; } set { _receiveDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceiveDateUtc() => !_receiveDateUtc.Clean;
        private Value<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !_receivedBy.Clean;
        private Value<DateTime?> _reorderDateUtc;
        public DateTime? ReorderDateUtc { get { return _reorderDateUtc; } set { _reorderDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReorderDateUtc() => !_reorderDateUtc.Clean;
        private Value<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequested() => !_requested.Clean;
        private Value<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedBy() => !_requestedBy.Clean;
        private Value<string> _requestedFrom;
        public string RequestedFrom { get { return _requestedFrom; } set { _requestedFrom = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedFrom() => !_requestedFrom.Clean;
        private Value<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRerequested() => !_rerequested.Clean;
        private Value<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRerequestedBy() => !_rerequestedBy.Clean;
        private Value<bool?> _reviewed;
        public bool? Reviewed { get { return _reviewed; } set { _reviewed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewed() => !_reviewed.Clean;
        private Value<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewedBy() => !_reviewedBy.Clean;
        private Value<DateTime?> _reviewedDateUtc;
        public DateTime? ReviewedDateUtc { get { return _reviewedDateUtc; } set { _reviewedDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReviewedDateUtc() => !_reviewedDateUtc.Clean;
        private Value<bool?> _shippingReady;
        public bool? ShippingReady { get { return _shippingReady; } set { _shippingReady = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingReady() => !_shippingReady.Clean;
        private Value<string> _shippingReadyBy;
        public string ShippingReadyBy { get { return _shippingReadyBy; } set { _shippingReadyBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingReadyBy() => !_shippingReadyBy.Clean;
        private Value<DateTime?> _shippingReadyDateUtc;
        public DateTime? ShippingReadyDateUtc { get { return _shippingReadyDateUtc; } set { _shippingReadyDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShippingReadyDateUtc() => !_shippingReadyDateUtc.Clean;
        private Value<string> _stage;
        public string Stage { get { return _stage; } set { _stage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStage() => !_stage.Clean;
        private Value<string> _status;
        public string Status { get { return _status; } set { _status = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatus() => !_status.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private Value<bool?> _underwritingReady;
        public bool? UnderwritingReady { get { return _underwritingReady; } set { _underwritingReady = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingReady() => !_underwritingReady.Clean;
        private Value<string> _underwritingReadyBy;
        public string UnderwritingReadyBy { get { return _underwritingReadyBy; } set { _underwritingReadyBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingReadyBy() => !_underwritingReadyBy.Clean;
        private Value<DateTime?> _underwritingReadyDateUtc;
        public DateTime? UnderwritingReadyDateUtc { get { return _underwritingReadyDateUtc; } set { _underwritingReadyDateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingReadyDateUtc() => !_underwritingReadyDateUtc.Clean;
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
                    && _fileAttachmentsMigrated.Clean
                    && _fileAttachmentsXml.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isEPassIndicator.Clean
                    && _isExpired.Clean
                    && _isExternalIndicator.Clean
                    && _isPastDue.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _isThirdPartyDocIndicator.Clean
                    && _isTPOWebcenterPortalIndicator.Clean
                    && _isWebCenterIndicator.Clean
                    && _logId.Clean
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
                var v0 = _accessedBy; v0.Clean = value; _accessedBy = v0;
                var v1 = _accessedDateUtc; v1.Clean = value; _accessedDateUtc = v1;
                var v2 = _addedBy; v2.Clean = value; _addedBy = v2;
                var v3 = _alerts; v3.Clean = value; _alerts = v3;
                var v4 = _alertsXml; v4.Clean = value; _alertsXml = v4;
                var v5 = _allowedRoleDelimitedList; v5.Clean = value; _allowedRoleDelimitedList = v5;
                var v6 = _allowedRoles; v6.Clean = value; _allowedRoles = v6;
                var v7 = _allowedRolesXml; v7.Clean = value; _allowedRolesXml = v7;
                var v8 = _archiveDateUtc; v8.Clean = value; _archiveDateUtc = v8;
                var v9 = _archivedBy; v9.Clean = value; _archivedBy = v9;
                var v10 = _closingDocumentIndicator; v10.Clean = value; _closingDocumentIndicator = v10;
                var v11 = _commentList; v11.Clean = value; _commentList = v11;
                var v12 = _commentListXml; v12.Clean = value; _commentListXml = v12;
                var v13 = _comments; v13.Clean = value; _comments = v13;
                var v14 = _company; v14.Clean = value; _company = v14;
                var v15 = _conditions; v15.Clean = value; _conditions = v15;
                var v16 = _conditionsXml; v16.Clean = value; _conditionsXml = v16;
                var v17 = _dateAddedUtc; v17.Clean = value; _dateAddedUtc = v17;
                var v18 = _dateExpected; v18.Clean = value; _dateExpected = v18;
                var v19 = _dateExpires; v19.Clean = value; _dateExpires = v19;
                var v20 = _dateReceived; v20.Clean = value; _dateReceived = v20;
                var v21 = _dateRequested; v21.Clean = value; _dateRequested = v21;
                var v22 = _dateRerequested; v22.Clean = value; _dateRerequested = v22;
                var v23 = _dateUtc; v23.Clean = value; _dateUtc = v23;
                var v24 = _daysDue; v24.Clean = value; _daysDue = v24;
                var v25 = _daysTillExpire; v25.Clean = value; _daysTillExpire = v25;
                var v26 = _documentDateTimeType; v26.Clean = value; _documentDateTimeType = v26;
                var v27 = _eDisclosureIndicator; v27.Clean = value; _eDisclosureIndicator = v27;
                var v28 = _ePassSignature; v28.Clean = value; _ePassSignature = v28;
                var v29 = _expected; v29.Clean = value; _expected = v29;
                var v30 = _expires; v30.Clean = value; _expires = v30;
                var v31 = _fileAttachmentsMigrated; v31.Clean = value; _fileAttachmentsMigrated = v31;
                var v32 = _fileAttachmentsXml; v32.Clean = value; _fileAttachmentsXml = v32;
                var v33 = _guid; v33.Clean = value; _guid = v33;
                var v34 = _id; v34.Clean = value; _id = v34;
                var v35 = _isEPassIndicator; v35.Clean = value; _isEPassIndicator = v35;
                var v36 = _isExpired; v36.Clean = value; _isExpired = v36;
                var v37 = _isExternalIndicator; v37.Clean = value; _isExternalIndicator = v37;
                var v38 = _isPastDue; v38.Clean = value; _isPastDue = v38;
                var v39 = _isSystemSpecificIndicator; v39.Clean = value; _isSystemSpecificIndicator = v39;
                var v40 = _isThirdPartyDocIndicator; v40.Clean = value; _isThirdPartyDocIndicator = v40;
                var v41 = _isTPOWebcenterPortalIndicator; v41.Clean = value; _isTPOWebcenterPortalIndicator = v41;
                var v42 = _isWebCenterIndicator; v42.Clean = value; _isWebCenterIndicator = v42;
                var v43 = _logId; v43.Clean = value; _logId = v43;
                var v44 = _logRecordIndex; v44.Clean = value; _logRecordIndex = v44;
                var v45 = _orderDateUtc; v45.Clean = value; _orderDateUtc = v45;
                var v46 = _pairId; v46.Clean = value; _pairId = v46;
                var v47 = _preClosingDocumentIndicator; v47.Clean = value; _preClosingDocumentIndicator = v47;
                var v48 = _received; v48.Clean = value; _received = v48;
                var v49 = _receiveDateUtc; v49.Clean = value; _receiveDateUtc = v49;
                var v50 = _receivedBy; v50.Clean = value; _receivedBy = v50;
                var v51 = _reorderDateUtc; v51.Clean = value; _reorderDateUtc = v51;
                var v52 = _requested; v52.Clean = value; _requested = v52;
                var v53 = _requestedBy; v53.Clean = value; _requestedBy = v53;
                var v54 = _requestedFrom; v54.Clean = value; _requestedFrom = v54;
                var v55 = _rerequested; v55.Clean = value; _rerequested = v55;
                var v56 = _rerequestedBy; v56.Clean = value; _rerequestedBy = v56;
                var v57 = _reviewed; v57.Clean = value; _reviewed = v57;
                var v58 = _reviewedBy; v58.Clean = value; _reviewedBy = v58;
                var v59 = _reviewedDateUtc; v59.Clean = value; _reviewedDateUtc = v59;
                var v60 = _shippingReady; v60.Clean = value; _shippingReady = v60;
                var v61 = _shippingReadyBy; v61.Clean = value; _shippingReadyBy = v61;
                var v62 = _shippingReadyDateUtc; v62.Clean = value; _shippingReadyDateUtc = v62;
                var v63 = _stage; v63.Clean = value; _stage = v63;
                var v64 = _status; v64.Clean = value; _status = v64;
                var v65 = _systemId; v65.Clean = value; _systemId = v65;
                var v66 = _title; v66.Clean = value; _title = v66;
                var v67 = _underwritingReady; v67.Clean = value; _underwritingReady = v67;
                var v68 = _underwritingReadyBy; v68.Clean = value; _underwritingReadyBy = v68;
                var v69 = _underwritingReadyDateUtc; v69.Clean = value; _underwritingReadyDateUtc = v69;
                _settingClean = 0;
            }
        }
    }
}