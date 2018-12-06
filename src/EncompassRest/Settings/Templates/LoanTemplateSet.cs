namespace EncompassRest.Settings.Templates
{
    /// <summary>
    /// The Loan Template Set Apis.
    /// </summary>
    public sealed class LoanTemplateSet : TemplateApiObject
    {
        internal LoanTemplateSet(EncompassRestClient client)
            : base(client, "loanTemplateSet")
        {
        }
    }
}