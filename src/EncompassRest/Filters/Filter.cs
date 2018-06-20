using System.Collections.Generic;
using System.Collections.ObjectModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    public class Filter
    {
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        private readonly FilterOperator? _operator;

        [JsonProperty("terms", NullValueHandling = NullValueHandling.Ignore)]
        private readonly ReadOnlyCollection<Filter> _terms;

        internal Filter()
        {
        }

        private Filter(FilterOperator @operator, ReadOnlyCollection<Filter> terms)
        {
            _operator = @operator;
            _terms = terms;
        }

        public Filter And(Filter filter) => Combine(FilterOperator.And, filter);

        public Filter Or(Filter filter) => Combine(FilterOperator.Or, filter);

        private Filter Combine(FilterOperator @operator, Filter filter)
        {
            Preconditions.NotNull(filter, nameof(filter));

            var terms = new List<Filter>();
            if (_operator == @operator)
            {
                terms.AddRange(_terms);
            }
            else
            {
                terms.Add(this);
            }
            if (filter._operator == @operator)
            {
                terms.AddRange(filter._terms);
            }
            else
            {
                terms.Add(filter);
            }
            return new Filter(@operator, new ReadOnlyCollection<Filter>(terms));
        }

        private enum FilterOperator
        {
            And,
            Or
        }
    }
}