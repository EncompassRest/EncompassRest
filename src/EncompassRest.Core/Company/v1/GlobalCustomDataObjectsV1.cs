using EncompassRest.CustomDataObjects.v1;

namespace EncompassRest.Company.v1
{
    /// <summary>
    /// Global Custom Data Objects Apis
    /// </summary>
    public interface IGlobalCustomDataObjectsV1 : ICustomDataObjectsV1
    {
    }

    internal sealed class GlobalCustomDataObjectsV1 : CustomDataObjectsV1, IGlobalCustomDataObjectsV1
    {
        internal GlobalCustomDataObjectsV1(EncompassRestClient client)
            : base(client, "encompass/v1/company/customObjects")
        {
        }
    }
}