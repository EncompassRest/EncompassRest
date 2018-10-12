namespace EncompassRest.Settings.Contacts
{
    public sealed class BusinessContactsSettings : ContactsSettings
    {
        internal BusinessContactsSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/businessContacts")
        {
        }
    }
}