using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Filters;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    public sealed class ViewPipelineParameters
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> LoanGuids { get; }

        [JsonRequired]
        public IEnumerable<string> Fields { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<FieldSort> SortOrder { get; }

        public ViewPipelineParameters(Filter filter, IEnumerable<string> fields, IEnumerable<FieldSort> sortOrder = null)
        {
            Preconditions.NotNull(filter, nameof(filter));
            Preconditions.NotNullOrEmpty(fields, nameof(fields));

            Filter = filter;
            Fields = new ReadOnlyCollection<string>(fields.ToList());
            SortOrder = sortOrder != null ? new ReadOnlyCollection<FieldSort>(sortOrder.ToList()) : null;
        }

        public ViewPipelineParameters(IEnumerable<string> loanGuids, IEnumerable<string> fields, IEnumerable<FieldSort> sortOrder = null)
        {
            Preconditions.NotNullOrEmpty(loanGuids, nameof(loanGuids));
            Preconditions.NotNullOrEmpty(fields, nameof(fields));

            LoanGuids = new ReadOnlyCollection<string>(loanGuids.ToList());
            Fields = new ReadOnlyCollection<string>(fields.ToList());
            SortOrder = sortOrder != null ? new ReadOnlyCollection<FieldSort>(sortOrder.ToList()) : null;
        }
    }
}