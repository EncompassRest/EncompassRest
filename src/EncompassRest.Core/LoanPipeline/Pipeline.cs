namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// The Loan Pipeline Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.LoanPipeline.v1 namespace.
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