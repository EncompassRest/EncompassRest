using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FileAttachmentReference : EntityReference
    {
        private DirtyValue<string?>? _refId;

        /// <summary>
        /// FileAttachmentReference RefId
        /// </summary>
        public string? RefId { get => _refId; set => SetField(ref _refId, value); }

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