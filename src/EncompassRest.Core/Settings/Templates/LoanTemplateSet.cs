namespace EncompassRest.Settings.Templates
{
    /// <summary>
    /// The Loan Template Set Apis.
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