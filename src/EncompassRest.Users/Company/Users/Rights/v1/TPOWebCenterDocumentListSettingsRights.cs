using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOWebCenterDocumentListSettingsRights
    /// </summary>
    public sealed class TPOWebCenterDocumentListSettingsRights : ParentAccessRights
    {
        /// <summary>
        /// TPOWebCenterDocumentListSettingsRights EditDocument
        /// </summary>
        [AllowNull]
        public TPOWebCenterDocumentListSettingsEditDocumentRights EditDocument { get => GetEntity<TPOWebCenterDocumentListSettingsEditDocumentRights>(); set => SetEntity(value); }
    }
}