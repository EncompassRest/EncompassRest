using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LogComment
/// </summary>
public sealed partial class LogComment : DirtyExtensibleObject, IIdentifiable
{
    private EntityReference? _addedBy;
    private DirtyValue<DateTime?>? _addedDate;
    private DirtyValue<string?>? _comments;
    private EntityReference? _forRole;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isExternal;
    private EntityReference? _reviewedBy;
    private DirtyValue<DateTime?>? _reviewedDate;

    /// <summary>
    /// LogCommentContract AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetField(ref _addedBy); set => SetField(ref _addedBy, value); }

    /// <summary>
    /// LogCommentContract AddedDate
    /// </summary>
    public DateTime? AddedDate { get => _addedDate; set => SetField(ref _addedDate, value); }

    /// <summary>
    /// LogCommentContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// LogCommentContract ForRole
    /// </summary>
    [AllowNull]
    public EntityReference ForRole { get => GetField(ref _forRole); set => SetField(ref _forRole, value); }

    /// <summary>
    /// LogCommentContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LogCommentContract IsExternal
    /// </summary>
    public bool? IsExternal { get => _isExternal; set => SetField(ref _isExternal, value); }

    /// <summary>
    /// LogCommentContract ReviewedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReviewedBy { get => GetField(ref _reviewedBy); set => SetField(ref _reviewedBy, value); }

    /// <summary>
    /// LogCommentContract ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }
}