using System.Collections.Generic;
using System.Collections.ObjectModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Filter base class.
    /// </summary>
    public class Filter : SerializableObject
    {
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        private readonly FilterOperator? _operator;

        [JsonProperty("terms", NullValueHandling = NullValueHandling.Ignore)]
        private readonly ReadOnlyCollection<Filter>? _terms;

        internal Filter()
        {
        }

        private Filter(FilterOperator @operator, ReadOnlyCollection<Filter> terms)
        {
            _operator = @operator;
            _terms = terms;
        }

        /// <summary>
        /// Returns a new filter which is the combination of this filter with the specified <paramref name="filter"/> using And semantics.
        /// </summary>
        /// <param name="filter">The other filter to combine with.</param>
        /// <returns></returns>
        public Filter And(Filter filter) => Combine(FilterOperator.And, filter);

        /// <summary>
        /// Returns a new filter which is the combination of this filter with the specified <paramref name="filter"/> using Or semantics.
        /// </summary>
        /// <param name="filter">The other filter to combine with.</param>
        /// <returns></returns>
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