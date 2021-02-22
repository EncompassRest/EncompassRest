namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Business Contacts Settings Apis.
    /// </summary>
    public interface IBusinessContactsSettings : IContactsSettings
    {
    }

    /// <summary>
    /// The Business Contacts Settings Apis.
    /// </summary>
    public sealed class BusinessContactsSettings : ContactsSettings, IBusinessContactsSettings
    {
        internal BusinessContactsSettings(IEncompassRestClient client)
            : base(client, "encompass/v1/settings/businessContacts")
        {
        }
    }
}