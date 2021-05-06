using System;
using Newtonsoft.Json;

namespace EncompassRest.Services.v1.Appraisal
{
    /// <summary>
    /// AppraisalProduct
    /// </summary>
    public sealed class AppraisalProduct : ServiceProduct
    {
        /// <summary>
        /// AppraisalProduct Options
        /// </summary>
        public new AppraisalOptions Options => (AppraisalOptions)base.Options;

        /// <summary>
        /// Object that encapsulates credentials and/or verification information with the Appraisal service provider.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public new AppraisalCredentials? Credentials { get; set; }

        internal override ServiceCredentials? CredentialsInternal
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

        /// <summary>
        /// AppraisalProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">AppraisalProduct options.</param>
        public AppraisalProduct(EntityReference entityRef, AppraisalOptions options)
            : this(entityRef, options, ServiceType.Appraisal.GetValue()!)
        {
        }

        /// <summary>
        /// AppraisalProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">AppraisalProduct options.</param>
        /// <param name="name">Name of the service to order.</param>
        public AppraisalProduct(EntityReference entityRef, AppraisalOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}