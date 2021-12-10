using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDisclosureFields
/// </summary>
public sealed partial class ClosingDisclosureFields : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _changesReceivedDate;
    private DirtyValue<bool?>? _is24HourAdvancePreview;
    private DirtyValue<bool?>? _isChangedCircumstanceEligibility;
    private DirtyValue<bool?>? _isChangeInAPR;
    private DirtyValue<bool?>? _isChangeInLoanProduct;
    private DirtyValue<bool?>? _isChangeInSettlementCharges;
    private DirtyValue<bool?>? _isClericalErrorCorrection;
    private DirtyValue<bool?>? _isInterestRateDependentCharges;
    private DirtyValue<bool?>? _isOther;
    private DirtyValue<bool?>? _isPrepaymentPenaltyAdded;
    private DirtyValue<bool?>? _isRevisionsRequestedByConsumer;
    private DirtyValue<bool?>? _isToleranceCure;
    private DirtyValue<string?>? _otherDescription;
    private DirtyValue<DateTime?>? _revisedDueDate;

    /// <summary>
    /// ClosingDisclosureFieldsContract ChangesReceivedDate
    /// </summary>
    public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => SetField(ref _changesReceivedDate, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract Is24HourAdvancePreview
    /// </summary>
    public bool? Is24HourAdvancePreview { get => _is24HourAdvancePreview; set => SetField(ref _is24HourAdvancePreview, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsChangedCircumstanceEligibility
    /// </summary>
    public bool? IsChangedCircumstanceEligibility { get => _isChangedCircumstanceEligibility; set => SetField(ref _isChangedCircumstanceEligibility, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsChangeInAPR
    /// </summary>
    public bool? IsChangeInAPR { get => _isChangeInAPR; set => SetField(ref _isChangeInAPR, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsChangeInLoanProduct
    /// </summary>
    public bool? IsChangeInLoanProduct { get => _isChangeInLoanProduct; set => SetField(ref _isChangeInLoanProduct, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsChangeInSettlementCharges
    /// </summary>
    public bool? IsChangeInSettlementCharges { get => _isChangeInSettlementCharges; set => SetField(ref _isChangeInSettlementCharges, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsClericalErrorCorrection
    /// </summary>
    public bool? IsClericalErrorCorrection { get => _isClericalErrorCorrection; set => SetField(ref _isClericalErrorCorrection, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsInterestRateDependentCharges
    /// </summary>
    public bool? IsInterestRateDependentCharges { get => _isInterestRateDependentCharges; set => SetField(ref _isInterestRateDependentCharges, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsOther
    /// </summary>
    public bool? IsOther { get => _isOther; set => SetField(ref _isOther, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsPrepaymentPenaltyAdded
    /// </summary>
    public bool? IsPrepaymentPenaltyAdded { get => _isPrepaymentPenaltyAdded; set => SetField(ref _isPrepaymentPenaltyAdded, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsRevisionsRequestedByConsumer
    /// </summary>
    public bool? IsRevisionsRequestedByConsumer { get => _isRevisionsRequestedByConsumer; set => SetField(ref _isRevisionsRequestedByConsumer, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract IsToleranceCure
    /// </summary>
    public bool? IsToleranceCure { get => _isToleranceCure; set => SetField(ref _isToleranceCure, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract OtherDescription
    /// </summary>
    public string? OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

    /// <summary>
    /// ClosingDisclosureFieldsContract RevisedDueDate
    /// </summary>
    public DateTime? RevisedDueDate { get => _revisedDueDate; set => SetField(ref _revisedDueDate, value); }
}