using System.Collections.Generic;

namespace EncompassRest.LoanPipeline
{
    public sealed class CanonicalNames : ExtensibleObject
    {
        public List<PipelineFieldDefinition> PipelineLoanReportFieldDefs { get; set; }
    }
}