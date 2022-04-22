using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// SellConditionLog
/// </summary>
public sealed partial class SellConditionLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// SellConditionLog AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog AllowToClearIndicator
    /// </summary>
    public bool? AllowToClearIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog ClearedBy
    /// </summary>
    public string? ClearedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog ConditionCode
    /// </summary>
    public string? ConditionCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateAddedUtc
    /// </summary>
    public DateTime? DateAddedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateClearedUtc
    /// </summary>
    public DateTime? DateClearedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateExpected
    /// </summary>
    public DateTime? DateExpected { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateFulfilledUtc
    /// </summary>
    public DateTime? DateFulfilledUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateReceived
    /// </summary>
    public DateTime? DateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateRejectedUtc
    /// </summary>
    public DateTime? DateRejectedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateRequestedUtc
    /// </summary>
    public DateTime? DateRequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateRerequestedUtc
    /// </summary>
    public DateTime? DateRerequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateReviewedUtc
    /// </summary>
    public DateTime? DateReviewedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DateWaivedUtc
    /// </summary>
    public DateTime? DateWaivedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Expected
    /// </summary>
    public bool? Expected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog ForRoleId
    /// </summary>
    public int? ForRoleId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog FulfilledBy
    /// </summary>
    public string? FulfilledBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog IsExternalIndicator
    /// </summary>
    public bool? IsExternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog IsInternalIndicator
    /// </summary>
    public bool? IsInternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog IsPastDue
    /// </summary>
    public bool? IsPastDue { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog PairId
    /// </summary>
    public string? PairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog ProviderURN
    /// </summary>
    public string? ProviderURN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Received
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog RejectedBy
    /// </summary>
    public string? RejectedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Requested
    /// </summary>
    public bool? Requested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Rerequested
    /// </summary>
    public bool? Rerequested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog RerequestedBy
    /// </summary>
    public string? RerequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog ReviewedBy
    /// </summary>
    public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SellConditionLog WaivedBy
    /// </summary>
    public string? WaivedBy { get => GetValue<string?>(); set => SetValue(value); }
}