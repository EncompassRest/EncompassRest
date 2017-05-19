using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachment
    {
        public string AttachmentId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public AttachmentCreateReason? CreateReason { get; set; }
        public AttachmentType? AttachmentType { get; set; }
        public long? FileSize { get; set; }
        public bool? IsActive { get; set; }
        public List<PageImage> Pages { get; set; }
        public int? Rotation { get; set; }
        public string Title { get; set; }
        public EntityReference Document { get; set; }
    }
}