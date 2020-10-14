namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contact Selector Apis.
    /// </summary>
    public interface IBorrowerContactSelector : IContactSelector
    {
    }

    /// <summary>
    /// The Borrower Contact Selector Apis.
    /// </summary>
    public sealed class BorrowerContactSelector : ContactSelector, IBorrowerContactSelector
    {
        internal BorrowerContactSelector(IEncompassRestClient client)
            : base(client, "encompass/v1/borrowerContactSelector")
        {
        }
    }
}