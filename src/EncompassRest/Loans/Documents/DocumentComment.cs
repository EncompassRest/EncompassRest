using System;

namespace EncompassRest.Loans.Documents
{
    public sealed class DocumentComment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        private DirtyValue<int?> _forRoleId;
        private DirtyValue<string> _commentId;
        private DirtyValue<DateTime?> _dateCreated;
        private DirtyValue<string> _createdBy;
        private DirtyValue<string> _createdByName;
        private DirtyValue<DateTime?> _dateReviewed;
        private DirtyValue<string> _reviewedBy;

        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }

        public string CommentId { get => _commentId; set => SetField(ref _commentId, value); }

        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        public DateTime? DateReviewed { get => _dateReviewed; set => SetField(ref _dateReviewed, value); }

        public string ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        [IdPropertyName(nameof(CommentId))]
        string IIdentifiable.Id { get => CommentId; set => CommentId = value; }
    }
}