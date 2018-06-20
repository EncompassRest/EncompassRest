using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public abstract class FieldFilter : Filter
    {
        [JsonRequired]
        public string CanonicalName { get; }

        [JsonRequired]
        public string MatchType => GetMatchType();
        
        internal FieldFilter(string canonicalName)
        {
            Preconditions.NotNullOrEmpty(canonicalName, nameof(canonicalName));

            CanonicalName = canonicalName;
        }

        protected abstract string GetMatchType();
    }
}