using System;
using EncompassApi.Extensions;
using Newtonsoft.Json;

namespace EncompassApi.Services.Flood
{
    /// <summary>
    /// FloodProduct
    /// </summary>
    public sealed class FloodProduct : ServiceProduct
    {
        /// <summary>
        /// FloodProduct Options
        /// </summary>
        public new FloodOptions Options => (FloodOptions)base.Options;

        /// <summary>
        /// Object that encapsulates credentials and/or verification information with the Flood service provider.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public new FloodCredentials? Credentials { get; set; }

        internal override ServiceCredentials? CredentialsInternal
        {
            get => Credentials;
            set
            {
                if (value == null)
                {
                    Credentials = null;
                }
                else if (value is FloodCredentials floodCredentials)
                {
                    Credentials = floodCredentials;
                }
                else
                {
                    throw new ArgumentException("Credentials must be of type FloodCredentials");
                }
            }
        }

        /// <summary>
        /// FloodProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type.</param>
        /// <param name="options">FloodProduct options.</param>
        public FloodProduct(EntityReference entityRef, FloodOptions options)
            : base(entityRef, options, ServiceType.Flood.GetValue()!)
        {
        }

        /// <summary>
        /// FloodProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type.</param>
        /// <param name="options">FloodProduct options.</param>
        /// <param name="name">Name of the service to order.</param>
        public FloodProduct(EntityReference entityRef, FloodOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}