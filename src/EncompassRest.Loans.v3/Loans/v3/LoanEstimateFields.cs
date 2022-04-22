using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanEstimateFields
/// </summary>
public sealed partial class LoanEstimateFields : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanEstimateFields ChangesReceivedDate
    /// </summary>
    public DateTime? ChangesReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsChangedCircumstanceEligibility
    /// </summary>
    public bool? IsChangedCircumstanceEligibility { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsChangedCircumstanceSettlementCharges
    /// </summary>
    public bool? IsChangedCircumstanceSettlementCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsDelayedSettlementOnConstructionLoans
    /// </summary>
    public bool? IsDelayedSettlementOnConstructionLoans { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsDisclosedByBroker
    /// </summary>
    public bool? IsDisclosedByBroker { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsExpiration
    /// </summary>
    public bool? IsExpiration { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsInterestRateDependentCharges
    /// </summary>
    public bool? IsInterestRateDependentCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsOther
    /// </summary>
    public bool? IsOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields IsRevisionsRequestedByConsumer
    /// </summary>
    public bool? IsRevisionsRequestedByConsumer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields OtherDescription
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimateFields RevisedDueDate
    /// </summary>
    public DateTime? RevisedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}