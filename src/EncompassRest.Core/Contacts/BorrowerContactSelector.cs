namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contact Selector Apis.
    /// </summary>
    public interface IBorrowerContactSelector : IContactSelector
    {
    }

    internal sealed class BorrowerContactSelector : ContactSelector, IBorrowerContactSelector
    {
        internal BorrowerContactSelector(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContactSelector")
        {
        }
    }
}