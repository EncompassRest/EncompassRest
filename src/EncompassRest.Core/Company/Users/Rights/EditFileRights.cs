namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// EditFileRights
    /// </summary>
    public sealed class EditFileRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deletePagePermanently;

        /// <summary>
        /// EditFileRights DeletePagePermanently
        /// </summary>
        public bool? DeletePagePermanently { get => _deletePagePermanently; set => SetField(ref _deletePagePermanently, value); }
    }
}