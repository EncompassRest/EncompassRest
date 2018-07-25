using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public sealed class NumericFieldFilter : FieldFilter
    {
        [JsonRequired]
        public new OrdinalFieldMatchType MatchType { get; }

        [JsonRequired]
        public decimal Value { get; }

        public NumericFieldFilter(CanonicalLoanField canonicalLoanField, OrdinalFieldMatchType matchType, decimal value)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName(), matchType, value)
        {
        }

        public NumericFieldFilter(CanonicalContactField canonicalContactField, OrdinalFieldMatchType matchType, decimal value)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName(), matchType, value)
        {
        }

        public NumericFieldFilter(string canonicalName, OrdinalFieldMatchType matchType, decimal value)
            : base(canonicalName)
        {
            matchType.Validate(nameof(matchType));

            MatchType = matchType;
            Value = value;
        }

        protected override string GetMatchType() => MatchType.AsString(EnumJsonConverter.CamelCaseNameFormat);

        internal override string GetQueryStringFormat() => $"{CanonicalName}:{MatchType.AsString(EnumFormat.Description)}:{Value}";
    }
}