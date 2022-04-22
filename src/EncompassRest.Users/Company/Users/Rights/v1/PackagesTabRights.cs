namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PackagesTabRights
    /// </summary>
    public sealed class PackagesTabRights : ParentAccessRights
    {
        /// <summary>
        /// PackagesTabRights ESignPackages
        /// </summary>
        public bool? ESignPackages { get => GetValue<bool?>(); set => SetValue(value); }
    }
}