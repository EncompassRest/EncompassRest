using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PrintLog
/// </summary>
public sealed partial class PrintLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrintLog Action
    /// </summary>
    public string? Action { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// PrintLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// PrintLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog PrintedBy
    /// </summary>
    public string? PrintedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog PrintedByFullName
    /// </summary>
    public string? PrintedByFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog PrintForms
    /// </summary>
    [AllowNull]
    public IList<PrintForm> PrintForms { get => GetList<PrintForm>(); set => SetList(value); }

    /// <summary>
    /// PrintLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrintLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}