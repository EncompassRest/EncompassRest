using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed class FileAttachmentReference : EntityReference
    {
        private DirtyValue<string> _refId;
        private DirtyValue<bool?> _isActive;

        public string RefId { get => _refId; set => SetField(ref _refId, value); }

        public bool? IsActive { get => _isActive; set => SetField(ref _isActive, value); }

        public FileAttachmentReference(string entityId, EntityType entityType)
            : base(entityId, entityType)
        {
        }

        public FileAttachmentReference(string entityId, string entityType)
            : base(entityId, entityType)
        {
        }

        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public FileAttachmentReference()
        {
        }
    }
}