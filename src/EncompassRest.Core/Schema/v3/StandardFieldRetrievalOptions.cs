using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest.Schema.v3
{
    /// <summary>
    /// The standard field retrieval options.
    /// </summary>
    public sealed class StandardFieldRetrievalOptions : Options
    {
        /// <summary>
        /// List of field IDs for which you want field definitions. Each loan data element has a corresponding Encompass field ID.
        /// </summary>
        public IReadOnlyCollection<string>? Ids { get; }

        /// <summary>
        /// Starting number on the page. Zero-based starting index. The default is zero.
        /// </summary>
        public int? Start { get; }

        /// <summary>
        /// The maximum number of items to return.
        /// </summary>
        public int? Limit { get; }

        /// <summary>
        /// The standard field retrieval options constructor.
        /// </summary>
        /// <param name="ids"></param>
        public StandardFieldRetrievalOptions(IEnumerable<string> ids)
        {
            Preconditions.NotNullOrEmpty(ids, nameof(ids));

            Ids = new ReadOnlyCollection<string>(ids.ToList());
        }

        /// <summary>
        /// The standard field retrieval options constructor.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        public StandardFieldRetrievalOptions(int start, int limit)
        {
            Start = start;
            Limit = limit;
        }

        internal override QueryParameters ToQueryParameters()
        {
            var queryParameters = base.ToQueryParameters();
            if (Ids?.Count > 0)
            {
                queryParameters.Add("ids", string.Join(",", Ids));
            }
            if (Start.HasValue)
            {
                queryParameters.Add("start", Start.ToString());
            }
            if (Start.HasValue)
            {
                queryParameters.Add("limit", Limit.ToString());
            }
            return queryParameters;
        }
    }
}