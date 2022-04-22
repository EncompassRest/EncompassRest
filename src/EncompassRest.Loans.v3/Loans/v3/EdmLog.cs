using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EdmLog
/// </summary>
public sealed partial class EdmLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EdmLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// EdmLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// EdmLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EdmLog Creator
    /// </summary>
    public string? Creator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EdmLog Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EdmLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EdmLog Documents
    /// </summary>
    [AllowNull]
    public IList<EdmDocument> Documents { get => GetList<EdmDocument>(); set => SetList(value); }

    /// <summary>
    /// EdmLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EdmLog Url
    /// </summary>
    public string? Url { get => GetValue<string?>(); set => SetValue(value); }
}