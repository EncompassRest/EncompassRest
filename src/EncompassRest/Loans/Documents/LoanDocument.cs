using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Documents
{
    public sealed class LoanDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _documentId;
        public string DocumentId { get => _documentId; set => _documentId = value; }
        private DirtyValue<string> _titleWithIndex;
        public string TitleWithIndex { get => _titleWithIndex; set => _titleWithIndex = value; }
        private DirtyValue<string> _applicationName;
        public string ApplicationName { get => _applicationName; set => _applicationName = value; }
        private DirtyValue<string> _milestoneId;
        public string MilestoneId { get => _milestoneId; set => _milestoneId = value; }
        private DirtyValue<bool?> _webCenterAllowed;
        public bool? WebCenterAllowed { get => _webCenterAllowed; set => _webCenterAllowed = value; }
        private DirtyValue<bool?> _tpoAllowed;
        public bool? TpoAllowed { get => _tpoAllowed; set => _tpoAllowed = value; }
        private DirtyValue<bool?> _thirdPartyAllowed;
        public bool? ThirdPartyAllowed { get => _thirdPartyAllowed; set => _thirdPartyAllowed = value; }
        private DirtyValue<bool?> _isRequested;
        public bool? IsRequested { get => _isRequested; set => _isRequested = value; }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get => _requestedBy; set => _requestedBy = value; }
        private DirtyValue<bool?> _isRerequested;
        public bool? IsRerequested { get => _isRerequested; set => _isRerequested = value; }
        private DirtyValue<DateTime?> _dateRerequested;
        public DateTime? DateRerequested { get => _dateRerequested; set => _dateRerequested = value; }
        private DirtyValue<string> _rerequestedBy;
        public string RerequestedBy { get => _rerequestedBy; set => _rerequestedBy = value; }
        private DirtyValue<int?> _daysDue;
        public int? DaysDue { get => _daysDue; set => _daysDue = value; }
        private DirtyValue<bool?> _isReceived;
        public bool? IsReceived { get => _isReceived; set => _isReceived = value; }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get => _receivedBy; set => _receivedBy = value; }
        private DirtyValue<int?> _daysTillExpire;
        public int? DaysTillExpire { get => _daysTillExpire; set => _daysTillExpire = value; }
        private DirtyValue<bool?> _isReviewed;
        public bool? IsReviewed { get => _isReviewed; set => _isReviewed = value; }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get => _reviewedBy; set => _reviewedBy = value; }
        private DirtyValue<bool?> _isReadyForUw;
        public bool? IsReadyForUw { get => _isReadyForUw; set => _isReadyForUw = value; }
        private DirtyValue<string> _readyForUwBy;
        public string ReadyForUwBy { get => _readyForUwBy; set => _readyForUwBy = value; }
        private DirtyValue<bool?> _isReadyToShip;
        public bool? IsReadyToShip { get => _isReadyToShip; set => _isReadyToShip = value; }
        private DirtyValue<string> _readyToShipBy;
        public string ReadyToShipBy { get => _readyToShipBy; set => _readyToShipBy = value; }
        private DirtyValue<DateTime?> _dateExpires;
        public DateTime? DateExpires { get => _dateExpires; set => _dateExpires = value; }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => _dateCreated = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _requestedFrom;
        public string RequestedFrom { get => _requestedFrom; set => _requestedFrom = value; }
        private DirtyValue<string> _applicationId;
        public string ApplicationId { get => _applicationId; set => _applicationId = value; }
        private DirtyValue<string> _emnSignature;
        public string EmnSignature { get => _emnSignature; set => _emnSignature = value; }
        private DirtyValue<StringEnumValue<DocumentStatus>> _status;
        public StringEnumValue<DocumentStatus> Status { get => _status; set => _status = value; }
        private DirtyValue<DateTime?> _statusDate;
        public DateTime? StatusDate { get => _statusDate; set => _statusDate = value; }
        private DirtyValue<DateTime?> _dateRequested;
        public DateTime? DateRequested { get => _dateRequested; set => _dateRequested = value; }
        private DirtyValue<DateTime?> _dateExpected;
        public DateTime? DateExpected { get => _dateExpected; set => _dateExpected = value; }
        private DirtyValue<DateTime?> _dateReceived;
        public DateTime? DateReceived { get => _dateReceived; set => _dateReceived = value; }
        private DirtyValue<DateTime?> _dateReviewed;
        public DateTime? DateReviewed { get => _dateReviewed; set => _dateReviewed = value; }
        private DirtyValue<DateTime?> _dateReadyForUw;
        public DateTime? DateReadyForUw { get => _dateReadyForUw; set => _dateReadyForUw = value; }
        private DirtyValue<DateTime?> _dateReadyToShip;
        public DateTime? DateReadyToShip { get => _dateReadyToShip; set => _dateReadyToShip = value; }
        private DirtyList<DocumentComment> _comments;
        public IList<DocumentComment> Comments { get => _comments ?? (_comments = new DirtyList<DocumentComment>()); set => _comments = new DirtyList<DocumentComment>(value); }
        private DirtyList<FileAttachmentReference> _attachments;
        public IList<FileAttachmentReference> Attachments { get => _attachments ?? (_attachments = new DirtyList<FileAttachmentReference>()); set => _attachments = new DirtyList<FileAttachmentReference>(value); }
        private DirtyList<EntityReference> _roles;
        public IList<EntityReference> Roles { get => _roles ?? (_roles = new DirtyList<EntityReference>()); set => _roles = new DirtyList<EntityReference>(value); }
        [IdPropertyName(nameof(DocumentId))]
        string IIdentifiable.Id { get => DocumentId; set => DocumentId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _documentId.Dirty
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
                    || _roles?.Dirty == true;
            }
            set
            {
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
            }
        }
    }
}