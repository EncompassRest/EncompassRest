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
        public string DocumentId { get => _documentId; set => SetField(ref _documentId, value); }
        private DirtyValue<string> _titleWithIndex;
        public string TitleWithIndex { get => _titleWithIndex; set => SetField(ref _titleWithIndex, value); }
        private DirtyValue<string> _applicationName;
        public string ApplicationName { get => _applicationName; set => SetField(ref _applicationName, value); }
        private DirtyValue<string> _milestoneId;
        public string MilestoneId { get => _milestoneId; set => SetField(ref _milestoneId, value); }
        private DirtyValue<bool?> _webCenterAllowed;
        public bool? WebCenterAllowed { get => _webCenterAllowed; set => SetField(ref _webCenterAllowed, value); }
        private DirtyValue<bool?> _tpoAllowed;
        public bool? TpoAllowed { get => _tpoAllowed; set => SetField(ref _tpoAllowed, value); }
        private DirtyValue<bool?> _thirdPartyAllowed;
        public bool? ThirdPartyAllowed { get => _thirdPartyAllowed; set => SetField(ref _thirdPartyAllowed, value); }
        private DirtyValue<bool?> _isRequested;
        public bool? IsRequested { get => _isRequested; set => SetField(ref _isRequested, value); }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }
        private DirtyValue<bool?> _isRerequested;
        public bool? IsRerequested { get => _isRerequested; set => SetField(ref _isRerequested, value); }
        private DirtyValue<DateTime?> _dateRerequested;
        public DateTime? DateRerequested { get => _dateRerequested; set => SetField(ref _dateRerequested, value); }
        private DirtyValue<string> _rerequestedBy;
        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }
        private DirtyValue<int?> _daysDue;
        public int? DaysDue { get => _daysDue; set => SetField(ref _daysDue, value); }
        private DirtyValue<bool?> _isReceived;
        public bool? IsReceived { get => _isReceived; set => SetField(ref _isReceived, value); }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }
        private DirtyValue<int?> _daysTillExpire;
        public int? DaysTillExpire { get => _daysTillExpire; set => SetField(ref _daysTillExpire, value); }
        private DirtyValue<bool?> _isReviewed;
        public bool? IsReviewed { get => _isReviewed; set => SetField(ref _isReviewed, value); }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }
        private DirtyValue<bool?> _isReadyForUw;
        public bool? IsReadyForUw { get => _isReadyForUw; set => SetField(ref _isReadyForUw, value); }
        private DirtyValue<string> _readyForUwBy;
        public string ReadyForUwBy { get => _readyForUwBy; set => SetField(ref _readyForUwBy, value); }
        private DirtyValue<bool?> _isReadyToShip;
        public bool? IsReadyToShip { get => _isReadyToShip; set => SetField(ref _isReadyToShip, value); }
        private DirtyValue<string> _readyToShipBy;
        public string ReadyToShipBy { get => _readyToShipBy; set => SetField(ref _readyToShipBy, value); }
        private DirtyValue<DateTime?> _dateExpires;
        public DateTime? DateExpires { get => _dateExpires; set => SetField(ref _dateExpires, value); }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _requestedFrom;
        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }
        private DirtyValue<string> _applicationId;
        public string ApplicationId { get => _applicationId; set => SetField(ref _applicationId, value); }
        private DirtyValue<string> _emnSignature;
        public string EmnSignature { get => _emnSignature; set => SetField(ref _emnSignature, value); }
        private DirtyValue<StringEnumValue<DocumentStatus>> _status;
        public StringEnumValue<DocumentStatus> Status { get => _status; set => SetField(ref _status, value); }
        private DirtyValue<DateTime?> _statusDate;
        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }
        private DirtyValue<DateTime?> _dateRequested;
        public DateTime? DateRequested { get => _dateRequested; set => SetField(ref _dateRequested, value); }
        private DirtyValue<DateTime?> _dateExpected;
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }
        private DirtyValue<DateTime?> _dateReceived;
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }
        private DirtyValue<DateTime?> _dateReviewed;
        public DateTime? DateReviewed { get => _dateReviewed; set => SetField(ref _dateReviewed, value); }
        private DirtyValue<DateTime?> _dateReadyForUw;
        public DateTime? DateReadyForUw { get => _dateReadyForUw; set => SetField(ref _dateReadyForUw, value); }
        private DirtyValue<DateTime?> _dateReadyToShip;
        public DateTime? DateReadyToShip { get => _dateReadyToShip; set => SetField(ref _dateReadyToShip, value); }
        private DirtyList<DocumentComment> _comments;
        public IList<DocumentComment> Comments { get => GetField(ref _comments); set => SetField(ref _comments, value); }
        private DirtyList<FileAttachmentReference> _attachments;
        public IList<FileAttachmentReference> Attachments { get => GetField(ref _attachments); set => SetField(ref _attachments, value); }
        private DirtyList<EntityReference> _roles;
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