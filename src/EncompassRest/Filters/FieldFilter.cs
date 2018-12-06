using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Field filter base class.
    /// </summary>
    public abstract class FieldFilter : Filter
    {
        /// <summary>
        /// Canonical field name.
        /// </summary>
        [JsonRequired]
        public string CanonicalName { get; }

        /// <summary>
        /// Filter match type.
        /// </summary>
        [JsonRequired]
        public string MatchType => GetMatchType();
        
        internal FieldFilter(string canonicalName)
        {
            Preconditions.NotNullOrEmpty(canonicalName, nameof(canonicalName));

            CanonicalName = canonicalName;
        }

        internal abstract string GetMatchType();

        internal abstract string GetQueryStringFormat();
    }
}