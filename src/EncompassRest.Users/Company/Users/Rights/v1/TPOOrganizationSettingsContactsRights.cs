namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOOrganizationSettingsContactsRights
    /// </summary>
    public sealed class TPOOrganizationSettingsContactsRights : ParentAccessRights
    {
        /// <summary>
        /// TPOOrganizationSettingsContactsRights EditTPOContacts
        /// </summary>
        public bool? EditTPOContacts { get => GetValue<bool?>(); set => SetValue(value); }
    }
}