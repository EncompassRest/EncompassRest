using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// MIServiceRadianLog
/// </summary>
public sealed partial class MIServiceRadianLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MIServiceRadianLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// MIServiceRadianLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// MIServiceRadianLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog Result
    /// </summary>
    public string? Result { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog ShowAlert
    /// </summary>
    public bool? ShowAlert { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MIServiceRadianLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}