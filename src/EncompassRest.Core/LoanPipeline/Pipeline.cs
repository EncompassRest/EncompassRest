namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// The Loan Pipeline Apis.
    /// </summary>
    public interface IPipeline : IApiObject
    {
    }

    internal sealed class Pipeline : ApiObject, IPipeline
    {
        internal Pipeline(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}