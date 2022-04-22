using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ElliLOCompensation
/// </summary>
public sealed partial class ElliLOCompensation : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Additional Amount [LCP.X12]
    /// </summary>
    public decimal? AdjustedPlanAdditonalAmountForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Additional Amount [LCP.X34]
    /// </summary>
    public decimal? AdjustedPlanAdditonalAmountForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Amount [LCP.X13]
    /// </summary>
    public decimal? AdjustedPlanAmountForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Amount [LCP.X35]
    /// </summary>
    public decimal? AdjustedPlanAmountForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Percentage [LCP.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? AdjustedPlanRateForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Percentage [LCP.X33]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? AdjustedPlanRateForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Adjustment Description [LCP.X15]
    /// </summary>
    public string? AdjustmentDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Adjustment Description [LCP.X37]
    /// </summary>
    public string? AdjustmentDescriptionForOfficer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Additional Amount [LCP.X7]
    /// </summary>
    public decimal? BasePlanAdditonalAmountForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Additional Amount [LCP.X26]
    /// </summary>
    public decimal? BasePlanAdditonalAmountForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Amount [LCP.X8]
    /// </summary>
    public decimal? BasePlanAmountForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Amount [LCP.X27]
    /// </summary>
    public decimal? BasePlanAmountForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Maximum Amount [LCP.X10]
    /// </summary>
    public decimal? BasePlanMaximumAmountForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Maximum Amount [LCP.X29]
    /// </summary>
    public decimal? BasePlanMaximumAmountForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Minimum Amount [LCP.X9]
    /// </summary>
    public decimal? BasePlanMinimumAmountForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Minimum Amount [LCP.X28]
    /// </summary>
    public decimal? BasePlanMinimumAmountForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Percentage [LCP.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? BasePlanRateForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Percentage [LCP.X25]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? BasePlanRateForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Additional Amount [LCP.X31]
    /// </summary>
    public decimal? BonusCompAdditonalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Amount [LCP.X32]
    /// </summary>
    public decimal? BonusCompAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Percentage [LCP.X30]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? BonusCompRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Last Applied Date [LCP.X20]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastAppliedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Last Applied Date and Time [LCP.X19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
    public DateTime? LastAppliedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Amount Type [LCP.X17]
    /// </summary>
    public StringEnumValue<LoanAmountType> LoanAmountType { get => GetValue<StringEnumValue<LoanAmountType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Loan Amount Type [LCP.X24]
    /// </summary>
    public StringEnumValue<LoanAmountType> LoanAmountTypeForOfficer { get => GetValue<StringEnumValue<LoanAmountType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator ID [LCP.X18]
    /// </summary>
    public string? LoanOriginatorId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer ID [LCP.X38]
    /// </summary>
    public string? LoanOriginatorIdForOfficer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator Name [LCP.X2]
    /// </summary>
    public string? LoanOriginatorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer Name [LCP.X21]
    /// </summary>
    public string? LoanOriginatorNameForOfficer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Net Adjusted Amount [LCP.X14]
    /// </summary>
    public decimal? NetAdjustedAmountForBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Net Adjusted Amount [LCP.X36]
    /// </summary>
    public decimal? NetAdjustedAmountForOfficer { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Plan Date [LCP.X5]
    /// </summary>
    public DateTime? PlanDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Plan Name [LCP.X3]
    /// </summary>
    public string? PlanName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Plan Name [LCP.X22]
    /// </summary>
    public string? PlanNameForOfficer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Wholesale/Broker Plan Details - Rounding Method [LCP.X16]
    /// </summary>
    public StringEnumValue<RoundingMethod> RoundingMethod { get => GetValue<StringEnumValue<RoundingMethod>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Loan Officer Plan Details - Rounding Method [LCP.X23]
    /// </summary>
    public StringEnumValue<RoundingMethod> RoundingMethodForOfficer { get => GetValue<StringEnumValue<RoundingMethod>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Trigger Field [LCP.X4]
    /// </summary>
    public string? TriggerField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Compensation Plan - Brrower/Lender Paid [LCP.X1]
    /// </summary>
    public StringEnumValue<BorrLenderPaid> WhoPaidCompensation { get => GetValue<StringEnumValue<BorrLenderPaid>>(); set => SetValue(value); }
}