using System.Collections.Generic;

namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// PipelineCanonicalNames
    /// </summary>
    public sealed class PipelineCanonicalNames : ExtensibleObject
    {
        /// <summary>
        /// PipelineCanonicalNames PipelineLoanReportFieldDefs
        /// </summary>
        public List<PipelineFieldDefinition> PipelineLoanReportFieldDefs { get; set; }
    }
}