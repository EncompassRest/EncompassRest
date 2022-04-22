namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OrganizationsUserRights
    /// </summary>
    public sealed class OrganizationsUserRights : ParentAccessRights
    {
        /// <summary>
        /// OrganizationsUserRights AddLEI
        /// </summary>
        public bool? AddLEI { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OrganizationsUserRights EditLEI
        /// </summary>
        public bool? EditLEI { get => GetValue<bool?>(); set => SetValue(value); }
    }
}