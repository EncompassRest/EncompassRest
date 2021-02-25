namespace EncompassApi.Services.Flood
{
    /// <summary>
    /// The parameters to specify when ordering flood.
    /// </summary>
    public sealed class OrderFloodParameters : OrderServiceParameters
    {
        /// <summary>
        /// Object containing all the necessary product information needed for a flood service provider to process a service request.
        /// </summary>
        public new FloodProduct Product => (FloodProduct)base.Product;

        /// <summary>
        /// OrderFloodParameters constructor.
        /// </summary>
        /// <param name="product">Object containing all the necessary product information needed for a flood service provider to process a service request.</param>
        public OrderFloodParameters(FloodProduct product)
            : base(product)
        {
        }
    }
}