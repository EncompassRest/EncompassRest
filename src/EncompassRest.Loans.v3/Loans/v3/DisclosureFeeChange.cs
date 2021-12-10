using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureFeeChange
/// </summary>
public sealed partial class DisclosureFeeChange : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _amount;
    private DirtyValue<string?>? _changedCircumstance;
    private DirtyValue<DateTime?>? _changesReceivedDate;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _feeDescription;
    private DirtyValue<string?>? _fieldId;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _reason;

    /// <summary>
    /// DisclosureFeeChangeContract Amount
    /// </summary>
    public string? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// DisclosureFeeChangeContract ChangedCircumstance
    /// </summary>
    public string? ChangedCircumstance { get => _changedCircumstance; set => SetField(ref _changedCircumstance, value); }

    /// <summary>
    /// DisclosureFeeChangeContract ChangesReceivedDate
    /// </summary>
    public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => SetField(ref _changesReceivedDate, value); }

    /// <summary>
    /// DisclosureFeeChangeContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// DisclosureFeeChangeContract FeeDescription
    /// </summary>
    public string? FeeDescription { get => _feeDescription; set => SetField(ref _feeDescription, value); }

    /// <summary>
    /// DisclosureFeeChangeContract FieldId
    /// </summary>
    public string? FieldId { get => _fieldId; set => SetField(ref _fieldId, value); }

    /// <summary>
    /// DisclosureFeeChangeContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// DisclosureFeeChangeContract Reason
    /// </summary>
    public string? Reason { get => _reason; set => SetField(ref _reason, value); }
}