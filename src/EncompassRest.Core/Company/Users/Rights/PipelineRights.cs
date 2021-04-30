using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// PipelineRights
    /// </summary>
    public sealed class PipelineRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _accessToPipelineLoanTab;
        private DirtyDictionary<string, bool>? _notAccessibleColumns;
        private PipelineTasksRights? _pipelineTasks;

        /// <summary>
        /// PipelineRights AccessToPipelineLoanTab
        /// </summary>
        [JsonProperty("accessToPipeline/LoanTab")]
        public bool? AccessToPipelineLoanTab { get => _accessToPipelineLoanTab; set => SetField(ref _accessToPipelineLoanTab, value); }

        /// <summary>
        /// PipelineRights NotAccessibleColumns
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> NotAccessibleColumns { get => GetField(ref _notAccessibleColumns); set => SetField(ref _notAccessibleColumns, value); }

        /// <summary>
        /// PipelineRights PipelineTasks
        /// </summary>
        [AllowNull]
        public PipelineTasksRights PipelineTasks { get => GetField(ref _pipelineTasks); set => SetField(ref _pipelineTasks, value); }
    }
}