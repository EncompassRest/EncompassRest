namespace EncompassRest.EFolder
{
    /// <summary>
    /// The EFolder Apis.
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
