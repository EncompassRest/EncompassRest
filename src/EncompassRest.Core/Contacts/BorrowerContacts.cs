namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contacts Apis.
    /// </summary>
    public interface IBorrowerContacts : IContacts<BorrowerContact>
    {
    }

    internal sealed class BorrowerContacts : Contacts<BorrowerContact>, IBorrowerContacts
    {
        internal BorrowerContacts(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContacts")
        {
        }
    }
}