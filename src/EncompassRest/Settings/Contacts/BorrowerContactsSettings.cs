namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Borrower Contacts Settings Apis.
    /// </summary>
    public interface IBorrowerContactsSettings : IContactsSettings
    {
    }

    /// <summary>
    /// The Borrower Contacts Settings Apis.
    /// </summary>
    public sealed class BorrowerContactsSettings : ContactsSettings, IBorrowerContactsSettings
    {
        internal BorrowerContactsSettings(IEncompassRestClient client)
            : base(client, "encompass/v1/settings/borrowerContacts")
        {
        }
    }
}