using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrackingDefinition
/// </summary>
public sealed partial class TrackingDefinition : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TrackingDefinition Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingDefinition Open
    /// </summary>
    public bool? Open { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingDefinition Roles
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Roles { get => GetList<EntityReference>(); set => SetList(value); }
}