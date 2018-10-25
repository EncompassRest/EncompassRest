namespace EncompassRest.Company
{
    /// <summary>
    /// Global Custom Data Objects Apis
    /// </summary>
    public sealed class GlobalCustomDataObjects : CustomDataObjects.CustomDataObjects
    {
        internal GlobalCustomDataObjects(EncompassRestClient client)
            : base(client, "encompass/v1/company/customObjects")
        {
        }
    }
}