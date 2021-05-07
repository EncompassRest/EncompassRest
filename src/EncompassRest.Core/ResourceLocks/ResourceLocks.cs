namespace EncompassRest.ResourceLocks
{
    /// <summary>
    /// The Resource Locks Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.ResourceLocks.v1 namespace.
    /// </summary>
    public interface IResourceLocks : IApiObject
    {
    }

    internal sealed class ResourceLocks : ApiObject, IResourceLocks
    {
        internal ResourceLocks(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}