using System;

namespace EncompassRest.Loans.Documents
{
    public sealed class DocumentComment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<int?> _forRoleId;
        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }
        private DirtyValue<string> _commentId;
        public string CommentId { get => _commentId; set => SetField(ref _commentId, value); }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }
        private DirtyValue<DateTime?> _dateReviewed;
        public DateTime? DateReviewed { get => _dateReviewed; set => SetField(ref _dateReviewed, value); }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }
        [IdPropertyName(nameof(CommentId))]
        string IIdentifiable.Id { get => CommentId; set => CommentId = value; }
    }
}