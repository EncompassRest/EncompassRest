using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Does not currently work with string fields
    /// </summary>
    public sealed class EmptyFieldFilter : FieldFilter
    {
        [JsonProperty]
        private object Value => System.DateTime.MinValue;

        public EmptyFieldFilter(CanonicalLoanField canonicalLoanField)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName())
        {
        }

        public EmptyFieldFilter(CanonicalContactField canonicalContactField)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName())
        {
        }

        public EmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        protected override string GetMatchType() => "isEmpty";

        internal override string GetQueryStringFormat() => $"{CanonicalName}:==:";
    }
}