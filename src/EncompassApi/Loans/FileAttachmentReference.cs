using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassApi.Loans
{
    /// <summary>
    /// FileAttachmentReference
    /// </summary>
    public sealed class FileAttachmentReference : EntityReference
    {
        private DirtyValue<string?>? _refId;
        private DirtyValue<bool?>? _isActive;

        /// <summary>
        /// FileAttachmentReference RefId
        /// </summary>
        public string? RefId { get => _refId; set => SetField(ref _refId, value); }

        /// <summary>
        /// FileAttachmentReference IsActive
        /// </summary>
        public bool? IsActive { get => _isActive; set => SetField(ref _isActive, value); }

        /// <summary>
        /// FileAttachmentReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public FileAttachmentReference(string entityId, EntityType entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// FileAttachmentReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public FileAttachmentReference(string entityId, string entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// FileAttachmentReference deserialization constructor.
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public FileAttachmentReference()
        {
        }
    }
}