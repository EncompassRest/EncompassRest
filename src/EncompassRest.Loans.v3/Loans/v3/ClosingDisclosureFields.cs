using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDisclosureFields
/// </summary>
public sealed partial class ClosingDisclosureFields : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ClosingDisclosureFields ChangesReceivedDate
    /// </summary>
    public DateTime? ChangesReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields Is24HourAdvancePreview
    /// </summary>
    public bool? Is24HourAdvancePreview { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsChangedCircumstanceEligibility
    /// </summary>
    public bool? IsChangedCircumstanceEligibility { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsChangeInAPR
    /// </summary>
    public bool? IsChangeInAPR { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsChangeInLoanProduct
    /// </summary>
    public bool? IsChangeInLoanProduct { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsChangeInSettlementCharges
    /// </summary>
    public bool? IsChangeInSettlementCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsClericalErrorCorrection
    /// </summary>
    public bool? IsClericalErrorCorrection { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsInterestRateDependentCharges
    /// </summary>
    public bool? IsInterestRateDependentCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsOther
    /// </summary>
    public bool? IsOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsPrepaymentPenaltyAdded
    /// </summary>
    public bool? IsPrepaymentPenaltyAdded { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsRevisionsRequestedByConsumer
    /// </summary>
    public bool? IsRevisionsRequestedByConsumer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields IsToleranceCure
    /// </summary>
    public bool? IsToleranceCure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields OtherDescription
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosureFields RevisedDueDate
    /// </summary>
    public DateTime? RevisedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}