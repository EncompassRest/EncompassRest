namespace EncompassRest.Services
{
    public sealed class ServiceResource : ExtensibleObject
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string MimeType { get; set; }

        public string Url { get; set; }
    }
}