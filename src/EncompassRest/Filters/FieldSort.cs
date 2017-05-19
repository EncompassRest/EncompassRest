using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public sealed class FieldSort
    {
        [JsonRequired]
        public string CanonicalName { get; }

        [JsonRequired]
        public SortOrder Order { get; }

        public FieldSort(CanonicalField canonicalField, SortOrder order)
            : this(canonicalField.Validate(nameof(canonicalField)).GetCanonicalName(), order)
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