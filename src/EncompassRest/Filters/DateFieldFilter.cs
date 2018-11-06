using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Date field filter.
    /// </summary>
    public sealed class DateFieldFilter : FieldFilter
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
        public DateTime Value { get; }

        /// <summary>
        /// Filter match precision.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(DateFieldMatchPrecision.Exact)]
        public DateFieldMatchPrecision Precision { get; }

        /// <summary>
        /// Date field filter constructor.
        /// </summary>
        /// <param name="canonicalLoanField">Canonical loan field.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        /// <param name="precision">Filter match precision.</param>
        public DateFieldFilter(CanonicalLoanField canonicalLoanField, OrdinalFieldMatchType matchType, DateTime value, DateFieldMatchPrecision precision = DateFieldMatchPrecision.Day)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName(), matchType, value, precision)
        {
        }

        /// <summary>
        /// Date field filter constructor.
        /// </summary>
        /// <param name="canonicalContactField">Canonical contact field.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        /// <param name="precision">Filter match precision.</param>
        public DateFieldFilter(CanonicalContactField canonicalContactField, OrdinalFieldMatchType matchType, DateTime value, DateFieldMatchPrecision precision = DateFieldMatchPrecision.Day)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName(), matchType, value, precision)
        {
        }

        /// <summary>
        /// Date field filter constructor.
        /// </summary>
        /// <param name="canonicalName">Canonical field name.</param>
        /// <param name="matchType">Filter match type.</param>
        /// <param name="value">Filter match value.</param>
        /// <param name="precision">Filter match precision.</param>
        public DateFieldFilter(string canonicalName, OrdinalFieldMatchType matchType, DateTime value, DateFieldMatchPrecision precision = DateFieldMatchPrecision.Day)
            : base(canonicalName)
        {
            matchType.Validate(nameof(matchType));
            precision.Validate(nameof(precision));

            MatchType = matchType;
            Value = value;
            Precision = precision;
        }

        internal override string GetMatchType() => MatchType.AsString(EnumJsonConverter.CamelCaseNameFormat);

        internal override string GetQueryStringFormat() => $"{CanonicalName}:{MatchType.AsString(EnumFormat.Description)}:{Value}";
    }
}