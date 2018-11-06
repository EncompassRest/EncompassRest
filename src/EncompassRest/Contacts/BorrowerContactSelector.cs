namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contact Selector Apis.
    /// </summary>
    public sealed class BorrowerContactSelector : ContactSelector
    {
        internal BorrowerContactSelector(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContactSelector")
        {
        }
    }
}