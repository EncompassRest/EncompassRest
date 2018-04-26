using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Services.Appraisal
{
    public sealed class AppraisalProduct : ServiceProduct
    {
        public new AppraisalOptions Options => (AppraisalOptions)base.Options;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public new AppraisalCredentials Credentials { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<EntityReference> Resources { get; set; }

        internal override ServiceCredentials CredentialsInternal
        {
            get => Credentials;
            set
            {
                if (value == null)
                {
                    Credentials = null;
                }
                else if (value is AppraisalCredentials appraisalCredentials)
                {
                    Credentials = appraisalCredentials;
                }
                else
                {
                    throw new ArgumentException("Credentials must be of type AppraisalCredentials");
                }
            }
        }

        public AppraisalProduct(EntityReference entityRef, AppraisalOptions options)
            : base(entityRef, options, ServiceType.Appraisal)
        {
        }
    }
}