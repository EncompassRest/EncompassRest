namespace EncompassRest.Services.Credit
{
    public sealed class OrderCreditParameters : OrderServiceParameters
    {
        public new CreditProduct Product => (CreditProduct)base.Product;

        public OrderCreditParameters(CreditProduct product)
            : base(product)
        {
        }
    }
}