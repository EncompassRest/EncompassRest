namespace EncompassRest.Settings.Templates
{
    public sealed class LoanTemplates : TemplateApiObject
    {
        internal LoanTemplates(EncompassRestClient client)
            : base(client, "loanTemplateSet")
        {
        }
    }
}