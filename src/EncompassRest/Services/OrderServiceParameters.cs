using EncompassRest.Utilities;

namespace EncompassRest.Services
{
    public abstract class OrderServiceParameters : SerializableObject
    {
        public ServiceProduct Product { get; }

        internal OrderServiceParameters(ServiceProduct product)
        {
            Preconditions.NotNull(product, nameof(product));

            Product = product;
        }
    }
}