using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Documents
{
    public sealed class LoanDocument
    {
        public string DocumentId { get; set; }
        public string TitleWithIndex { get; set; }
        public string ApplicationName { get; set; }
        public string MilestoneId { get; set; }
        public bool? WebCenterAllowed { get; set; }
        public bool? TpoAllowed { get; set; }
        public bool? ThirdPartyAllowed { get; set; }
        public bool? IsRequested { get; set; }
        public string RequestedBy { get; set; }
        public bool? IsRerequested { get; set; }
        public DateTime? DateRerequested { get; set; }
        public string RerequestedBy { get; set; }
        public int? DaysDue { get; set; }
        public bool? IsRecieved { get; set; }
        public string RecievedBy { get; set; }
        public int? DaysTillExpire { get; set; }
        public bool? IsReviewed { get; set; }
        public string ReviewedBy { get; set; }
        public bool? IsReadyForUw { get; set; }
        public string ReadyForUwBy { get; set; }
        public bool? IsReadyToShip { get; set; }
        public string ReadyToShipBy { get; set; }
        public DateTime? DateExpires { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RequestedFrom { get; set; }
        public string ApplicationId { get; set; }
        public string EmnSignature { get; set; }
        public DocumentStatus? Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? DateRequested { get; set; }
        public DateTime? DateExpected { get; set; }
        public DateTime? DateRecieved { get; set; }
        public DateTime? DateReviewed { get; set; }
        public DateTime? DateReadyForUw { get; set; }
        public DateTime? DateReadyToShip { get; set; }
        public List<DocumentComment> Comments { get; set; }
        public List<FileAttachmentReference> Attachments { get; set; }
        public List<EntityReference> Roles { get; set; }

        public LoanDocument()
        {
            Comments = new List<DocumentComment>();
            Attachments = new List<FileAttachmentReference>();
            Roles = new List<EntityReference>();
        }
    }
}