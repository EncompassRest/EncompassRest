namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contacts Apis.
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