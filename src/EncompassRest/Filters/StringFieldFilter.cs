using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// String field filter.
    /// </summary>
    public sealed class StringFieldFilter : FieldFilter
    {
        /// <summary>
        /// Filter match type.
        /// </summary>
        [JsonRequired]
        public new StringFieldMatchType MatchType { get; }

        /// <summary>
        /// Filter match value.
        /// </summary>
        [JsonRequired]
        public string Value { get; }

        /// <summary>
        /// Indicates whether to include the matched items in the results.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(true)]
        public bool Include { get; }

        /// <summary>
        /// String field filter.
        /// </summary>
        /// <param name="canonicalLoanField">Canonical loan field.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        /// <param name="include">Indicates whether to include the matched items in the results.</param>
        public StringFieldFilter(CanonicalLoanField canonicalLoanField, StringFieldMatchType matchType, string value, bool include = true)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName(), matchType, value, include)
        {
        }

        /// <summary>
        /// String field filter.
        /// </summary>
        /// <param name="canonicalContactField">Canonical contact field.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        /// <param name="include">Indicates whether to include the matched items in the results.</param>
        public StringFieldFilter(CanonicalContactField canonicalContactField, StringFieldMatchType matchType, string value, bool include = true)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName(), matchType, value, include)
        {
        }

        /// <summary>
        /// String field filter.
        /// </summary>
        /// <param name="canonicalName">Canonical field name.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        /// <param name="include">Indicates whether to include the matched items in the results.</param>
        public StringFieldFilter(string canonicalName, StringFieldMatchType matchType, string value, bool include = true)
            : base(canonicalName)
        {
            matchType.Validate(nameof(matchType));

            MatchType = matchType;
            Value = value ?? string.Empty;
            Include = include;
        }

        internal override string GetMatchType() => MatchType.AsString(EnumJsonConverter.CamelCaseNameFormat);

        internal override string GetQueryStringFormat() => $"{CanonicalName}:{MatchType.AsString(EnumFormat.Description)}:{Value}";
    }
}