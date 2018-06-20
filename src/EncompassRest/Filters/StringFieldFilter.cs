using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public sealed class StringFieldFilter : FieldFilter
    {
        [JsonRequired]
        public new StringFieldMatchType MatchType { get; }

        [JsonRequired]
        public string Value { get; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(true)]
        public bool Include { get; }

        public StringFieldFilter(CanonicalLoanField canonicalField, StringFieldMatchType matchType, string value, bool include = true)
            : this(canonicalField.Validate(nameof(canonicalField)).GetCanonicalName(), matchType, value, include)
        {
        }

        public StringFieldFilter(string canonicalName, StringFieldMatchType matchType, string value, bool include = true)
            : base(canonicalName)
        {
            matchType.Validate(nameof(matchType));

            MatchType = matchType;
            Value = value ?? string.Empty;
            Include = include;
        }

        protected override string GetMatchType() => MatchType.AsString(EnumJsonConverter.CamelCaseNameFormat);
    }
}