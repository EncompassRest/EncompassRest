using System.Collections.Generic;

namespace EncompassApi.Services
{
    /// <summary>
    /// ServiceTransaction
    /// </summary>
    public sealed class ServiceTransaction : ExtensibleObject
    {
        /// <summary>
        /// Status of the transaction.
        /// </summary>
        public StringEnumValue<ServiceStatus> Status { get; set; }

        /// <summary>
        /// Object encapsulating metadata for viewable documents/attachments returned by the Partner service provider as part of their service response. These files are saved to the loan's eFolder and are accessible via the eFolder API's.
        /// </summary>
        public List<ServiceDocument>? Documents { get; set; }

        /// <summary>
        /// Object encapsulating information about the specific product for which the service request was placed.
        /// </summary>
        public ServiceTransactionProduct? Product { get; set; }

        /// <summary>
        /// Container for the files/documents returned by the service Partner as part of their service response.
        /// </summary>
        public List<ServiceResource>? Resources { get; set; }

        /// <summary>
        /// ServiceTransaction Identity
        /// </summary>
        public ServiceTransactionIdentity? Identity { get; set; }
    }
}