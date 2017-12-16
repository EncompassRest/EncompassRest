namespace EncompassRest.Settings.Templates
{
    public sealed class LoanTemplateSet : TemplateApiObject
    {
        internal LoanTemplateSet(EncompassRestClient client)
            : base(client, "loanTemplateSet")
        {
        }
    }
}