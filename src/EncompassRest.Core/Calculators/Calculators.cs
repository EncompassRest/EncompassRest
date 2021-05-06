namespace EncompassRest.Calculators
{
    /// <summary>
    /// The Calculators Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Calculators.v1 namespace.
    /// </summary>
    public interface ICalculators : IApiObject
    {
    }

    internal sealed class Calculators : ApiObject, ICalculators
    {
        internal Calculators(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}