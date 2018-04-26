namespace EncompassRest.Services.Verification
{
    public sealed class EV4506TProduct : VerificationProduct
    {
        public new EV4506TOptions Options => (EV4506TOptions)base.Options;

        public EV4506TProduct(EntityReference entityRef, EV4506TOptions options)
            : base(entityRef, options)
        {
        }
    }
}