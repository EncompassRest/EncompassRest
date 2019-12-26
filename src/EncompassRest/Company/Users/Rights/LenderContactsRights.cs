namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// LenderContactsRights
    /// </summary>
    public sealed class LenderContactsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editLenderContacts;

        /// <summary>
        /// LenderContactsRights EditLenderContacts
        /// </summary>
        public bool? EditLenderContacts { get => _editLenderContacts; set => SetField(ref _editLenderContacts, value); }
    }
}