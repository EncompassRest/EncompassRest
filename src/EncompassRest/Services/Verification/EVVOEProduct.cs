namespace EncompassRest.Services.Verification
{
    public sealed class EVVOEProduct : VerificationProduct
    {
        public new EVVOEOptions Options => (EVVOEOptions)base.Options;

        public EVVOEProduct(EntityReference entityRef, EVVOEOptions options)
            : base(entityRef, options)
        {
        }
    }
}