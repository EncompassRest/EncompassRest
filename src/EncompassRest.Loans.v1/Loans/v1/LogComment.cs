using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LogComment
/// </summary>
public sealed partial class LogComment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LogComment AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment AddedByName
    /// </summary>
    public string? AddedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment ForRoleId
    /// </summary>
    public int? ForRoleId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment IsExternal
    /// </summary>
    public bool? IsExternal { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment IsInternal
    /// </summary>
    public bool? IsInternal { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment ReviewedBy
    /// </summary>
    public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LogComment ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}