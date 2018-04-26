namespace EncompassRest.Services.Verification
{
    public sealed class OrderEVVOEParameters : OrderServiceParameters
    {
        public new EVVOEProduct Product => (EVVOEProduct)base.Product;

        public OrderEVVOEParameters(EVVOEProduct product)
            : base(product)
        {
        }
    }
}