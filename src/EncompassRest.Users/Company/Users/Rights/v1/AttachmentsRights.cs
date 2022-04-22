using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AttachmentsRights
    /// </summary>
    public sealed class AttachmentsRights : ParentAccessRights
    {
        /// <summary>
        /// AttachmentsRights EditAttachments
        /// </summary>
        [AllowNull]
        public EditAttachmentsRights EditAttachments { get => GetEntity<EditAttachmentsRights>(); set => SetEntity(value); }
    }
}