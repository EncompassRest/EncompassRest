using EncompassRest.Utilities;

namespace EncompassRest.Services.v1
{
    /// <summary>
    /// The parameters to specify when ordering a service.
    /// </summary>
    public abstract class OrderServiceParameters : ExtensibleObject
    {
        /// <summary>
        /// Object containing all the necessary product information needed for a service provider to process a service request.
        /// </summary>
        public ServiceProduct Product { get; }

        internal OrderServiceParameters(ServiceProduct product)
        {
            Preconditions.NotNull(product, nameof(product));

            Product = product;
        }
    }
}