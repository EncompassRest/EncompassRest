using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public class Filter
    {
        private Filter _parent;

        [JsonProperty("operator")]
        private readonly FilterOperator? _operator;

        [JsonProperty("terms")]
        private readonly List<Filter> _terms;

        internal Filter()
        {
        }

        internal Filter(Filter filter)
        {
            Preconditions.NotNull(filter, nameof(filter));

            _operator = filter._operator;
            _terms = filter._terms?.Select(term => term.Clone()).ToList();
        }

        private Filter(FilterOperator @operator, Filter first, Filter second)
        {
            first._parent = this;
            second._parent = this;

            _operator = @operator;
            _terms = new List<Filter> { first, second };
        }

        public Filter And(Filter filter) => Combine(FilterOperator.And, this, filter);

        public Filter Or(Filter filter) => Combine(FilterOperator.Or, this, filter);

        public Filter Clone() => CloneFilter();

        protected virtual Filter CloneFilter() => new Filter(this);

        private static Filter Combine(FilterOperator @operator, Filter first, Filter second)
        {
            Preconditions.NotNull(second, nameof(second));

            var firstFilter = GetParentlessFilter(first);
            var secondFilter = GetParentlessFilter(second);

            if (firstFilter._operator == @operator)
            {
                firstFilter._terms.Add(secondFilter);
                return firstFilter;
            }
            return new Filter(@operator, firstFilter, secondFilter);
        }

        private static Filter GetParentlessFilter(Filter filter) => filter._parent != null ? filter.Clone() : filter;

        private enum FilterOperator
        {
            And,
            Or
        }
    }
}