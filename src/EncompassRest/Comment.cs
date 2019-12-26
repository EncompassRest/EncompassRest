using System;

namespace EncompassRest
{
    /// <summary>
    /// Comment
    /// </summary>
    public sealed class Comment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _commentId;
        private DirtyValue<string?>? _comments;
        private DirtyValue<int?>? _forRoleId;
        private DirtyValue<EntityReference?>? _forRole;
        private DirtyValue<DateTime?>? _dateCreated;
        private DirtyValue<string?>? _createdBy;
        private DirtyValue<string?>? _createdByName;
        private DirtyValue<DateTime?>? _dateReviewed;
        private DirtyValue<string?>? _reviewedBy;

        /// <summary>
        /// Unique identifier of a comment.
        /// </summary>
        public string? CommentId { get => _commentId; set => SetField(ref _commentId, value); }

        /// <summary>
        /// Any comments for the condition.
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Unique identifier of the role that this comment was assigned to.
        /// </summary>
        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }

        /// <summary>
        /// Information about the Encompass role ID that has access to this comment.
        /// </summary>
        public EntityReference? ForRole { get => _forRole; set => SetField(ref _forRole, value); }

        /// <summary>
        /// Date the comment was created.
        /// </summary>
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        /// <summary>
        /// Encompass user ID of the user who created the comment.
        /// </summary>
        public string? CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        /// <summary>
        /// Name of the user who created the comment.
        /// </summary>
        public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// Date the comment was reviewed.
        /// </summary>
        public DateTime? DateReviewed { get => _dateReviewed; set => SetField(ref _dateReviewed, value); }

        /// <summary>
        /// Encompass user ID of the user who reviewed the comment.
        /// </summary>
        public string? ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        [IdPropertyName(nameof(CommentId))]
        string? IIdentifiable.Id { get => _commentId; set => SetField(ref _commentId, value); }
    }
}