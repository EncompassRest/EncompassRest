using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public sealed class DateFieldFilter : FieldFilter
    {
        [JsonRequired]
        public new OrdinalFieldMatchType MatchType { get; }

        [JsonRequired]
        public DateTime Value { get; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(DateFieldMatchPrecision.Exact)]
        public DateFieldMatchPrecision Precision { get; }

        public DateFieldFilter(CanonicalLoanField canonicalLoanField, OrdinalFieldMatchType matchType, DateTime value, DateFieldMatchPrecision precision = DateFieldMatchPrecision.Day)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName(), matchType, value, precision)
        {
        }

        public DateFieldFilter(CanonicalContactField canonicalContactField, OrdinalFieldMatchType matchType, DateTime value, DateFieldMatchPrecision precision = DateFieldMatchPrecision.Day)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName(), matchType, value, precision)
        {
        }

        public DateFieldFilter(string canonicalName, OrdinalFieldMatchType matchType, DateTime value, DateFieldMatchPrecision precision = DateFieldMatchPrecision.Day)
            : base(canonicalName)
        {
            matchType.Validate(nameof(matchType));
            precision.Validate(nameof(precision));

            MatchType = matchType;
            Value = value;
            Precision = precision;
        }

        protected override string GetMatchType() => MatchType.AsString(EnumJsonConverter.CamelCaseNameFormat);

        internal override string GetQueryStringFormat() => $"{CanonicalName}:{MatchType.AsString(EnumFormat.Description)}:{Value}";
    }
}