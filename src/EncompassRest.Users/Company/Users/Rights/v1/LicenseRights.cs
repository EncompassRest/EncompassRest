namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LicenseRights
    /// </summary>
    public sealed class LicenseRights : ParentAccessRights
    {
        /// <summary>
        /// LicenseRights EditLicenseInformation
        /// </summary>
        public bool? EditLicenseInformation { get => GetValue<bool?>(); set => SetValue(value); }
    }
}