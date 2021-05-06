namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Borrower Contacts Settings Apis exposed as extension methods from the EncompassRest.Contacts.v1 package
    /// within the EncompassRest.Settings.Contacts.v1 namespace.
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