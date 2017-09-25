using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Filters;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    public sealed class PipelineParameters
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> LoanGuids { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Fields { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<FieldSort> SortOrder { get; }

        public PipelineParameters(Filter filter, IEnumerable<string> fields = null, IEnumerable<FieldSort> sortOrder = null)
        {
            Preconditions.NotNull(filter, nameof(filter));

            Filter = filter;
            Fields = fields != null ? new ReadOnlyCollection<string>(fields.ToList()) : null;
            SortOrder = sortOrder != null ? new ReadOnlyCollection<FieldSort>(sortOrder.ToList()) : null;
        }

        public PipelineParameters(IEnumerable<string> loanGuids, IEnumerable<string> fields = null, IEnumerable<FieldSort> sortOrder = null)
        {
            Preconditions.NotNullOrEmpty(loanGuids, nameof(loanGuids));

            LoanGuids = new ReadOnlyCollection<string>(loanGuids.ToList());
            Fields = fields != null ? new ReadOnlyCollection<string>(fields.ToList()) : null;
            SortOrder = sortOrder != null ? new ReadOnlyCollection<FieldSort>(sortOrder.ToList()) : null;
        }
    }
}