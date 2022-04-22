using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PipelineRights
    /// </summary>
    public sealed class PipelineRights : DirtyExtensibleObject
    {
        /// <summary>
        /// PipelineRights AccessToPipelineLoanTab
        /// </summary>
        [JsonProperty("accessToPipeline/LoanTab")]
        public bool? AccessToPipelineLoanTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineRights NotAccessibleColumns
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> NotAccessibleColumns { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// PipelineRights PipelineTasks
        /// </summary>
        [AllowNull]
        public PipelineTasksRights PipelineTasks { get => GetEntity<PipelineTasksRights>(); set => SetEntity(value); }
    }
}