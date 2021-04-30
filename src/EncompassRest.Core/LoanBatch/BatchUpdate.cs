namespace EncompassRest.LoanBatch
{
    /// <summary>
    /// The Loan Batch Update Apis.
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