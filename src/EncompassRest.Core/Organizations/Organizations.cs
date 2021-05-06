namespace EncompassRest.Organizations
{
    /// <summary>
    /// Organizations Apis
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