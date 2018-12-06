namespace EncompassRest.Services.Verification
{
    /// <summary>
    /// The parameters to specify when ordering EVVOE.
    /// </summary>
    public sealed class OrderEVVOEParameters : OrderServiceParameters
    {
        /// <summary>
        /// Object containing all the necessary product information needed for a EVVOE service provider to process a service request.
        /// </summary>
        public new EVVOEProduct Product => (EVVOEProduct)base.Product;

        /// <summary>
        /// OrderEVVOEParameters constructor.
        /// </summary>
        /// <param name="product">Object containing all the necessary product information needed for a EVVOE service provider to process a service request.</param>
        public OrderEVVOEParameters(EVVOEProduct product)
            : base(product)
        {
        }
    }
}