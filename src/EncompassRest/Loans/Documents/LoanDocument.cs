using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Documents
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class LoanDocument : IDirty
    {
        private DirtyValue<string> _documentId;
        public string DocumentId { get { return _documentId; } set { _documentId = value; } }
        private DirtyValue<string> _titleWithIndex;
        public string TitleWithIndex { get { return _titleWithIndex; } set { _titleWithIndex = value; } }
        private DirtyValue<string> _applicationName;
        public string ApplicationName { get { return _applicationName; } set { _applicationName = value; } }
        private DirtyValue<string> _milestoneId;
        public string MilestoneId { get { return _milestoneId; } set { _milestoneId = value; } }
        private DirtyValue<bool?> _webCenterAllowed;
        public bool? WebCenterAllowed { get { return _webCenterAllowed; } set { _webCenterAllowed = value; } }
        private DirtyValue<bool?> _tpoAllowed;
        public bool? TpoAllowed { get { return _tpoAllowed; } set { _tpoAllowed = value; } }
        private DirtyValue<bool?> _thirdPartyAllowed;
        public bool? ThirdPartyAllowed { get { return _thirdPartyAllowed; } set { _thirdPartyAllowed = value; } }
        private DirtyValue<bool?> _isRequested;
        public bool? IsRequested { get { return _isRequested; } set { _isRequested = value; } }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private DirtyValue<bool?> _isRerequested;
        public bool? IsRerequested { get { return _isRerequested; } set { _isRerequested = value; } }
        private DirtyValue<DateTime?> _dateRerequested;
        public DateTime? DateRerequested { get { return _dateRerequested; } set { _dateRerequested = value; } }
        private DirtyValue<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private DirtyValue<int?> _daysDue;
        public int? DaysDue { get { return _daysDue; } set { _daysDue = value; } }
        private DirtyValue<bool?> _isReceived;
        public bool? IsReceived { get { return _isReceived; } set { _isReceived = value; } }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private DirtyValue<int?> _daysTillExpire;
        public int? DaysTillExpire { get { return _daysTillExpire; } set { _daysTillExpire = value; } }
        private DirtyValue<bool?> _isReviewed;
        public bool? IsReviewed { get { return _isReviewed; } set { _isReviewed = value; } }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
        private DirtyValue<bool?> _isReadyForUw;
        public bool? IsReadyForUw { get { return _isReadyForUw; } set { _isReadyForUw = value; } }
        private DirtyValue<string> _readyForUwBy;
        public string ReadyForUwBy { get { return _readyForUwBy; } set { _readyForUwBy = value; } }
        private DirtyValue<bool?> _isReadyToShip;
        public bool? IsReadyToShip { get { return _isReadyToShip; } set { _isReadyToShip = value; } }
        private DirtyValue<string> _readyToShipBy;
        public string ReadyToShipBy { get { return _readyToShipBy; } set { _readyToShipBy = value; } }
        private DirtyValue<DateTime?> _dateExpires;
        public DateTime? DateExpires { get { return _dateExpires; } set { _dateExpires = value; } }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }
        private DirtyValue<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _requestedFrom;
        public string RequestedFrom { get { return _requestedFrom; } set { _requestedFrom = value; } }
        private DirtyValue<string> _applicationId;
        public string ApplicationId { get { return _applicationId; } set { _applicationId = value; } }
        private DirtyValue<string> _emnSignature;
        public string EmnSignature { get { return _emnSignature; } set { _emnSignature = value; } }
        private StringEnumValue<DocumentStatus> _status;
        public StringEnumValue<DocumentStatus> Status { get { return _status; } set { _status = value; } }
        private DirtyValue<DateTime?> _statusDate;
        public DateTime? StatusDate { get { return _statusDate; } set { _statusDate = value; } }
        private DirtyValue<DateTime?> _dateRequested;
        public DateTime? DateRequested { get { return _dateRequested; } set { _dateRequested = value; } }
        private DirtyValue<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        private DirtyValue<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private DirtyValue<DateTime?> _dateReviewed;
        public DateTime? DateReviewed { get { return _dateReviewed; } set { _dateReviewed = value; } }
        private DirtyValue<DateTime?> _dateReadyForUw;
        public DateTime? DateReadyForUw { get { return _dateReadyForUw; } set { _dateReadyForUw = value; } }
        private DirtyValue<DateTime?> _dateReadyToShip;
        public DateTime? DateReadyToShip { get { return _dateReadyToShip; } set { _dateReadyToShip = value; } }
        private DirtyList<DocumentComment> _comments;
        public IList<DocumentComment> Comments { get { return _comments ?? (_comments = new DirtyList<DocumentComment>()); } set { _comments = new DirtyList<DocumentComment>(value); } }
        private DirtyList<FileAttachmentReference> _attachments;
        public IList<FileAttachmentReference> Attachments { get { return _attachments ?? (_attachments = new DirtyList<FileAttachmentReference>()); } set { _attachments = new DirtyList<FileAttachmentReference>(value); } }
        private DirtyList<EntityReference> _roles;
        public IList<EntityReference> Roles { get { return _roles ?? (_roles = new DirtyList<EntityReference>()); } set { _roles = new DirtyList<EntityReference>(value); } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _documentId.Dirty
                    || _titleWithIndex.Dirty
                    || _applicationName.Dirty
                    || _milestoneId.Dirty
                    || _webCenterAllowed.Dirty
                    || _tpoAllowed.Dirty
                    || _thirdPartyAllowed.Dirty
                    || _isRequested.Dirty
                    || _requestedBy.Dirty
                    || _isRerequested.Dirty
                    || _dateRerequested.Dirty
                    || _rerequestedBy.Dirty
                    || _daysDue.Dirty
                    || _isReceived.Dirty
                    || _receivedBy.Dirty
                    || _daysTillExpire.Dirty
                    || _isReviewed.Dirty
                    || _reviewedBy.Dirty
                    || _isReadyForUw.Dirty
                    || _readyForUwBy.Dirty
                    || _isReadyToShip.Dirty
                    || _readyToShipBy.Dirty
                    || _dateExpires.Dirty
                    || _createdBy.Dirty
                    || _dateCreated.Dirty
                    || _title.Dirty
                    || _description.Dirty
                    || _requestedFrom.Dirty
                    || _applicationId.Dirty
                    || _emnSignature.Dirty
                    || _status.Dirty
                    || _statusDate.Dirty
                    || _dateRequested.Dirty
                    || _dateExpected.Dirty
                    || _dateReceived.Dirty
                    || _dateReviewed.Dirty
                    || _dateReadyForUw.Dirty
                    || _dateReadyToShip.Dirty
                    || _comments?.Dirty == true
                    || _attachments?.Dirty == true
                    || _roles?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _documentId.Dirty = value;
                _titleWithIndex.Dirty = value;
                _applicationName.Dirty = value;
                _milestoneId.Dirty = value;
                _webCenterAllowed.Dirty = value;
                _tpoAllowed.Dirty = value;
                _thirdPartyAllowed.Dirty = value;
                _isRequested.Dirty = value;
                _requestedBy.Dirty = value;
                _isRerequested.Dirty = value;
                _dateRerequested.Dirty = value;
                _rerequestedBy.Dirty = value;
                _daysDue.Dirty = value;
                _isReceived.Dirty = value;
                _receivedBy.Dirty = value;
                _daysTillExpire.Dirty = value;
                _isReviewed.Dirty = value;
                _reviewedBy.Dirty = value;
                _isReadyForUw.Dirty = value;
                _readyForUwBy.Dirty = value;
                _isReadyToShip.Dirty = value;
                _readyToShipBy.Dirty = value;
                _dateExpires.Dirty = value;
                _createdBy.Dirty = value;
                _dateCreated.Dirty = value;
                _title.Dirty = value;
                _description.Dirty = value;
                _requestedFrom.Dirty = value;
                _applicationId.Dirty = value;
                _emnSignature.Dirty = value;
                _status.Dirty = value;
                _statusDate.Dirty = value;
                _dateRequested.Dirty = value;
                _dateExpected.Dirty = value;
                _dateReceived.Dirty = value;
                _dateReviewed.Dirty = value;
                _dateReadyForUw.Dirty = value;
                _dateReadyToShip.Dirty = value;
                if (_comments != null) _comments.Dirty = value;
                if (_attachments != null) _attachments.Dirty = value;
                if (_roles != null) _roles.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}