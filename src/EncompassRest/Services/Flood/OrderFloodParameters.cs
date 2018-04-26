namespace EncompassRest.Services.Flood
{
    public sealed class OrderFloodParameters : OrderServiceParameters
    {
        public new FloodProduct Product => (FloodProduct)base.Product;

        public OrderFloodParameters(FloodProduct product)
            : base(product)
        {
        }
    }
}