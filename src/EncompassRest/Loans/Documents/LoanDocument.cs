using System;
using System.Collections.Generic;
using System.ComponentModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Documents
{
    /// <summary>
    /// LoanDocument
    /// </summary>
    public sealed class LoanDocument : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _documentId;
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
        private DirtyValue<string> _reviewedBy;
        private DirtyValue<bool?> _isReviewed;
        private DirtyValue<bool?> _isReadyForUw;
        private DirtyValue<string> _readyForUwBy;
        private DirtyValue<bool?> _isReadyToShip;
        private DirtyValue<string> _readyToShipBy;
        private DirtyValue<DateTime?> _dateExpires;
        private DirtyValue<string> _createdBy;
        private DirtyValue<string> _createdByName;
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
        private DirtyList<Comment> _comments;
        private DirtyList<FileAttachmentReference> _attachments;
        private DirtyList<EntityReference> _roles;
        private DirtyValue<string> _titleWithIndex;
        private DirtyList<EntityReference> _conditions;

        /// <summary>
        /// LoanDocument DocumentId.
        /// </summary>
        public string DocumentId { get => _documentId; set => SetField(ref _documentId, value); }

        /// <summary>
        /// Borrower Pair Name of the document.
        /// </summary>
        public string ApplicationName { get => _applicationName; set => SetField(ref _applicationName, value); }

        /// <summary>
        /// Unique identifier of the milestone assigned to the document.
        /// </summary>
        public string MilestoneId { get => _milestoneId; set => SetField(ref _milestoneId, value); }

        /// <summary>
        /// Indicates whether the document is available for Encompass WebCenter.
        /// </summary>
        public bool? WebCenterAllowed { get => _webCenterAllowed; set => SetField(ref _webCenterAllowed, value); }

        /// <summary>
        /// Indicates whether the document is available for Encompass TPO WebCenter.
        /// </summary>
        public bool? TpoAllowed { get => _tpoAllowed; set => SetField(ref _tpoAllowed, value); }

        /// <summary>
        /// Indicates whether the document is available for Third Parties.
        /// </summary>
        public bool? ThirdPartyAllowed { get => _thirdPartyAllowed; set => SetField(ref _thirdPartyAllowed, value); }

        /// <summary>
        /// Indicates whether the document is requested.
        /// </summary>
        public bool? IsRequested { get => _isRequested; set => SetField(ref _isRequested, value); }

        /// <summary>
        /// UserId of the user who marked the document as requested.
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// Indicates whether the document is re-requested.
        /// </summary>
        public bool? IsRerequested { get => _isRerequested; set => SetField(ref _isRerequested, value); }

        /// <summary>
        /// Re-requested Date from the Status area in Document Details window.
        /// </summary>
        public DateTime? DateRerequested { get => _dateRerequested; set => SetField(ref _dateRerequested, value); }

        /// <summary>
        /// UserId of the user who marked the document as re-requested.
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        /// <summary>
        /// Number of days when a requested document is due.
        /// </summary>
        public int? DaysDue { get => _daysDue; set => SetField(ref _daysDue, value); }

        /// <summary>
        /// Indicates whether the document is received.
        /// </summary>
        public bool? IsReceived { get => _isReceived; set => SetField(ref _isReceived, value); }

        /// <summary>
        /// UserId of the user who marked the document as received.
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// Number of days a received document is valid.
        /// </summary>
        public int? DaysTillExpire { get => _daysTillExpire; set => SetField(ref _daysTillExpire, value); }

        /// <summary>
        /// UserId of the user who marked the document as reviewed.
        /// </summary>
        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        /// <summary>
        /// Indicates whether the document is reviewed.
        /// </summary>
        public bool? IsReviewed { get => _isReviewed; set => SetField(ref _isReviewed, value); }

        /// <summary>
        /// Indicates the document is ready for underwritingReady for UW Date from Status area in Document Details window.
        /// </summary>
        public bool? IsReadyForUw { get => _isReadyForUw; set => SetField(ref _isReadyForUw, value); }

        /// <summary>
        /// UserId of the user who marked the document as ready for underwriting.
        /// </summary>
        public string ReadyForUwBy { get => _readyForUwBy; set => SetField(ref _readyForUwBy, value); }

        /// <summary>
        /// Indicates whether the document is ready for shipping.
        /// </summary>
        public bool? IsReadyToShip { get => _isReadyToShip; set => SetField(ref _isReadyToShip, value); }

        /// <summary>
        /// UserId of the user who marked the document as ready to ship.
        /// </summary>
        public string ReadyToShipBy { get => _readyToShipBy; set => SetField(ref _readyToShipBy, value); }

        /// <summary>
        /// The date a received document will expire.
        /// </summary>
        public DateTime? DateExpires { get => _dateExpires; set => SetField(ref _dateExpires, value); }

        /// <summary>
        /// UserId of the user who created the document or comment.
        /// </summary>
        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        /// <summary>
        /// User Name of the user who created the comment.
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// Date the document or comment was added.
        /// </summary>
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        /// <summary>
        /// The title of the file.
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Description of the document in the Encompass eFolder UI.
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Person or company the document is being requested by.
        /// </summary>
        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

        /// <summary>
        /// Identifies which borrower pair (or “All”) the document will be assigned to.
        /// </summary>
        public string ApplicationId { get => _applicationId; set => SetField(ref _applicationId, value); }

        /// <summary>
        /// EPASS Signature that is used by thick client EMN integrations.
        /// </summary>
        public string EmnSignature { get => _emnSignature; set => SetField(ref _emnSignature, value); }

        /// <summary>
        /// The document status.
        /// </summary>
        public StringEnumValue<DocumentStatus> Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// Date the current status was achieved.
        /// </summary>
        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

        /// <summary>
        /// Date the document was requested.
        /// </summary>
        public DateTime? DateRequested { get => _dateRequested; set => SetField(ref _dateRequested, value); }

        /// <summary>
        /// Date the document is expected to be received by.
        /// </summary>
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }

        /// <summary>
        /// Date the document was received.
        /// </summary>
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        /// <summary>
        /// Date the document was reviewed by processor or role user.
        /// </summary>
        public DateTime? DateReviewed { get => _dateReviewed; set => SetField(ref _dateReviewed, value); }

        /// <summary>
        /// Date the document is ready for underwriting to review.
        /// </summary>
        public DateTime? DateReadyForUw { get => _dateReadyForUw; set => SetField(ref _dateReadyForUw, value); }

        /// <summary>
        /// Date the document is ready for shipping to investor.
        /// </summary>
        public DateTime? DateReadyToShip { get => _dateReadyToShip; set => SetField(ref _dateReadyToShip, value); }

        /// <summary>
        /// List of comments.
        /// </summary>
        public IList<Comment> Comments { get => GetField(ref _comments); set => SetField(ref _comments, value); }

        /// <summary>
        /// LoanDocument Attachments.
        /// </summary>
        public IList<FileAttachmentReference> Attachments { get => GetField(ref _attachments); set => SetField(ref _attachments, value); }

        /// <summary>
        /// LoanDocument Roles.
        /// </summary>
        public IList<EntityReference> Roles { get => GetField(ref _roles); set => SetField(ref _roles, value); }

        /// <summary>
        /// LoanDocument TitleWithIndex.
        /// </summary>
        public string TitleWithIndex { get => _titleWithIndex; set => SetField(ref _titleWithIndex, value); }

        /// <summary>
        /// LoanDocument Conditions.
        /// </summary>
        public IList<EntityReference> Conditions { get => GetField(ref _conditions); set => SetField(ref _conditions, value); }

        [IdPropertyName(nameof(DocumentId))]
        string IIdentifiable.Id { get => DocumentId; set => DocumentId = value; }

        /// <summary>
        /// Loan document creation constructor
        /// </summary>
        /// <param name="title">The title of the file.</param>
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
        /// <param name="documentId">The document id.</param>
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