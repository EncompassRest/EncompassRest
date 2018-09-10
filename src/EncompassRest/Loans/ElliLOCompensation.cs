using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ElliLOCompensation
    /// </summary>
    public sealed partial class ElliLOCompensation : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Additional Amount [LCP.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Additional Amount")]
        public decimal? AdjustedPlanAdditonalAmountForBroker { get => _adjustedPlanAdditonalAmountForBroker; set => SetField(ref _adjustedPlanAdditonalAmountForBroker, value); }
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Additional Amount [LCP.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Additional Amount")]
        public decimal? AdjustedPlanAdditonalAmountForOfficer { get => _adjustedPlanAdditonalAmountForOfficer; set => SetField(ref _adjustedPlanAdditonalAmountForOfficer, value); }
        private DirtyValue<decimal?> _adjustedPlanAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Amount [LCP.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Amount")]
        public decimal? AdjustedPlanAmountForBroker { get => _adjustedPlanAmountForBroker; set => SetField(ref _adjustedPlanAmountForBroker, value); }
        private DirtyValue<decimal?> _adjustedPlanAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Amount [LCP.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Amount")]
        public decimal? AdjustedPlanAmountForOfficer { get => _adjustedPlanAmountForOfficer; set => SetField(ref _adjustedPlanAmountForOfficer, value); }
        private DirtyValue<decimal?> _adjustedPlanRateForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Percentage [LCP.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Percentage")]
        public decimal? AdjustedPlanRateForBroker { get => _adjustedPlanRateForBroker; set => SetField(ref _adjustedPlanRateForBroker, value); }
        private DirtyValue<decimal?> _adjustedPlanRateForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Percentage [LCP.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Percentage")]
        public decimal? AdjustedPlanRateForOfficer { get => _adjustedPlanRateForOfficer; set => SetField(ref _adjustedPlanRateForOfficer, value); }
        private DirtyValue<string> _adjustmentDescription;
        /// <summary>
        /// Loan Compensation Plan - Adjustment Description [LCP.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Adjustment Description")]
        public string AdjustmentDescription { get => _adjustmentDescription; set => SetField(ref _adjustmentDescription, value); }
        private DirtyValue<string> _adjustmentDescriptionForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjustment Description [LCP.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjustment Description")]
        public string AdjustmentDescriptionForOfficer { get => _adjustmentDescriptionForOfficer; set => SetField(ref _adjustmentDescriptionForOfficer, value); }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Additional Amount [LCP.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Additional Amount")]
        public decimal? BasePlanAdditonalAmountForBroker { get => _basePlanAdditonalAmountForBroker; set => SetField(ref _basePlanAdditonalAmountForBroker, value); }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Additional Amount [LCP.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Additional Amount")]
        public decimal? BasePlanAdditonalAmountForOfficer { get => _basePlanAdditonalAmountForOfficer; set => SetField(ref _basePlanAdditonalAmountForOfficer, value); }
        private DirtyValue<decimal?> _basePlanAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Amount [LCP.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Amount")]
        public decimal? BasePlanAmountForBroker { get => _basePlanAmountForBroker; set => SetField(ref _basePlanAmountForBroker, value); }
        private DirtyValue<decimal?> _basePlanAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Amount [LCP.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Amount")]
        public decimal? BasePlanAmountForOfficer { get => _basePlanAmountForOfficer; set => SetField(ref _basePlanAmountForOfficer, value); }
        private DirtyValue<decimal?> _basePlanMaximumAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Maximum Amount [LCP.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Maximum Amount")]
        public decimal? BasePlanMaximumAmountForBroker { get => _basePlanMaximumAmountForBroker; set => SetField(ref _basePlanMaximumAmountForBroker, value); }
        private DirtyValue<decimal?> _basePlanMaximumAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Maximum Amount [LCP.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Maximum Amount")]
        public decimal? BasePlanMaximumAmountForOfficer { get => _basePlanMaximumAmountForOfficer; set => SetField(ref _basePlanMaximumAmountForOfficer, value); }
        private DirtyValue<decimal?> _basePlanMinimumAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Minimum Amount [LCP.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Minimum Amount")]
        public decimal? BasePlanMinimumAmountForBroker { get => _basePlanMinimumAmountForBroker; set => SetField(ref _basePlanMinimumAmountForBroker, value); }
        private DirtyValue<decimal?> _basePlanMinimumAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Minimum Amount [LCP.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Minimum Amount")]
        public decimal? BasePlanMinimumAmountForOfficer { get => _basePlanMinimumAmountForOfficer; set => SetField(ref _basePlanMinimumAmountForOfficer, value); }
        private DirtyValue<decimal?> _basePlanRateForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Percentage [LCP.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Percentage")]
        public decimal? BasePlanRateForBroker { get => _basePlanRateForBroker; set => SetField(ref _basePlanRateForBroker, value); }
        private DirtyValue<decimal?> _basePlanRateForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Percentage [LCP.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Percentage")]
        public decimal? BasePlanRateForOfficer { get => _basePlanRateForOfficer; set => SetField(ref _basePlanRateForOfficer, value); }
        private DirtyValue<decimal?> _bonusCompAdditonalAmount;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Additional Amount [LCP.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Additional Amount")]
        public decimal? BonusCompAdditonalAmount { get => _bonusCompAdditonalAmount; set => SetField(ref _bonusCompAdditonalAmount, value); }
        private DirtyValue<decimal?> _bonusCompAmount;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Amount [LCP.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Amount")]
        public decimal? BonusCompAmount { get => _bonusCompAmount; set => SetField(ref _bonusCompAmount, value); }
        private DirtyValue<decimal?> _bonusCompRate;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Percentage [LCP.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Percentage")]
        public decimal? BonusCompRate { get => _bonusCompRate; set => SetField(ref _bonusCompRate, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ElliLOCompensation Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<DateTime?> _lastAppliedDate;
        /// <summary>
        /// Loan Compensation Plan - Last Applied Date [LCP.X20]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Compensation Plan - Last Applied Date")]
        public DateTime? LastAppliedDate { get => _lastAppliedDate; set => SetField(ref _lastAppliedDate, value); }
        private DirtyValue<string> _lastAppliedDateTime;
        /// <summary>
        /// Loan Compensation Plan - Last Applied Date and Time [LCP.X19]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Compensation Plan - Last Applied Date and Time")]
        public string LastAppliedDateTime { get => _lastAppliedDateTime; set => SetField(ref _lastAppliedDateTime, value); }
        private DirtyValue<StringEnumValue<LoanAmountType>> _loanAmountType;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Amount Type [LCP.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Amount Type")]
        public StringEnumValue<LoanAmountType> LoanAmountType { get => _loanAmountType; set => SetField(ref _loanAmountType, value); }
        private DirtyValue<StringEnumValue<LoanAmountType>> _loanAmountTypeForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Loan Amount Type [LCP.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Loan Amount Type")]
        public StringEnumValue<LoanAmountType> LoanAmountTypeForOfficer { get => _loanAmountTypeForOfficer; set => SetField(ref _loanAmountTypeForOfficer, value); }
        private DirtyValue<string> _loanOriginatorID;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator ID [LCP.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator ID")]
        public string LoanOriginatorID { get => _loanOriginatorID; set => SetField(ref _loanOriginatorID, value); }
        private DirtyValue<string> _loanOriginatorIDForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer ID [LCP.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Loan Officer ID")]
        public string LoanOriginatorIDForOfficer { get => _loanOriginatorIDForOfficer; set => SetField(ref _loanOriginatorIDForOfficer, value); }
        private DirtyValue<string> _loanOriginatorName;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator Name [LCP.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator Name")]
        public string LoanOriginatorName { get => _loanOriginatorName; set => SetField(ref _loanOriginatorName, value); }
        private DirtyValue<string> _loanOriginatorNameForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer Name [LCP.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Loan Officer Name")]
        public string LoanOriginatorNameForOfficer { get => _loanOriginatorNameForOfficer; set => SetField(ref _loanOriginatorNameForOfficer, value); }
        private DirtyValue<decimal?> _netAdjustedAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Net Adjusted Amount [LCP.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Net Adjusted Amount")]
        public decimal? NetAdjustedAmountForBroker { get => _netAdjustedAmountForBroker; set => SetField(ref _netAdjustedAmountForBroker, value); }
        private DirtyValue<decimal?> _netAdjustedAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Net Adjusted Amount [LCP.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Net Adjusted Amount")]
        public decimal? NetAdjustedAmountForOfficer { get => _netAdjustedAmountForOfficer; set => SetField(ref _netAdjustedAmountForOfficer, value); }
        private DirtyValue<DateTime?> _planDate;
        /// <summary>
        /// Loan Compensation Plan - Plan Date [LCP.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Plan Date")]
        public DateTime? PlanDate { get => _planDate; set => SetField(ref _planDate, value); }
        private DirtyValue<string> _planName;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Plan Name [LCP.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Plan Name")]
        public string PlanName { get => _planName; set => SetField(ref _planName, value); }
        private DirtyValue<string> _planNameForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Plan Name [LCP.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Plan Name")]
        public string PlanNameForOfficer { get => _planNameForOfficer; set => SetField(ref _planNameForOfficer, value); }
        private DirtyValue<StringEnumValue<RoundingMethod>> _roundingMethod;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Rounding Method [LCP.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Rounding Method")]
        public StringEnumValue<RoundingMethod> RoundingMethod { get => _roundingMethod; set => SetField(ref _roundingMethod, value); }
        private DirtyValue<StringEnumValue<RoundingMethod>> _roundingMethodForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Rounding Method [LCP.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Rounding Method")]
        public StringEnumValue<RoundingMethod> RoundingMethodForOfficer { get => _roundingMethodForOfficer; set => SetField(ref _roundingMethodForOfficer, value); }
        private DirtyValue<string> _triggerField;
        /// <summary>
        /// Loan Compensation Plan - Trigger Field [LCP.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Trigger Field")]
        public string TriggerField { get => _triggerField; set => SetField(ref _triggerField, value); }
        private DirtyValue<StringEnumValue<WhoPaidCompensation>> _whoPaidCompensation;
        /// <summary>
        /// Loan Compensation Plan - Brrower/Lender Paid [LCP.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Brrower/Lender Paid")]
        public StringEnumValue<WhoPaidCompensation> WhoPaidCompensation { get => _whoPaidCompensation; set => SetField(ref _whoPaidCompensation, value); }
    }
}