using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockConfirm
/// </summary>
public sealed partial class LockConfirm : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _alertIndicator;
    private DirtyValue<DateTime?>? _buySideExpirationDate;
    private DirtyValue<string?>? _comments;
    private DirtyValue<bool?>? _commitmentTermEnabled;
    private DirtyValue<string?>? _confirmedBy;
    private DirtyValue<string?>? _confirmedById;
    private DirtyValue<bool?>? _confirmedByIdIndicator;
    private DirtyValue<bool?>? _hideLog;
    private DirtyValue<string?>? _requestGuid;
    private DirtyValue<string?>? _sellSideDeliveredBy;
    private DirtyValue<DateTime?>? _sellSideDeliveryDate;
    private DirtyValue<DateTime?>? _sellSideExpirationDate;
    private DirtyValue<string?>? _timeConfirmed;
    private DirtyValue<bool?>? _voided;

    /// <summary>
    /// LockConfirmContract AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }

    /// <summary>
    /// LockConfirmContract BuySideExpirationDate
    /// </summary>
    public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }

    /// <summary>
    /// LockConfirmContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// LockConfirmContract CommitmentTermEnabled
    /// </summary>
    public bool? CommitmentTermEnabled { get => _commitmentTermEnabled; set => SetField(ref _commitmentTermEnabled, value); }

    /// <summary>
    /// LockConfirmContract ConfirmedBy
    /// </summary>
    public string? ConfirmedBy { get => _confirmedBy; set => SetField(ref _confirmedBy, value); }

    /// <summary>
    /// LockConfirmContract ConfirmedById
    /// </summary>
    public string? ConfirmedById { get => _confirmedById; set => SetField(ref _confirmedById, value); }

    /// <summary>
    /// LockConfirmContract ConfirmedByIdIndicator
    /// </summary>
    public bool? ConfirmedByIdIndicator { get => _confirmedByIdIndicator; set => SetField(ref _confirmedByIdIndicator, value); }

    /// <summary>
    /// LockConfirmContract HideLog
    /// </summary>
    public bool? HideLog { get => _hideLog; set => SetField(ref _hideLog, value); }

    /// <summary>
    /// LockConfirmContract RequestGuid
    /// </summary>
    public string? RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }

    /// <summary>
    /// LockConfirmContract SellSideDeliveredBy
    /// </summary>
    public string? SellSideDeliveredBy { get => _sellSideDeliveredBy; set => SetField(ref _sellSideDeliveredBy, value); }

    /// <summary>
    /// LockConfirmContract SellSideDeliveryDate
    /// </summary>
    public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => SetField(ref _sellSideDeliveryDate, value); }

    /// <summary>
    /// LockConfirmContract SellSideExpirationDate
    /// </summary>
    public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => SetField(ref _sellSideExpirationDate, value); }

    /// <summary>
    /// LockConfirmContract TimeConfirmed
    /// </summary>
    public string? TimeConfirmed { get => _timeConfirmed; set => SetField(ref _timeConfirmed, value); }

    /// <summary>
    /// LockConfirmContract Voided
    /// </summary>
    public bool? Voided { get => _voided; set => SetField(ref _voided, value); }
}