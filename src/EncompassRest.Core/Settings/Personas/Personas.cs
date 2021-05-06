namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// The Personas Apis.
    /// </summary>
    public interface IPersonas : IApiObject
    {
    }

    internal sealed class Personas : ApiObject, IPersonas
    {
        internal Personas(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}