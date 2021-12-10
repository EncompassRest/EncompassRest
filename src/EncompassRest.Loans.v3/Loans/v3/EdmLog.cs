using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EdmLog
/// </summary>
public sealed partial class EdmLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _creator;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _description;
    private DirtyList<EdmDocument>? _documents;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _url;

    /// <summary>
    /// EdmLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// EdmLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// EdmLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// EdmLogContract Creator
    /// </summary>
    public string? Creator { get => _creator; set => SetField(ref _creator, value); }

    /// <summary>
    /// EdmLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// EdmLogContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// EdmLogContract Documents
    /// </summary>
    [AllowNull]
    public IList<EdmDocument> Documents { get => GetField(ref _documents); set => SetField(ref _documents, value); }

    /// <summary>
    /// EdmLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EdmLogContract Url
    /// </summary>
    public string? Url { get => _url; set => SetField(ref _url, value); }
}