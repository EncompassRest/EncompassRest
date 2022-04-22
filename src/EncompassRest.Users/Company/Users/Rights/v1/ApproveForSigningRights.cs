namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ApproveForSigningRights
    /// </summary>
    public sealed class ApproveForSigningRights : ParentAccessRights
    {
        /// <summary>
        /// ApproveForSigningRights PackageExpiration
        /// </summary>
        public bool? PackageExpiration { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ApproveForSigningRights PackagePreview
        /// </summary>
        public bool? PackagePreview { get => GetValue<bool?>(); set => SetValue(value); }
    }
}