namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ViewClosingDocumentDataRights
    /// </summary>
    public sealed class ViewClosingDocumentDataRights : ParentAccessRights
    {
        private DirtyValue<bool?> _overrideClosingDocumentDataFields;

        /// <summary>
        /// ViewClosingDocumentDataRights OverrideClosingDocumentDataFields
        /// </summary>
        public bool? OverrideClosingDocumentDataFields { get => _overrideClosingDocumentDataFields; set => SetField(ref _overrideClosingDocumentDataFields, value); }
    }
}