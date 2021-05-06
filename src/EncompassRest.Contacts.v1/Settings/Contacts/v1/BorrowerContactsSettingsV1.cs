namespace EncompassRest.Settings.Contacts.v1
{
    /// <summary>
    /// The Borrower Contacts Settings Apis.
    /// </summary>
    public interface IBorrowerContactsSettingsV1 : IContactsSettingsV1
    {
    }

    internal sealed class BorrowerContactsSettingsV1 : ContactsSettingsV1, IBorrowerContactsSettingsV1
    {
        internal BorrowerContactsSettingsV1(EncompassRestClient client)
            : base(client, "encompass/v1/settings/borrowerContacts")
        {
        }
    }
}