namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// The Personas Apis exposed as extension methods from the EncompassRest.Users package
    /// within the EncompassRest.Settings.Personas.v1 namespace.
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