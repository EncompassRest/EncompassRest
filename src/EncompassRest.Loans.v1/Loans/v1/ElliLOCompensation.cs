using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ElliLOCompensation
/// </summary>
public sealed partial class ElliLOCompensation : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _adjustedPlanAdditonalAmountForBroker;
    private DirtyValue<decimal?>? _adjustedPlanAdditonalAmountForOfficer;
    private DirtyValue<decimal?>? _adjustedPlanAmountForBroker;
    private DirtyValue<decimal?>? _adjustedPlanAmountForOfficer;
    private DirtyValue<decimal?>? _adjustedPlanRateForBroker;
    private DirtyValue<decimal?>? _adjustedPlanRateForOfficer;
    private DirtyValue<string?>? _adjustmentDescription;
    private DirtyValue<string?>? _adjustmentDescriptionForOfficer;
    private DirtyValue<decimal?>? _basePlanAdditonalAmountForBroker;
    private DirtyValue<decimal?>? _basePlanAdditonalAmountForOfficer;
    private DirtyValue<decimal?>? _basePlanAmountForBroker;
    private DirtyValue<decimal?>? _basePlanAmountForOfficer;
    private DirtyValue<decimal?>? _basePlanMaximumAmountForBroker;
    private DirtyValue<decimal?>? _basePlanMaximumAmountForOfficer;
    private DirtyValue<decimal?>? _basePlanMinimumAmountForBroker;
    private DirtyValue<decimal?>? _basePlanMinimumAmountForOfficer;
    private DirtyValue<decimal?>? _basePlanRateForBroker;
    private DirtyValue<decimal?>? _basePlanRateForOfficer;
    private DirtyValue<decimal?>? _bonusCompAdditonalAmount;
    private DirtyValue<decimal?>? _bonusCompAmount;
    private DirtyValue<decimal?>? _bonusCompRate;
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _lastAppliedDate;
    private DirtyValue<string?>? _lastAppliedDateTime;
    private DirtyValue<StringEnumValue<LoanAmountType>>? _loanAmountType;
    private DirtyValue<StringEnumValue<LoanAmountType>>? _loanAmountTypeForOfficer;
    private DirtyValue<string?>? _loanOriginatorID;
    private DirtyValue<string?>? _loanOriginatorIDForOfficer;
    private DirtyValue<string?>? _loanOriginatorName;
    private DirtyValue<string?>? _loanOriginatorNameForOfficer;
    private DirtyValue<decimal?>? _netAdjustedAmountForBroker;
    private DirtyValue<decimal?>? _netAdjustedAmountForOfficer;
    private DirtyValue<DateTime?>? _planDate;
    private DirtyValue<string?>? _planName;
    private DirtyValue<string?>? _planNameForOfficer;
    private DirtyValue<StringEnumValue<RoundingMethod>>? _roundingMethod;
    private DirtyValue<StringEnumValue<RoundingMethod>>? _roundingMethodForOfficer;
    private DirtyValue<string?>? _triggerField;
    private DirtyValue<StringEnumValue<BorrLenderPaid>>? _whoPaidCompensation;

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Additional Amount [LCP.X12]
    /// </summary>
    public decimal? AdjustedPlanAdditonalAmountForBroker { get => _adjustedPlanAdditonalAmountForBroker; set => SetField(ref _adjustedPlanAdditonalAmountForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Additional Amount [LCP.X34]
    /// </summary>
    public decimal? AdjustedPlanAdditonalAmountForOfficer { get => _adjustedPlanAdditonalAmountForOfficer; set => SetField(ref _adjustedPlanAdditonalAmountForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Amount [LCP.X13]
    /// </summary>
    public decimal? AdjustedPlanAmountForBroker { get => _adjustedPlanAmountForBroker; set => SetField(ref _adjustedPlanAmountForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Amount [LCP.X35]
    /// </summary>
    public decimal? AdjustedPlanAmountForOfficer { get => _adjustedPlanAmountForOfficer; set => SetField(ref _adjustedPlanAmountForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Percentage [LCP.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? AdjustedPlanRateForBroker { get => _adjustedPlanRateForBroker; set => SetField(ref _adjustedPlanRateForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Percentage [LCP.X33]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? AdjustedPlanRateForOfficer { get => _adjustedPlanRateForOfficer; set => SetField(ref _adjustedPlanRateForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Adjustment Description [LCP.X15]
    /// </summary>
    public string? AdjustmentDescription { get => _adjustmentDescription; set => SetField(ref _adjustmentDescription, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjustment Description [LCP.X37]
    /// </summary>
    public string? AdjustmentDescriptionForOfficer { get => _adjustmentDescriptionForOfficer; set => SetField(ref _adjustmentDescriptionForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Additional Amount [LCP.X7]
    /// </summary>
    public decimal? BasePlanAdditonalAmountForBroker { get => _basePlanAdditonalAmountForBroker; set => SetField(ref _basePlanAdditonalAmountForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Additional Amount [LCP.X26]
    /// </summary>
    public decimal? BasePlanAdditonalAmountForOfficer { get => _basePlanAdditonalAmountForOfficer; set => SetField(ref _basePlanAdditonalAmountForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Amount [LCP.X8]
    /// </summary>
    public decimal? BasePlanAmountForBroker { get => _basePlanAmountForBroker; set => SetField(ref _basePlanAmountForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Amount [LCP.X27]
    /// </summary>
    public decimal? BasePlanAmountForOfficer { get => _basePlanAmountForOfficer; set => SetField(ref _basePlanAmountForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Maximum Amount [LCP.X10]
    /// </summary>
    public decimal? BasePlanMaximumAmountForBroker { get => _basePlanMaximumAmountForBroker; set => SetField(ref _basePlanMaximumAmountForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Maximum Amount [LCP.X29]
    /// </summary>
    public decimal? BasePlanMaximumAmountForOfficer { get => _basePlanMaximumAmountForOfficer; set => SetField(ref _basePlanMaximumAmountForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Minimum Amount [LCP.X9]
    /// </summary>
    public decimal? BasePlanMinimumAmountForBroker { get => _basePlanMinimumAmountForBroker; set => SetField(ref _basePlanMinimumAmountForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Minimum Amount [LCP.X28]
    /// </summary>
    public decimal? BasePlanMinimumAmountForOfficer { get => _basePlanMinimumAmountForOfficer; set => SetField(ref _basePlanMinimumAmountForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Percentage [LCP.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? BasePlanRateForBroker { get => _basePlanRateForBroker; set => SetField(ref _basePlanRateForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Percentage [LCP.X25]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? BasePlanRateForOfficer { get => _basePlanRateForOfficer; set => SetField(ref _basePlanRateForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Additional Amount [LCP.X31]
    /// </summary>
    public decimal? BonusCompAdditonalAmount { get => _bonusCompAdditonalAmount; set => SetField(ref _bonusCompAdditonalAmount, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Amount [LCP.X32]
    /// </summary>
    public decimal? BonusCompAmount { get => _bonusCompAmount; set => SetField(ref _bonusCompAmount, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Percentage [LCP.X30]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? BonusCompRate { get => _bonusCompRate; set => SetField(ref _bonusCompRate, value); }

    /// <summary>
    /// ElliLOCompensation Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Loan Compensation Plan - Last Applied Date [LCP.X20]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastAppliedDate { get => _lastAppliedDate; set => SetField(ref _lastAppliedDate, value); }

    /// <summary>
    /// Loan Compensation Plan - Last Applied Date and Time [LCP.X19]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LastAppliedDateTime { get => _lastAppliedDateTime; set => SetField(ref _lastAppliedDateTime, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Amount Type [LCP.X17]
    /// </summary>
    public StringEnumValue<LoanAmountType> LoanAmountType { get => _loanAmountType; set => SetField(ref _loanAmountType, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Loan Amount Type [LCP.X24]
    /// </summary>
    public StringEnumValue<LoanAmountType> LoanAmountTypeForOfficer { get => _loanAmountTypeForOfficer; set => SetField(ref _loanAmountTypeForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator ID [LCP.X18]
    /// </summary>
    public string? LoanOriginatorID { get => _loanOriginatorID; set => SetField(ref _loanOriginatorID, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer ID [LCP.X38]
    /// </summary>
    public string? LoanOriginatorIDForOfficer { get => _loanOriginatorIDForOfficer; set => SetField(ref _loanOriginatorIDForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator Name [LCP.X2]
    /// </summary>
    public string? LoanOriginatorName { get => _loanOriginatorName; set => SetField(ref _loanOriginatorName, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer Name [LCP.X21]
    /// </summary>
    public string? LoanOriginatorNameForOfficer { get => _loanOriginatorNameForOfficer; set => SetField(ref _loanOriginatorNameForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Net Adjusted Amount [LCP.X14]
    /// </summary>
    public decimal? NetAdjustedAmountForBroker { get => _netAdjustedAmountForBroker; set => SetField(ref _netAdjustedAmountForBroker, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Net Adjusted Amount [LCP.X36]
    /// </summary>
    public decimal? NetAdjustedAmountForOfficer { get => _netAdjustedAmountForOfficer; set => SetField(ref _netAdjustedAmountForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Plan Date [LCP.X5]
    /// </summary>
    public DateTime? PlanDate { get => _planDate; set => SetField(ref _planDate, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Plan Name [LCP.X3]
    /// </summary>
    public string? PlanName { get => _planName; set => SetField(ref _planName, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Plan Name [LCP.X22]
    /// </summary>
    public string? PlanNameForOfficer { get => _planNameForOfficer; set => SetField(ref _planNameForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Rounding Method [LCP.X16]
    /// </summary>
    public StringEnumValue<RoundingMethod> RoundingMethod { get => _roundingMethod; set => SetField(ref _roundingMethod, value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Rounding Method [LCP.X23]
    /// </summary>
    public StringEnumValue<RoundingMethod> RoundingMethodForOfficer { get => _roundingMethodForOfficer; set => SetField(ref _roundingMethodForOfficer, value); }

    /// <summary>
    /// Loan Compensation Plan - Trigger Field [LCP.X4]
    /// </summary>
    public string? TriggerField { get => _triggerField; set => SetField(ref _triggerField, value); }

    /// <summary>
    /// Loan Compensation Plan - Brrower/Lender Paid [LCP.X1]
    /// </summary>
    public StringEnumValue<BorrLenderPaid> WhoPaidCompensation { get => _whoPaidCompensation; set => SetField(ref _whoPaidCompensation, value); }
}