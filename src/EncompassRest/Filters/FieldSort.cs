using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public sealed class FieldSort : SerializableObject
    {
        [JsonRequired]
        public string CanonicalName { get; }

        [JsonRequired]
        public SortOrder Order { get; }

        public FieldSort(CanonicalLoanField canonicalLoanField, SortOrder order)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName(), order)
        {
        }

        public FieldSort(CanonicalContactField canonicalContactField, SortOrder order)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName(), order)
        {
        }

        public FieldSort(string canonicalName, SortOrder order)
        {
            Preconditions.NotNullOrEmpty(canonicalName, nameof(canonicalName));
            order.Validate(nameof(order));

            CanonicalName = canonicalName;
            Order = order;
        }
    }
}