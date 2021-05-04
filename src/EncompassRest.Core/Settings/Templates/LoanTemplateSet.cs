namespace EncompassRest.Settings.Templates
{
    /// <summary>
    /// The Loan Template Set Apis.
    /// </summary>
    public interface ILoanTemplateSet : ITemplateApiObject
    {
    }

    internal sealed class LoanTemplateSet : TemplateApiObject, ILoanTemplateSet
    {
        internal LoanTemplateSet(EncompassRestClient client)
            : base(client, "loanTemplateSet")
        {
        }
    }
}