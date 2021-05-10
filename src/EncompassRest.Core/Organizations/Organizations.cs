namespace EncompassRest.Organizations
{
    /// <summary>
    /// The Organizations Apis exposed as extension methods from the EncompassRest.Users package
    /// within the EncompassRest.Organizations.v1 namespace.
    /// </summary>
    public interface IOrganizations : IApiObject
    {
    }

    internal sealed class Organizations : ApiObject, IOrganizations
    {
        internal Organizations(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}