namespace EncompassRest.Services
{
    /// <summary>
    /// The Services Apis exposed as extension methods from the EncompassRest.Services package
    /// within the EncompassRest.Services.v1 namespace.
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