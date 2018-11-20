using System;

namespace EncompassRest.Services
{
    /// <summary>
    /// ServiceAttachmentContent
    /// </summary>
    public sealed class ServiceAttachmentContent : ExtensibleObject
    {
        /// <summary>
        /// The date and time when the eFolder attachment was created.
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// The unique identifier for the eFolder attachment that is needed to retrieve the attachment using the eFolder API's.
        /// </summary>
        public string AttachmentFile { get; set; }
    }
}