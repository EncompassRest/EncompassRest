namespace EncompassRest.Contacts
{
    public sealed class BorrowerContacts : Contacts<BorrowerContact>
    {
        internal BorrowerContacts(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContacts")
        {
        }
    }
}