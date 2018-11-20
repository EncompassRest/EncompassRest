namespace EncompassRest.Services.Verification
{
    /// <summary>
    /// The parameters to specify when ordering EV4506T.
    /// </summary>
    public sealed class OrderEV4506TParameters : OrderServiceParameters
    {
        /// <summary>
        /// Object containing all the necessary product information needed for a EV4506T service provider to process a service request.
        /// </summary>
        public new EV4506TProduct Product => (EV4506TProduct)base.Product;

        /// <summary>
        /// OrderEV4506TParameters constructor.
        /// </summary>
        /// <param name="product">Object containing all the necessary product information needed for a EV4506T service provider to process a service request.</param>
        public OrderEV4506TParameters(EV4506TProduct product)
            : base(product)
        {
        }
    }
}