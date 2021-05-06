namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contact Selector Apis.
    /// </summary>
    public interface IBorrowerContactSelector : IApiObject
    {
    }

    internal sealed class BorrowerContactSelector : ApiObject, IBorrowerContactSelector
    {
        internal BorrowerContactSelector(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}