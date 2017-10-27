using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class PageThumbnail : Image
    {
    }
}