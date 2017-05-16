using System;

namespace EncompassRest.Loans.Documents
{
    public sealed class Comment
    {
        public string Comments { get; set; }
        public int ForRoleId { get; set; }
        public string CommentId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? DateReviewed { get; set; }
        public string ReviewedBy { get; set; }
    }
}