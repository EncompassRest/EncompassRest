using System;
using Newtonsoft.Json;

namespace EncompassRest.Services.v1.AUS
{
    /// <summary>
    /// AUSProduct
    /// </summary>
    public sealed class AUSProduct : ServiceProduct
    {
        /// <summary>
        /// AUSProduct Options
        /// </summary>
        public new AUSOptions Options => (AUSOptions)base.Options;

        /// <summary>
        /// Object that encapsulates user preferences for service specific functionality.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AUSPreferences? Preferences { get; set; }

        /// <summary>
        /// Object that encapsulates credentials and/or verification information with the AUS provider.
        /// </summary>
        public new AUSCredentials? Credentials { get; set; }

        internal override ServiceCredentials? CredentialsInternal
        {
            get => Credentials;
            set
            {
                if (value == null)
                {
                    Credentials = null;
                }
                else if (value is AUSCredentials ausCredentials)
                {
                    Credentials = ausCredentials;
                }
                else
                {
                    throw new ArgumentException("Credentials must be of type AUSCredentials");
                }
            }
        }

        /// <summary>
        /// AUSProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">AUSProduct options.</param>
        public AUSProduct(EntityReference entityRef, AUSOptions options)
            : this(entityRef, options, ServiceType.AUS.GetValue())
        {
        }

        /// <summary>
        /// AUSProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">AUSProduct options.</param>
        /// <param name="name">Name of the service to order.</param>
        public AUSProduct(EntityReference entityRef, AUSOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}