using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LogAlert
/// </summary>
public sealed partial class LogAlert : DirtyExtensibleObject, IIdentifiable
{
    private EntityReference? _createdBy;
    private DirtyValue<DateTime?>? _dueDate;
    private DirtyValue<DateTime?>? _followedUpDate;
    private DirtyValue<string?>? _id;
    private EntityReference? _role;

    /// <summary>
    /// LogAlertContract CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetField(ref _createdBy); set => SetField(ref _createdBy, value); }

    /// <summary>
    /// LogAlertContract DueDate
    /// </summary>
    public DateTime? DueDate { get => _dueDate; set => SetField(ref _dueDate, value); }

    /// <summary>
    /// LogAlertContract FollowedUpDate
    /// </summary>
    public DateTime? FollowedUpDate { get => _followedUpDate; set => SetField(ref _followedUpDate, value); }

    /// <summary>
    /// LogAlertContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LogAlertContract Role
    /// </summary>
    [AllowNull]
    public EntityReference Role { get => GetField(ref _role); set => SetField(ref _role, value); }
}