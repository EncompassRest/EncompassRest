namespace EncompassRest.Company
{
    /// <summary>
    /// Global Custom Data Objects Apis
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