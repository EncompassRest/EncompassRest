namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ContactsRights
    /// </summary>
    public sealed class ContactsRights : DirtyExtensibleObject
    {
        private AccessToContactsTabRights _accessToContactsTab;

        /// <summary>
        /// ContactsRights AccessToContactsTab
        /// </summary>
        public AccessToContactsTabRights AccessToContactsTab { get => GetField(ref _accessToContactsTab); set => SetField(ref _accessToContactsTab, value); }
    }
}