namespace EncompassRest.Schema
{
    /// <summary>
    /// The Schema Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Schema.v1 namespace.
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