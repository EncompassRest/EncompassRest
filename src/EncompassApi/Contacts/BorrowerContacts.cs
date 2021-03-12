namespace EncompassApi.Contacts
{
    /// <summary>
    /// The Borrower Contacts Apis.
    /// </summary>
    public interface IBorrowerContacts : IContacts<BorrowerContact>
    {
    }

    /// <summary>
    /// The Borrower Contacts Apis.
    /// </summary>
    public sealed class BorrowerContacts : Contacts<BorrowerContact>, IBorrowerContacts
    {
        internal BorrowerContacts(IEncompassApiClient client)
            : base(client, "encompass/v1/borrowerContacts")
        {
        }
    }
}