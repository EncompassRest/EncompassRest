using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Not empty field filter. Does not currently work with string fields with cursors.
    /// </summary>
    public sealed class NotEmptyFieldFilter : FieldFilter
    {
        [JsonProperty]
        private object Value => System.DateTime.MinValue;

        /// <summary>
        /// Not empty field filter constructor.
        /// </summary>
        /// <param name="canonicalLoanField">Canonical loan field.</param>
        public NotEmptyFieldFilter(CanonicalLoanField canonicalLoanField)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName())
        {
        }

        /// <summary>
        /// Not empty field filter constructor.
        /// </summary>
        /// <param name="canonicalContactField">Canonical contact field.</param>
        public NotEmptyFieldFilter(CanonicalContactField canonicalContactField)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName())
        {
        }

        /// <summary>
        /// Not empty field filter constructor.
        /// </summary>
        /// <param name="canonicalName">Canonical field name.</param>
        public NotEmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        internal override string GetMatchType() => "isNotEmpty";

        internal override string GetQueryStringFormat() => $"{CanonicalName}:!=:";
    }
}