using System;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.Flood
{
    public sealed class FloodProduct : ServiceProduct
    {
        public new FloodOptions Options => (FloodOptions)base.Options;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public new FloodCredentials Credentials { get; set; }

        internal override ServiceCredentials CredentialsInternal
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

        public FloodProduct(EntityReference entityRef, FloodOptions options)
            : base(entityRef, options, ServiceType.Flood.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        public FloodProduct(EntityReference entityRef, FloodOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}