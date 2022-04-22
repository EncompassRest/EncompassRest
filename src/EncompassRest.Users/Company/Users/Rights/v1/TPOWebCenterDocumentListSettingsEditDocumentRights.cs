namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ExternalSettingsRightsEditDocumentRights
    /// </summary>
    public sealed class TPOWebCenterDocumentListSettingsEditDocumentRights : ParentAccessRights
    {
        /// <summary>
        /// ExternalSettingsRightsEditDocumentRights DeleteDocument
        /// </summary>
        public bool? DeleteDocument { get => GetValue<bool?>(); set => SetValue(value); }
    }
}