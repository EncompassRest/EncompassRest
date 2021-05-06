namespace EncompassRest.Company.Users.Rights.v1
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