namespace EncompassRest.LoanBatch
{
    /// <summary>
    /// The Loan Batch Update Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.LoanBatch.v1 namespace.
    /// </summary>
    public interface IBatchUpdate : IApiObject
    {
    }

    internal sealed class BatchUpdate : ApiObject, IBatchUpdate
    {
        internal BatchUpdate(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}