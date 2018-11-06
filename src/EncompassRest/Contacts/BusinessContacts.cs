namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contacts Apis.
    /// </summary>
    public sealed class BusinessContacts : Contacts<BusinessContact>
    {
        internal BusinessContacts(EncompassRestClient client)
            : base(client, "encompass/v1/businessContacts")
        {
        }
    }
}