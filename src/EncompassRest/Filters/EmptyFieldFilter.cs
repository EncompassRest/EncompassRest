using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public sealed class EmptyFieldFilter : FieldFilter
    {
        [JsonProperty("Value")]
        private object value => System.DateTime.MinValue;

        public EmptyFieldFilter(CanonicalLoanField canonicalField)
            : this(canonicalField.Validate(nameof(canonicalField)).GetCanonicalName())
        {
        }

        public EmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        protected override string GetMatchType() => "isEmpty";
    }
}