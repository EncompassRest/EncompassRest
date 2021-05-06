using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AttachmentsRights
    /// </summary>
    public sealed class AttachmentsRights : ParentAccessRights
    {
        private EditAttachmentsRights? _editAttachments;

        /// <summary>
        /// AttachmentsRights EditAttachments
        /// </summary>
        [AllowNull]
        public EditAttachmentsRights EditAttachments { get => GetField(ref _editAttachments); set => SetField(ref _editAttachments, value); }
    }
}