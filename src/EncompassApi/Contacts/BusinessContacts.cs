namespace EncompassApi.Contacts
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
        internal BusinessContacts(IEncompassApiClient client)
            : base(client, "encompass/v1/businessContacts")
        {
        }
    }
}