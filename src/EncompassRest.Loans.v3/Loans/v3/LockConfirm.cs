using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockConfirm
/// </summary>
public sealed partial class LockConfirm : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockConfirm AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm BuySideExpirationDate
    /// </summary>
    public DateTime? BuySideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm CommitmentTermEnabled
    /// </summary>
    public bool? CommitmentTermEnabled { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm ConfirmedBy
    /// </summary>
    public string? ConfirmedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm ConfirmedById
    /// </summary>
    public string? ConfirmedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm ConfirmedByIdIndicator
    /// </summary>
    public bool? ConfirmedByIdIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm HideLog
    /// </summary>
    public bool? HideLog { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm IncludeConfirmCount
    /// </summary>
    public bool? IncludeConfirmCount { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm RequestGuid
    /// </summary>
    public string? RequestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm SellSideDeliveredBy
    /// </summary>
    public string? SellSideDeliveredBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm SellSideDeliveryDate
    /// </summary>
    public DateTime? SellSideDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm SellSideExpirationDate
    /// </summary>
    public DateTime? SellSideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm TimeConfirmed
    /// </summary>
    public string? TimeConfirmed { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirm Voided
    /// </summary>
    public bool? Voided { get => GetValue<bool?>(); set => SetValue(value); }
}