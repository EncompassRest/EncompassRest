namespace EncompassRest.Services
{
    /// <summary>
    /// The Services Apis.
    /// </summary>
    public interface IServices : IApiObject
    {
    }

    internal sealed class Services : ApiObject, IServices
    {
        internal Services(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}