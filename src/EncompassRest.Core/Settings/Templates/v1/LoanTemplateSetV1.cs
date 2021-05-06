namespace EncompassRest.Settings.Templates.v1
{
    /// <summary>
    /// The Loan Template Set Apis.
    /// </summary>
    public interface ILoanTemplateSetV1 : ITemplateApiObjectV1
    {
    }

    internal sealed class LoanTemplateSetV1 : TemplateApiObjectV1, ILoanTemplateSetV1
    {
        internal LoanTemplateSetV1(EncompassRestClient client)
            : base(client, "loanTemplateSet")
        {
        }
    }
}