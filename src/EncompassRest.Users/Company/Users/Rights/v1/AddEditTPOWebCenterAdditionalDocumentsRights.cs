namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AddEditTPOWebCenterAdditionalDocumentsRights
    /// </summary>
    public sealed class AddEditTPOWebCenterAdditionalDocumentsRights : ParentAccessRights
    {
        /// <summary>
        /// AddEditTPOWebCenterAdditionalDocumentsRights DeleteTPOWebCenterDocuments
        /// </summary>
        public bool? DeleteTPOWebCenterDocuments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}