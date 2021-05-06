namespace EncompassRest.EFolder
{
    /// <summary>
    /// The EFolder Apis exposed as extension methods from the EncompassRest.EFolder.v1 package
    /// within the EncompassRest.EFolder.v1 namespace.
    /// </summary>
    public interface IEFolder : IApiObject
    {
    }

    internal sealed class EFolder : ApiObject, IEFolder
    {
        internal EFolder(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}
