using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Numeric field filter.
    /// </summary>
    public sealed class NumericFieldFilter : FieldFilter
    {
        /// <summary>
        /// Filter match type.
        /// </summary>
        [JsonRequired]
        public new OrdinalFieldMatchType MatchType { get; }

        /// <summary>
        /// Filter match value.
        /// </summary>
        [JsonRequired]
        public decimal Value { get; }

        /// <summary>
        /// Numeric field filter constructor.
        /// </summary>
        /// <param name="canonicalLoanField">Canonical loan field.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        public NumericFieldFilter(CanonicalLoanField canonicalLoanField, OrdinalFieldMatchType matchType, decimal value)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName(), matchType, value)
        {
        }

        /// <summary>
        /// Numeric field filter constructor.
        /// </summary>
        /// <param name="canonicalContactField">Canonical contact field.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        public NumericFieldFilter(CanonicalContactField canonicalContactField, OrdinalFieldMatchType matchType, decimal value)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName(), matchType, value)
        {
        }

        /// <summary>
        /// Numeric field filter constructor.
        /// </summary>
        /// <param name="canonicalName">Canonical field name.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        public NumericFieldFilter(string canonicalName, OrdinalFieldMatchType matchType, decimal value)
            : base(canonicalName)
        {
            matchType.Validate(nameof(matchType));

            MatchType = matchType;
            Value = value;
        }

        internal override string GetMatchType() => MatchType.AsString(EnumJsonConverter.CamelCaseNameFormat);

        internal override string GetQueryStringFormat() => $"{CanonicalName}:{MatchType.AsString(EnumFormat.Description)}:{Value}";
    }
}