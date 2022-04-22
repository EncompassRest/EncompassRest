using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LogAlert
/// </summary>
public sealed partial class LogAlert : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LogAlert CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LogAlert DueDate
    /// </summary>
    public DateTime? DueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LogAlert FollowedUpDate
    /// </summary>
    public DateTime? FollowedUpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LogAlert Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogAlert Role
    /// </summary>
    [AllowNull]
    public EntityReference Role { get => GetEntity<EntityReference>(); set => SetEntity(value); }
}