using Newtonsoft.Json;

namespace EncompassRest.Services.Credit
{
    /// <summary>
    /// CreditProduct
    /// </summary>
    public sealed class CreditProduct : ServiceProduct
    {
        /// <summary>
        /// CreditProduct Options
        /// </summary>
        public new CreditOptions Options => (CreditOptions)base.Options;

        /// <summary>
        /// CreditProduct Preferences
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CreditPreferences Preferences { get; set; }

        /// <summary>
        /// CreditProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">CreditProduct options.</param>
        public CreditProduct(EntityReference entityRef, CreditOptions options)
            : this(entityRef, options, ServiceType.Credit.GetValue())
        {
        }

        /// <summary>
        /// CreditProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">CreditProduct options.</param>
        /// <param name="name">Name of the service to order.</param>
        public CreditProduct(EntityReference entityRef, CreditOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}