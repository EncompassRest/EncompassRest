using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Documents.v1
{
    /// <summary>
    /// LoanDocument
    /// </summary>
    public sealed class LoanDocument : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Implicitly converts the specified document to an <see cref="EntityReference"/>.
        /// </summary>
        /// <param name="document">The document to convert to an <see cref="EntityReference"/>.</param>
        public static implicit operator EntityReference?(LoanDocument? document) => document != null && document.DocumentId != null ? new EntityReference(document.DocumentId, EntityType.Document) : null;

        /// <summary>
        /// LoanDocument DocumentId.
        /// </summary>
        public string? DocumentId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Borrower Pair Name of the document.
        /// </summary>
        public string? ApplicationName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Unique identifier of the milestone assigned to the document.
        /// </summary>
        public string? MilestoneId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is available for Encompass WebCenter.
        /// </summary>
        public bool? WebCenterAllowed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is available for Encompass TPO WebCenter.
        /// </summary>
        public bool? TpoAllowed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is available for Third Parties.
        /// </summary>
        public bool? ThirdPartyAllowed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is requested.
        /// </summary>
        public bool? IsRequested { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserId of the user who marked the document as requested.
        /// </summary>
        public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is re-requested.
        /// </summary>
        public bool? IsRerequested { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Re-requested Date from the Status area in Document Details window.
        /// </summary>
        public DateTime? DateRerequested { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// UserId of the user who marked the document as re-requested.
        /// </summary>
        public string? RerequestedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Number of days when a requested document is due.
        /// </summary>
        public int? DaysDue { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is received.
        /// </summary>
        public bool? IsReceived { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserId of the user who marked the document as received.
        /// </summary>
        public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Number of days a received document is valid.
        /// </summary>
        public int? DaysTillExpire { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// UserId of the user who marked the document as reviewed.
        /// </summary>
        public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is reviewed.
        /// </summary>
        public bool? IsReviewed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates the document is ready for underwritingReady for UW Date from Status area in Document Details window.
        /// </summary>
        public bool? IsReadyForUw { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserId of the user who marked the document as ready for underwriting.
        /// </summary>
        public string? ReadyForUwBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the document is ready for shipping.
        /// </summary>
        public bool? IsReadyToShip { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserId of the user who marked the document as ready to ship.
        /// </summary>
        public string? ReadyToShipBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The date a received document will expire.
        /// </summary>
        public DateTime? DateExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// UserId of the user who created the document or comment.
        /// </summary>
        public string? CreatedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// User Name of the user who created the comment.
        /// </summary>
        public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Date the document or comment was added.
        /// </summary>
        public DateTime? DateCreated { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The title of the file.
        /// </summary>
        public string? Title { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Description of the document in the Encompass eFolder UI.
        /// </summary>
        public string? Description { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Person or company the document is being requested by.
        /// </summary>
        public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Identifies which borrower pair (or “All”) the document will be assigned to.
        /// </summary>
        public string? ApplicationId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// EPASS Signature that is used by thick client EMN integrations.
        /// </summary>
        public string? EmnSignature { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The document status.
        /// </summary>
        public StringEnumValue<DocumentStatus> Status { get => GetValue<StringEnumValue<DocumentStatus>>(); set => SetValue(value); }

        /// <summary>
        /// Date the current status was achieved.
        /// </summary>
        public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Date the document was requested.
        /// </summary>
        public DateTime? DateRequested { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Date the document is expected to be received by.
        /// </summary>
        public DateTime? DateExpected { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Date the document was received.
        /// </summary>
        public DateTime? DateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Date the document was reviewed by processor or role user.
        /// </summary>
        public DateTime? DateReviewed { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Date the document is ready for underwriting to review.
        /// </summary>
        public DateTime? DateReadyForUw { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Date the document is ready for shipping to investor.
        /// </summary>
        public DateTime? DateReadyToShip { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// List of comments.
        /// </summary>
        [AllowNull]
        public IList<Comment> Comments { get => GetList<Comment>(); set => SetList(value); }

        /// <summary>
        /// LoanDocument Attachments.
        /// </summary>
        [AllowNull]
        public IList<FileAttachmentReference> Attachments { get => GetList<FileAttachmentReference>(); set => SetList(value); }

        /// <summary>
        /// LoanDocument Roles.
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Roles { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// LoanDocument TitleWithIndex.
        /// </summary>
        public string? TitleWithIndex { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// LoanDocument Conditions.
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Conditions { get => GetList<EntityReference>(); set => SetList(value); }

        [IdPropertyName(nameof(DocumentId))]
        string? IIdentifiable.Id { get => DocumentId; set => DocumentId = value; }

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