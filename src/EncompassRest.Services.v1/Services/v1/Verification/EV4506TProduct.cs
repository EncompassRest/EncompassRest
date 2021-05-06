namespace EncompassRest.Services.v1.Verification
{
    /// <summary>
    /// EV4506TProduct
    /// </summary>
    public sealed class EV4506TProduct : VerificationProduct
    {
        /// <summary>
        /// EV4506TProduct Options
        /// </summary>
        public new EV4506TOptions Options => (EV4506TOptions)base.Options;

        /// <summary>
        /// EV4506TProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">EV4506TProduct options.</param>
        public EV4506TProduct(EntityReference entityRef, EV4506TOptions options)
            : base(entityRef, options)
        {
        }

        /// <summary>
        /// EV4506TProduct constructor.
        /// </summary>
        /// <param name="entityRef">References the entity ID and entity type. Both must include the loan ID and borrower application ID associated with the loan.</param>
        /// <param name="options">EV4506TProduct options.</param>
        /// <param name="name">Name of the service to order.</param>
        public EV4506TProduct(EntityReference entityRef, EV4506TOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}