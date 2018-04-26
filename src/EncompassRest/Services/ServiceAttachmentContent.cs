using System;

namespace EncompassRest.Services
{
    public sealed class ServiceAttachmentContent : ExtensibleObject
    {
        public DateTime? CreatedDateTime { get; set; }

        public string AttachmentFile { get; set; }
    }
}