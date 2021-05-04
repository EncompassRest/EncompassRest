namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Borrower Contacts Settings Apis.
    /// </summary>
    public interface IBorrowerContactsSettings : IContactsSettings
    {
    }

    internal sealed class BorrowerContactsSettings : ContactsSettings, IBorrowerContactsSettings
    {
        internal BorrowerContactsSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/borrowerContacts")
        {
        }
    }
}