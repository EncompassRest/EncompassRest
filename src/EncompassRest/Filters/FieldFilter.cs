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

        internal FieldFilter(FieldFilter fieldFilter)
            : base(fieldFilter)
        {
            CanonicalName = fieldFilter.CanonicalName;
        }

        public new FieldFilter Clone() => CloneFieldFilter();

        protected sealed override Filter CloneFilter() => CloneFieldFilter();

        protected abstract FieldFilter CloneFieldFilter();

        protected abstract string GetMatchType();
    }
}