using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// PipelineRights
    /// </summary>
    public sealed class PipelineRights : PersonaAccess
    {
        /// <summary>
        /// PipelineRights PipelineTasks
        /// </summary>
        [AllowNull]
        public IList<string> PipelineTasks { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// PipelineRights PipelineViews
        /// </summary>
        [AllowNull]
        public IList<EntityReference> PipelineViews { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// PipelineRights NonAccessibleColumns
        /// </summary>
        [AllowNull]
        public IList<NonAccessibleColumn> NonAccessibleColumns { get => GetList<NonAccessibleColumn>(); set => SetList(value); }
    }
}