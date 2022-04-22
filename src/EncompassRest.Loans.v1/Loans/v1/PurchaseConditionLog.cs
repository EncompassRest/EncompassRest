using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PurchaseConditionLog
/// </summary>
public sealed partial class PurchaseConditionLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PurchaseConditionLog AllowToClearIndicator
    /// </summary>
    public bool? AllowToClearIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog ClearedBy
    /// </summary>
    public string? ClearedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog DateClearedUtc
    /// </summary>
    public DateTime? DateClearedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog DateFulfilledUtc
    /// </summary>
    public DateTime? DateFulfilledUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog DateRejectedUtc
    /// </summary>
    public DateTime? DateRejectedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog DateReviewedUtc
    /// </summary>
    public DateTime? DateReviewedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog DateWaivedUtc
    /// </summary>
    public DateTime? DateWaivedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog ForRoleId
    /// </summary>
    public int? ForRoleId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog FulfilledBy
    /// </summary>
    public string? FulfilledBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog IsExternalIndicator
    /// </summary>
    public bool? IsExternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog IsInternalIndicator
    /// </summary>
    public bool? IsInternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog RejectedBy
    /// </summary>
    public string? RejectedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog ReviewedBy
    /// </summary>
    public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PurchaseConditionLog WaivedBy
    /// </summary>
    public string? WaivedBy { get => GetValue<string?>(); set => SetValue(value); }
}