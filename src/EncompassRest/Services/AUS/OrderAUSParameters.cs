namespace EncompassRest.Services.AUS
{
    /// <summary>
    /// The parameters to specify when ordering AUS.
    /// </summary>
    public sealed class OrderAUSParameters : OrderServiceParameters
    {
        /// <summary>
        /// Object containing all the necessary product information needed for an AUS service provider to process a service request.
        /// </summary>
        public new AUSProduct Product => (AUSProduct)base.Product;

        /// <summary>
        /// OrderAUSParameters constructor.
        /// </summary>
        /// <param name="product">Object containing all the necessary product information needed for an AUS service provider to process a service request.</param>
        public OrderAUSParameters(AUSProduct product)
            : base(product)
        {
        }
    }
}