namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// EditAttachmentsRights
    /// </summary>
    public sealed class EditAttachmentsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deleteAttachments;

        /// <summary>
        /// EditAttachmentsRights DeleteAttachments
        /// </summary>
        public bool? DeleteAttachments { get => _deleteAttachments; set => SetField(ref _deleteAttachments, value); }
    }
}