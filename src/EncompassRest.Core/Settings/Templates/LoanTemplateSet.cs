namespace EncompassRest.Settings.Templates
{
    /// <summary>
    /// The Loan Template Set Apis exposed as extension methods
    /// within the EncompassRest.Settings.Templates.v1 namespace.
    /// </summary>
    public interface ILoanTemplateSet : IApiObject
    {
    }

    internal sealed class LoanTemplateSet : ApiObject, ILoanTemplateSet
    {
        internal LoanTemplateSet(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}