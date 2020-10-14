namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contacts Apis.
    /// </summary>
    public interface IBusinessContacts : IContacts<BusinessContact>
    {
    }

    /// <summary>
    /// The Business Contacts Apis.
    /// </summary>
    public sealed class BusinessContacts : Contacts<BusinessContact>, IBusinessContacts
    {
        internal BusinessContacts(IEncompassRestClient client)
            : base(client, "encompass/v1/businessContacts")
        {
        }
    }
}