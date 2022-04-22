namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EditDocumentDetailsRights
    /// </summary>
    public sealed class EditDocumentDetailsRights : ParentAccessRights
    {
        /// <summary>
        /// EditDocumentDetailsRights CreateNewDocumentName
        /// </summary>
        public bool? CreateNewDocumentName { get => GetValue<bool?>(); set => SetValue(value); }
    }
}