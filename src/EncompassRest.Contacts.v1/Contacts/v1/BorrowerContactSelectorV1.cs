namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Borrower Contact Selector Apis.
    /// </summary>
    public interface IBorrowerContactSelectorV1 : IContactSelectorV1
    {
    }

    internal sealed class BorrowerContactSelectorV1 : ContactSelectorV1, IBorrowerContactSelectorV1
    {
        internal BorrowerContactSelectorV1(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContactSelector")
        {
        }
    }
}