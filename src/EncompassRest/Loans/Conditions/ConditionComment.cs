using System;

namespace EncompassRest.Loans.Conditions
{
    public sealed class ConditionComment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _commentId;
        private DirtyValue<string> _comments;
        private DirtyValue<int?> _forRoleId;
        private EntityReference _forRole;
        private DirtyValue<DateTime?> _dateCreated;
        private DirtyValue<string> _createdBy;
        private DirtyValue<string> _createdByName;

        public string CommentId { get => _commentId; set => SetField(ref _commentId, value); }

        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }

        public EntityReference ForRole { get => GetField(ref _forRole); set => SetField(ref _forRole, value); }

        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        [IdPropertyName(nameof(CommentId))]
        string IIdentifiable.Id { get => _commentId; set => SetField(ref _commentId, value); }
    }
}