namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Borrower Contact Selector Apis exposed as extension methods from the EncompassRest.Contacts package
    /// within the EncompassRest.Contacts.v1 namespace.
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