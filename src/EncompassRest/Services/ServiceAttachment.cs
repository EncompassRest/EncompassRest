namespace EncompassRest.Services
{
    public sealed class ServiceAttachment : ExtensibleObject
    {
        public string Name { get; set; }

        public string MimeType { get; set; }

        public ServiceAttachmentContent Content { get; set; }
    }
}