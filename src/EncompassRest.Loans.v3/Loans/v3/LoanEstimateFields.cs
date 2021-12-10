using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanEstimateFields
/// </summary>
public sealed partial class LoanEstimateFields : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _changesReceivedDate;
    private DirtyValue<bool?>? _isChangedCircumstanceEligibility;
    private DirtyValue<bool?>? _isChangedCircumstanceSettlementCharges;
    private DirtyValue<bool?>? _isDelayedSettlementOnConstructionLoans;
    private DirtyValue<bool?>? _isDisclosedByBroker;
    private DirtyValue<bool?>? _isExpiration;
    private DirtyValue<bool?>? _isInterestRateDependentCharges;
    private DirtyValue<bool?>? _isOther;
    private DirtyValue<bool?>? _isRevisionsRequestedByConsumer;
    private DirtyValue<string?>? _otherDescription;
    private DirtyValue<DateTime?>? _revisedDueDate;

    /// <summary>
    /// LoanEstimateFieldsContract ChangesReceivedDate
    /// </summary>
    public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => SetField(ref _changesReceivedDate, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsChangedCircumstanceEligibility
    /// </summary>
    public bool? IsChangedCircumstanceEligibility { get => _isChangedCircumstanceEligibility; set => SetField(ref _isChangedCircumstanceEligibility, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsChangedCircumstanceSettlementCharges
    /// </summary>
    public bool? IsChangedCircumstanceSettlementCharges { get => _isChangedCircumstanceSettlementCharges; set => SetField(ref _isChangedCircumstanceSettlementCharges, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsDelayedSettlementOnConstructionLoans
    /// </summary>
    public bool? IsDelayedSettlementOnConstructionLoans { get => _isDelayedSettlementOnConstructionLoans; set => SetField(ref _isDelayedSettlementOnConstructionLoans, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsDisclosedByBroker
    /// </summary>
    public bool? IsDisclosedByBroker { get => _isDisclosedByBroker; set => SetField(ref _isDisclosedByBroker, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsExpiration
    /// </summary>
    public bool? IsExpiration { get => _isExpiration; set => SetField(ref _isExpiration, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsInterestRateDependentCharges
    /// </summary>
    public bool? IsInterestRateDependentCharges { get => _isInterestRateDependentCharges; set => SetField(ref _isInterestRateDependentCharges, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsOther
    /// </summary>
    public bool? IsOther { get => _isOther; set => SetField(ref _isOther, value); }

    /// <summary>
    /// LoanEstimateFieldsContract IsRevisionsRequestedByConsumer
    /// </summary>
    public bool? IsRevisionsRequestedByConsumer { get => _isRevisionsRequestedByConsumer; set => SetField(ref _isRevisionsRequestedByConsumer, value); }

    /// <summary>
    /// LoanEstimateFieldsContract OtherDescription
    /// </summary>
    public string? OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

    /// <summary>
    /// LoanEstimateFieldsContract RevisedDueDate
    /// </summary>
    public DateTime? RevisedDueDate { get => _revisedDueDate; set => SetField(ref _revisedDueDate, value); }
}