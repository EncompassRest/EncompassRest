using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Filters;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Conditions
{
    public sealed class ConditionQueryParameters
    {
        private ReadOnlyCollection<FieldSort> _sort;
        private ReadOnlyCollection<FieldFilter> _filter;
        private int? _start;
        private int? _limit;

        public IEnumerable<FieldSort> Sort
        {
            get => _sort;
            set
            {
                if (value != null)
                {
                    var list = value.ToList();
                    Preconditions.NotAnyNull(list, nameof(Sort));

                    _sort = new ReadOnlyCollection<FieldSort>(list);
                }
                else
                {
                    _sort = null;
                }
            }
        }

        public IEnumerable<FieldFilter> Filter
        {
            get => _filter;
            set
            {
                if (value != null)
                {
                    var list = value.ToList();
                    Preconditions.NotAnyNull(list, nameof(Filter));

                    _filter = new ReadOnlyCollection<FieldFilter>(list);
                }
                else
                {
                    _filter = null;
                }
            }
        }

        public int? Start
        {
            get => _start;
            set
            {
                if (value.HasValue)
                {
                    Preconditions.GreaterThanOrEquals(value.GetValueOrDefault(), nameof(Start), 0);
                }
                _start = value;
            }
        }

        public int? Limit
        {
            get => _limit;
            set
            {
                if (value.HasValue)
                {
                    Preconditions.GreaterThan(value.GetValueOrDefault(), nameof(Limit), 0);
                }
                _limit = value;
            }
        }

        public bool? IncludeRemoved { get; set; }

        public override string ToString()
        {
            var queryParameters = new QueryParameters();
            if (Sort != null)
            {
                queryParameters.Add("sort", string.Join(",", Sort.Select(fieldSort => $"{(fieldSort.Order == SortOrder.Ascending ? "+" : "-")}{fieldSort.CanonicalName}")));
            }
            if (Filter != null)
            {
                queryParameters.Add("filter", string.Join(",", Filter.Select(f => f.GetQueryStringFormat())));
            }
            if (Start.HasValue)
            {
                queryParameters.Add("start", Start.ToString());
            }
            if (Limit.HasValue)
            {
                queryParameters.Add("limit", Limit.ToString());
            }
            if (IncludeRemoved.HasValue)
            {
                queryParameters.Add("includeRemoved", IncludeRemoved.ToString().ToLower());
            }
            return queryParameters.ToString();
        }
    }
}