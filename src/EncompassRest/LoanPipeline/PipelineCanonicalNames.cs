using System.Collections.Generic;

namespace EncompassRest.LoanPipeline
{
    public sealed class PipelineCanonicalNames : ExtensibleObject
    {
        public List<PipelineFieldDefinition> PipelineLoanReportFieldDefs { get; set; }
    }
}