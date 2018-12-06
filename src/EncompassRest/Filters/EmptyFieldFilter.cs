using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Empty field filter. Does not currently work with string fields with cursors.
    /// </summary>
    public sealed class EmptyFieldFilter : FieldFilter
    {
        [JsonProperty]
        private object Value => System.DateTime.MinValue;

        /// <summary>
        /// Empty field filter constructor.
        /// </summary>
        /// <param name="canonicalLoanField">Canonical loan field.</param>
        public EmptyFieldFilter(CanonicalLoanField canonicalLoanField)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName())
        {
        }

        /// <summary>
        /// Empty field filter constructor.
        /// </summary>
        /// <param name="canonicalContactField">Canonical contact field.</param>
        public EmptyFieldFilter(CanonicalContactField canonicalContactField)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName())
        {
        }

        /// <summary>
        /// Empty field filter constructor.
        /// </summary>
        /// <param name="canonicalName">Canonical field name.</param>
        public EmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        internal override string GetMatchType() => "isEmpty";

        internal override string GetQueryStringFormat() => $"{CanonicalName}:==:";
    }
}