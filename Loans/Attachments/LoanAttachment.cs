using System;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachment
    {
        public string Title { get; set; }
        public string AttachmentId { get; set; }
        public EntityInfo Document { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public int AttachmentType { get; set; }
        public int FileSize { get; set; }
        public bool IsActive { get; set; }
        public int Rotation { get; set; }
    }
}