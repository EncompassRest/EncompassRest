using System.Collections.Generic;

namespace EncompassRest.Services
{
    public sealed class ServiceTransaction : ExtensibleObject
    {
        public StringEnumValue<ServiceStatus> Status { get; set; }

        public List<ServiceDocument> Documents { get; set; }

        public ServiceTransactionProduct Product { get; set; }

        public ServiceTransactionIdentity Identity { get; set; }

        public List<ServiceResource> Resources { get; set; }
    }
}