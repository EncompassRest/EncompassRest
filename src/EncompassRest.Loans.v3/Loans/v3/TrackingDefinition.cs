using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrackingDefinition
/// </summary>
public sealed partial class TrackingDefinition : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _name;
    private DirtyValue<bool?>? _open;
    private DirtyList<EntityReference>? _roles;

    /// <summary>
    /// TrackingDefinitionContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// TrackingDefinitionContract Open
    /// </summary>
    public bool? Open { get => _open; set => SetField(ref _open, value); }

    /// <summary>
    /// TrackingDefinitionContract Roles
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Roles { get => GetField(ref _roles); set => SetField(ref _roles, value); }
}