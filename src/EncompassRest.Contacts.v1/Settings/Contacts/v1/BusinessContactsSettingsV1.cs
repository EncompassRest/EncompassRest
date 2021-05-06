namespace EncompassRest.Settings.Contacts.v1
{
    /// <summary>
    /// The Business Contacts Settings Apis.
    /// </summary>
    public interface IBusinessContactsSettingsV1 : IContactsSettingsV1
    {
    }

    internal sealed class BusinessContactsSettingsV1 : ContactsSettingsV1, IBusinessContactsSettingsV1
    {
        internal BusinessContactsSettingsV1(EncompassRestClient client)
            : base(client, "encompass/v1/settings/businessContacts")
        {
        }
    }
}