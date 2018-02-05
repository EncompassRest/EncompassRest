namespace EncompassRest.Contacts
{
    public sealed class BusinessContactSelector : ContactSelector
    {
        internal BusinessContactSelector(EncompassRestClient client)
            : base(client, "encompass/v1/businessContactSelector")
        {
        }
    }
}