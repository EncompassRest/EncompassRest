namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contacts Apis.
    /// </summary>
    public sealed class BorrowerContacts : Contacts<BorrowerContact>
    {
        internal BorrowerContacts(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContacts")
        {
        }
    }
}