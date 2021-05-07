namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Borrower Contacts Apis.
    /// </summary>
    public interface IBorrowerContactsV1 : IContactsV1<BorrowerContact>
    {
    }

    internal sealed class BorrowerContactsV1 : ContactsV1<BorrowerContact>, IBorrowerContactsV1
    {
        internal BorrowerContactsV1(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContacts")
        {
        }
    }
}