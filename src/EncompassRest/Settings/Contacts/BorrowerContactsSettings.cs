namespace EncompassRest.Settings.Contacts
{
    public sealed class BorrowerContactsSettings : ContactsSettings
    {
        internal BorrowerContactsSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/borrowerContacts")
        {
        }
    }
}