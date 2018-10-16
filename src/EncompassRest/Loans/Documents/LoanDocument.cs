using System;
using System.Collections.Generic;
using System.ComponentModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Documents
{
    public sealed class LoanDocument : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _documentId;
        private DirtyValue<string> _titleWithIndex;
        private DirtyValue<string> _applicationName;
        private DirtyValue<string> _milestoneId;
        private DirtyValue<bool?> _webCenterAllowed;
        private DirtyValue<bool?> _tpoAllowed;
        private DirtyValue<bool?> _thirdPartyAllowed;
        private DirtyValue<bool?> _isRequested;
        private DirtyValue<string> _requestedBy;
        private DirtyValue<bool?> _isRerequested;
        private DirtyValue<DateTime?> _dateRerequested;
        private DirtyValue<string> _rerequestedBy;
        private DirtyValue<int?> _daysDue;
        private DirtyValue<bool?> _isReceived;
        private DirtyValue<string> _receivedBy;
        private DirtyValue<int?> _daysTillExpire;
        private DirtyValue<bool?> _isReviewed;
        private DirtyValue<string> _reviewedBy;
        private DirtyValue<bool?> _isReadyForUw;
        private DirtyValue<string> _readyForUwBy;
        private DirtyValue<bool?> _isReadyToShip;
        private DirtyValue<string> _readyToShipBy;
        private DirtyValue<DateTime?> _dateExpires;
        private DirtyValue<string> _createdBy;
        private DirtyValue<DateTime?> _dateCreated;
        private DirtyValue<string> _title;
        private DirtyValue<string> _description;
        private DirtyValue<string> _requestedFrom;
        private DirtyValue<string> _applicationId;
        private DirtyValue<string> _emnSignature;
        private DirtyValue<StringEnumValue<DocumentStatus>> _status;
        private DirtyValue<DateTime?> _statusDate;
        private DirtyValue<DateTime?> _dateRequested;
        private DirtyValue<DateTime?> _dateExpected;
        private DirtyValue<DateTime?> _dateReceived;
        private DirtyValue<DateTime?> _dateReviewed;
        private DirtyValue<DateTime?> _dateReadyForUw;
        private DirtyValue<DateTime?> _dateReadyToShip;
        private DirtyList<DocumentComment> _comments;
        private DirtyList<FileAttachmentReference> _attachments;
        private DirtyList<EntityReference> _roles;

        public string DocumentId { get => _documentId; set => SetField(ref _documentId, value); }

        public string TitleWithIndex { get => _titleWithIndex; set => SetField(ref _titleWithIndex, value); }

        public string ApplicationName { get => _applicationName; set => SetField(ref _applicationName, value); }

        public string MilestoneId { get => _milestoneId; set => SetField(ref _milestoneId, value); }

        public bool? WebCenterAllowed { get => _webCenterAllowed; set => SetField(ref _webCenterAllowed, value); }

        public bool? TpoAllowed { get => _tpoAllowed; set => SetField(ref _tpoAllowed, value); }

        public bool? ThirdPartyAllowed { get => _thirdPartyAllowed; set => SetField(ref _thirdPartyAllowed, value); }

        public bool? IsRequested { get => _isRequested; set => SetField(ref _isRequested, value); }

        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        public bool? IsRerequested { get => _isRerequested; set => SetField(ref _isRerequested, value); }

        public DateTime? DateRerequested { get => _dateRerequested; set => SetField(ref _dateRerequested, value); }

        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        public int? DaysDue { get => _daysDue; set => SetField(ref _daysDue, value); }

        public bool? IsReceived { get => _isReceived; set => SetField(ref _isReceived, value); }

        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        public int? DaysTillExpire { get => _daysTillExpire; set => SetField(ref _daysTillExpire, value); }

        public bool? IsReviewed { get => _isReviewed; set => SetField(ref _isReviewed, value); }

        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        public bool? IsReadyForUw { get => _isReadyForUw; set => SetField(ref _isReadyForUw, value); }

        public string ReadyForUwBy { get => _readyForUwBy; set => SetField(ref _readyForUwBy, value); }

        public bool? IsReadyToShip { get => _isReadyToShip; set => SetField(ref _isReadyToShip, value); }

        public string ReadyToShipBy { get => _readyToShipBy; set => SetField(ref _readyToShipBy, value); }

        public DateTime? DateExpires { get => _dateExpires; set => SetField(ref _dateExpires, value); }

        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        public string Title { get => _title; set => SetField(ref _title, value); }

        public string Description { get => _description; set => SetField(ref _description, value); }

        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

        public string ApplicationId { get => _applicationId; set => SetField(ref _applicationId, value); }

        public string EmnSignature { get => _emnSignature; set => SetField(ref _emnSignature, value); }

        public StringEnumValue<DocumentStatus> Status { get => _status; set => SetField(ref _status, value); }

        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

        public DateTime? DateRequested { get => _dateRequested; set => SetField(ref _dateRequested, value); }

        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }

        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        public DateTime? DateReviewed { get => _dateReviewed; set => SetField(ref _dateReviewed, value); }

        public DateTime? DateReadyForUw { get => _dateReadyForUw; set => SetField(ref _dateReadyForUw, value); }

        public DateTime? DateReadyToShip { get => _dateReadyToShip; set => SetField(ref _dateReadyToShip, value); }

        public IList<DocumentComment> Comments { get => GetField(ref _comments); set => SetField(ref _comments, value); }

        public IList<FileAttachmentReference> Attachments { get => GetField(ref _attachments); set => SetField(ref _attachments, value); }

        public IList<EntityReference> Roles { get => GetField(ref _roles); set => SetField(ref _roles, value); }

        [IdPropertyName(nameof(DocumentId))]
        string IIdentifiable.Id { get => DocumentId; set => DocumentId = value; }

        /// <summary>
        /// Loan document creation constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="applicationId">Identifies which borrower pair (or “All”) the document will be assigned to.</param>
        public LoanDocument(string title, string applicationId)
        {
            Preconditions.NotNullOrEmpty(title, nameof(title));
            Preconditions.NotNullOrEmpty(applicationId, nameof(applicationId));

            Title = title;
            ApplicationId = applicationId;
        }

        /// <summary>
        /// Loan document update constructor
        /// </summary>
        /// <param name="documentId"></param>
        public LoanDocument(string documentId)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            DocumentId = documentId;
        }

        /// <summary>
        /// Loan document deserialization constructor
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public LoanDocument()
        {
        }
    }
}