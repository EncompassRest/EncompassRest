using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ConversationLog
/// </summary>
public sealed partial class ConversationLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _company;
    private EntityReference? _createdBy;
    private DirtyValue<DateTime?>? _createdDate;
    private DirtyValue<string?>? _email;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _inLogIndicator;
    private DirtyValue<bool?>? _isEmailIndicator;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _phone;

    /// <summary>
    /// ConversationLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// ConversationLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// ConversationLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// ConversationLogContract Company
    /// </summary>
    public string? Company { get => _company; set => SetField(ref _company, value); }

    /// <summary>
    /// ConversationLogContract CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetField(ref _createdBy); set => SetField(ref _createdBy, value); }

    /// <summary>
    /// ConversationLogContract CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

    /// <summary>
    /// ConversationLogContract Email
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// ConversationLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// ConversationLogContract InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => _inLogIndicator; set => SetField(ref _inLogIndicator, value); }

    /// <summary>
    /// ConversationLogContract IsEmailIndicator
    /// </summary>
    public bool? IsEmailIndicator { get => _isEmailIndicator; set => SetField(ref _isEmailIndicator, value); }

    /// <summary>
    /// ConversationLogContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// ConversationLogContract Phone
    /// </summary>
    public string? Phone { get => _phone; set => SetField(ref _phone, value); }
}