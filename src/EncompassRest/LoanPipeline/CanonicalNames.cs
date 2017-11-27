using System.Collections.Generic;

namespace EncompassRest.LoanPipeline
{
    public sealed class CanonicalNames
    {
        public List<PipelineFieldDefinition> PipelineLoanReportFieldDefs { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}