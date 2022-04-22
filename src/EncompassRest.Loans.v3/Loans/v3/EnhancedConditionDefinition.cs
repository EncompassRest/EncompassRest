using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EnhancedConditionDefinition
/// </summary>
public sealed partial class EnhancedConditionDefinition : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EnhancedConditionDefinition CategoryDefinitions
    /// </summary>
    [AllowNull]
    public IList<OptionDefinition> CategoryDefinitions { get => GetList<OptionDefinition>(); set => SetList(value); }

    /// <summary>
    /// EnhancedConditionDefinition PriorToDefinitions
    /// </summary>
    [AllowNull]
    public IList<OptionDefinition> PriorToDefinitions { get => GetList<OptionDefinition>(); set => SetList(value); }

    /// <summary>
    /// EnhancedConditionDefinition RecipientDefinitions
    /// </summary>
    [AllowNull]
    public IList<OptionDefinition> RecipientDefinitions { get => GetList<OptionDefinition>(); set => SetList(value); }

    /// <summary>
    /// EnhancedConditionDefinition SourceDefinitions
    /// </summary>
    [AllowNull]
    public IList<OptionDefinition> SourceDefinitions { get => GetList<OptionDefinition>(); set => SetList(value); }

    /// <summary>
    /// EnhancedConditionDefinition TrackingDefinitions
    /// </summary>
    [AllowNull]
    public IList<TrackingDefinition> TrackingDefinitions { get => GetList<TrackingDefinition>(); set => SetList(value); }
}