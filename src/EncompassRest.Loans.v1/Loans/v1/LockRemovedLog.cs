using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LockRemovedLog
/// </summary>
public sealed partial class LockRemovedLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _alertIndicator;
    private DirtyValue<DateTime?>? _dateUtc;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _removedBy;
    private DirtyValue<string?>? _removedByID;
    private DirtyValue<string?>? _requestGuid;
    private DirtyValue<string?>? _timeRemoved;
    private DirtyValue<DateTime?>? _updatedDateUtc;

    /// <summary>
    /// LockRemovedLog AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }

    /// <summary>
    /// LockRemovedLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

    /// <summary>
    /// LockRemovedLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LockRemovedLog RemovedBy
    /// </summary>
    public string? RemovedBy { get => _removedBy; set => SetField(ref _removedBy, value); }

    /// <summary>
    /// LockRemovedLog RemovedByID
    /// </summary>
    public string? RemovedByID { get => _removedByID; set => SetField(ref _removedByID, value); }

    /// <summary>
    /// LockRemovedLog RequestGuid
    /// </summary>
    public string? RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }

    /// <summary>
    /// LockRemovedLog TimeRemoved
    /// </summary>
    public string? TimeRemoved { get => _timeRemoved; set => SetField(ref _timeRemoved, value); }

    /// <summary>
    /// LockRemovedLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
}