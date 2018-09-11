using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Services
{
    public abstract class ServiceProduct : SerializableObject
    {
        public EntityReference EntityRef { get; }

        public StringEnumValue<ServiceType> Name { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ServiceCredentials Credentials { get => CredentialsInternal; set => CredentialsInternal = value; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<ServiceCredentialStore> CredentialStore { get; set; }

        public ServiceOptions Options { get; }

        internal virtual ServiceCredentials CredentialsInternal { get; set; }

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