namespace EncompassRest.Services.Verification
{
    /// <summary>
    /// EVVOEProduct
    /// </summary>
    public sealed class EVVOEProduct : VerificationProduct
    {
        /// <summary>
        /// EVVOEProduct Options
        /// </summary>
        public new EVVOEOptions Options => (EVVOEOptions)base.Options;

        /// <summary>
        /// EVVOEProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">EVVOEProduct options.</param>
        public EVVOEProduct(EntityReference entityRef, EVVOEOptions options)
            : base(entityRef, options)
        {
        }

        /// <summary>
        /// EVVOEProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">EVVOEProduct options.</param>
        /// <param name="name">Name of the service to order.</param>
        public EVVOEProduct(EntityReference entityRef, EVVOEOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}