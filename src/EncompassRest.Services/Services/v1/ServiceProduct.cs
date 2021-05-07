using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Services.v1
{
    /// <summary>
    /// ServiceProduct
    /// </summary>
    public abstract class ServiceProduct : ExtensibleObject
    {
        /// <summary>
        /// References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.
        /// </summary>
        public EntityReference EntityRef { get; }

        /// <summary>
        /// Name of the service to order.
        /// </summary>
        public StringEnumValue<ServiceType> Name { get; }

        /// <summary>
        /// Login credentials for the service provider.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ServiceCredentials? Credentials { get => CredentialsInternal; set => CredentialsInternal = value; }

        /// <summary>
        /// Indicates that the API user will use credentials stored in the Encompass Services Password Manager at a user-level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<ServiceCredentialStore> CredentialStore { get; set; }

        /// <summary>
        /// ServiceProduct Options
        /// </summary>
        public ServiceOptions Options { get; }

        /// <summary>
        /// This object contains the resources (documents and attachments) associated with the loan that are being shared with the service partner with respect to the service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<EntityReference>? Resources { get; set; }

        internal virtual ServiceCredentials? CredentialsInternal { get; set; }

        internal ServiceProduct(EntityReference entityRef, ServiceOptions options, string name)
        {
            Preconditions.NotNull(entityRef, nameof(entityRef));
            Preconditions.NotNull(options, nameof(options));
            Preconditions.NotNullOrEmpty(name, nameof(name));

            EntityRef = entityRef;
            Options = options;
            Name = name;
        }
    }
}