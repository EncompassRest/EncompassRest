using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LogAlert
/// </summary>
public sealed partial class LogAlert : DirtyExtensibleObject, IIdentifiable
{
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
    /// LogAlert LogRecord
    /// </summary>
    public LogRecord? LogRecord { get => GetValue<LogRecord?>(); set => SetValue(value); }

    /// <summary>
    /// LogAlert RoleId
    /// </summary>
    public int? RoleId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LogAlert SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogAlert UserId
    /// </summary>
    public string? UserId { get => GetValue<string?>(); set => SetValue(value); }
}