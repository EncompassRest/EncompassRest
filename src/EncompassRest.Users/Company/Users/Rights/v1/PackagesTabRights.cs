namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PackagesTabRights
    /// </summary>
    public sealed class PackagesTabRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _eSignPackages;

        /// <summary>
        /// PackagesTabRights ESignPackages
        /// </summary>
        public bool? ESignPackages { get => _eSignPackages; set => SetField(ref _eSignPackages, value); }
    }
}