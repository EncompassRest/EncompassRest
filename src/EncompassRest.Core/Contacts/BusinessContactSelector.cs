namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contact Selector Apis.
    /// </summary>
    public interface IBusinessContactSelector : IApiObject
    {
    }

    internal sealed class BusinessContactSelector : ApiObject, IBusinessContactSelector
    {
        internal BusinessContactSelector(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}