namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Borrower Contacts Settings Apis.
    /// </summary>
    public interface IBorrowerContactsSettings : IApiObject
    {
    }

    internal sealed class BorrowerContactsSettings : ApiObject, IBorrowerContactsSettings
    {
        internal BorrowerContactsSettings(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}