namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Contact Groups Apis exposed as extension methods from the EncompassRest.Contacts.v1 package
    /// within the EncompassRest.Contacts.v1 namespace.
    /// </summary>
    public interface IContactGroups : IApiObject
    {
    }

    internal sealed class ContactGroups : ApiObject, IContactGroups
    {
        internal ContactGroups(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}