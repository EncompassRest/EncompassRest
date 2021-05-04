namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Business Contacts Settings Apis.
    /// </summary>
    public interface IBusinessContactsSettings : IContactsSettings
    {
    }

    internal sealed class BusinessContactsSettings : ContactsSettings, IBusinessContactsSettings
    {
        internal BusinessContactsSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/businessContacts")
        {
        }
    }
}