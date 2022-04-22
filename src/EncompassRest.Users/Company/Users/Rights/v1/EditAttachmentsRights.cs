namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EditAttachmentsRights
    /// </summary>
    public sealed class EditAttachmentsRights : ParentAccessRights
    {
        /// <summary>
        /// EditAttachmentsRights DeleteAttachments
        /// </summary>
        public bool? DeleteAttachments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}