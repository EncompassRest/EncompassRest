using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DownloadLog
/// </summary>
public sealed partial class DownloadLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyValue<string?>? _barcodePage;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _documentId;
    private DirtyValue<string?>? _downloadId;
    private DirtyValue<string?>? _fileSource;
    private DirtyValue<string?>? _fileType;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _receivedBy;
    private DirtyValue<DateTime?>? _receivedDate;
    private DirtyValue<string?>? _sender;
    private DirtyValue<string?>? _title;

    /// <summary>
    /// DownloadLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// DownloadLogContract BarcodePage
    /// </summary>
    public string? BarcodePage { get => _barcodePage; set => SetField(ref _barcodePage, value); }

    /// <summary>
    /// DownloadLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// DownloadLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// DownloadLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// DownloadLogContract DocumentId
    /// </summary>
    public string? DocumentId { get => _documentId; set => SetField(ref _documentId, value); }

    /// <summary>
    /// DownloadLogContract DownloadId
    /// </summary>
    public string? DownloadId { get => _downloadId; set => SetField(ref _downloadId, value); }

    /// <summary>
    /// DownloadLogContract FileSource
    /// </summary>
    public string? FileSource { get => _fileSource; set => SetField(ref _fileSource, value); }

    /// <summary>
    /// DownloadLogContract FileType
    /// </summary>
    public string? FileType { get => _fileType; set => SetField(ref _fileType, value); }

    /// <summary>
    /// DownloadLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// DownloadLogContract ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

    /// <summary>
    /// DownloadLogContract ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

    /// <summary>
    /// DownloadLogContract Sender
    /// </summary>
    public string? Sender { get => _sender; set => SetField(ref _sender, value); }

    /// <summary>
    /// DownloadLogContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }
}