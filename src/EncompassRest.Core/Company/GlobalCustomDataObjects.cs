namespace EncompassRest.Company
{
    /// <summary>
    /// Global Custom Data Objects Apis exposed as extension methods
    /// within the EncompassRest.Company.v1 namespace.
    /// </summary>
    public interface IGlobalCustomDataObjects : IApiObject
    {
    }

    internal sealed class GlobalCustomDataObjects : ApiObject, IGlobalCustomDataObjects
    {
        internal GlobalCustomDataObjects(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}