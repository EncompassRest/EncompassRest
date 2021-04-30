using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Field sort.
    /// </summary>
    public sealed class FieldSort : SerializableObject
    {
        /// <summary>
        /// Canonical field name.
        /// </summary>
        [JsonRequired]
        public string CanonicalName { get; }

        /// <summary>
        /// Field sort order.
        /// </summary>
        [JsonRequired]
        public SortOrder Order { get; }

        /// <summary>
        /// Field sort constructor.
        /// </summary>
        /// <param name="canonicalLoanField">Canonical loan field.</param>
        /// <param name="order">Field sort order.</param>
        public FieldSort(CanonicalLoanField canonicalLoanField, SortOrder order)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName(), order)
        {
        }

        /// <summary>
        /// Field sort constructor.
        /// </summary>
        /// <param name="canonicalContactField">Canonical contact field.</param>
        /// <param name="order">Field sort order.</param>
        public FieldSort(CanonicalContactField canonicalContactField, SortOrder order)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName(), order)
        {
        }

        /// <summary>
        /// Field sort constructor.
        /// </summary>
        /// <param name="canonicalName">Canonical field name.</param>
        /// <param name="order">Field sort order.</param>
        public FieldSort(string canonicalName, SortOrder order)
        {
            Preconditions.NotNullOrEmpty(canonicalName, nameof(canonicalName));
            order.Validate(nameof(order));

            CanonicalName = canonicalName;
            Order = order;
        }
    }
}