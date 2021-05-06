namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contacts Apis exposed as extension methods from the EncompassRest.Contacts.v1 package
    /// within the EncompassRest.Contacts.v1 namespace.
    /// </summary>
    public interface IBusinessContacts : IApiObject
    {
    }

    internal sealed class BusinessContacts : ApiObject, IBusinessContacts
    {
        internal BusinessContacts(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}