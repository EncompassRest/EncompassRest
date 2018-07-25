using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Does not currently work with string fields
    /// </summary>
    public sealed class NotEmptyFieldFilter : FieldFilter
    {
        [JsonProperty]
        private object Value => System.DateTime.MinValue;

        public NotEmptyFieldFilter(CanonicalLoanField canonicalLoanField)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName())
        {
        }

        public NotEmptyFieldFilter(CanonicalContactField canonicalContactField)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName())
        {
        }

        public NotEmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        private NotEmptyFieldFilter(NotEmptyFieldFilter notEmptyFieldFilter)
            : base(notEmptyFieldFilter)
        {
        }

        public new NotEmptyFieldFilter Clone() => new NotEmptyFieldFilter(this);

        protected override FieldFilter CloneFieldFilter() => Clone();

        protected override string GetMatchType() => "isNotEmpty";

        internal override string GetQueryStringFormat() => $"{CanonicalName}:!=:";
    }
}