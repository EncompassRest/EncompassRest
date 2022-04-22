namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ViewClosingDocumentDataRights
    /// </summary>
    public sealed class ViewClosingDocumentDataRights : ParentAccessRights
    {
        /// <summary>
        /// ViewClosingDocumentDataRights OverrideClosingDocumentDataFields
        /// </summary>
        public bool? OverrideClosingDocumentDataFields { get => GetValue<bool?>(); set => SetValue(value); }
    }
}