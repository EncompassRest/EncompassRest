using System;

namespace EncompassRest
{
    /// <summary>
    /// Comment
    /// </summary>
    public sealed class Comment : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Unique identifier of a comment.
        /// </summary>
        public string? CommentId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Any comments for the condition.
        /// </summary>
        public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Unique identifier of the role that this comment was assigned to.
        /// </summary>
        public int? ForRoleId { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Information about the Encompass role ID that has access to this comment.
        /// </summary>
        public EntityReference? ForRole { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Date the comment was created.
        /// </summary>
        public DateTime? DateCreated { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Encompass user ID of the user who created the comment.
        /// </summary>
        public string? CreatedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Name of the user who created the comment.
        /// </summary>
        public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Date the comment was reviewed.
        /// </summary>
        public DateTime? DateReviewed { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Encompass user ID of the user who reviewed the comment.
        /// </summary>
        public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

        [IdPropertyName(nameof(CommentId))]
        string? IIdentifiable.Id { get => CommentId; set => CommentId = value; }
    }
}