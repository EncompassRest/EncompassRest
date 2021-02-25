namespace EncompassApi.Services
{
    /// <summary>
    /// ServiceAttachment
    /// </summary>
    public sealed class ServiceAttachment : ExtensibleObject
    {
        /// <summary>
        /// MIME type/format of an individual eFolder attachment.
        /// </summary>
        public string? MimeType { get; set; }

        /// <summary>
        /// Name of an individual eFolder attachment.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Object encapsulating attachment content metadata for an individual attachment.
        /// </summary>
        public ServiceAttachmentContent? Content { get; set; }
    }
}