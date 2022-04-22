using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LockRemovedLog
/// </summary>
public sealed partial class LockRemovedLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockRemovedLog AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRemovedLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRemovedLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRemovedLog RemovedBy
    /// </summary>
    public string? RemovedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRemovedLog RemovedByID
    /// </summary>
    public string? RemovedByID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRemovedLog RequestGuid
    /// </summary>
    public string? RequestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRemovedLog TimeRemoved
    /// </summary>
    public string? TimeRemoved { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRemovedLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}