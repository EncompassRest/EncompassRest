namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TPOOrganizationSettingsContactsRights
    /// </summary>
    public sealed class TPOOrganizationSettingsContactsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTPOContacts;

        /// <summary>
        /// TPOOrganizationSettingsContactsRights EditTPOContacts
        /// </summary>
        public bool? EditTPOContacts { get => _editTPOContacts; set => SetField(ref _editTPOContacts, value); }
    }
}