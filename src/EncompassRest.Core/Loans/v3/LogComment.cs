using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LogComment
/// </summary>
public sealed partial class LogComment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LogComment AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LogComment AddedDate
    /// </summary>
    public DateTime? AddedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment ForRole
    /// </summary>
    [AllowNull]
    public EntityReference ForRole { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LogComment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment IsExternal
    /// </summary>
    public bool? IsExternal { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment ReviewedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReviewedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LogComment ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}