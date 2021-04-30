namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loans Apis.
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