namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Business Contact Selector Apis exposed as extension methods from the EncompassRest.Contacts package
    /// within the EncompassRest.Contacts.v1 namespace.
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