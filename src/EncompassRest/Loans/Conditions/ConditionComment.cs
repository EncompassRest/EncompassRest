using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class ConditionComment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _commentId;
        public string CommentId { get => _commentId; set => _commentId = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<int?> _forRoleId;
        public int? ForRoleId { get => _forRoleId; set => _forRoleId = value; }
        private EntityReference _forRole;
        public EntityReference ForRole { get => _forRole ?? (_forRole = new EntityReference()); set => _forRole = value; }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => _dateCreated = value; }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }

        [IdPropertyName(nameof(CommentId))]
        string IIdentifiable.Id { get => _commentId; set => _commentId = value; }
    }
}