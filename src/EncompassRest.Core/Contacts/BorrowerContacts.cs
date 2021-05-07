namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contacts Apis exposed as extension methods from the EncompassRest.Contacts package
    /// within the EncompassRest.Contacts.v1 namespace.
    /// </summary>
    public interface IBorrowerContacts : IApiObject
    {
    }

    internal sealed class BorrowerContacts : ApiObject, IBorrowerContacts
    {
        internal BorrowerContacts(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}