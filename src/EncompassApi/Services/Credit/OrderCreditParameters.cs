namespace EncompassApi.Services.Credit
{
    /// <summary>
    /// The parameters to specify when ordering credit.
    /// </summary>
    public sealed class OrderCreditParameters : OrderServiceParameters
    {
        /// <summary>
        /// Object containing all the necessary product information needed for a credit service provider to process a service request.
        /// </summary>
        public new CreditProduct Product => (CreditProduct)base.Product;

        /// <summary>
        /// OrderCreditParameters constructor.
        /// </summary>
        /// <param name="product">Object containing all the necessary product information needed for a credit service provider to process a service request.</param>
        public OrderCreditParameters(CreditProduct product)
            : base(product)
        {
        }
    }
}