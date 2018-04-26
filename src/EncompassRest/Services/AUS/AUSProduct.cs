using System;
using Newtonsoft.Json;

namespace EncompassRest.Services.AUS
{
    public sealed class AUSProduct : ServiceProduct
    {
        public new AUSOptions Options => (AUSOptions)base.Options;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AUSPreferences Preferences { get; set; }

        public new AUSCredentials Credentials { get; set; }

        internal override ServiceCredentials CredentialsInternal
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

        public AUSProduct(EntityReference entityRef, AUSOptions options)
            : base(entityRef, options, ServiceType.AUS)
        {
        }
    }
}