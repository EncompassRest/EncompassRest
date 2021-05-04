namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contacts Apis.
    /// </summary>
    public interface IBusinessContacts : IContacts<BusinessContact>
    {
    }

    internal sealed class BusinessContacts : Contacts<BusinessContact>, IBusinessContacts
    {
        internal BusinessContacts(EncompassRestClient client)
            : base(client, "encompass/v1/businessContacts")
        {
        }
    }
}