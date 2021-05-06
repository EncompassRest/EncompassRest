namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Business Contacts Apis.
    /// </summary>
    public interface IBusinessContactsV1 : IContactsV1<BusinessContact>
    {
    }

    internal sealed class BusinessContactsV1 : ContactsV1<BusinessContact>, IBusinessContactsV1
    {
        internal BusinessContactsV1(EncompassRestClient client)
            : base(client, "encompass/v1/businessContacts")
        {
        }
    }
}