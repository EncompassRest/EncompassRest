using System.Collections.Generic;

namespace EncompassRest.Services
{
    /// <summary>
    /// ServiceDocument
    /// </summary>
    public sealed class ServiceDocument : ExtensibleObject
    {
        /// <summary>
        /// Unique identifier for the eFolder document.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the eFolder document.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Collection of eFolder attachments associated with the response document.
        /// </summary>
        public List<ServiceAttachment> Attachments { get; set; }
    }
}