namespace EncompassRest.Schema
{
    /// <summary>
    /// The Schema Apis.
    /// </summary>
    public interface ISchema : IApiObject
    {
    }

    internal sealed class Schema : ApiObject, ISchema
    {
        internal Schema(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}