namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Borrower Contacts Settings Apis.
    /// </summary>
    public sealed class BorrowerContactsSettings : ContactsSettings
    {
        internal BorrowerContactsSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/borrowerContacts")
        {
        }
    }
}