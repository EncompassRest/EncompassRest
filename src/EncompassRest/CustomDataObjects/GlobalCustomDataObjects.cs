namespace EncompassRest.CustomDataObjects
{
    public sealed class GlobalCustomDataObjects : CustomDataObjects
    {
        internal GlobalCustomDataObjects(EncompassRestClient client)
            : base(client, "encompass/v1/company/customObjects")
        {
        }
    }
}