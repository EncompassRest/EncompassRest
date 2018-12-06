namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contact Selector Apis.
    /// </summary>
    public sealed class BusinessContactSelector : ContactSelector
    {
        internal BusinessContactSelector(EncompassRestClient client)
            : base(client, "encompass/v1/businessContactSelector")
        {
        }
    }
}