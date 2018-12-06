namespace EncompassRest.CustomDataObjects
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class GlobalCustomDataObjects : CustomDataObjects
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        internal GlobalCustomDataObjects(EncompassRestClient client)
            : base(client, "encompass/v1/company/customObjects")
        {
        }
    }
}