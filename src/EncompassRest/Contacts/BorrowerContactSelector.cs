namespace EncompassRest.Contacts
{
    public sealed class BorrowerContactSelector : ContactSelector
    {
        internal BorrowerContactSelector(EncompassRestClient client)
            : base(client, "encompass/v1/borrowerContactSelector")
        {
        }
    }
}