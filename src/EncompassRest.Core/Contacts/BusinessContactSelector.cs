namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contact Selector Apis.
    /// </summary>
    public interface IBusinessContactSelector : IContactSelector
    {
    }

    internal sealed class BusinessContactSelector : ContactSelector, IBusinessContactSelector
    {
        internal BusinessContactSelector(EncompassRestClient client)
            : base(client, "encompass/v1/businessContactSelector")
        {
        }
    }
}