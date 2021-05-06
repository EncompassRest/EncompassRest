namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loans Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.v1 namespace.
    /// </summary>
    public interface ILoans : IApiObject
    {
    }

    internal sealed class Loans : ApiObject, ILoans
    {
        internal Loans(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}