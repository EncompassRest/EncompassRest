using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DownloadLog
/// </summary>
public sealed partial class DownloadLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DownloadLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// DownloadLog BarcodePage
    /// </summary>
    public string? BarcodePage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// DownloadLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog DateReceived
    /// </summary>
    public string? DateReceived { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog DocumentId
    /// </summary>
    public string? DocumentId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog DownloadId
    /// </summary>
    public string? DownloadId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog FileSource
    /// </summary>
    public string? FileSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog FileType
    /// </summary>
    public string? FileType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog Sender
    /// </summary>
    public string? Sender { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DownloadLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}