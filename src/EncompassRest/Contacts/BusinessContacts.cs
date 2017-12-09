namespace EncompassRest.Contacts
{
    public sealed class BusinessContacts : Contacts<BusinessContact>
    {
        internal BusinessContacts(EncompassRestClient client)
            : base(client, "encompass/v1/businessContacts")
        {
        }
    }
}