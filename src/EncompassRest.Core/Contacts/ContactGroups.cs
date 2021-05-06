namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Contact Groups Apis.
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