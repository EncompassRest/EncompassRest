namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ApproveForSigningRights
    /// </summary>
    public sealed class ApproveForSigningRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _packageExpiration;
        private DirtyValue<bool?>? _packagePreview;

        /// <summary>
        /// ApproveForSigningRights PackageExpiration
        /// </summary>
        public bool? PackageExpiration { get => _packageExpiration; set => SetField(ref _packageExpiration, value); }

        /// <summary>
        /// ApproveForSigningRights PackagePreview
        /// </summary>
        public bool? PackagePreview { get => _packagePreview; set => SetField(ref _packagePreview, value); }
    }
}