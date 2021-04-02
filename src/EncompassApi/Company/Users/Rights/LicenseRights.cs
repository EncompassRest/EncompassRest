namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// LicenseRights
    /// </summary>
    public sealed class LicenseRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editLicenseInformation;

        /// <summary>
        /// LicenseRights EditLicenseInformation
        /// </summary>
        public bool? EditLicenseInformation { get => _editLicenseInformation; set => SetField(ref _editLicenseInformation, value); }
    }
}