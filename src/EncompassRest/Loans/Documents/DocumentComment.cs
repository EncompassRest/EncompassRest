using System;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Documents
{
    public sealed class DocumentComment : ExtensibleObject
    {
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<int?> _forRoleId;
        public int? ForRoleId { get => _forRoleId; set => _forRoleId = value; }
        private DirtyValue<Guid?> _commentId;
        public Guid? CommentId { get => _commentId; set => _commentId = value; }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => _dateCreated = value; }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _dateReviewed;
        public DateTime? DateReviewed { get => _dateReviewed; set => _dateReviewed = value; }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get => _reviewedBy; set => _reviewedBy = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _comments.Dirty
                    || _forRoleId.Dirty
                    || _commentId.Dirty
                    || _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _createdByName.Dirty
                    || _dateReviewed.Dirty
                    || _reviewedBy.Dirty;
            }
            set
            {
                _comments.Dirty = value;
                _forRoleId.Dirty = value;
                _commentId.Dirty = value;
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _createdByName.Dirty = value;
                _dateReviewed.Dirty = value;
                _reviewedBy.Dirty = value;
            }
        }
    }
}