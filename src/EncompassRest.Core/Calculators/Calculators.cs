namespace EncompassRest.Calculators
{
    /// <summary>
    /// The Calculators Apis.
    /// </summary>
    public interface ICalculators : IApiObject
    {
    }

    /// <summary>
    /// The Calculators Apis.
    /// </summary>
    internal sealed class Calculators : ApiObject, ICalculators
    {
        internal Calculators(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}