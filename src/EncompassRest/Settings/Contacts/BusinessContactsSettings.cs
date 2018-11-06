namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Business Contacts Settings Apis.
    /// </summary>
    public sealed class BusinessContactsSettings : ContactsSettings
    {
        internal BusinessContactsSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/businessContacts")
        {
        }
    }
}