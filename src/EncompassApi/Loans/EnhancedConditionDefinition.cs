using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans
{
    /// <summary>
    /// EnhancedConditionDefinition
    /// </summary>
    public sealed partial class EnhancedConditionDefinition : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<OptionDefinition>? _categoryDefinitions;
        private DirtyList<OptionDefinition>? _priorToDefinitions;
        private DirtyList<OptionDefinition>? _recipientDefinitions;
        private DirtyList<OptionDefinition>? _sourceDefinitions;
        private DirtyList<TrackingDefinition>? _trackingDefinitions;

        /// <summary>
        /// EnhancedConditionDefinition CategoryDefinitions
        /// </summary>
        [AllowNull]
        public IList<OptionDefinition> CategoryDefinitions { get => GetField(ref _categoryDefinitions); set => SetField(ref _categoryDefinitions, value); }

        /// <summary>
        /// EnhancedConditionDefinition PriorToDefinitions
        /// </summary>
        [AllowNull]
        public IList<OptionDefinition> PriorToDefinitions { get => GetField(ref _priorToDefinitions); set => SetField(ref _priorToDefinitions, value); }

        /// <summary>
        /// EnhancedConditionDefinition RecipientDefinitions
        /// </summary>
        [AllowNull]
        public IList<OptionDefinition> RecipientDefinitions { get => GetField(ref _recipientDefinitions); set => SetField(ref _recipientDefinitions, value); }

        /// <summary>
        /// EnhancedConditionDefinition SourceDefinitions
        /// </summary>
        [AllowNull]
        public IList<OptionDefinition> SourceDefinitions { get => GetField(ref _sourceDefinitions); set => SetField(ref _sourceDefinitions, value); }

        /// <summary>
        /// EnhancedConditionDefinition TrackingDefinitions
        /// </summary>
        [AllowNull]
        public IList<TrackingDefinition> TrackingDefinitions { get => GetField(ref _trackingDefinitions); set => SetField(ref _trackingDefinitions, value); }
    }
}