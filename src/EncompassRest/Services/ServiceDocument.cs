using System.Collections.Generic;

namespace EncompassRest.Services
{
    public sealed class ServiceDocument : ExtensibleObject
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<ServiceAttachment> Attachments { get; set; }
    }
}