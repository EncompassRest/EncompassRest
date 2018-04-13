namespace EncompassRest.Services.AUS
{
    public sealed class OrderAUSParameters : OrderServiceParameters
    {
        public AUSProduct Product => (AUSProduct)base.Product;

        public OrderAUSParameters(AUSProduct product)
            : base(product)
        {
        }
    }
}