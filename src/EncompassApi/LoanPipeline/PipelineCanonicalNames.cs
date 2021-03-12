using System.Collections.Generic;

namespace EncompassApi.LoanPipeline
{
    /// <summary>
    /// PipelineCanonicalNames
    /// </summary>
    public sealed class PipelineCanonicalNames : ExtensibleObject
    {
        /// <summary>
        /// PipelineCanonicalNames PipelineLoanReportFieldDefs
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public List<PipelineFieldDefinition> PipelineLoanReportFieldDefs { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    }
}