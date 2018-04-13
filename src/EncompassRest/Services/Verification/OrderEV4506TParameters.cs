namespace EncompassRest.Services.Verification
{
    public sealed class OrderEV4506TParameters : OrderServiceParameters
    {
        public new EV4506TProduct Product => (EV4506TProduct)base.Product;

        public OrderEV4506TParameters(EV4506TProduct product)
            : base(product)
        {
        }
    }
}